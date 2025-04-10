ENG VERSION:



---

### ⚙️ What is **Grafana**?

**Grafana** is a **visualization and monitoring tool**. It allows you to create **graphs**, **tables**, and **dashboards** that display real-time information about the systems you're monitoring.

- It **does not collect data on its own** — instead, it visualizes data coming from various sources, most commonly **Prometheus**, 
but also **InfluxDB**, **Elasticsearch**, **MySQL**, and many others.
- It supports **alerting**, **dashboard sharing**, **auto-refresh**, and more.

---

### 📊 What is **Prometheus**?

**Prometheus** is a **monitoring and metrics collection system**. It:

-**Scrapes * *(pulls)metrics from various sources (called * exporters *).
- Stores those metrics in its **own time-series database**.
- Has a powerful query language called **PromQL (Prometheus Query Language)**.
- Supports **alerting**, integration with **Alertmanager**, and so on.

---

### 🧪 What is **Blackbox Exporter**?

The **Blackbox Exporter** is a special **Prometheus exporter** that lets you monitor the **availability of services from the outside**, 
without needing to install anything on the monitored service itself.

#### Example checks:
- Whether an **HTTP site** responds (e.g. `https://google.com`).
-Pinging * *IP addresses or hostnames** (ICMP ping).
- Checking **TCP ports** (whether they are open).
- Other kinds of external "black box" checks (it doesn't care how the service works internally — only if it responds).

---

## 🔗 How do they work together?

Here’s the data flow:

```text
[Blackbox Exporter] < --Prometheus scrape--[Prometheus] < --Grafana query--[Grafana Dashboard]
```

1. * *Blackbox Exporter** performs probes (e.g., checks if a website or service is available).
2. **Prometheus** regularly scrapes metrics from the Blackbox Exporter (e.g., whether the site returned HTTP 200, how long the response took, etc.).
3. **Grafana** uses **PromQL queries** to fetch those metrics from Prometheus and displays them in **graphs**, **tables**, **alerts**, and so on.
4. You get a clear, beautiful dashboard with real-time info.

---

## 🔁 Real-life Example

Let’s say you want to monitor whether your website `https://mycoolsite.com` is up and running.

-You configure** Blackbox Exporter** to probe that website.
- In **Prometheus**, you add a `job_name: "blackbox"` and tell it: "Ask Blackbox Exporter to check `https://mycoolsite.com` every 30 seconds."
- In * *Grafana * *, you create a graph with a PromQL query like:

```promql
probe_success
{ instance="https://mycoolsite.com"}
```

-This will show a graph with a value of 1 (if the site is up) or 0 (if it's down).

---




BG VERSION:


---

### ⚙️ Какво е **Grafana**?

**Grafana** е **инструмент за визуализация и мониторинг**. С нея можеш да създаваш **графики**, **таблици**, **дашборди** (табла), 
които показват в реално време състоянието на системите, които наблюдаваш.

- Тя **не събира сама по себе си данни**, а визуализира данните, които получава от различни източници – най-често **Prometheus**, 
но също така и **InfluxDB**, **ElasticSearch**, **MySQL** и много други.
- Поддържа **аларми**, **дашборд споделяне**, **автоматични обновявания на графиките**, и т.н.

---

### 📊 Какво е **Prometheus**?

**Prometheus** е **инструмент за мониторинг и събиране на метрики**. Той:

-**Събира(scrape - ва) * *метрики от различни източници (exporter-и).
- **Записва ги в собствена база данни от времеви редове (time series)**.
- Поддържа собствен език за заявки – **PromQL (Prometheus Query Language)**.
- Позволява **алармиране**, интеграция с **Alertmanager**, и т.н.

---

### 🧪 Какво е **Blackbox Exporter**?

**Blackbox Exporter** е специален **exporter за Prometheus**, който ти позволява да следиш **достъпността на услуги отвън**, без да трябва да инсталираш нещо на самите тях.

#### Примери:
- Проверява дали даден **HTTP сайт** отговаря (напр. `https://google.com`).
-Пингва * *IP адреси или хостове** (ICMP ping).
- Проверява **TCP портове** (дали са отворени).
- И други проверки на принципа "черна кутия" (не го интересува вътрешното поведение на услугата, а само дали тя отговаря отвън).

---

## 🔗 Как всичко това се връзва?

Нека ти покажа потока на данните, мастер:

```text
[Blackbox Exporter] < --Prometheus scrape--[Prometheus] < --Grafana query--[Grafana Dashboard]
```

1. * *Blackbox Exporter** проверява дали дадени сайтове, IP-та, или услуги отвън са достъпни.
2. **Prometheus** периодично "дърпа" (scrape-ва) метрики от Blackbox Exporter (например: дали сайт X върна HTTP 200, колко време отне, и т.н.).
3. **Grafana** използва **PromQL заявки**, за да покаже тези метрики под формата на **графики**, **таблици**, **аларми**, и т.н.
4. Ти гледаш всичко красиво и разбираемо на Grafana дашборда си.

---

## 🔁 Пример от реалния живот

Да кажем, че искаш да следиш дали твоят уебсайт `https://mycoolsite.com` е достъпен.

-Настройваш * *Blackbox Exporter** с конфигурация да проверява този сайт.
- В **Prometheus**, добавяш `job_name: "blackbox"` и казваш: „Питай Blackbox Exporter да проверява `https://mycoolsite.com` на всеки 30 секунди“.
-В * *Grafana * *, правиш графика с PromQL заявка като:

```promql
probe_success
{ instance="https://mycoolsite.com"}
```

-Така ще виждаш графика със стойност 1 (ако сайтът е достъпен) или 0 (ако не е).

---