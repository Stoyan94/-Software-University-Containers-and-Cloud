��������� �� ��������� � ���������� �� ������������� �������
������������� ������� (OS) ��������� �������� � �������� �� ���������, ��������� ������������� ��������� � �������� ������������ �� ������������. 
��������� ���������� �� ���� OS ��:

1.����(Kernel)
������ � ���-������� ���������, ����� �� ������� ����� � ������ � �������.

������� ������� �� ������:
���������� �� ��������� � �������, ������� � ���������� �������.
���������� �� ������� � ���������� RAM �� �������� ������.
���������� �� ������������ � ���������� � �������� ���� ��������.
������� ������� � ���� � ������� ������� �� �����.
��������� � ������ � ��������� ������������ � ��������������.
������ ����:
��������� ���� � ������ ������ ������� � ������ (Linux, Windows NT).
��������� � ���� ��������� ������� �� � ������ (Minix, QNX).
�������� ���� � ���� ����� ����� (Windows, macOS).


2. ������� (Shell)
��������� � ����������� �� ����������� ����� ����������� � ������������� �������.

������ �������:
�������� ���(CLI) � ��������� �������� ������� (Bash, PowerShell, CMD).
�������� ��������� (GUI) � ��������� �������� ���������� (Windows Explorer, Finder, GNOME).
������� �� ���������:
��������� �������, �������� �� �����������.
��������� ������������� ���� ��������� (������� CLI).
��������� ������� � ��������.


3. ������� �������� (Utilities)
��������� �������� �� ����� ��������� �����������, ����� ���������� ������������� �� ������������� �������.

������� �� ������� ��������:
���������� �� ������� � ������� ���������, ������� ���� ls � cd.
������������ �� ������� � ZIP, RAR, tar, gzip.
������� ����������� � SSH (��������� ������), FTP, ping, traceroute.
���������� �� ��������� � Task Manager, top � Linux.
���������� � �������������� � �������� ��������������, ������� ����������.

4. ����� ���������� �� OS
4.1. ������� �������
������������� ������� ��������� ��������� ���� ������� �������, ����� �� ���������� � ����������. �������: NTFS(Windows), ext4(Linux), HFS + (macOS).

4.2.�������� �� ����������
���������� ���������� ������������� ����� ������������� ������� � ����������� ���������� (��������, ����������, USB ����������).

4.3. �������� ���������� (API)
���������� ���������� �� ����������, ���� ����� ������������ �������� ������ �� ������. �������: open(), read(), write() � Unix.



Operating System Components � Detailed Explanation
An operating system (OS) is responsible for managing hardware and software resources, providing a user interface, and ensuring the execution of applications. It consists of several core components:

1.Kernel
The kernel is the core of the operating system. It is the first component loaded into memory when the computer starts and remains active throughout operation.

Key Responsibilities of the Kernel:
Process Management � Creates, schedules, and terminates processes.
Memory Management � Allocates and deallocates RAM for processes.
Device Management � Communicates with hardware via drivers.
File System Management � Organizes, reads, and writes files.
System Security & Access Control � Implements authentication and permissions.
Types of Kernels:
Monolithic Kernel � All OS services run in kernel space (e.g., Linux, Windows NT).
Microkernel � Only essential functions run in kernel space, while others run in user space (e.g., Minix, QNX).
Hybrid Kernel � A mix of monolithic and microkernel approaches (e.g., Windows, macOS).


2. Shell
The shell is the user interface for interacting with the operating system.It acts as a bridge between the user and the kernel.

Types of Shells:
Command - Line Interface(CLI) � Users interact through text - based commands(e.g., Bash, PowerShell, Command Prompt).
Graphical User Interface(GUI) � Users interact through visual elements(e.g., Windows Explorer, GNOME, macOS Finder).
Functions of the Shell:
Accepts user commands and passes them to the kernel.
Allows script automation(especially CLI shells).
Can execute programs and manage files.


3.Utilities(System Tools & Services)
Utilities are small programs that extend the capabilities of the operating system.

Examples of Common Utilities:
File Management � File explorers, command - line file tools.
Compression Utilities � ZIP, RAR, tar, gzip.
Networking Tools � SSH(remote access), FTP, ping, traceroute.
System Monitoring � Task Manager, Process Explorer, top(Linux).
Backup & Recovery � System restore, disk cloning, cloud backups.


4.Other OS Components(Additional Details)
4.1.File System
The OS manages file storage using a structured file system, which organizes files into directories. Examples: NTFS(Windows), ext4(Linux), HFS + (macOS).

4.2.Device Drivers
Drivers allow communication between the OS and hardware components (e.g., printers, graphics cards, USB devices).

4.3. System Calls (APIs)
System calls provide an interface for programs to request services from the kernel.Examples: open(), read(), write() in Unix - based systems.
