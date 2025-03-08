English Version:
To create your own environment variables in Linux, you can define them temporarily for the current session or permanently by modifying configuration files. Here�s how:

1.Creating Temporary Variables:
You can define environment variables in your current shell session.
These variables will only exist for the duration of the session.
Once the terminal is closed, they are lost.

To create a temporary variable, use the export command:
export MY_VARIABLE="Hello, world!"

You can check the value of this variable by using echo:
echo $MY_VARIABLE


2. Creating Permanent Variables:
To make your environment variables persist across sessions, you need to add them to a configuration file. 
Common files to modify are:

~/.bashrc(for Bash shell users)
    ~/.bash_profile(for login shells)
    ~/.zshrc(for Zsh shell users)

    To create a permanent variable, open one of the configuration files with a text editor:
    

nano ~/.bashrc
Then, add the following line to set the variable:
export MY_VARIABLE="Hello, world!"

After saving the file, apply the changes:
source ~/.bashrc


3. Using Variables in Scripts:
You can also define variables inside shell scripts. 
Here�s an example of how to create and use your variables within a script:

#!/bin/bash

# Defining the variable
MY_NAME="John"
echo "Hello, $MY_NAME"
After saving the script (e.g., greeting.sh), make it executable and run it:
chmod +x greeting.sh
./greeting.sh



��������� ������:
�� �� �������� ���� ��������� ���������� � Linux, ����� �� �� ��������� �������� �� �������� ����� ��� ���������, 
���� �������� ��������������� �������. 
��� ���:

1.��������� �� �������� ����������:
����� �� ��������� ���������� � �������� �� shell �����. ���� ���������� �� ����������� ���� �� ����� �� �������.
���� ��������� �� ��������� �� �� ����� ��������.

�� �� �������� �������� ����������, ��������� ��������� export:
export MY_VARIABLE="�������, ����!"

����� �� �������� ���������� �� ���� ���������� � echo:
echo $MY_VARIABLE


2. ��������� �� ��������� ����������:
�� �� �������� ������������ �� ��������� � �� �� �� �������� ��� ����� ���� ���������� �� ���������, ������ �� �� ������� � ��������������� ����.
���������� ������� �� ����������� ��:

~/.bashrc(�� ����������� �� Bash shell)
~/.bash_profile(�� login shell)
~/.zshrc(�� ����������� �� Zsh shell)

�� �� �������� ��������� ����������, ������ ���� �� ���� ��������������� ������� � ������� ��������:

nano ~/.bashrc
���� ���� ������ ������� ��� �� �������� �� ������������:
export MY_VARIABLE="�������, ����!"

���� ���� ������� �����, ������� ���������:
source ~/.bashrc


3. ���������� �� ���������� � ���������:
����� ���� �� ��������� ���������� ����� � shell ���������. ��� ������ ��� �� �������� � ��������� ���� ���������� � ������:

#!/bin/bash

# ���������� �� ������������
MY_NAME="����"
echo "�������, $MY_NAME"

���� ���� ������� ������� (�������� greeting.sh), ������� �� �������� � �� ���������:

chmod +x greeting.sh
./greeting.sh