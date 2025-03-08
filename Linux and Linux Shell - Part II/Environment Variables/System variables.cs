English Version:

System variables in Linux are environment variables that store important configuration settings. 
These variables can influence the behavior of the system and programs running on it. They are typically defined in the shell session and can be used by scripts and programs.

Common System Variables:

$HOME
Represents the current user's home directory.
echo $HOME
Example output: / home / username

$USER
Represents the current logged-in user's name.
echo $USER
Example output: username


$PATH
Contains a colon-separated list of directories that the shell searches for executable files.
echo $PATH
Example output: / usr / local / bin:/ usr / bin:/ bin


$PWD
Represents the current working directory.
echo $PWD
Example output: / home / username / Documents


$SHELL
Contains the path to the current shell.
Edit
echo $SHELL
Example output: / bin / bash


How to Use System Variables:
Accessing: Simply type $VARIABLE_NAME in the terminal to access the value of the variable. For example, to access the home directory, type:
echo $HOME

Setting or Modifying: You can modify a system variable by assigning a new value to it.
export PATH=$PATH:/ new/ directory

Using in Scripts: System variables can be used inside scripts to control the behavior of your scripts dynamically.

#!/bin/bash
echo "Your current directory is $PWD"

Viewing All Variables: To list all environment variables, you can use the env or printenv command.
env






Българска версия:
Системните променливи в Linux са променливи на средата, които съхраняват важни конфигурационни настройки. 
Тези променливи могат да влияят на поведението на системата и на програмите, които се изпълняват върху нея. Те обикновено се дефинират в сесията на shell и могат да се използват от скриптове и програми.

Често използвани системни променливи:
$HOME
Представлява домашната директория на текущия потребител.

echo $HOME
Примерен изход: / home / username


$USER
Представлява името на текущия влезъл потребител.
echo $USER
Примерен изход: username


$PATH
Съдържа списък с директории, разделени с двоеточие, които shell търси за изпълними файлове.
echo $PATH
Примерен изход: / usr / local / bin:/ usr / bin:/ bin


$PWD
Представлява текущата работна директория.
echo $PWD
Примерен изход: / home / username / Documents


$SHELL
Съдържа пътя до текущия shell.
echo $SHELL
Примерен изход: / bin / bash



Как да използваме системни променливи:
Достъпване: Просто напишете $ИМЕ_НА_ПРЕМИНЛИВАТА в терминала, за да получите стойността на променливата. 
Например, за да достъпите домашната директория, напишете:

echo $HOME
Настройване или модифициране: Можете да промените стойността на системната променлива, като ѝ зададете нова стойност.

export PATH=$PATH:/ new/ directory
Използване в скриптове: Системните променливи могат да се използват в скриптове за динамично контролиране на поведението на скрипта.
#!/bin/bash
echo "Вашата текуща директория е $PWD"


Преглеждане на всички променливи: За да изведете всички променливи на средата, можете да използвате командата env или printenv.
env