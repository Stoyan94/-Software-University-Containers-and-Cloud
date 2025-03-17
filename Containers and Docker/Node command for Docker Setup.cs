BG Version:

1.docker run
Стартира нов Docker контейнер на базата на даден имидж.

2. -it
Състои се от две флага:

-i(interactive) – Поддържа стандартния вход от терминала активен, за да можем да взаимодействаме с контейнера.
-t (tty) – Създава псевдо-терминал, което прави интерфейса по-четим и удобен.
Заедно тези два флага позволяват стартиране на интерактивна сесия в контейнера.

3. -p 8080:8080
Определя портовото пренасочване:

8080:8080 означава, че порт 8080 на хост машината (компютъра, където стартираме контейнера) ще бъде свързан с порт 8080 в контейнера.
Това позволява да достъпим уеб сървъра, който ще стартира в контейнера, чрез http://localhost:8080.


4. -v %cd%:/app
Монтира текущата директория от хост машината (%cd%) в /app в контейнера:

% cd % (Windows)връща текущата директория на терминала.
/app е директорията в контейнера, в която ще бъде монтирана текущата директория от хоста.
Това осигурява споделен достъп, така че всички промени в хост директорията веднага се отразяват в контейнера.


За Linux/macOS:
Вместо %cd%, използваме $(pwd), което връща текущата директория:

-v $(pwd):/app


5. - w / app
Задава /app като работна директория вътре в контейнера. 
Това означава, че всички команди ще се изпълняват в /app.


6. node:20
Указва, че контейнерът ще бъде създаден от имидж node:20, който съдържа Node.js версия 20.


7. npm run serve
След като контейнерът стартира, ще бъде изпълнена командата npm run serve.

Тази команда обикновено стартира уеб сървър за JavaScript приложения (например Vue.js, React, Express и др.).
npm run стартира команди, дефинирани в package.json (в секцията scripts).

Какво ще се случи при изпълнение?
Docker ще създаде и стартира контейнер от имиджа node:20.
Контейнерът ще има достъп до файловете в текущата директория (%cd%) чрез /app.
Работната директория ще бъде /app в контейнера.
Ще бъде изпълнена командата npm run serve, което ще стартира уеб сървър.
Порт 8080 на хоста ще бъде свързан с порт 8080 в контейнера, така че ще можем да отворим приложението в браузър чрез http://localhost:8080.

 Създава и стартира нов контейнер с Node.js
🔹 Настройва пренасочване на портове от 8080 на хоста към 8080 в контейнера
🔹 Монтира локалните ти файлове в /app в контейнера
🔹 Задава /app като работна директория
🔹 Изпълнява npm run serve, за да стартира уеб сървър
🔹 Прави сървъра достъпен на localhost:8080



🧐 Забележка:
В контейнера и на хост машината имат еднакви имена на двете папки app, това се дължи на монтирането на обем (volume mounting) чрез флага -v %cd%:/app.

📌 Обяснение:
Когато изпълняваш командата:


docker run -it -p 8080:8080 -v %cd%:/app -w /app node: 20 npm run serve

става следното:

% cd % (на Windows) или $(pwd) (на Linux/macOS) означава текущата директория на хост машината.
-v %cd%:/ app казва на Docker:
"Свържи текущата директория на моя компютър (%cd%) с /app в контейнера".
В резултат съдържанието на твоята директория се отразява в контейнера под /app.
    Това означава, че всички файлове и папки в текущата директория на хост машината са достъпни в контейнера под /app.
    -w /app задава /app като работна директория в контейнера.
    Така че всички команди, които изпълняваш, ще работят в /app в контейнера.

    🤔 Въпрос:
❓ Защо изглежда, че папките са с едно и също име?
Ако на хост машината имаш проект в C:\Users\Твоето_име\project, след изпълнение на командата файловете вътре ще се виждат в /app в контейнера. 
Ако влизаш в контейнера с:

docker exec -it <container_id> sh
и изпълниш ls, ще видиш същите файлове, защото /app е огледало на твоята директория.

💡 Това е полезно, защото:

Промените, които правиш на хост машината, веднага се отразяват в контейнера.
Не се налага всеки път да копираш файлове в контейнера.

