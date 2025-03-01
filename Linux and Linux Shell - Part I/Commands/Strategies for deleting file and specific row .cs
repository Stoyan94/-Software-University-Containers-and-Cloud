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
bash
Copy
Edit
vim filename.txt
Отиди на реда, който искаш да изтриеш.
Натисни dd, за да го изтриеш.
Запази с :wq.
