ENG VERSION:

### **What is Blob Storage?**  
**Azure Blob Storage** is a **modern cloud technology** for **storing unstructured data**, such as files, images, videos, archives, and databases.  

💡 **Real-life analogy:**
Imagine a** huge virtual warehouse** where you can upload files and access them from anywhere in the world.  

---

### **How Does Blob Storage Work?**  
📦 **Blob (Binary Large Object)** – A file (text, image, video).  
🗂️ **Container** – A folder that holds blobs.  
☁ **Storage Account** – A cloud space that contains containers and blobs.  

📌 **Example:**
If you store photos in **Google Photos**, it's similar to Blob Storage in Azure.  

---

### **Types of Blob Storage**  
1️⃣ **Block Blob** – For storing large files (images, videos, documents).  
2️⃣ **Append Blob** – For log files and data that needs to be appended.  
3️⃣ **Page Blob** – For virtual hard disks (VHD files).  

---

### **C# Code Example for Azure Blob Storage**  

#### **1. Install Azure SDK**  
```bash
dotnet add package Azure.Storage.Blobs
```

#### **2. Upload a File to Blob Storage**  
```csharp
using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;

class Program
{
    static async Task Main()
    {
        string connectionString = "your_connection_string";
        string containerName = "mycontainer";
        string filePath = "C:\\temp\\file.txt";

        BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
        BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
        BlobClient blobClient = containerClient.GetBlobClient("file.txt");

        using FileStream uploadFileStream = File.OpenRead(filePath);
        await blobClient.UploadAsync(uploadFileStream, true);
        Console.WriteLine("File uploaded to Azure Blob Storage!");
    }
}
```

📌 **This code uploads a file to Azure Blob Storage.**  

---

### **Blob Storage vs Google Drive vs OneDrive**  

Factor	     Blob Storage	                 Google Drive	        OneDrive
Purpose	     Cloud storage for applications	 Personal storage	    Personal & business storage
Access	     API and code	                 Web & mobile apps      Web, mobile, Windows integration
Flexibility	 Very high	                     Limited	            Medium

💡 **Example:**
-**Google Drive * * is like a regular hard drive, but in the cloud.  
- **Blob Storage** is a **professional storage solution** for applications, allowing automated uploads and processing.




BG VERSION:


### **Какво е Blob Storage?**  
**Azure Blob Storage** е **съвременна облачна технология** за **съхранение на неструктурирани данни**, като файлове, изображения, видеа, архиви и бази данни.  

💡 **Пример от живота:**
Представи си** огромен виртуален склад**, в който можеш да качваш всякакви файлове и да ги изтегляш от всяко място по света.  

---

### **Как работи Blob Storage?**  
📦 **Blob (Binary Large Object)** – Представлява файл (текст, изображение, видео).  
🗂️ **Container** – Папка, в която се съхраняват файловете.  
☁ **Storage Account** – Облачно пространство, което съдържа контейнери и файлове.  

📌 **Пример:**
Ако съхраняваш снимки в **Google Photos**, това е подобно на Blob Storage в Azure.  

---

### **Видове Blob Storage**  
1️⃣ **Block Blob** – За качване на големи файлове (изображения, видеа, документи).  
2️⃣ **Append Blob** – За лог файлове и данни, които се добавят последователно.  
3️⃣ **Page Blob** – За виртуални дискове (VHD файлове).  

---

### **Код за работа с Azure Blob Storage в C#**  

#### **1. Инсталирай Azure SDK**  
```bash
dotnet add package Azure.Storage.Blobs
```

#### **2. Качи файл в Blob Storage**  
```csharp
using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;

class Program
{
    static async Task Main()
    {
        string connectionString = "your_connection_string";
        string containerName = "mycontainer";
        string filePath = "C:\\temp\\file.txt";

        BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
        BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
        BlobClient blobClient = containerClient.GetBlobClient("file.txt");

        using FileStream uploadFileStream = File.OpenRead(filePath);
        await blobClient.UploadAsync(uploadFileStream, true);
        Console.WriteLine("File uploaded to Azure Blob Storage!");
    }
}
```

📌 **Кодът качва файл в Azure Blob Storage.**  

---

### **Blob Storage vs Google Drive vs OneDrive**  
Фактор	        Blob Storage	                 Google Drive	           OneDrive
Предназначение	Облачно хранилище за приложения	 Лично съхранение	       Лично и корпоративно съхранение
Достъп	        През API и код	                 Уеб и мобилни приложения  Уеб, мобилни, Windows интеграция
Гъвкавост	    Много висока	                 Ограничена	               Средна

💡 **Пример:**
-**Google Drive** е като обикновен твърд диск, но в облака.  
- **Blob Storage** е като **професионално хранилище** за приложения, с възможност за автоматизирано качване и обработка.