Ако искаш папките да имат различни имена, просто можеш да промениш дестинацията в контейнера, например:
docker run -it -v %cd%:/ my_project - w /my_project node: 20 npm run serve

Така файловете от текущата директория ще се виждат в /my_project в контейнера вместо в /app. 🚀




ENG Version:


Super Detailed Explanation of the Command

    Let's break down the command step by step:

1. docker run
Starts a new Docker container based on a specified image.


2. -it
This consists of two flags:

✅ -i(interactive) – Keeps the container’s standard input open, allowing interaction with it.
✅ -t (tty) – Creates a pseudo-terminal, making the interface more readable and user-friendly.

🔹 Why do we use this?
Together, these flags allow us to interact with the container via the terminal.


3. -p 8080:8080
This sets up port forwarding:

📌 8080:8080 means that port 8080 on the host machine (your computer) is connected to port 8080 inside the container.

🔹 Why do we use this?
This allows us to access the web server running inside the container via:
➡️ http://localhost:8080


4. - v "%cd%:/app"
Mounts the current directory from the host machine (%cd%) into /app inside the container.

📌 Explanation:

% cd % (Windows)or $(pwd)(Linux / macOS) represents the current directory where the command is executed.
-v "%cd%:/app" tells Docker:
✅ "Sync my local directory (%cd%) with /app inside the container."
🔹 Why do we use this?
✔️ Changes made on the host machine are immediately reflected inside the container.
✔️ No need to manually copy files into the container.

For Linux/macOS, use:
-v $(pwd):/ app


5. - w / app
Sets / app as the working directory inside the container.

🔹 Why do we use this?
📌 Any commands we run inside the container will be executed in /app by default.


6. node:20
Tells Docker to use the node:20 image, which contains Node.js version 20.

🔹 Why do we use this?
✅ Ensures that Node.js is installed and ready inside the container.


7. npm run serve
After the container starts, this command is executed inside it.

📌 What does it do?

Runs the serve script defined in package.json.
Typically used to start a web server for JavaScript applications like Vue.js, React, or Express.
📌 What Happens When You Run the Command?
1️⃣ Docker creates and starts a container from the node:20 image.
2️⃣ The container mounts your current directory (%cd%) into /app.
3️⃣ The working directory inside the container is set to /app.
4️⃣ The command npm run serve executes, starting a web server.
5️⃣ Port 8080 on your host is linked to port 8080 in the container.
6️⃣ You can open the app in a browser via ➡️ http://localhost:8080 🚀

🧐 Note:
❓ Why Do Both Folders Have the Same Name?
If you notice that the folders inside the container and on the host machine have the same name, this happens because of volume mounting (-v %cd%:/ app).

📌 Detailed Explanation:
When you run:
docker run -it -p 8080:8080 - v % cd %:/ app - w / app node: 20 npm run serve
Here’s what happens:

✔️ % cd % (Windows)or $(pwd)(Linux / macOS) represents the current directory on your machine.
✔️ -v %cd%:/ app tells Docker:
"Mount my local directory (%cd%) to /app inside the container."
✔️ As a result, your host machine's files appear inside /app in the container.


🔹 Why Does It Look Like They Have the Same Name?
If you have a project in:

C:\Users\Your_Name\project
After running the command, the files inside that directory will be visible inside the container at /app.

📌 To check inside the container, run:


docker exec -it <container_id> sh
Then, inside the container, run:

ls
You'll see the same files, because /app is a mirror of your host directory.


💡 How to Use a Different Name?
If you want a different folder name inside the container, just change the destination path:

docker run -it -v %cd%:/ my_project - w / my_project node: 20 npm run serve
🔹 What happens now?
✅ Your local files will be inside /my_project instead of /app in the container. 🚀


🔥 Summary
This command:
docker run -it -p 8080:8080 - v "%cd%:/app" - w / app node: 20 npm run serve
🔹 Creates and Starts a new Node.js container
🔹 Sets up port forwarding from 8080 on the host to 8080 in the container
    🔹 Mounts your local files to /app in the container
    🔹 Sets /app as the working directory
    🔹 Runs npm run serve to start a web server
    🔹 Exposes it on localhost:8080