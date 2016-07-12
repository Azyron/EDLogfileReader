
# About EDLogFileReader

This is a very simplistic logfile reader for Elite Dangerous.

Every five seconds the files in the configured log directory are tested for
new data. If any new information is found it is tested for new jumps into a
system. If new system data is found, it is displayed in a small text window
and, if enabled, written to a text file for output by OBS.

By default, the current system name and position are written. If enabled,
the distance to Sol is also displayed.

The tool will also add up the distance traveled so far. This is handy for
longer exploration trips to know the current distance traveled. This only
works reliably if the tool is running all the time, so if you're playing for
some time without having the logfile reader running in the background this
distance will be missing from the total sum.

The distance traveled can be set in the settings. You can put any numeric
value there, so you can enter 1,000,000 light years traveled if you think
that's nice.

After starting for the first time you'll have to tell the tool where your logs
are located. Usually this is a path in the following form:

```
C:\Users\<put-your-username-here>\AppData\Local\Frontier_Developments\Products\elite-dangerous-64\Logs
```

![Example screenshot](/Example-Screenshot.png?raw=true "Example Screenshot")