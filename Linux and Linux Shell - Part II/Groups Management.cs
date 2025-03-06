How to View Users in a Specific Group in Linux

1. Display All Users in a Specific Group
Use this command to see which users belong to a specific group:
getent group group_name

Example:

getent group sudo
The output will look like this:
sudo:x: 27:user1, user2, user3
The list after the last colon (:) represents the users in the group.

2. Show Groups a User Belongs To

groups username
or
id -Gn username

Example:

groups user1
Possible output:

user1 : user1 sudo docker
This means user1 is in the groups user1, sudo, and docker.

3. List All Existing Groups in the System

cut -d: -f1 / etc / group
or
getent group | cut -d: -f1
This will display all groups in the system.

4. Use awk for Cleaner Output
If you want to see only the list of users in a given group (without additional information):

getent group group_name | awk -F: '{print $4}'

Example:
getent group sudo | awk -F: '{print $4}'
Output:

user1, user2, user3




Adding, Removing, or Moving a User in Groups in Linux
1. Adding a User to a Group
✅ Add a user to a single group:


sudo usermod -aG group_name username
✅ Add a user to multiple groups:

sudo usermod -aG group1, group2, group3 username
❗ -aG means "append to the group without removing existing ones."

✅ Adding with gpasswd (more secure method):
sudo gpasswd -a username group_name


2. Removing a User from a Group
✅ Remove a user from a group:
sudo gpasswd -d username group_name

✅ Remove all additional groups (except the primary one):

sudo usermod -G primary_group username
✅ Change the primary group:
sudo usermod -g new_primary_group username


3. Moving a User to Another Group
If you want the user to be in a new group and remove them from all previous groups:

sudo usermod -G new_group username
⚠️ This will remove the user from all previous groups, leaving only new_group!

4. Checking User Group Membership
✅ Check all groups a user belongs to:

groups username
or
id -Gn username

✅ List all users in a specific group:
getent group group_name

✅ List all existing groups in the system:
cut -d: -f1 / etc / group






FКак да видиш потребителите в дадена група в Linux
1. Показване на всички потребители в конкретна група

Използвай тази команда, за да видиш кой е в определена група:
getent group group_name

Пример:

getent group sudo
Резултатът ще изглежда така:

sudo:x: 27:user1, user2, user3
Списъкът след последното двоеточие (:) са потребителите в групата.

2. Показване на групите, в които е даден потребител

groups username

или
id -Gn username

Пример:

groups user1

Може да върне нещо като:

user1 : user1 sudo docker
Това означава, че user1 е в групите user1, sudo и docker.

3. Показване на всички съществуващи групи в системата

cut -d: -f1 / etc / group

или

getent group | cut -d: -f1
Това ще изведе всички групи в системата.

4. Използване на awk за по-чист изход
Ако искаш само списъка с потребителите в дадена група (без другата информация):

getent group group_name | awk -F: '{print $4}'

Пример:
getent group sudo | awk -F: '{print $4}'

Резултат:
user1, user2, user3






Добавяне, премахване или преместване на потребител в групи в Linux
1. Добавяне на потребител в група

✅ Добавяне на потребител към една група:
sudo usermod -aG group_name username

✅ Добавяне на потребител към няколко групи:
sudo usermod -aG group1, group2, group3 username
❗ -aG означава „добави в групата, без да премахваш текущите“.

✅ Добавяне с gpasswd (по-сигурен метод)
sudo gpasswd -a username group_name

2. Премахване на потребител от група

✅ Премахване на потребител от група:
sudo gpasswd -d username group_name

✅ Премахване на всички допълнителни групи (освен основната):
sudo usermod -G primary_group username

✅ Промяна на основната група:

sudo usermod -g new_primary_group username


3. Преместване на потребител в друга група
Ако искаш потребителят да бъде само в нова група (и да бъде премахнат от предишните):

sudo usermod -G new_group username
⚠️ Това ще изтрие всички предишни групи, в които е бил, и ще остави само new_group!

4. Проверка на групите на потребител
✅ Проверка на всички групи, в които е даден потребител:

groups username

или

id -Gn username

✅ Показване на всички потребители в дадена група:
getent group group_name

✅ Списък с всички групи в системата:

cut -d: -f1 / etc / group