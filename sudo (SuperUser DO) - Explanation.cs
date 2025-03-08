sudo(SuperUser DO) is a command - line tool in Linux and Unix-like operating systems that allows regular users to perform administrative tasks without having to log in as the root user. It is very useful for system management because it provides control over permissions and makes the system more secure by limiting access to sensitive operations.

How sudo works:
Purpose: Allows users to execute specific commands with root privileges without logging into the root account.
Configuration: Users can be configured in the /etc/sudoers file with permissions to run certain commands as root or other users.
Security: Enables system administrators to control who can run which commands, when, and from where.

Basic Examples with Explanation:

Basic sudo command:
sudo [command]
This runs the command inside the square brackets as the superuser (root). 

For example:
sudo ls /root
This will execute the ls command in the /root directory, which is protected and only accessible by the root user.

Running a command as another user:
sudo -u testuser whoami
This command runs the whoami command but as the user testuser, instead of the current user.
The result will be the name of the user, which is testuser.


Switching to a user with sudo su:
sudo su testuser
This command switches the current user to testuser and enters a shell with their privileges, staying in the same terminal session.
It's useful when you want to operate as another user without leaving your current session.

Switching to a user with a full login session:
su - testuser

This command also switches the user to testuser, but it starts a full session (with environment settings), so you'll need to enter testuser's password.
Unlike sudo su, it begins a new session for the user.


Running a command as root:
sudo chmod + x hello.txt
This command runs the chmod command with root privileges, which allows you to change the permissions of a file 
that may require administrative rights, such as a file in a protected directory.


Configuration Examples:
The / etc / sudoers file contains all the configurations and rules for which users can use sudo and what commands they can execute.

You can add users using the visudo editor:
sudo visudo

Example of adding a user username who can execute any command:
username ALL=(ALL) ALL
This means that the user username can use sudo for any command from anywhere.


Conclusion:
sudo is a powerful tool for controlling user permissions and is crucial for maintaining security in systems,
allowing temporary elevation of privileges without needing to log into a full administrative account like root.









sudo (SuperUser DO) � �������� ���������� � Linux � Unix-������� ����������� �������, 
����� ��������� �� ���������� ����������� �� ���������� ������ � ���������������� ����������, 
��� �� �� ������ �� ������ �������� ���� root ����������. ���� � ����� ������� �� ���������� �� ���������, 
��� ���� ���������� ������� ����� ������� � ����� ��������� ��-�������, ���� ���������� ������� �� ������������ ��������.


��� ������ sudo:
���: ��������� �� ����������� �� ���������� ���������� ������� � ���������� �� ��������������� (root), ��� �� � ���������� �� ������ � root �������.
������������: ������������� ����� �� ����� ������������� � /etc/sudoers ���� � ����� �� ���������� �� ���������� ������� ���� root ��� ����� �����������.
�����������: ��������� �� ���������� �������������� �� ���������� ��� ��� ����� �� ��������� ����� �������, ������ � �� ����.

������� ������� � ���������:
������� ������� � sudo:
sudo [command]
���� ��������� ��������� � ����������� ����� �� ����� �� ���������������� (root).

��������:
sudo ls /root
���� �� ������� ��������� ls � ������������ /root, ����� � �������� � ���� root ��� ������ �� ���.

����������� �� ������� ���� ���� ����������:
sudo -u testuser whoami
���� ������� ��������� ��������� whoami, �� �� ����� �� ����������� testuser, ������ ������� ����������.
���������� �� ���� ����� �� �����������, ����� � testuser.


����� �� ���������� � sudo su:
sudo su testuser
���� ������� �� ����� ������� ���������� � �� ����� � ��� � ������� �� testuser, �� �� ������ � �������� ����� �� ���������.
���� � �������, ������ ������ �� �������� ���� ���� ����������, ��� �� ��������� �������� �� �����.

����� �� ���������� � ����� �����:
su - testuser
���� ������� ���� ����� ����������� �� testuser, �� ������ ����� ����� (� ����������� �� �������), ���� �� �� �� ������ �� �������� ������ �� testuser.
�� ������� �� sudo su, �� ������� ���� ����� �� �����������.


���������� �� ������� ���� root:
sudo chmod +x hello.txt
���� ������� �� ������� ��������� chmod � ���������� �� root, ����� ��������� �� �� �������� ������� �� ����,
����� ���� �� ������� ��������������� �����, ���� �������� ���� � �������� ����������.


������� �� ������������:
������ / etc / sudoers ������� ������ ������������ � ������� �� ���� ��� ���������� ���� �� �������� sudo � ����� ������� ���� �� ���������.

������ �� �������� �����������, ���� ���������� ��������� visudo:
sudo visudo

������ �� �������� �� ���������� username, ����� ��� ����� �� ��������� ����� �������:
username ALL=(ALL) ALL
���� ��������, �� ������������ username ���� �� �������� sudo �� ����� ������� �� ����� �����.

����������:
sudo � ����� ���������� �� ������� �� ������� �� ������������� � � ����� �� ���������� �� ����������� � ���������, 
������������ �������� ���������� �� ������������ ��� �� �� ������ ������� � ������ � ����� ��������������� ����� ���� root.