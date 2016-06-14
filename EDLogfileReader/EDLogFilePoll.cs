using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace EDLogfileReader
{
    public class EDLogFilePoll
    {
        public delegate void SystemChangeNotificationDelegate(String newSystemName, Position newPosition);

        private String logFilePath = null;
        private StreamReader reader = null;
        private String lastLogFileName = null;
        private long lastLogFileOffset;
        private SystemChangeNotificationDelegate notificationDelegate = null;
        private System.Timers.Timer timerClock = new System.Timers.Timer();
        private String lastSystemName = null;
        private Position lastPosition;

        private readonly Regex logRegex = new Regex(
           @"^\{[0-9:]{8}\}\sSystem:""(?<system>[^""]+)"" StarPos:\((?<starpos1>[^,]+),(?<starpos2>[^,]+),(?<starpos3>[^)]+)\)",
            RegexOptions.Multiline | RegexOptions.CultureInvariant | RegexOptions.Compiled);


        public EDLogFilePoll(String logFilePath) : this(logFilePath, null) { }


        public EDLogFilePoll(String logFilePath, SystemChangeNotificationDelegate notificationDelegate)
        {
            this.logFilePath = logFilePath;
            this.notificationDelegate = notificationDelegate;
            timerClock.Elapsed += new ElapsedEventHandler(OnTimer);
            timerClock.Interval = 5000;
        }


        public void setLogFilePath(String newPath)
        {
            this.logFilePath = newPath;
        }


        public void OnTimer(Object source, ElapsedEventArgs e)
        {
            if (findLatestLogfile())
            {
                parseLatestLogFile();
            }
        }


        public bool startWatching()
        {
            // Begin watching.
            if (findLatestLogfile())
            {
                timerClock.Enabled = true;
                return true;
            }
            else
            {
                return false;
            }
        }


        public void stopWatching()
        {
            timerClock.Enabled = false;
        }


        private bool findLatestLogfile()
        {
            try
            {
                var netLogs = Directory.GetFiles(this.logFilePath, "netLog*");

                var latestNetlog = netLogs.OrderByDescending(f => f).First();

                if ((this.lastLogFileName == null) || (!(this.lastLogFileName.Equals(latestNetlog))))
                {
                    Console.WriteLine("Found new netlog.");
                    this.lastLogFileName = latestNetlog;
                    this.lastLogFileOffset = 0;
                    this.reader = new StreamReader(new FileStream(latestNetlog, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
                    //parseLatestLogFile();
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                stopWatching();
                return false;
            }
        }


        private void parseLatestLogFile()
        {
            if (this.lastLogFileOffset < reader.BaseStream.Length)
            {
                reader.BaseStream.Seek(lastLogFileOffset, SeekOrigin.Begin);

                String line;
                String systemName = null;
                Position pos = null;

                while ((line = reader.ReadLine()) != null)
                {
                    Match m = this.logRegex.Match(line);
                    if (m.Success)
                    {
                        systemName = m.Groups["system"].Value;
                        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
                        double starPos1 = double.Parse(m.Groups["starpos1"].Value, culture);
                        double starPos2 = double.Parse(m.Groups["starpos2"].Value, culture);
                        double starPos3 = double.Parse(m.Groups["starpos3"].Value, culture);
                        pos = new Position(starPos1, starPos3, starPos2);
                    }
                }

                this.lastLogFileOffset = reader.BaseStream.Position;

                if ((systemName != null) && ((this.lastSystemName == null) || (!(this.lastSystemName.Equals(systemName)))))
                {
                    this.lastSystemName = systemName;
                    this.lastPosition = pos;

                    notificationDelegate(this.lastSystemName, this.lastPosition);
                }
            }
        }
    }
}
