ENG VERSION:

С удоволствие, мастер! Ето превод на всичко това на **английски**:

---

## 💡 What is Prometheus?

**Prometheus * * is an * *open - source monitoring and alerting system**, originally developed by SoundCloud.

---

## 🔍 What does it do?

- **Collects metrics** (status data) from apps, servers, and services
- Stores them as **time series data**
- Allows for **visualization and alerting**
- Uses a query language called **PromQL** (like SQL, but for metrics)

---

## 📦 How does it work?

1. **Scrapes** metrics from targets at regular intervals (e.g., every 15 seconds)
2. Each target should expose a `/metrics` endpoint
3. Data is stored locally in a time-series database
4. You can:
   -View charts in the **Prometheus UI**
   - Use **Grafana** for beautiful dashboards
   - Set up **alerts** for problems

---

## 🧱 Core Components

| Component | Purpose |
|-----------|---------|
| `prometheus.yml` | The main config file |
| Exporters | Programs that expose metrics (e.g., Blackbox, Node Exporter) |
| PromQL | The query language for working with metrics |
| Alerts | Notifications when certain conditions are met (e.g., “CPU > 90%”) |

---

## ✅ What can you monitor with it?

- CPU, RAM, disk on servers
- Website availability (with Blackbox Exporter)
- Database queries
- API response times

---





BG VERSION:


С най-голямо удоволствие, мастер! Ето ти **накратко и ясно** обяснение за **Prometheus**:

---

## 💡 Какво е Prometheus?

**Prometheus * *е * *система за мониторинг и алармиране с отворен код**, разработена първоначално от SoundCloud.

---

## 🔍 Какво прави?

- **Събира метрики** (данни за състоянието) от приложения, сървъри, услуги и др.
- **Записва ги във времеви серии** (time series).
- Позволява **визуализация и аларми** при проблеми.
- Използва език за заявки: **PromQL * *(подобен на SQL, но за метрики).

---

## 📦 Как работи?

1. **Scrape-ва** (дърпа) метрики от таргети на интервали от време (напр. на всеки 15 сек).
2. Всеки таргет трябва да има `/metrics` endpoint.
3. Данните се съхраняват локално във time series база.
4. Можеш да:
   -Гледаш графики в **Prometheus UI**
   - Използваш **Grafana** за по-красиви dashboard-и
   - Настройваш **alerts** (аларми)

---

## 🧱 Основни компоненти

| Компонент | Роля |
|-----------|------|
| `prometheus.yml` | Конфигурационен файл |
| Exporters | Програми, които изнасят метрики (например Blackbox, Node Exporter) |
| PromQL | Език за заявки върху метриките |
| Alerts | Уведомления при определени условия (например „CPU > 90%“) |

---

## ✅ Примери какво може да следиш

- CPU, RAM, диск на сървъри
- Достъпност на сайтове (с Blackbox Exporter)
- Заявки към база данни
- Време за отговор на API

---