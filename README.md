This is a very simplistic logfile reader for Elite Dangerous.

Every five seconds the files in the configured log directory are tested for
new data. If any new information is found it is tested for new jumps into a
system. If new system data is found, it is displayed in a small text window
and, if enabled, written to a text file for output by OBS.

By default, the current system name and position are written. If enabled,
the distance to Sol is also displayed.


