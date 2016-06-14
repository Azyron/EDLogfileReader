using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


// Originally I tried using a FileSystemWatcher to keep track of changes in
// the log directory, which however didn't work (everytime E:D appends data
// nothing is triggered, although appending / creating data from other processes
// did. Since figuring this out took too long I used polling instead using the
// EDLogFilePoll class.


namespace EDLogfileReader
{
    class EDLogFileWatcher
    {
        private String logFilePath = null;
        private FileSystemWatcher watcher = null;
        private StreamReader reader = null;
        private String lastLogFileName = null;
        private long lastLogFileOffset;
        private EDLogFilePoll.SystemChangeNotificationDelegate notificationDelegate = null;

        private String lastSystemName = null;
        private decimal lastX;
        private decimal lastY;
        private decimal lastZ;


        private readonly Regex logRegex = new Regex(
           @"^\{[0-9:]{8}\}\sSystem:""(?<system>[^""]+)"" StarPos:\((?<starpos1>[^,]+),(?<starpos2>[^,]+),(?<starpos3>[^)]+)\)",
            RegexOptions.Multiline | RegexOptions.CultureInvariant | RegexOptions.Compiled);

        public EDLogFileWatcher() : this(null) { }

        public EDLogFileWatcher(String logFilePath) : this(logFilePath, null) { }

        public EDLogFileWatcher(String logFilePath, EDLogFilePoll.SystemChangeNotificationDelegate notificationDelegate)
        {
            this.setPath(logFilePath);
            this.notificationDelegate = notificationDelegate;
       }


    public void setPath(String logFilePath)
        {
            if (watcher != null) {
                throw new Exception("Watcher already initialized.");
            }

            this.logFilePath = logFilePath;

            watcher = new FileSystemWatcher();

            watcher.Path = logFilePath;
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.CreationTime | NotifyFilters.Size;
            watcher.Filter = @"netLog.*.log";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
        }


        public void startWatching()
        {
            if (watcher == null) {
                throw new Exception("Watcher not initialized, set path to create new.");
            }
            // Begin watching.
            watcher.EnableRaisingEvents = true;
            findLatestLogfile();
        }


        public void stopWatching()
        {
            if (watcher == null) {
                throw new Exception("Watcher not initialized, set path to create new.");
            }
            watcher.EnableRaisingEvents = false;
        }


        public void dispose()
        {
            if (watcher != null) { }
            watcher.Dispose();
        }


        private void findLatestLogfile()
        {
            var netLogs = Directory.GetFiles(this.logFilePath, "netLog*");

            var latestNetlog = netLogs.OrderByDescending(f => f).First();

            if ((this.lastLogFileName == null) || (!(this.lastLogFileName.Equals(latestNetlog))))
            {
                Console.WriteLine("Found new netlog.");
                this.lastLogFileName = latestNetlog;
                this.lastLogFileOffset = 0;
                this.reader = new StreamReader(new FileStream(latestNetlog, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
                parseLatestLogFile();
            }
        }


        private void parseLatestLogFile()
        {
            if (this.lastLogFileOffset < reader.BaseStream.Length) {
                reader.BaseStream.Seek(lastLogFileOffset, SeekOrigin.Begin);

                String line;
                String systemName = null;
                decimal starPos1 = 0, starPos2 = 0, starPos3 = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    Match m = this.logRegex.Match(line);
                    if (m.Success)
                    {
                        systemName = m.Groups["system"].Value;
                        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
                        starPos1 = decimal.Parse(m.Groups["starpos1"].Value, culture);
                        starPos2 = decimal.Parse(m.Groups["starpos2"].Value, culture);
                        starPos3 = decimal.Parse(m.Groups["starpos3"].Value, culture);
                    }
                }

                this.lastLogFileOffset = reader.BaseStream.Position;
                
                if ((systemName != null) && ((this.lastSystemName == null) || (!(this.lastSystemName.Equals(systemName)))))
                {
                    this.lastSystemName = systemName;
                    this.lastX = starPos1;
                    this.lastZ = starPos2;
                    this.lastY = starPos3;
                    //notificationDelegate(this.lastSystemName, lastX, lastY, lastZ);
                }
            }
        }


        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed: " + e.FullPath + " " + e.ChangeType);
            parseLatestLogFile();
        }


        private void OnCreated(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("Created: " + e.FullPath + " " + e.ChangeType);
            findLatestLogfile();
        }
    }
}
