ENG VERSION:

---

## 🌀 What is `curl`?

`curl` is a **command-line tool (CLI)** used to send **HTTP(S), FTP, SMTP**, and other types of network requests to servers.

In other words:  
> `curl` lets you "talk" to websites and APIs directly from the terminal.

---

## 📦 Common use cases:

- Downloading files from the internet  
- Calling REST APIs  
- Checking server or website responses  
- Automating tests and scripts  

---

## ✅ Example commands:

### 1. 🎯 Accessing a website:
```bash
curl https://softuni.org
```
**Result:**Displays the HTML content of the page in the terminal.

---

### 2. 📬 Sending a POST request to an API:
```bash
curl -X POST https://example.com/api -d "username=admin&password=1234"
```

---

### 3. 📥 Downloading a file:
```bash
curl -O https://example.com/file.zip
```

---

### 4. 🕵️‍♂️ Checking HTTP response headers:
```bash
curl -I https://softuni.org
```
**Result:**
```
HTTP / 2 200...
```

---

## 💡 Useful options:

| Option | Description |
| --------| -------------|
| `-X`   | Sets the HTTP method (e.g., GET, POST, PUT) |
| `-d`   | Sends data (e.g., forms, JSON) |
| `-H`   | Adds custom HTTP headers |
| `-I`   | Fetches only HTTP headers |
| `-o file.html` | Saves the result to a file |
| `-s`   | Silent mode (no progress bar or extra output) |

---

## 🧪 Example with Blackbox Exporter:

```bash
curl "http://localhost:9115/probe?target=https://softuni.org"
```

This sends an HTTP request to **Blackbox Exporter**, which performs a probe to the website and returns **Prometheus-style metrics**.

---

If you want, I can also translate or explain how to use `curl` in PowerShell or in scripts. Just say the word! 🧙‍♂️








BG VERSION:

---

## 🌀 Какво е `curl`?

`curl` е **инструмент от командния ред** (CLI), който се използва за **изпращане на HTTP(S), FTP, SMTP, и други мрежови заявки** към дадени сървъри.

С други думи:  
> `curl` ти позволява да "говориш" с уеб страници и API-та от терминала.

---

## 📦 Примери за какво се ползва:
- Теглене на файл от интернет
- Извикване на REST API
- Проверка на отговор от сайт или сървър
- Автоматизирани скриптове за тестване

---

## ✅ Примерни команди:

### 1. 🎯 Извикване на уебсайт:
```bash
curl https://softuni.org
```

Резултат: ще покаже HTML съдържанието на страницата.

---

### 2. 📬 POST заявка към API:
```bash
curl -X POST https://example.com/api -d "username=admin&password=1234"
```

---

### 3. 📥 Теглене на файл:
```bash
curl -O https://example.com/file.zip
```

---

### 4. 🕵️‍♂️ Проверка на статус код:
```bash
curl -I https://softuni.org
```

Резултат:

```
HTTP / 2 200...
```

---

## 💡 Полезни опции:

| Опция | Какво прави |
| -------| -------------|
| `-X` | Задава HTTP метод(GET, POST, PUT...) |
| `-d` | Данни за изпращане(формуляри, JSON и т.н.) |
| `-H` | Добавя HTTP заглавка(headers) |
| `-I` | Извлича само HTTP заглавките |
| `-o file.html` | Записва резултата в файл |
| `-s` | Тих режим (без прогрес бар и излишен текст) |

---

## 🧪 Пример с Blackbox Exporter:

```bash
curl "http://localhost:9115/probe?target=https://softuni.org"
```

Това изпраща HTTP заявка към Blackbox Exporter, който прави проверка към сайта и връща метрики.

---