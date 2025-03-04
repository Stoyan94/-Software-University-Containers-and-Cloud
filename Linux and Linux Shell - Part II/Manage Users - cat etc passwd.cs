The command cat /etc/passwd in Linux and Unix-based operating systems will display the contents of the /etc/passwd file.

This file contains information about the system's users, with each line describing a single user and including the following fields, separated by colons (:):

Username
Password (usually x, if /etc/shadow is used to store passwords)
User ID (UID)
Group ID (GID)
Full name or additional user information
Home directory
Shell (command interpreter)

Example content of /etc/passwd:
root:x: 0:0:root:/ root:/ bin / bash
user: x: 1000:1000:John Doe:/ home / user:/ bin / bash
nobody: x: 65534:65534:nobody:/ nonexistent:/ usr / sbin / nologin

Explanation of each field:

1.Root user:
root:x: 0:0:root:/ root:/ bin / bash
root – Username (login name).
This is the name the user logs in with.
root is the superuser (administrator).
x – Password (or a reference to /etc/shadow).
In the past, the encrypted password was stored here, but now it is usually x, meaning the actual password is in /etc/shadow for security.

0 – User ID (UID).
Each user has a unique UID.

0 means this is the root user.
Regular users typically have UIDs starting from 1000.

0 – Group ID (GID).
Defines the user’s primary group.
Here, the GID is also 0, meaning root belongs to the group with ID 0 (usually root).
root – Full name or additional user info.
Often contains the user's full name but can be left empty.

For root, it’s simply "root".
/root – Home directory.
Indicates where the user’s personal files are stored.
For root, this is /root.

For regular users, it’s usually /home/username.
/bin/bash – Shell (command interpreter).
Specifies which shell is used when the user logs in.
bash (Bourne Again Shell) is the most commonly used shell.
It can also be /bin/sh, /bin/zsh, or /usr/sbin/nologin (if login is not allowed).

2. Regular user:
user:x: 1000:1000:John Doe:/ home / user:/ bin / bash
user – Username.
x – Password stored in /etc/shadow.
1000 – UID (regular users usually start from 1000).
1000 – GID (the user's primary group has the same ID as the UID).
John Doe – Full name.
/home/user – Home directory.
/bin/bash – Default shell.

3. System user without interactive access:
nobody:x: 65534:65534:nobody:/ nonexistent:/ usr / sbin / nologin
nobody – A special user with minimal permissions, used by the system.
x – Password is in /etc/shadow.
65534 – UID (commonly reserved for nobody, with the lowest privileges).
65534 – GID (group is also nobody).
nobody – Description.
/nonexistent – No real home directory, since this user should not have access to personal files.
/usr/sbin/nologin – Prevents login to the system.






Командата cat /etc/passwd в Linux и Unix-базирани операционни системи ще покаже съдържанието на файла /etc/passwd.

Този файл съдържа информация за потребителите на системата, като всяки ред описва един потребител и включва следните полета, разделени с двоеточие (:):

Потребителско име
Парола (обикновено x, ако се използва /etc/shadow за съхранение на паролите)
UID (User ID)
GID (Group ID)
Пълно име или допълнителна информация за потребителя
Домашна директория
Shell (команден интерпретатор)

Примерно съдържание на /etc/passwd:
root:x: 0:0:root:/ root:/ bin / bash
user: x: 1000:1000:John Doe:/ home / user:/ bin / bash
nobody: x: 65534:65534:nobody:/ nonexistent:/ usr / sbin / nologin

Важно:
Ако имаш root достъп, можеш да виждаш всички потребители.
Паролите не се съхраняват в този файл за сигурност – те се намират в /etc/shadow (до който обикновените потребители нямат достъп).
Командата cat /etc/passwd е безопасна за изпълнение, но не трябва да се модифицира този файл ръчно, защото може да причини проблеми с автентикацията.

Всяки ред в /etc/passwd съдържа информация за един потребител и е разделен на 7 полета, разделени с двоеточие (:).

Нека разгледаме този ред като пример:

root:x: 0:0:root:/ root:/ bin / bash

Полета:
root – Потребителско име(login name).
Това е името, с което потребителят влиза в системата.
root е суперпотребителят (администратор).

x – Парола (или препратка към /etc/shadow).
В миналото тук се е съхранявала криптираната парола, но днес обикновено е x, което означава, че истинската парола се намира в /etc/shadow и е защитена.

0 – User ID (UID).
Всеки потребител има уникален идентификатор (UID).

0 означава, че това е root потребителят.
Обикновените потребители обикновено започват от UID 1000.

0 – Group ID (GID).
Определя основната група на потребителя.
Тук GID също е 0, което означава, че root принадлежи към групата с ID 0 (обикновено root).

root – Пълно име или допълнителна информация за потребителя.
Това поле често съдържа пълното име на потребителя, но може да остане празно.
За root просто е "root".

/root – Домашна директория.
Показва къде се намират личните файлове на потребителя.
За root това е /root, а за обикновен потребител обикновено е /home/потребителско_име.

/bin/bash – Shell (команден интерпретатор).
Определя коя обвивка (shell) ще се стартира, когато потребителят влезе в системата.
bash (Bourne Again Shell) е най-често използваният shell, но може да бъде и /bin/sh, /bin/zsh, /usr/sbin/nologin (ако не е позволен интерактивен достъп) и др.

Разгледайки другите примери:

1.Обикновен потребител:
user:x: 1000:1000:John Doe:/ home / user:/ bin / bash
user – Потребителското име.
x – Паролата се намира в /etc/shadow.
1000 – UID (обикновено първият нормален потребител започва от 1000).
1000 – GID (групата му има същия ID като UID).
John Doe – Пълното име на потребителя.
/home/user – Домашната директория.
/bin/bash – Използваният shell.

2. Потребител без интерактивен достъп:
nobody:x: 65534:65534:nobody:/ nonexistent:/ usr / sbin / nologin
nobody – Специален потребител с минимални права, използван от системата.
x – Паролата е в /etc/shadow.
65534 – UID, който обикновено е резервиран за „nobody“ (най-ниски права).
65534 – GID, групата също е „nobody“.
nobody – Описание.
/nonexistent – Няма истинска домашна директория, защото този потребител не трябва да има такива права.
/usr/sbin/nologin – Не може да се вписва в системата.
Така системата контролира достъпа на потребителите и определя правата им върху файлове и ресурси. 🚀
