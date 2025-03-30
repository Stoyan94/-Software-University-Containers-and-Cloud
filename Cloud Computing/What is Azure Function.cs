## **What is Azure Function? (Detailed and Simple Explanation)**  

### **🔹 The Main Idea**  
Azure Function is a **serverless** cloud service that allows you to execute **small pieces of code**, called **functions**, without worrying about servers or infrastructure.  

**📌 Key Points:**
✅ **Runs only when needed** (it’s not always running)  
✅ **Automatically scales** (handles high traffic efficiently)  
✅ **You pay only for the actual usage**  

---

## **🎯 How Does Azure Function Work?**  
Azure Function works similarly to a **smart motion-sensor light**:  

Azure Function Component	    Real-Life Analogy
Function	                    The light itself
Trigger	                        The motion sensor
Code execution	                The light turns on
Idle state	                    The light is off until triggered

🛠️ **How the process works:**
1️⃣ **You set up the function**  
2️⃣ **You choose a trigger (what activates it)**  
3️⃣ **The code executes automatically**  
4️⃣ **You get the result**  

---

## **🔹 Types of Azure Functions (Triggers – What Activates It?)**  

🔹 **HTTP Trigger** – Executes on an HTTP request (like an API).  
🔹 **Timer Trigger** – Runs on a schedule (e.g., every day at 12:00 PM).  
🔹 **Blob Storage Trigger** – Starts when a new file is uploaded to Azure Storage.  
🔹 **Queue Trigger * * – Works when there are messages in Azure Queue.  
🔹 **Event Grid Trigger** – Responds to events from other Azure services.  

---

## **👨‍💻 Real Example in C# (HTTP Trigger Function)**  

### **1️⃣ Creating an Azure Function**  
**Install the required tools**  
```bash
npm install -g azure-functions-core-tools@4 --unsafe -perm true
```

**Create a new function:**
```bash
func init MyFunctionApp --worker-runtime dotnet
cd MyFunctionApp
func new --name HelloFunction --template "HttpTrigger" --authlevel "anonymous"
```
📌 This creates an **HTTP-triggered function** that runs when someone sends a request to its URL.  

---

### **2️⃣ Azure Function Code (HelloFunction.cs)**  
```csharp
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

public static class HelloFunction
{
    [FunctionName("HelloFunction")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Azure Function triggered.");
        return new OkObjectResult("Hello from Azure Function!");
    }
}
```
📌 **What does this code do?**  
✅ Creates an **HTTP API** that returns "Hello from Azure Function!"  
✅ Runs** only when someone calls the URL**

---

### **3️⃣ Running the Function Locally**  
```bash
func start
```
📌 **You will get a local URL for testing, for example:**  
```
http://localhost:7071/api/HelloFunction
```
If you open this in a browser, you will see:  
```
Hello from Azure Function!
```

---

### **4️⃣ Deploying to Azure (Uploading to the Cloud)**  

**Log in to Azure:**  
```bash
az login
```
**Create a Function App:**  
```bash
az functionapp create --resource-group MyResourceGroup --consumption-plan-location westeurope --runtime dotnet --name MyAzureFunction
```
**Publish the function to the cloud:**  
```bash
func azure functionapp publish MyAzureFunction
```
📌 **Your API will be available at:**  
```
https://myazurefunction.azurewebsites.net/api/HelloFunction
```

---

## **📊 Advantages of Azure Functions**
Feature           Description
Serverless        No need to configure or manage servers.
Auto-scaling      Handles high traffic automatically.
Pay-per-use       You don’t pay if the function isn’t running.
Easy integration  Works with Azure Storage, Databases, Event Grid, etc.
---

## **📌 Real-World Use Cases for Azure Functions**  

### ✅ **1. Automatically Sending Emails**
A function can send emails when a new record is added to a database.  

### ✅ **2. Generating Reports on a Schedule**
Using a **Timer Trigger**, you can generate reports every day at 12:00 PM.

### ✅ **3. Reacting to File Uploads**
If you upload an image to **Blob Storage**, Azure Function can automatically process it.  

### ✅ **4. Processing Messages from Azure Queue**
The function can read messages from **Azure Queue Storage** and handle backend requests.  

---

## **💡 Conclusion**
🔹 **Azure Function is like a smart light – it turns on only when needed.**  
🔹 **Allows you to execute code in the cloud without managing servers.**  
🔹 **You only pay for actual execution time.**  
🔹 **Easily integrates with other Azure services.**









BG VERSION:

## **Какво е Azure Function? (Обяснено подробно и лесно)**  

### **🔹 Основна идея**  
Azure Function е **безсървърна** (serverless) услуга в облака, която ти позволява да изпълняваш **малки части от код**, наречени **функции**, без да се грижиш за сървъри или инфраструктура.  

