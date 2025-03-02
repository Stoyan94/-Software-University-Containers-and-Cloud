The mv(move) command in Linux is used for:

Moving files and directories
Renaming files and directories

    The mv command is used to move files and directories from one location to another. It can also be used to rename files and directories.

Syntax:
mv [options] source destination

1. Moving Examples
Move a file to another directory
mv file.txt /home/user/Documents/
Moves file.txt to /home/user/Documents/.

Move multiple files
mv file1.txt file2.txt /home/user/Documents/
Moves file1.txt and file2.txt to /home/user/Documents/.

Move a directory
mv my_folder /home/user/Documents/
Moves my_folder to /home/user/Documents/.

2. Renaming Examples
Rename a file
mv old_name.txt new_name.txt
Renames old_name.txt to new_name.txt.

Rename a directory
mv old_folder new_folder
Renames old_folder to new_folder.

3. Useful Options
Prompt before overwriting (-i)
mv -i file.txt /home/user/Documents/
Asks for confirmation before overwriting if a file with the same name exists in the target directory.

Force overwrite without confirmation (-f)
mv -f file.txt /home/user/Documents/
Moves and overwrites without warning.

Show what is being moved (-v)
mv -v file.txt /home/user/Documents/
Displays the operation (useful for debugging).

4. Efficient Usage Tips

Move all .txt files to another directory:
mv *.txt /home/user/Documents/


Move all files starting with "log":
mv log* /var/logs/


Move only files (excluding directories):
mv -t /destination $(find . -maxdepth 1 -type f)




mv (move) � Linux �������, ����� �� �������� ��:

����������� �� ������� � ����������
������������ �� ������� � ����������
���������:

mv [�����] �������� ����������
1. ������� �� �����������
����������� �� ���� � ����� ����������

mv file.txt /home/user/Documents/
��������� file.txt � /home/user/Documents/.

����������� �� ������� �����
mv file1.txt file2.txt /home/user/Documents/
��������� file1.txt � file2.txt � /home/user/Documents/.

����������� �� ����������
mv my_folder /home/user/Documents/
��������� my_folder � /home/user/Documents/.


2. ������� �� ������������

������������ �� ����
mv old_name.txt new_name.txt
���������� old_name.txt �� new_name.txt.

������������ �� ����������
mv old_folder new_folder
���������� old_folder �� new_folder.


3. ������� �����

������������� ����� ������������ (-i)
mv -i file.txt /home/user/Documents/
��� � �������� ���������� ��� ���� ��� ������ ���, ���� �� ������������ ����� ��������.

�������� ��� ������������ (-f)
mv -f file.txt /home/user/Documents/
������������ ��������� � ���������� ��� ��������������.

��������� �� ���������� (-v)
mv -v file.txt /home/user/Documents/
������� ����� �� ��������� (������� �� ���������).


4. ���������� �� ��-��������� ������

����������� �� ������ .txt ������� � ����� ����������:
mv *.txt /home/user/Documents/


����������� �� ������ �������, ��������� � �log�:
mv log* /var/logs/


����������� ���� �� �������, ��� ����������:
mv -t /destination $(find . -maxdepth 1 -type f)