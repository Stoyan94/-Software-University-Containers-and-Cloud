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




mv (move) е Linux команда, която се използва за:

Преместване на файлове и директории
Преименуване на файлове и директории
Синтаксис:

mv [опции] източник дестинация
1. Примери за преместване
Преместване на файл в друга директория

mv file.txt /home/user/Documents/
Премества file.txt в /home/user/Documents/.

Преместване на няколко файла
mv file1.txt file2.txt /home/user/Documents/
Премества file1.txt и file2.txt в /home/user/Documents/.

Преместване на директория
mv my_folder /home/user/Documents/
Премества my_folder в /home/user/Documents/.


2. Примери за преименуване

Преименуване на файл
mv old_name.txt new_name.txt
Преименува old_name.txt на new_name.txt.

Преименуване на директория
mv old_folder new_folder
Преименува old_folder на new_folder.


3. Полезни опции

Подсигуряване преди презаписване (-i)
mv -i file.txt /home/user/Documents/
Ако в целевата директория има файл със същото име, пита за потвърждение преди презапис.

Презапис без потвърждение (-f)
mv -f file.txt /home/user/Documents/
Принудително премества и презаписва без предупреждение.

Показване на операцията (-v)
mv -v file.txt /home/user/Documents/
Показва какво се премества (полезно за дебъгване).


4. Комбинации за по-ефективна работа

Преместване на всички .txt файлове в друга директория:
mv *.txt /home/user/Documents/


Преместване на всички файлове, започващи с „log“:
mv log* /var/logs/


Преместване само на файлове, без директории:
mv -t /destination $(find . -maxdepth 1 -type f)