ENG VERSION:


---

## 🔍 What is Blackbox Exporter?

**Blackbox Exporter * * is a component of the **Prometheus ecosystem** that allows you to monitor external services 
using a **"blackbox" approach * * — meaning you don't need to know what’s inside. 
It's primarily used for **ping, HTTP, TCP, and DNS checks** — to verify whether a service is "alive" and responding correctly.

---

### 🔧 Main types of probes it supports:

- **http** – HTTP(S) GET/POST checks  
- **icmp** – ping (similar to the `ping` command in the terminal)  
- **tcp** – check if a TCP port is open  
- **dns** – verify that a DNS record resolves correctly  

---

## 🌐 URL Analysis:

```
http://localhost:9115/probe?target=https://softuni.org/
```

This is a * *direct call to the Blackbox Exporter**, which will:

-**start a probe**
- to the site `https://softuni.org/`
- using the **default module * *, which is `http_2xx` (unless specified otherwise in the configuration)

---

## 📌 What it does in practice:

- Sends an **HTTP GET request** to `https://softuni.org/`
-Checks:
  - if **access is successful * *(i.e., it receives a response)
  - if the **status code** is in the 2xx range (e.g., 200, 204)
  - if there is a valid **connection to the domain**
  - how long it takes (`probe_duration_seconds`)
- Returns **Prometheus-formatted metrics**

---

## 📋 Example output (if opened in a browser or via `curl`):

```
probe_success 1
probe_http_status_code 200
probe_duration_seconds 0.294
...
```

- `probe_success 1` = the probe was **successful**  
- `probe_http_status_code 200` = site responded with **HTTP 200 OK**  
- `probe_duration_seconds` = how long the probe took

---

## 🧪 Bonus: Test it in the terminal

```bash
curl "http://localhost:9115/probe?target=https://softuni.org/"
```

If you get `probe_success 0`, it means **something is broken**. Possible reasons:

-The site is not reachable
- No internet connection
- SSL error
- Blackbox Exporter is not running

---






BG VERSION:

Какво е Blackbox Exporter?
Blackbox Exporter е компонент на екосистемата на Prometheus, който позволява мониторинг на външни услуги 
чрез „blackbox“ подход – тоест без да знаеш какво има „вътре“.
Използва се основно за проверки от типа ping, HTTP, TCP и DNS – дали дадена услуга е „жива“ и отговаря коректно.

🔧 Основни проверки, които поддържа:
http – HTTP(S) GET/POST проверки

icmp – ping (подобно на ping в терминала)

tcp – проверка дали TCP порт е отворен

dns – дали даден DNS запис се резолва правилно

URL анализ:

http://localhost:9115/probe?target=https://softuni.org/
Това е директно извикване на Blackbox Exporter, което ще:

стартира проверка(probe)

към сайта https://softuni.org/

използвайки дефолтния модул, който е http_2xx (ако не е указано друго в конфигурацията)

📌 Какво ще направи на практика:
Ще направи HTTP GET заявка към https://softuni.org/

Ще провери:

дали достъпът е успешен (получи ли се отговор)

дали статус кодът е 2xx (напр. 200, 204)

дали има връзка към домейна

колко време отнема (probe_duration_seconds)

ще върне Prometheus-сови метрики

📋 Примерен резултат (ако го отвориш в браузър или с curl):

probe_success 1
probe_http_status_code 200
probe_duration_seconds 0.294
...
probe_success 1 значи: "Успешна проверка".probe_http_status_code 200 → "OK" отговор от сайта. probe_duration_seconds → колко време е отнело.

🧪 Бонус:

curl "http://localhost:9115/probe?target=https://softuni.org/"
Ако получиш probe_success 0, значи нещо е счупено – възможни причини:

сайтът не е достъпен

няма интернет

лош SSL

blackbox exporter не работи