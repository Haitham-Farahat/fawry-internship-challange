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
      - Calls `ShippingService` for all shippable items, using an interface with:
        ```java
        String getName();
        double getWeight();
        ```

---

## 🧪 Example Usage

```java
cart.add(cheese, 2);
cart.add(tv, 3);
cart.add(scratchCard, 1);

checkout(customer, cart);
