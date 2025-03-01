🔹 Delete a single file

rm filename.txt
📌 Deletes filename.txt. If the file is protected, it may ask for confirmation.

🔹 Delete without confirmation
rm -f filename.txt
📌 -f (force) removes the file without asking for confirmation.


🔹 Delete multiple files at once
rm file1.txt file2.txt file3.txt


🔹 Delete all files with a specific extension
rm *.txt
📌 This will delete all .txt files in the current directory.


🔹 Delete an empty directory
rmdir directory_name
📌 rmdir only works if the directory is empty.


🔹 Delete a directory and its contents
rm -r directory_name
📌 -r (recursive) deletes the directory and all files inside.



🔹 Force delete a directory without confirmation
rm -rf directory_name
📌 Useful for removing folders with many files.

⚠️ Warning! Running rm -rf / can wipe your entire system! Use this command carefully.




Delete a specific line using sed
Delete the 3rd line from the file:


sed -i '3d' filename.txt
📌 -i applies the change directly to filename.txt.


Delete multiple lines (e.g., from line 2 to 4):
sed -i '2,4d' filename.txt


Delete a line containing specific text:
sed -i '/some text/d' filename.txt
📌 Removes all lines that contain "some text".


🔹 Delete a line using awk
Delete the 5th line:
awk 'NR!=5' filename.txt > temp && mv temp filename.txt
📌 NR!=5 means "print all lines except the 5th".


🔹 Delete a line in vim (manual editing)
Open the file with vim:
vim filename.txt
Go to the line you want to delete.
Press dd to delete it.
Save and exit with :wq.


🔹 Delete a file using its full path
If two files have the same name but are in different directories, use the full path:

rm /path/to/file/filename.txt
📌 Example:

rm /home/user/Documents/filename.txt


🔹 Delete by date or size using ls and rm
If two files with the same name exist in the same directory but have different content (different timestamps or sizes), list them with:
ls -lt filename.txt
📌 This sorts files by date.


Delete the older file:
ls -lt filename.txt | tail -1 | awk '{print $9}' | xargs rm
📌 This removes the oldest file if there is a duplicate.


🔹 Delete by inode (for hard links in the same directory)
Check inode numbers of the files:
ls -i filename.txt
📌 This displays unique inode numbers.

Delete a file by inode:
find . -inum 123456 -delete
📌 Replace 123456 with the actual inode number.


🔹 Delete with confirmation (rm -i)
If you are unsure which file to delete, use:
rm -i filename.txt
📌 Linux will ask for confirmation before deleting.





🔹 Изтриване на един файл
rm filename.txt
📌 Изтрива filename.txt. Ако файлът е защитен, може да поиска потвърждение.


🔹 Изтриване без потвърждение
rm -f filename.txt
📌 -f (force) премахва файла без да пита за потвърждение.


🔹 Изтриване на няколко файла едновременно
rm file1.txt file2.txt file3.txt


🔹 Изтриване на всички файлове с определено разширение
rm *.txt
📌 Това ще изтрие всички .txt файлове в текущата директория.


🔹 Изтриване на празна директория
rmdir directory_name
📌 rmdir работи само ако директорията е празна.


🔹 Изтриване на директория и нейното съдържание
rm -r directory_name
📌 -r (recursive) изтрива директорията и всички файлове вътре.


🔹 Принудително изтриване на директория без потвърждение
rm -rf directory_name
📌 Полезно за премахване на папки с много файлове.

⚠️ Внимание! rm -rf / може да изтрие цялата система! Използвай командата внимателно.


В Linux можеш да изтриеш конкретен ред от файл с командите sed, awk или vim.

🔹 Изтриване на определен ред с sed
Изтриване на 3-ти ред от файла:
sed -i '3d' filename.txt
📌 -i прави промяната директно в filename.txt.

Изтриване на няколко реда (например 2-ри до 4-ти):
sed -i '2,4d' filename.txt

Изтриване на ред, съдържащ определен текст:
sed -i '/some text/d' filename.txt
📌 Изтрива всички редове, които съдържат "some text".


🔹 Изтриване на ред с awk
Изтриване на 5-ти ред:
awk 'NR!=5' filename.txt > temp && mv temp filename.txt
📌 NR!=5 означава „изведи всички редове, освен петия“.


🔹 Изтриване на ред в vim (ръчно редактиране)
Отвори файла с vim:
vim filename.txt
Отиди на реда, който искаш да изтриеш.
Натисни dd, за да го изтриеш.
Запази с :wq.




В Linux не можеш да имаш два напълно еднакви файла в една и съща директория, защото файловите имена трябва да са уникални.
Но ако имаш два файла със същото име в различни директории, можеш да изтриеш конкретния файл, който искаш, по няколко начина:

🔹 Изтриване по пълен път на файла
Ако двата файла са в различни директории, просто използвай пълния път:
rm /path/to/file/filename.txt

📌 Например:
rm /home/user/Documents/filename.txt


🔹 Изтриване по дата или размер с ls и rm
Ако двата файла са в една директория, но са с различно съдържание (различни дати/размери), можеш да видиш детайли с:
ls -lt filename.txt
📌 Това ще покаже файловете, подредени по дата.

Изтриване на по-стария файл:
ls -lt filename.txt | tail -1 | awk '{print $9}' | xargs rm
📌 Изтрива по-стария файл, ако има дубликат.


🔹 Изтриване по inode (ако файловете са дубликати в една папка, създадени чрез ln)
Провери inode номерата на файловете:
ls -i filename.txt
📌 Това ще покаже inode номерата (уникални идентификатори за файлове в една директория).


Изтрий файла по inode:
find . -inum 123456 -delete
📌 Заместваме 123456 с реалния inode номер.


🔹 Изтриване с потвърждение (rm -i)
Ако не си сигурен кой файл да изтриеш, използвай:
rm -i filename.txt
📌 Linux ще те попита преди изтриването.
