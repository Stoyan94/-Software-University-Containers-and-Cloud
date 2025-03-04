Groups in Linux
Groups in Linux are defined in the /etc/group file. This file contains information about user groups in the system and looks like this:


root:x: 0:
sudo: x: 27:user1, user2
developers:x: 1001:user1, user3

Fields in /etc/group:
Each line contains four fields, separated by colons (:):

Group name
Password (usually x or empty if not used)
Group ID (GID)
List of users who are members of the group

Examples:
1.The root group:
root:x: 0:
root – Group name.
x – Password stored in /etc/gshadow (groups rarely use passwords).
0 – GID of the group. The root group has GID 0.
(No listed users, because root is automatically a member via /etc/passwd).

2. The sudo group:
sudo:x: 27:user1, user2
sudo – Group name.
x – Password stored in /etc/gshadow.
27 – GID of the group.
user1, user2 – These users are members of the sudo group, allowing them to run administrative commands using sudo.

3.The developers group:
developers:x: 1001:user1, user3
developers – Group name.
x – Password stored in /etc/gshadow.
1001 – GID of the group.
user1, user3 – Users who are members of the developers group.

Types of Groups:

1.Primary Group
Defined in /etc/passwd (the fourth field - GID).
Any new file a user creates belongs to this group.
Example: If user1 has developers as their primary group, all files they create will belong to developers.

2. Secondary (Supplementary) Groups
Listed in /etc/group.
A user can be a member of multiple groups, granting them additional access to files and resources.
Useful Group Management Commands:

Show a user’s groups
groups user1
Displays all groups the user user1 belongs to.

Add a user to a group
sudo usermod -aG developers user1
Adds user1 to the developers group (important: -aG adds without removing other groups).

Create a new group
sudo groupadd newgroup
Creates a new group named newgroup.

Change a user’s primary group
sudo usermod -g developers user1
Sets developers as the primary group for user1.

Remove a user from a group
sudo gpasswd -d user1 developers
Removes user1 from the developers group.

This is how Linux controls user access and file permissions using users and groups! 🚀




Групите в Linux се дефинират в файла /etc/group. Той съдържа информация за потребителските групи в системата и изглежда подобно на това:

root:x: 0:
sudo: x: 27:user1, user2
developers:x: 1001:user1, user3
Полетата във файла /etc/group:

Всеки ред съдържа 4 полета, разделени с двоеточие (:):

Име на групата
Парола (обикновено x или празно, ако не се използва)
Group ID (GID)
Списък с потребители, които са членове на групата

Разгледай примерите:

1.Групата root:
root:x: 0:
root – Името на групата.
x – Паролата е в /etc/gshadow, но групите рядко използват пароли.
0 – GID на групата. Root групата има GID 0.
(няма потребители, защото root е основен член чрез /etc/passwd).


2. Групата sudo:
sudo:x: 27:user1, user2
sudo – Името на групата.
x – Паролата е в /etc/gshadow.
27 – GID на групата.
user1, user2 – Тези потребители са част от групата sudo, което им позволява да изпълняват команди с административни права (sudo).


3. Групата developers:
developers:x: 1001:user1, user3
developers – Групата се нарича "developers".
x – Паролата е в /etc/gshadow.
1001 – GID на групата.
user1, user3 – Тези потребители са членове на групата developers.

Видове групи:

1.Основна(primary) група
Посочва се в /etc/passwd (четвъртото поле - GID).
Всеки нов файл, който потребителят създава, ще принадлежи на тази група.
Например, ако user1 има основна група developers, тогава всички файлове, които създаде, ще принадлежат на developers.


2. Допълнителни (secondary) групи
Посочват се в /etc/group.
Потребителят може да бъде член на няколко групи, което му дава допълнителни права върху файлове и ресурси.

Полезни команди за управление на групи:

Показване на групите на потребител
groups user1
Извежда всички групи, в които членува user1.

Добавяне на потребител в група
sudo usermod -aG developers user1
Добавя user1 в групата developers (важно: -aG добавя, без да премахва други групи).

Създаване на нова група
sudo groupadd newgroup
Това ще създаде нова група newgroup.

Промяна на основната група на потребител
sudo usermod -g developers user1
Задава developers като основна група на user1.

Премахване на потребител от група
sudo gpasswd -d user1 developers
Премахва user1 от developers.