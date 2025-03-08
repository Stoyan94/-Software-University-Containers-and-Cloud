English Version:
To create your own environment variables in Linux, you can define them temporarily for the current session or permanently by modifying configuration files. Here’s how:

1.Creating Temporary Variables:
You can define environment variables in your current shell session.
These variables will only exist for the duration of the session.
Once the terminal is closed, they are lost.

To create a temporary variable, use the export command:
export MY_VARIABLE="Hello, world!"

You can check the value of this variable by using echo:
echo $MY_VARIABLE


2. Creating Permanent Variables:
To make your environment variables persist across sessions, you need to add them to a configuration file. 
Common files to modify are:

~/.bashrc(for Bash shell users)
    ~/.bash_profile(for login shells)
    ~/.zshrc(for Zsh shell users)

    To create a permanent variable, open one of the configuration files with a text editor:
    

nano ~/.bashrc
Then, add the following line to set the variable:
export MY_VARIABLE="Hello, world!"

After saving the file, apply the changes:
source ~/.bashrc


3. Using Variables in Scripts:
You can also define variables inside shell scripts. 
Here’s an example of how to create and use your variables within a script:

#!/bin/bash

# Defining the variable
MY_NAME="John"
echo "Hello, $MY_NAME"
After saving the script (e.g., greeting.sh), make it executable and run it:
chmod +x greeting.sh
./greeting.sh



Българска версия:
За да създадеш свои собствени променливи в Linux, можеш да ги дефинираш временно за текущата сесия или постоянно, 
като промениш конфигурационни файлове. 
Ето как:

1.Създаване на временни променливи:
Можеш да дефинираш променливи в текущата си shell сесия. Тези променливи ще съществуват само по време на сесията.
След затваряне на терминала те ще бъдат изгубени.

За да създадеш временна променлива, използвай командата export:
export MY_VARIABLE="Здравей, свят!"

Можеш да провериш стойността на тази променлива с echo:
echo $MY_VARIABLE


2. Създаване на постоянни променливи:
За да направиш променливите си постоянни и те да се запазват при всяко ново стартиране на терминала, трябва да ги добавиш в конфигурационен файл.
Обикновени файлове за модификация са:

~/.bashrc(за потребители на Bash shell)
~/.bash_profile(за login shell)
~/.zshrc(за потребители на Zsh shell)

За да създадеш постоянна променлива, отвори един от тези конфигурационни файлове с текстов редактор:

nano ~/.bashrc
След това добави следния ред за задаване на променливата:
export MY_VARIABLE="Здравей, свят!"

След като запазиш файла, приложи промените:
source ~/.bashrc


3. Използване на променливи в скриптове:
Можеш също да дефинираш променливи вътре в shell скриптове. Ето пример как да създадеш и използваш свои променливи в скрипт:

#!/bin/bash

# Дефиниране на променливата
MY_NAME="Иван"
echo "Здравей, $MY_NAME"

След като запишеш скрипта (например greeting.sh), направи го изпълним и го стартирай:

chmod +x greeting.sh
./greeting.sh