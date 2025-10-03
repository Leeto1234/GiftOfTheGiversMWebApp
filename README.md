# 🌍 Gift of the Givers Foundation Web Application

The **Gift of the Givers Foundation Web App** is a digital platform built to support one of Africa’s largest disaster response and humanitarian aid organizations.  
It enables **efficient management of donations, disaster relief activities, volunteers, and resources** while maintaining transparency and accessibility for both the foundation and the public.  

This project was developed in **C# (ASP.NET Core)** with **SQL Server** for backend storage and deployed via **Azure DevOps Pipelines**.

Link to Azure Devops https://dev.Azure.com/ST103758110469/
Link to GitHub  https://github.com/Leeto1234/GiftOfTheGiversMWebApp.git

## 🎯 Project Vision
The goal of this project is to provide a **centralized, secure, and scalable platform** that helps the Gift of the Givers Foundation:
- Collect and manage **donations** (financial & resources)  
- Register and manage **volunteers**  
- Track **disaster relief activities** and progress  
- Improve **communication** between the organization and the public  
- Provide an **administrative portal** for internal staff  

---

## 📌 Key Features

### 👥 User Features
- Register and log in securely  
- View ongoing **disaster relief projects**  
- Make **donations online**  
- Track contribution history  
- Access latest updates and news  

### 🔐 Admin Features
- Manage disasters and relief campaigns  
- Track donations and generate reports  
- Approve and manage volunteers  
- Manage user accounts and permissions  
- Dashboard analytics for decision-making  

---

## 🛠️ Tech Stack

- **Frontend:** Razor Pages / ASP.NET MVC  
- **Backend:** C# ASP.NET Core  
- **Database:** SQL Server (Relational Database)  
- **Version Control:** GitHub (Gitflow branching strategy)  
- **CI/CD:** Azure DevOps Pipelines  
- **Hosting:** Azure App Service  

---

## 🏗️ System Architecture Overview

```plaintext
User/Browser
     │
     ▼
 ASP.NET Core MVC (Controllers, Views, Razor Pages)
     │
     ▼
 Business Logic Layer (C# Services & Models)
     │
     ▼
 SQL Server Database (Relational Data)
