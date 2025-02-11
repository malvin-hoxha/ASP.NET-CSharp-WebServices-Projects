# 2020_02_ΕΘ Project Documentation

## Overview

This project contains an ASP.NET Web Service that provides two mathematical operations: calculating the **cube** of a number and raising a number to a specific power. The Web Service is integrated with an **ASP.NET Web Forms** user interface to allow users to interact with the service through a web page.

The project consists of two main components:
1. **Web Service**: A service that exposes methods to calculate the cube of a number and raise it to a specified power.
2. **Web Forms**: A user interface that allows users to input numbers and get results via the Web Service.

---

## Project Structure

```
2020_02_ΕΘ/
│
├── 2020_02_ΕΘ.asmx              # ASP.NET Web Service File
├── 2020_02_ΕΘ.asmx.cs           # Web Service Logic (Code-behind)
├── Form.aspx                    # Web Forms Interface (UI)
├── 2020_02_ΕΘ.csproj            # Project File
├── README.md                    # Project Documentation (This file)
└── Other files and configurations
```

---

## Features

- **Web Service Methods**:
    - **THREE(double num)**: Calculates the cube of the input number.
    - **POW(double num, double num2)**: Calculates the result of raising `num` to the power of `num2`.
  
- **Web Forms Interface**:
    - A **TextBox** to input the number for cube calculation.
    - A **TextBox** for the base number and another for the exponent in the power calculation.
    - **Labels** to display the results of the calculations.
    - **Buttons** to trigger the calculations.

---

## Web Service Methods

### THREE

**URL**: `/2020_02_ΕΘ.asmx/THREE`

**Parameters**: 
- `num` (double): The number to be cubed.

**Returns**: 
- The cube of the input number (`num^3`).

**Example**:
```csharp
double result = myS.THREE(2);  // Result will be 8 (2^3)
```

### POW

**URL**: `/2020_02_ΕΘ.asmx/POW`

**Parameters**: 
- `num` (double): The base number.
- `num2` (double): The exponent.

**Returns**: 
- The result of raising `num` to the power of `num2` (`num^num2`).

**Example**:
```csharp
double result = myS.POW(2, 3);  // Result will be 8 (2^3)
```

---

## How to Use the Web Forms Interface

1. **Launch the Web Forms Page**:  
   Open the `Form.aspx` page in your browser.

2. **Input the Number for Cube Calculation**:
   - Enter a number in **TextBox1** and click the **Button1** to calculate the cube of the number.
   - The result will be displayed in **Label1**.

3. **Input the Numbers for Power Calculation**:
   - Enter the base number in **TextBox2** and the exponent in **TextBox3**.
   - Click the **Button2** to calculate the result of raising the base number to the exponent.
   - The result will be displayed in **Label2**.

---

## How to Set Up the Project Locally

### Prerequisites

- **Visual Studio** (or any other C# IDE).
- **.NET Framework** installed on your machine.

### Steps

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/repository-name.git
   ```

2. Open the project in **Visual Studio**.

3. Build and run the project.

4. Navigate to the `Form.aspx` page in your browser to use the Web Forms interface.
