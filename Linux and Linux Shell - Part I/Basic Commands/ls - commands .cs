In Linux, the ls command is used to list files and directories in a given directory. 
It is one of the most commonly used commands in the terminal.

Syntax:

bash

ls [options][path]
If executed without arguments, the ls command displays the contents of the current directory.

Commonly Used Options:
Option Description
-l	Long format (shows permissions, owner, group, size, modification date, and file name).
-a	Shows all files, including hidden ones (files starting with .).
-h	Displays file sizes in a human-readable format (e.g., 1K, 234M, 2G). Works with -l (ls -lh).
-R	Lists directory contents recursively (including subdirectories).
-t	Sorts files by modification time (newest first).
-S	Sorts files by size (largest first).
-r	Reverses the sorting order.

Examples:
List all files, including hidden ones:
ls -a

Detailed view with human-readable file sizes:
ls -lh

List files sorted by size:
ls -lS

Recursively list all files and subdirectories:
ls -R

Additional Tips:
You can combine multiple options, for example:
ls -lah

This will show all files (including hidden ones) in a detailed view with human-readable sizes.

To list files in a specific directory, specify the path:
ls /var/log



When to Use ls -al
When you want to see all files, including hidden ones, to check configuration files (e.g., .bashrc, .gitignore).
When you need detailed information about files (permissions, owner, size, last modification date).
For diagnosing file and permission issues – if a program isn't working, it might be due to incorrect permissions (chmod can fix them).
When administering a server or working in the Linux terminal.
Yes, exactly! In Linux, you can combine ls options to get different levels of information.

Examples of Combining Options:
Show all files + Detailed view + Human-readable sizes
ls -alh
-a → Shows all files, including hidden ones
-l → Long format (detailed view)
-h → Human-readable sizes (MB, KB, GB)


Show all files + Detailed view + Sort by size
ls -alS
-S → Sorts by size (largest files first)


Show all files + Detailed view + Sort by modification date
ls -alt
-t → Sorts by modification date (newest files first)

Show all files + Detailed view + Recursively list subdirectories
ls -alR
-R → Displays all subdirectories and their files

Reverse sorting order (smallest or oldest files first)
ls -alSr
-r → Reverses sorting order

How to Check All Available Options?
If you want to see the full list of ls options, use:
man ls







В Linux командата ls се използва за изброяване на файловете и директориите в дадена директория. 
Това е една от най-често използваните команди в терминала.

Синтаксис:
bash
ls [опции][път]
Ако бъде изпълнена без аргументи, командата ls показва съдържанието на текущата директория.

Често използвани опции:
Опция Описание
-l	Подробен изглед (показва права за достъп, собственик, група, размер, дата на промяна и име на файла).
-a	Показва всички файлове, включително скритите (файлове, които започват с .).
-h	Прави размера на файловете по-разбираем (например 1K, 234M, 2G). Работи с -l (ls -lh).
-R	Показва съдържанието рекурсивно (включително поддиректориите).
-t	Сортира файловете по време на последна промяна (най-новите първи).
-S	Сортира файловете по размер (най-големите първи).
-r	Обръща реда на сортиране.


Примери:
Преглед на всички файлове, включително скритите:
ls -a

Подробен изглед с човешки-разбираеми размери:
ls -lh

Изброяване на файлове, сортирани по размер:
ls -lS

Рекурсивно изброяване на всички файлове и поддиректории:
ls -R

Допълнителни съвети:
Можеш да комбинираш опциите, например:
ls -lah
Това ще покаже всички файлове (включително скритите) в подробен режим с разбираеми размери.

Ако искаш да видиш файловете в дадена директория, можеш да посочиш път:
ls /var/log


Кога да използваш ls -al?
Когато искаш да видиш всички файлове, включително скритите, за да провериш конфигурационни файлове (например .bashrc, .gitignore).
Когато ти трябва подробна инфоровемация за файлте (права за достъп, собственик, размер, дата на последна промяна).
При диагностика на файлове и права – ако дадена програма не работи, може да е заради грешни права (chmod може да ги коригира).
Когато администрираш сървър или работиш с терминала в Linux.

Да, точно така! В Linux можеш да комбинираш опциите на ls, за да получиш различни нива на информация.

Примери за комбиниране на опции:
Всички файлове + Подробен изглед + Човешко-четим размер
ls -alh
-a → Показва всички, включително скритите
-l → Детайлен изглед
-h → По-четим формат за размери (MB, KB, GB)

Всички файлове + Подробен изглед + Сортиране по размер
ls -alS
-S → Сортира по размер (най-големите файлове първи)

Всички файлове + Подробен изглед + Сортиране по дата на последна промяна
ls -alt
-t → Сортира по дата на промяна (най-новите файлове първи)

Всички файлове + Подробен изглед + Рекурсивно преглеждане на поддиректории
ls -alR
-R → Показва всички поддиректории и техните файлове


Обратен ред на сортиране (най-малките или най-старите файлове първи)
ls -alSr
-r → Обръща реда на сортиране

Как да провериш всички налични опции?
Ако искаш да видиш пълния списък с възможности на ls, използвай:
man ls
