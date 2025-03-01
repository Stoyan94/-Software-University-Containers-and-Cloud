The cat command in Linux stands for "concatenate" and is primarily used for reading, combining, and redirecting file content.

🔹 Basic cat functionalities
View the contents of a file
cat filename.txt
📌 Displays the file contents in the terminal.


View multiple files sequentially
cat file1.txt file2.txt
📌 Shows the contents of file1.txt, followed by file2.txt.


Redirect file content to another file
cat file1.txt > file2.txt
📌 Copies the content of file1.txt into file2.txt, overwriting file2.txt.


Append content to another file
cat file1.txt >> file2.txt
📌 Appends the content of file1.txt to the end of file2.txt without deleting the existing content.


Create a new file and enter text
cat > newfile.txt
📌 Allows you to type text directly into the terminal, which will be saved in newfile.txt.
Press Ctrl + D to save and exit.


Number lines in a text file
cat -n filename.txt
📌 Displays the file content with line numbers.

Show hidden characters (such as tabs and end-of-line markers)
cat -A filename.txt
📌 Useful for detecting extra or special characters.

Merge multiple files into one
cat file1.txt file2.txt > merged.txt
📌 Combines file1.txt and file2.txt into merged.txt.


Read from standard input (stdin) and output to the terminal (stdout)
cat
📌 This command waits for user input and echoes it back.
Output can be redirected using >.

Display binary files (not human-readable output)
cat image.png
📌 Displays unreadable binary data. Useful when redirecting content to another file.



🔹 Useful cat command combinations
Piping (|) to another command
cat file.txt | grep "Linux"
📌 Filters lines that contain the word "Linux."

Using less for better readability of large files
cat largefile.txt | less
📌 Allows scrolling through the file page by page.

Comparing the contents of two files
cat file1.txt file2.txt | sort | uniq -u
📌 Displays differences between the two files.

🔹 When NOT to use cat
You don’t need to use cat file.txt | grep "Linux" because you can directly run:
grep "Linux" file.txt

If the file is very large, use less instead of cat to avoid flooding the terminal with text:
less file.txt



Командата cat в Linux е съкращение от „concatenate“ и се използва основно за четене, комбиниране и пренасочване на съдържанието на файлове.

🔹 Основни функционалности на cat
Преглед на съдържанието на файл
cat filename.txt
📌 Извежда съдържанието на файла в терминала.


Преглед на няколко файла последователно
cat file1.txt file2.txt
📌 Показва съдържанието на file1.txt, последвано от file2.txt.


Пренасочване на съдържанието на файл към друг файл
cat file1.txt > file2.txt
📌 Копира съдържанието на file1.txt в file2.txt, като презаписва file2.txt.


Добавяне на съдържание към друг файл (append)
cat file1.txt >> file2.txt
📌 Добавя съдържанието на file1.txt към края на file2.txt, без да изтрива старото съдържание.


Създаване на нов файл и въвеждане на текст
cat > newfile.txt
📌 Ще можеш да въвеждаш текст в терминала, който ще бъде записан във newfile.txt.
За да завършиш, натисни Ctrl + D.


Номериране на редове в текстов файл
cat -n filename.txt
📌 Показва съдържанието на файла с номерация на редовете.


Показване на невидими символи (например табулации и край на редове)
cat -A filename.txt
📌 Полезно за откриване на допълнителни или специални символи.


Обединяване на няколко файла в един
cat file1.txt file2.txt > merged.txt
📌 Комбинира file1.txt и file2.txt в merged.txt.


Четене от стандартен вход (stdin) и запис в изход (stdout)
cat
📌 Тази команда ще чака въвеждане от потребителя и ще отпечатва въведеното. 
Изходът може да се пренасочи с >.


Използване на cat за показване на двоични файлове
cat image.png
📌 Ще изведе неразбираем текст (бинарни данни). Полезно е, ако искаш да пренасочиш съдържанието към друг файл.


🔹 Примери за полезни комбинации
Пренасочване чрез | към друга команда

cat file.txt | grep "Linux"
📌 Филтрира редовете, които съдържат думата „Linux“.


Използване с less за по-добра четимост на големи файлове
cat largefile.txt | less
📌 Позволява преглед на файла страница по страница.


Сравняване на съдържанието на два файла
cat file1.txt file2.txt | sort | uniq -u
📌 Показва разликите между двата файла.


🔹 Кога НЕ трябва да използваш cat?
Не е нужно да използваш cat file.txt | grep "Linux", защото можеш директно да изпълниш:
grep "Linux" file.txt


Ако файлът е много голям, по-добре използвай less вместо cat, за да не залива терминала с текст:
less file.txt