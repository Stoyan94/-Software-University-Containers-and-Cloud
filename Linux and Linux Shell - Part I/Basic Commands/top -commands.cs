top Command in Linux
The top command is used to monitor system performance in real-time, including CPU usage, memory usage, and running processes.

Basic Usage:
bash
Copy
Edit
top
This opens an interactive process viewer, similar to Task Manager in Windows.

Example Output:
yaml
Copy
Edit
top - 10:30:45 up 2 days,  4:15,  1 user, load average: 0.34, 0.45, 0.50
Tasks: 184 total,   1 running, 183 sleeping,   0 stopped,   0 zombie
%Cpu(s):  5.3 us,  1.2 sy,  0.0 ni, 93.5 id,  0.0 wa,  0.0 hi,  0.0 si,  0.0 st
MiB Mem :   7980.4 total,   2435.2 free,   3012.7 used,   2532.5 buff/cache
MiB Swap:   2048.0 total,   2048.0 free,      0.0 used.   4321.0 avail Mem 

  PID USER      PR  NI    VIRT    RES    SHR S  %CPU %MEM     TIME+ COMMAND
 1123 root      20   0  404512  56456  13244 S   3.0  0.7   1:23.45 firefox
  894 user      20   0  227844  48272  19152 S   1.5  0.6   0:45.78 gnome - terminal
Understanding top Output:
System Uptime & Load Average: Shows how long the system has been running and the CPU load.
Tasks: Number of running, sleeping, stopped, and zombie processes.
CPU Usage: Breakdown of CPU usage percentages (user, system, idle, etc.).
Memory Usage: RAM and swap memory usage details.
Process List: Displays active processes with details like PID, user, CPU & memory usage.


Useful top Command Options
Command	Description
top -o %CPU	Sorts processes by CPU usage
top -o %MEM	Sorts processes by memory usage
top -n 1 -b	Runs top once in batch mode (useful for scripting)
top -u username	Show only processes from a specific user


Understanding top -d 2 -n 5
This command modifies the behavior of top by setting:

-d 2 → Updates every 2 seconds instead of the default (which is usually 3 seconds).
-n 5 → Runs for 5 iterations (refreshes 5 times) and then exits instead of running indefinitely.

Example Usage:
top -d 2 -n 5
What Happens?
top opens and refreshes every 2 seconds.
It runs for 5 iterations (so, it runs for about 10 seconds in total).
After the 5th update, it automatically exits.


Why Use This?
If you want to monitor processes for a short period instead of keeping top open.
When logging or analyzing system performance for a set duration.
Useful in scripts where you need limited monitoring instead of real-time interaction.


Alternative Example – Run for 10 iterations, updating every 1 second:
top -d 1 -n 10
This will refresh every second and stop after 10 updates.

Want Non-Interactive Output?
For logging or automated scripts, use batch mode (-b):

top -b -d 2 -n 5 > top_output.txt
Runs in non-interactive mode.
Saves output to top_output.txt for later review.


1. htop – Improved Interactive Process Viewer
A more user-friendly version of top with color-coded output and better navigation.
sudo apt install htop   # Debian/Ubuntu
sudo yum install htop   # CentOS/RHEL
sudo dnf install htop   # Fedora
htop


Features:
Scroll through processes easily.
Kill processes with a single key.
Display CPU and memory usage in a graphical bar format.

2. atop – Advanced System & Process Monitor
Shows system performance over time, including disk and network usage.
sudo apt install atop   # Debian/Ubuntu
sudo yum install atop   # CentOS/RHEL
sudo dnf install atop   # Fedora
atop
Features:
Logs system activity for historical analysis.
Shows disk read/write usage per process.
Provides insights into bottlenecks.


3. glances – Cross-platform Performance Monitoring
Provides an overview of CPU, memory, disk, and network in a single view.
sudo apt install glances   # Debian/Ubuntu
sudo yum install glances   # CentOS/RHEL
pip install glances        # Works on any system
glances
Features:
Works on Linux, macOS, and Windows.
Displays system stats in a clean format.
Can be run in web mode (glances -w).


4. vmstat – CPU, Memory, I/O & Swap Statistics
Provides detailed system performance metrics in a simple output.
vmstat 1 5
Meaning of output:
procs → Number of running and blocked processes.
memory → Free and used memory.
swap → Swap memory statistics.
io → Disk read/write activity.
cpu → CPU usage breakdown.


5. iotop – Disk I/O Monitoring
Similar to top, but focuses on disk read/write activity.
sudo apt install iotop   # Debian/Ubuntu
sudo yum install iotop   # CentOS/RHEL
iotop
Features:
See which processes are using disk the most.
Useful for diagnosing slow disk performance.

6.nmon – Performance Monitoring for CPU, Disk, Network
Provides real - time graphs and logs performance over time.
sudo apt install nmon   # Debian/Ubuntu
sudo yum install nmon   # CentOS/RHEL
nmon
Press different keys to show CPU(c), memory(m), network(n), disk(d), etc.


7.ps – Snapshot of Running Processes
Unlike top, ps gives a one - time snapshot of active processes.
ps aux--sort = -% cpu
ps aux--sort = -% mem
aux → Shows all processes.
--sort = -% cpu → Sorts by CPU usage.
--sort = -% mem → Sorts by memory usage.


8.sar – Collect and Analyze System Performance
Useful for tracking CPU, memory, disk, and network usage historically.
sudo apt install sysstat   # Debian/Ubuntu
sar - u 5 10   # CPU usage every 5 seconds for 10 cycles
Can be scheduled to log system performance over time.


Summary: Which One to Use ?

Command Best For
top General system monitoring
htop    Interactive & user - friendly process viewer
atop    Detailed logging of system resources
glances All -in-one monitoring
vmstat  CPU, memory, and I / O statistics
iotop   Disk usage per process
nmon    Graphical performance monitoring
ps  One - time process snapshot
sar Historical performance tracking



When to Use top?
Monitoring system performance (CPU, memory, load).
Identifying resource-hungry processes.
Killing unresponsive processes.
Checking system uptime and load average.