**📌 Най-важното:**
✅ **Изпълнява се само при нужда** (не работи постоянно)  
✅ **Автоматично се мащабира** (работи бързо при голямо натоварване)  
✅ **Плащаш само за реалното използване**  

---

## **🎯 Как работи Azure Function?**  
Работата на Azure Function може да се сравни с **умна лампа със сензор за движение**:  

Част от Azure Function	 Аналогия с лампа
Функция (Function)	     Самата лампа
Тригър (Trigger)	     Датчикът за движение
Изпълнение на кода	     Лампата светва
Изчакване	             Лампата е изгасена, докато някой не мине покрай нея

🛠️ **Как се случва процесът?**  
1️⃣ **Настройваш функцията**  
2️⃣ **Избираш тригър (какво ще я задейства)**  
3️⃣ **Кодът се изпълнява автоматично**  
4️⃣ **Резултатът се връща**  

---

## **🔹 Какви типове Azure Functions има? (Тригъри – какво я задейства)**  

🔹 **HTTP тригър** – Изпълнява се при HTTP заявка (като API).  
🔹 **Timer тригър** – Работи по график (например всеки ден в 12:00).  
🔹 **Blob Storage тригър** – Стартира, когато се качи нов файл в Azure Storage.  
🔹 **Queue тригър** – Работи, когато има съобщения в Azure Queue.  
🔹 **Event Grid тригър** – Реагира на събития в други Azure услуги.  

---

## **👨‍💻 Реален пример с C# (HTTP тригър)**  

### **1️⃣ Създаване на Azure Function**  
**Инсталирай необходимите инструменти**  
```bash
npm install -g azure-functions-core-tools@4 --unsafe -perm true
```

**Създай нова функция:**
```bash
func init MyFunctionApp --worker-runtime dotnet
cd MyFunctionApp
func new --name HelloFunction --template "HttpTrigger" --authlevel "anonymous"
```
📌 Това създава **HTTP тригър функция**, която ще се задейства при заявка към URL.  

---

### **2️⃣ Код на функцията (HelloFunction.cs)**  
```csharp
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

public static class HelloFunction
{
    [FunctionName("HelloFunction")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Azure Function triggered.");
        return new OkObjectResult("Hello from Azure Function!");
    }
}
```
📌 **Какво прави този код?**  
✅ Създава HTTP API, което връща "Hello from Azure Function!"  
✅ Работи само когато някой извика URL адреса  

---

### **3️⃣ Стартиране локално**  
```bash
func start
```
📌 **Ще получиш URL за тестване, напр.:**
```
http://localhost:7071/api/HelloFunction
```
Ако отвориш този адрес в браузър, ще видиш:  
```
Hello from Azure Function!
```

---

### **4️⃣ Деплой в Azure (Качване в облака)**  

**Логни се в Azure:**  
```bash
az login
```
**Създай Function App:**  
```bash
az functionapp create --resource-group MyResourceGroup --consumption-plan-location westeurope --runtime dotnet --name MyAzureFunction
```
**Публикувай функцията в облака:**  
```bash
func azure functionapp publish MyAzureFunction
```
📌 **Твоето API ще бъде достъпно на:**  
```
https://myazurefunction.azurewebsites.net/api/HelloFunction
```

---

## **📊 Предимства на Azure Functions**
Функционалност	             Описание
Без сървъри	                 Няма нужда да конфигурираш или управляваш сървъри.
Автоматично мащабиране	     Работи добре дори при голям трафик.
Плащаш само за използването	 Ако функцията не работи, не плащаш.
Лесна интеграция	         Работи с Azure Storage, Databases, Event Grid и др.

---

## **📌 Примери за използване на Azure Functions**  

### ✅ **1. Автоматично изпращане на имейли**
Функцията може да изпраща имейли, когато се добави нов запис в база данни.  

### ✅ **2. Генериране на отчети (работа по график)**
Използвай **Timer Trigger**, за да генерираш отчети всеки ден в 12:00.  

### ✅ **3. Реакция на качени файлове**
Ако качиш снимка в **Blob Storage**, Azure Function може автоматично да я обработи.  

### ✅ **4. Обработка на съобщения от Azure Queue**
Функцията може да чете съобщения от **Azure Queue Storage** и да обработва заявки в бекенда.  

---

## **💡 Заключение**
🔹 **Azure Function е като умна лампа – включва се само когато е нужно.**  
🔹 **Позволява ти да изпълняваш код в облака без сървъри.**  
🔹 **Плащаш само за реалното използване.**  
🔹 **Лесна интеграция с други услуги на Azure.**  

🚀 **Искаш ли още примери или специфичен use case?** 😎