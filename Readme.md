# VitaPharm

A WinForms-based pharmacy management application built with .NET 6, DevExpress, and SQL Server.
Supports distinct **Admin** and **User** roles for day-to-day operations: product catalog, purchase receipts, sales invoices, and revenue reporting.

---

## Table of Contents

1. [Features](#features)
2. [System Requirements](#system-requirements)
3. [Installation](#installation)
4. [Configuration](#configuration)
5. [Usage](#usage)

---

## Features

* **Authentication & Authorization**

  * Two roles: **Admin** (full control) and **User** (transactional only)
  * Login form with role-based menu visibility

* **User Management** *(Admin only)*

  * Create, edit, delete user accounts
  * Assign roles and activation status
  * Reset user passwords

* **Customer Management** *(Admin only)*

  * Add, edit, delete customer profiles (name, gender, contact, address)

* **Product (Commodity) Management**

  * Add/edit products (name, manufacturer, unit, type, price, status)
  * Bulk import/export via Excel (ClosedXML)
  * Activate/deactivate product listings

* **Goods Receipt (Purchase Orders)**

  * **User Role**: Create new receipts—enter supplier, batch details (manufacture/expiry date, purchase price, quantity)
  * Auto-generate receipt and batch codes when needed
  * **Admin Role**: View all receipts, deactivate obsolete entries, import/export receipts via Excel

* **Sales Invoice**

  * **User Role**: Build a “cart” by selecting product + batch to ensure correct inventory
  * Auto-calculate tax and grand total; auto-generate invoice codes
  * **Admin Role**: View all invoices, cancel invoices, import/export invoice data

* **Revenue Reporting** *(Admin only)*

  * Filter sales by date range
  * Display total sales (with/without tax)
  * Export or print summaries

---

## System Requirements

* **.NET**: .NET 6.0 and 9.0 (or the version targeted by the build)
* **Database**: SQL Server 2019 (or compatible)
* **Libraries**:
  * DevExpress WinForms (for UI controls)
  * ClosedXML (for Excel import/export)

---

## Installation

1. **Clone Repository**

   ```bash
   git clone https://github.com/ngocloan202/VitaPharm.git
   cd vitapharm
   ```

2. **Database Setup**

   * Launch SQL Server Management Studio (or equivalent).
   * Create a new database named `Database`.
   * Run the SQL scripts in `./Database/Pharmacy-DB.sql` to create all required tables.

3. **Install Dependencies**

   * Ensure you have DevExpress WinForms installed and referenced in the project.
   * The solution already references ClosedXML (for Excel import/export).
   * Build the solution in Visual Studio 2022 (or later).

4. **Run the Application**

   * In Visual Studio, set `VitaPharm.exe` (found in `/bin/Debug`) as the startup project.
   * Press **F5** or click **Run**.
   * Login with default credentials:

     * **Admin**: `hoangthilan / 12345`
     * **User**: `lethihong / 12345`

---

## Usage

1. **Login**

   * Launch the app, enter username/password, and click **Sign In**.
   * The main window displays a ribbon with menu items specific to your role.

2. **Navigate Menus**

   * **Admin View**:

     * **Human Manage**: Profile, New User, All Users, All Customers
     * **Commodity**: New Product, All Products
     * **Goods Receipt**: All Receipts → View, Deactivate, Import/Export
     * **Invoice**: All Invoices → View, Cancel, Import/Export
     * **Report**: Revenue Report

   * **User View**:

     * **Human Manage**: Profile
     * **Commodity**: (View-only or New Product if permitted)
     * **Goods Receipt**: New Receipt, All My Receipts
     * **Invoice**: New Invoice, All My Invoices

3. **Create a New Product**

   * `Commodity → New Product` → fill in name, manufacturer, unit, type, price → click **Add**.

4. **Record a Purchase (Goods Receipt)**

   * `Goods Receipt → New Receipt` → enter supplier, add batches (batch code, mfg/exp dates, price, quantity) → click **Add Receipt**.

5. **Record a Sale (Invoice)**

   * `Invoice → New Invoice` → select customer, build cart by adding products/batches, specify quantity → click **Add Invoice**.

6. **Generate Revenue Report**

   * `Report → Revenue Report` → set **From** / **To** dates → click **View Report** → export/print as needed.

---
