uname Command in Linux
The uname command is used to display system information, such as the operating system, kernel version, architecture, and more.

Basic Usage:

uname
Example Output:
Linux
This shows the operating system name.

Common uname Options:
Command Description	Example Output
uname -s	Show the kernel name	Linux
uname -n	Show the hostname of the system	ubuntu-server
uname -r	Show the kernel release/version	5.15.0-91-generic
uname -v	Show the kernel version	#102-Ubuntu SMP
uname -m	Show the machine architecture	x86_64 (for 64-bit)
uname -p	Show the processor type	x86_64 (or unknown on some systems)
uname -i	Show the hardware platform	x86_64 (or unknown)
uname -o	Show the operating system	GNU/Linux

Get Full System Information
uname -a
Example Output:
Linux ubuntu-server 5.15.0-91-generic #102-Ubuntu SMP Thu Jan 11 10:14:33 UTC 2024 x86_64 x86_64 x86_64 GNU/Linux
Linux → Kernel name
ubuntu-server → Hostname
5.15.0-91-generic → Kernel version
#102-Ubuntu SMP → Kernel build details
x86_64 → 64-bit architecture
GNU/Linux → Operating system

When to Use uname?
To check the Linux version and kernel details.
To verify system architecture (32-bit or 64-bit).
When debugging hardware or OS-related issues.