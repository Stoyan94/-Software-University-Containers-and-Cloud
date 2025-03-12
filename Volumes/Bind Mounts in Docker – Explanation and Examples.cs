BG Version:

Bind Mounts в Docker – Обяснение и Примери

1. Какво представляват Bind Mounts?
Bind Mounts в Docker позволяват на контейнер да използва директно файлове и папки от хост машината.
Това означава, че данните не се управляват от Docker, а се намират в конкретна директория на хост ОС.


2. Основни характеристики на Bind Mounts:
✅ Файловете се съхраняват на хоста – контейнерът просто получава достъп до тях.
✅ Промените са в реално време – ако файл бъде редактиран на хоста, той се променя и в контейнера.
✅ Подходящи за разработка – могат да се използват за директно редактиране на код в контейнера.
✅ По-малка сигурност – контейнерът има пълен достъп до хост файловете, което може да доведе до рискове.


3. Реални примери за Bind Mounts

Пример 1: Свързване на локална папка с контейнер
Ако имаме директория /home/user/project на хост машината и искаме тя да бъде достъпна вътре в контейнера на път /app, използваме:

docker run -d --name my_container -v /home/user/project:/ app nginx
📌 Какво се случва тук?

Всички файлове в /home/user/project на хоста ще бъдат достъпни в /app в контейнера.
Ако добавим файл в /home/user/project, той веднага ще се появи в контейнера.

Пример 2: Свързване на единичен файл
Ако искаме контейнерът да използва конкретен файл от хост машината, можем да направим:

docker run -d --name my_container -v /home/user/config/nginx.conf:/ etc / nginx / nginx.conf nginx
📌 Това означава:

Файлът nginx.conf от хоста ще се използва като конфигурационен файл в контейнера.
Всяка промяна в този файл на хоста автоматично ще се отрази в контейнера.


Пример 3: Read - Only Bind Mount
Ако искаме контейнерът да има само достъп за четене до дадена директория:

docker run -d --name my_container -v /home/user/data:/ app / data:ro nginx
📌 Какво прави :ro?

Контейнерът може да чете, но не може да записва или изтрива файлове в /app/data.
Това е полезно, когато искаме контейнерът да има достъп само до конфигурации, но без да ги променя.


Пример 4: Live Code Editing (Node.js приложение)
Ако разработваме Node.js приложение и искаме автоматично обновяване при промени в кода:

docker run -d --name node_app -v $(pwd):/ usr / src / app - w / usr / src / app node npm start
📌 Какво прави това?

$(pwd) означава „текущата директория“, така че целият проект се монтира в контейнера.
Всички промени в кода веднага ще се отразяват в работещото приложение.
Подходящо за разработка, защото не се налага рестартиране на контейнера.



5. Кога да използваме Bind Mounts?
✅ Когато разработваме софтуер и искаме автоматично обновяване на кода в контейнера.
✅ Когато трябва да споделим конфигурационни файлове между контейнера и хост машината.
✅ Когато искаме директен достъп до файловете от хоста.

⚠ Не е препоръчително за production среди, защото контейнерът може случайно да изтрие или промени важни файлове на хоста.

Ако трябва да съхраняваш важни данни (като бази данни), по-добре използвай Docker Volumes.

6. Заключение
Bind Mounts са мощен инструмент за разработка, позволяващ динамична работа с файлове между контейнера и хост машината.
Те са идеални за разработчици, но не толкова сигурни за production.
Ако искаш сигурност и стабилност, Docker Volumes са по-доброто решение. 🚀





ENG Version:


Bind Mounts in Docker – Explanation and Examples

1. What are Bind Mounts?
Bind Mounts in Docker allow a container to directly use files and folders from the host machine.
This means that the data is not managed by Docker but resides in a specific directory on the host OS.


2. Key Features of Bind Mounts:
✅ Files are stored on the host – the container only gets access to them.
✅ Changes are in real-time – if a file is edited on the host, it is immediately updated in the container.
✅ Great for development – allows direct code editing inside the container.
✅ Lower security – the container has full access to host files, which may pose security risks.


3. Real-World Examples of Bind Mounts
Example 1: Mounting a Local Folder to a Container
If we have a directory /home/user/project on the host machine and want to make it accessible inside the container at /app, we use:

docker run -d --name my_container -v /home/user/project:/ app nginx
📌 What happens here?

All files in /home/user/project on the host will be available in /app inside the container.
If a file is added to /home/user/project, it will instantly appear in the container.


Example 2: Mounting a Single File
If we want the container to use a specific file from the host machine, we can do:

docker run -d --name my_container -v /home/user/config/nginx.conf:/ etc / nginx / nginx.conf nginx
📌 This means:

The nginx.conf file from the host will be used as the configuration file in the container.
Any modification to this file on the host will automatically be reflected in the container.


Example 3: Read - Only Bind Mount
If we want the container to have read-only access to a directory:

docker run -d --name my_container -v /home/user/data:/ app / data:ro nginx
📌 What does :ro do?

The container can read but cannot write or delete files in /app/data.
This is useful when we want the container to access configurations without modifying them.


Example 4: Live Code Editing (Node.js Application)
If we are developing a Node.js application and want automatic updates when making code changes:

docker run -d --name node_app -v $(pwd):/ usr / src / app - w / usr / src / app node npm start
📌 What does this do?

$(pwd) refers to the current directory, so the entire project is mounted inside the container.
Any changes to the code will immediately reflect in the running application.
This is useful for development since the container does not need to be restarted.


⚠ Not recommended for production environments, as the container may accidentally delete or modify important host files.

If you need to store critical data (such as databases), using Docker Volumes is a better choice.

6.Conclusion
Bind Mounts are a powerful tool for development, enabling seamless file access between the container and the host machine. 
They are ideal for developers but not as secure for production environments.
If security and stability are priorities, Docker Volumes are the better option. 🚀