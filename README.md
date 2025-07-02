# Ecommerce_DB

This project contains the full relational database schema for a fictional e-commerce platform. It is designed for learning, demonstration, or as a foundation for building more advanced systems involving customer management, product tracking, orders, payments, and shipment workflows.

## Project Overview

`Ecommerce_DB` models a comprehensive backend for an online store with the following core capabilities:

- Customer registration and profiling
- Shopping cart and order creation
- Product catalog with categories and inventory
- Shipment and delivery tracking
- Payments and transaction history
- Supplier and product management
- Store feedback and reviews

---

## Contents

- `SQLQuery2.sql`: SQL script that defines all the tables, constraints, and possibly stored procedures for the database schema.
- `Screenshots/`: UI or ERD visuals that support the schema (if available).
- `.gitignore`: Excludes Visual Studio-specific and temporary files from version control.
- `.vs/`, `bin/`, `obj/`: IDE-generated folders (usually excluded from commits).

---

## Database Tables (Examples)

Here are some of the main tables and their purposes:

| Table Name         | Description |
|--------------------|-------------|
| `CustomerCart`     | Holds customer data and temporary cart information. |
| `Product`          | Contains product details (name, price, description). |
| `Orders`           | Tracks placed orders. |
| `OrderDetails`     | Line-item details for each order. |
| `Shipment`         | Tracks shipment statuses and delivery information. |
| `Payment`          | Logs payment transactions and methods. |
| `Supplier`         | Manages suppliers linked to products. |

---

Clone the repository:
   ```bash
   git clone https://github.com/Omarta1258/Ecommerce_DB.git
