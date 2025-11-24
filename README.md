# Bank Management System

Welcome to the **Bank Management System** — a complete multi-layered C#/.NET application designed to manage all operations inside a banking environment.
The system provides full functionality for customer management, account creation, deposits, withdrawals, transfers, loan management, and financial reporting.

---

## Table of Contents

1. [Project Overview](#project-overview)
2. [Architecture](#architecture)
3. [Technology Stack](#technology-stack)
4. [Project Structure](#project-structure)
5. [Features](#features)
6. [Getting Started](#getting-started)
7. [Configuration](#configuration)
8. [Modules](#modules)
9. [Data Flow](#data-flow)
10. [Database Setup](#database-setup)
11. [Business Rules](#business-rules)
12. [Error Handling](#error-handling)
13. [Testing](#testing)
14. [Support](#support)

---

## Project Overview

The **Bank Management System** is a full-featured desktop application built with C# and a layered architecture approach.
It ensures clean separation between UI, business logic, and data access.

### Key Capabilities:

* **Customer Management**: Full CRUD operations for banking customers
* **Account Management**: Create, close, activate, suspend, or update bank accounts
* **Transactions**: Deposit, withdraw, and transfer money between accounts
* **Loans**: Apply for loans, approve/reject, calculate installments, track payments
* **Authentication**: Basic login and user identity
* **Financial Reports**: Transaction logs, account statements, loan summaries
* **Audit Logs**: Track operations performed on accounts and customers

---

## Architecture

The project follows a **Clean, Layered Architecture** with the following layers:

### Layer Structure:

#### 1. **Bank (Presentation Layer)**

* WinForms UI  
* Forms for customers, accounts, transactions, loans  
* Validations and user interaction logic  
* Calls Business Layer to perform operations  

#### 2. **Bank_Business (Business Logic Layer)**

* All banking domain logic  
* Rules for transactions, loan eligibility, and account validation  
* Mapping data between DAL and UI  
* Reusable service and manager classes  

#### 3. **Bank_DataAccess (Data Access Layer)**

* SQL connection and execution  
* CRUD operations using ADO.NET  
* Stored procedures integration  
* Maps database results to entities  

---

## Technology Stack

### Core Technologies:

* **C# (.NET Framework / Windows Forms)**
* **SQL Server** (Primary database)
* **ADO.NET** for data access
* **Layered Architecture (UI → Business → DAL)**

### Additional Tools:

* Stored Procedures  
* Database Views  
* DTOs for data mapping  
* Logging (optional)

---

## Project Structure
```
BankManagementSystem/
│
├── Bank/ # Presentation Layer (Windows Forms)
│ ├── Forms/ # UI Forms
│ ├── Controls/ # User controls
│ ├── Models/ # UI models
│ ├── Helpers/ # UI helpers
│ └── Program.cs # App entry point
│
├── Bank_Business/ # Business Layer
│ ├── Services/ # Customer, Account, Transaction, Loan services
│ ├── Logic/ # Business rules
│ ├── Managers/ # Domain managers
│ └── Models/ # Domain entities
│
└── Bank_DataAccess/ # Data Access Layer
├── Data/ # SQL queries & stored procedures
├── Repositories/ # CRUD operations
├── Connection.cs # Database connection
└── DTOs/ # Data transfer objects
```
---

## Features

### 1. Customer Management

* Add, update, or delete customer data  
* Store personal info, contact details, national ID  
* Link customers to multiple accounts  

### 2. Account Management

* Create checking/savings accounts  
* Activate, suspend, close accounts  
* Auto-generate account numbers  
* Track balance and status  

### 3. Transactions Module

* Deposit  
* Withdraw  
* Transfer between accounts  
* Validate sufficient balance  
* Generate transaction history  

### 4. Loans Module

* Loan applications  
* Approval workflow  
* Payment schedules  
* Track paid and unpaid installments  

### 5. Authentication

* Basic login  
* Username/password stored securely  
* Restrict access based on user role  

### 6. Reporting

* Customer reports  
* Account statements  
* Loan summaries  
* Transaction logs  

---

## Getting Started

### Prerequisites

* **Visual Studio 2022** (recommended)
* **SQL Server / SQL Server Express**
* .NET Desktop Development tools

### Steps to Run:

1. **Clone Repository**

```bash
git clone <repository-url>
cd BankManagementSystem
```
2. **Import Database**

* Restore the SQL `.bak` or run the `.sql` file
* Ensure stored procedures & views are created

3. **Update Database Connection**
   In the DAL layer:
```csharp
public static string ConnectionString =
    "Server=YOUR_SERVER;Database=BankDB;Trusted_Connection=True;";
```

4. **Build Solution**

```
Build → Rebuild Solution
```

5. **Run Application**
   
Start Bank project

## Configuration

### Database Connection

Located in:

```
Bank_DataAccess/Connection.cs
```

### Business Rules

Defined in:
```
Bank_Business/Logic/
Bank_Business/Services/
```

## Modules

### 1. Customer Module

* Register customer
* Edit customer info
* Search by name, ID, phone
* View customer accounts

### 2. Account Module

* Create, close, suspend accounts
* Retrieve account info
* Manage balances
* Search accounts

### 3. Transactions Module

* Deposit money
* Withdraw money
* Transfer between two accounts
* Transaction logs

### 4. Loans Module

* Create loan request
* Approve/reject
* Generate payment schedule
* Track installments

### 5. Reports Module

* Account statements
* Customer summaries
* Loan reports
* Transaction lists

---

## Data Flow

```
UI (Forms)
     ↓
Business Layer (Rules & Validation)
     ↓
Data Access Layer (SQL Queries)
     ↓
Database (Tables, SPs, Views)
```

---

## Database Setup

### Required Tables:

* Customers
* Accounts
* Transactions
* Loans
* LoanPayments
* Users
* Logs

### Stored Procedures:

* Insert/Update Customers
* Insert/Update Accounts
* Perform Transaction
* Create Loan
* Generate Reports
* Insert Logs

---

## Business Rules

* Withdrawals require **sufficient balance**
* Transfers require:
  * Valid source & destination accounts
  * Enough funds
* Cannot delete customer with active accounts
* Loan approval requires:
  * No overdue payments
  * Eligibility criteria met
* Transactions only allowed on **active accounts**

---

## Error Handling

* UI validation for required fields
* SQL exception handling in DAL
* Business rules validation in BLL
* User-friendly error messages
* Optional logging for exceptions

---

## Testing

### Manual Testing

* Create customers
* Open accounts
* Deposit, withdraw, transfer
* Apply and approve loans
* Generate reports

### Future Enhancements

* Unit tests
* Role-based security
* Online banking version (Web API + Angular/React)

---

## Support

If something doesn’t work:

1. Check database connection
2. Verify stored procedures exist
3. Confirm tables are correctly linked
4. Contact your system administrator

