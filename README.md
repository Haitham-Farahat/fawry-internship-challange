# 🛒 Fawry Rise Journey – E-commerce OOP Challenge

This project is a solution for the Full Stack Development Internship Challenge by **Fawry**.  
It demonstrates strong OOP (Object-Oriented Programming) design with real-world modeling for an **e-commerce system**.

---

## 📌 Problem Statement

Design a console-based e-commerce system with the following features:

### ✅ Product System
- Products have:
  - `name`
  - `price`
  - `quantity`
- Products can be:
  - **Expirable** (e.g. Cheese, Biscuits)
  - **Non-expirable** (e.g. TV, Mobile)
- Some products:
  - Require **shipping** and must provide a **weight** (e.g. Cheese, TV)
  - Others **don’t require shipping** (e.g. Mobile scratch cards)

### ✅ Cart System
- Customers can:
  - Add products to their **cart** with a specific quantity (limited to available stock).
  - Proceed to **checkout**, which:
    - Fails if:
      - The cart is empty.
      - The customer’s balance is insufficient.
      - Any product is expired or out of stock.
    - Otherwise:
      - Prints:
        - 🧾 **Order Subtotal**
        - 🚚 **Shipping Fees**
        - 💰 **Total Paid**
        - 💳 **Customer Balance After Payment**
  ## 🖼️ Sample Console Output

> Below is a live preview of the application running in the console.  
> The output shows a customer adding products to their cart and performing a successful checkout, including subtotal, shipping fees, total amount paid, and updated balance.

<div align="center">
  <img src="https://github.com/user-attachments/assets/2d95dc32-a4eb-48e5-bee9-5a2fbee08510" 
       alt="Console Output" 
       style="width:80%; border-radius:10px; box-shadow:0px 4px 12px rgba(0, 0, 0, 0.1);">
</div>



