# Bank Transfer Exception Handling in C#

A console application demonstrating custom exceptions, business logic validation, and robust error handling using `try-catch-finally` blocks in C#.

## 🚀 Project Overview

This project simulates a simplified bank transfer system where users can withdraw, deposit, and transfer funds between bank accounts. It highlights best practices for exception handling in object-oriented programming.

## 🛠️ Key Features

* **Custom Exceptions:**
  * `InsufficientFundsException`: Thrown when an account does not have enough balance for a withdrawal or transfer. It contains custom properties (`CurrentBalance` and `RequestedAmount`) to provide detailed error context.
  * `AccountLockedException`: Thrown when attempting an operation on a locked account.
  * `InvalidAmountException`: Thrown when an operation involves a zero or negative amount.
* **Business Logic & Validation (`BankAccount` & `BankService`):**
  * Validates account states and amounts before executing transactions.
  * Ensures safe execution flow using structured exception handling (`try-catch-finally`).
* **Detailed Logging:**
  * Tracks account balances at the start (`[START]`) and end (`[END]`) of every operation.

## 📂 Project Structure

* `Program.cs` — Contains test scenarios to verify successful transfers, negative amounts, insufficient funds, and locked accounts.
* `BankService.cs` — Handles the transfer logic between accounts wrapped in a `try-catch-finally` block.
* `BankAccount.cs` — Represents a bank account with `Withdraw` and `Deposit` methods.
* `InsufficientFundsException.cs` — Custom exception with balance details.
* `AccountLockedException.cs` — Custom exception for locked accounts.
* `InvalidAmountException.cs` — Custom exception for invalid amounts.

## 🧪 How to Run

1. Open the project in Visual Studio or any C# compatible IDE.
2. Build the solution.
3. Run the `Program.cs` file to execute the test scenarios in the console.
