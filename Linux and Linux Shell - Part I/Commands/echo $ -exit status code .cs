The echo $? command in Linux returns the exit status code of the last executed command.

🔹 What does the exit status code mean?
When you run a command in Linux, it returns a numerical value that indicates whether the command was successful or encountered an error:

0 – Successful execution.
1 - 255 – Error or various types of issues.

📌 Examples of using echo $?
    The echo $? command is useful for checking the exit status code of the last command executed in the terminal or a script.
✅ Example 1: Successful command
ls
echo $?
👉 If ls runs without errors, echo $? will return 0.


❌ Example 2: Failing command
ls /non_existing_folder
echo $?
👉 Since the folder does not exist, ls will return an error, and echo $? may return, 
for example, 2 (error while searching for a file or directory).


🛠 Example 3: Check after running a script
./myscript.sh
echo $?
👉 If myscript.sh runs successfully, it will return 0; otherwise, it will return another value.


🔄 Example 4: Conditional check
If we want to check whether a given command ran successfully:

mkdir test_dir
if [ $? -eq 0 ] ; then
  echo "Directory was created successfully!"
else
  echo "Error creating the directory!"
fi
💡 Summary:
The echo $? command is useful for debugging, scripting, and automation, as it allows you to check 
if a command completed successfully or encountered an error.







Командата echo $? в Linux връща кода за изход (exit status) на последната изпълнена команда.

🔹 Какво означава кодът за изход?
Когато изпълнявате команда в Linux, тя връща числова стойност, която показва дали командата е била успешна или е срещнала грешка:

0 – Успешно изпълнение.
1 - 255 – Грешка или различни видове проблеми.

📌 Примери за използване на echo $?
✅ Пример 1: Успешна команда
ls
echo $?
👉 Ако ls се изпълни без грешки, echo $? ще върне 0.


❌ Пример 2: Грешна команда
ls /несъществуваща_папка
echo $?
👉 Тъй като папката не съществува, ls ще даде грешка, а echo $? може да върне напр. 2 (грешка при търсене на файл или директория).


🛠 Пример 3: Проверка след изпълнение на скрипт
./myscript.sh
echo $?
👉 Ако myscript.sh се изпълни успешно, ще върне 0, иначе ще върне друга стойност.


🔄 Пример 4: Условна проверка
Ако искаме да проверим дали дадена команда е изпълнена успешно:


mkdir test_dir
if [ $? -eq 0 ] ; then
  echo "Директорията е създадена успешно!"
else
  echo "Грешка при създаването на директория!"
fi

Това е краят на условния блок if. 
В bash скриптовете, блокът if трябва да бъде завършен с fi.


💡 Обобщение:
Командата echo $? е полезна за отстраняване на грешки, скриптове и автоматизация, 
защото позволява да се провери дали дадена команда е завършила успешно или е дала грешка.
