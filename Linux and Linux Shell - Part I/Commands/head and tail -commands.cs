In Linux, the head and tail commands are used to view the beginning or the end of a file.

🟢 head Command
The head command displays the first 10 lines of a file by default.

Examples:

Display the first 10 lines of file.txt:
head file.txt


Display the first 5 lines:
head -n 5 file.txt


Show the first 15 lines of multiple files:
head -n 15 file1.txt file2.txt



🔴 tail Command
The tail command displays the last 10 lines of a file by default.

Examples:

Show the last 10 lines of a file:
tail file.txt


Show the last 20 lines:
tail -n 20 file.txt


Continuously monitor a file (e.g., log files):
tail -f /var/log/syslog
(-f follows the file in real-time as it updates.)


Combining head and tail
For example, to display lines 11 to 20 from a file:
head -n 20 file.txt | tail -n 10

Here, head -n 20 extracts the first 20 lines, and tail -n 10 keeps only the last 10 of them (lines 11-20).