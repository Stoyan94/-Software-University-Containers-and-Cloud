Adding a New User and Changing Their Password in Linux via CLI

1. Adding a New User
To add a new user, run:
sudo useradd -m new_user
The -m option creates a home directory for the user (under /home/new_user).

If you want to assign a specific shell (e.g., /bin/bash), use:
sudo useradd -m -s /bin/bash new_user

2. Setting or Changing a User’s Password
sudo passwd new_user
This will prompt you to enter and confirm a new password.

Useful User Management Commands
Changing User Information
Changing the Home Directory
sudo usermod -d /new/ path / to / home new_user

(If the home directory contains files, move them manually using:
mv /home/new_user /new/ path / to / home
```)

#### **Changing the Default Shell**  
```bash
sudo usermod -s /bin/zsh new_user

Adding the User to a Group
For example, to grant sudo privileges:
sudo usermod -aG sudo new_user


Deleting a User
Delete the user (without removing files):
sudo userdel new_user

Delete the user and their home directory:
sudo userdel -r new_user



Checking User Settings After Configuration
Check which groups a user belongs to:
groups new_user

Check sudo privileges:
sudo -l -U new_user

Apply new group settings without logging out
newgrp group_name
If Using SSH
If this user needs SSH access, don’t forget to add their public key to ~/.ssh / authorized_keys to allow passwordless login.

Viewing a User’s Password
You cannot see the user’s password in plain text because it is stored in a hashed format. However, you can check if a password is set.

Check if a user has a password:

sudo grep new_user /etc/shadow
Example output:
new_user:$6$hjd8...$fKJz3q8Y...:19452:0:99999:7:::
If the entry contains "!!" or "*", it means the password is not set or locked.
If it contains a hashed string (e.g., $6$...), the user has a password.

Testing if you know the password:
su - new_user
This will ask for the password, allowing you to test if it works.

Change a user’s password without knowing the current one:
sudo passwd new_user

Unlock a locked user account:
sudo passwd -u new_user
Changing a User’s Name and Other Details
Changing the Username
If you want to change a user’s name from old_name to new_name:
sudo usermod -l new_name old_name


⚠️ Important:

This does not change the home directory! (See the next section if needed.)
Ensure the user is logged out before renaming.
Changing the Home Directory

To rename the home directory and move files:
sudo usermod -d /home/new_name -m new_name

Changing User ID (UID)
sudo usermod -u 1234 new_name

⚠️ If you change the UID, update file ownership accordingly:
sudo find / -user old_UID -exec chown -h new_name {} \;

Changing the Group ID (GID)
sudo usermod -g new_group new_name


To add the user to an additional group instead of changing their primary one:
sudo usermod -aG group new_name

Locking/Unlocking a User
Lock the user (disable password login):
sudo passwd -l new_name

Unlock the user:
sudo passwd -u new_name

Deleting a User
Delete the user (keep files):
sudo userdel new_name

Delete the user and their home directory:
sudo userdel -r new_name

Changing the User’s Shell
To switch the user’s shell (e.g., to Zsh):
sudo usermod -s /bin/zsh new_name
Verifying Changes


After making changes, confirm everything is correct:

Check user ID and groups:
id new_name

Check the home directory permissions:
ls -ld /home/new_name

This guide should cover everything you need to manage users in Linux!🚀








В Linux можеш да добавиш нов потребител и да му смениш паролата през терминала със следните команди:

1.Добавяне на нов потребител
sudo useradd -m нов_потребител
-m създава home директория за потребителя (по пътя /home/нов_потребител).

Ако искаш веднага да му дадеш shell (например /bin/bash), използвай:
sudo useradd -m -s /bin/bash нов_потребител

2. Задаване или промяна на парола
sudo passwd нов_потребител
Ще ти поиска да въведеш новата парола и да я потвърдиш.


Полезни неща за управление на потребителя:

Промяна на информацията за потребителя
Промяна на home директория:
sudo usermod -d /нов/път/до/home нов_потребител
(Препоръчително е да преместиш и файловете: mv / home / нов_потребител / нов / път / до / home)

Промяна на shell:
sudo usermod -s /bin/zsh нов_потребител


Добавяне на потребителя в група:
sudo usermod -aG sudo нов_потребител
(Това ще даде sudo права на потребителя)

Изтриване на потребител
Само потребителя (без файловете):
sudo userdel нов_потребител


Потребителя + home директорията:
sudo userdel -r нов_потребител


Обновяване на правата след настройка
След като си конфигурирал потребителя, можеш да провериш дали всичко е настроено правилно:

Проверка на групите, в които е потребителят
groups нов_потребител

Проверка на sudo правата
sudo -l -U нов_потребител

Принудително обновяване на групите без да се излиза от сесията
newgrp група
Ако ще използваш този потребител за работа с отдалечен достъп (SSH), не забравяй да му добавиш публичен ключ в ~/.ssh/authorized_keys, ако искаш безпаролен достъп.



Можеш да видиш дали даден потребител има зададена парола, но не можеш да видиш самата парола в чист текст (тя се съхранява хеширана).

Проверка дали потребителят има парола
Файлът, в който Linux съхранява хешираните пароли, е /etc/shadow. За да провериш статуса на паролата, използвай:
sudo grep нов_потребител /etc/shadow

Ще получиш ред, който изглежда така:
нов_потребител:$6$hjd8...$fKJz3q8Y...:19452:0:99999:7:::
Ако след потребителското име има "!!" или "*", това означава, че потребителят няма зададена парола или тя е заключена.
Ако има хеширан стринг (като $6$...), тогава потребителят има парола.

Разкодиране на паролата
Няма как директно да видиш паролата в чист текст, защото тя е хеширана. 
Единственият начин да провериш дали знаеш паролата е да опиташ да се логнеш или да използваш:
su - нов_потребител
и да въведеш паролата.

Ако искаш да смениш паролата, без да знаеш старата
sudo passwd нов_потребител
Това ще презапише старата парола без да изисква въвеждане на текущата.

Ако потребителят е заключен (passwd -l нов_потребител), можеш да го отключиш с:
sudo passwd -u нов_потребител


    Смяна на името на потребителя и други детайли
    
 В Linux, можеш да използваш usermod. Ето няколко основни примера:

1.Промяна на потребителско име
Ако искаш да смениш името на потребителя от старо_име на ново_име:
sudo usermod -l ново_име старо_име

⚠️ Важно:
Това не променя home директорията! Ако искаш да я смениш, виж следващата точка.
Ако потребителят е логнат, трябва първо да го излезеш (logout) или да спреш всички сесии.


2. Промяна на home директория
Ако искаш да смениш home директорията и да преместиш файловете:
sudo usermod -d /home/ново_име -m ново_име
Това ще премести старите файлове в новата директория.

3. Промяна на потребителския UID (User ID)
sudo usermod -u 1234 ново_име
⚠️ Ако сменяш UID, трябва да актуализираш правата на старите файлове с:
sudo find / -user старото_UID -exec chown -h ново_име {} \;

4.Промяна на потребителската група (GID)
sudo usermod -g нова_група ново_име

Ако искаш да добавиш допълнителна група, вместо да сменяш основната:
sudo usermod -aG група ново_име

5. Заключване/отключване на потребител
Заключване:
sudo passwd -l ново_име
Това не изтрива паролата, а просто я деактивира.

Отключване:
sudo passwd -u ново_име


6. Изтриване на потребител
Само потребителя:
sudo userdel ново_име

Потребителя + home директорията:
sudo userdel -r ново_име


7. Промяна на shell
Ако искаш да смениш shell-а на потребителя (примерно на Zsh):
sudo usermod -s /bin/zsh ново_име

Допълнителен съвет:
Ако сменяш име, UID или нещо друго важно, провери дали всичко се е променило правилно:

id ново_име
и
ls -ld /home/ново_име

за да видиш дали файловете са с правилните права.