# Employee_Form_Addition

**a web page for adding employee details**

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)

## Introduction

Employee_Form_Addition is a robust web application designed to streamline the process of managing employee details. It has been meticulously developed using industry-standard practices, including the implementation of an n-tier architecture and the utilization of the repository pattern to ensure maintainability and scalability.

## Features

- **N-Tier Architecture:** The application follows a well-structured n-tier architecture, separating presentation, business logic, and data access layers to enhance code maintainability and modularity.

- **Repository Pattern:** To facilitate efficient data access and manipulation, the repository pattern has been employed, abstracting the data layer from the rest of the application and promoting code reusability.

- **Responsive Design:** Utilizing modern frontend technologies, the application features a responsive design that adapts seamlessly to various screen sizes, ensuring an optimal user experience across devices.

- **Dynamic Tables with AJAX and jQuery:** Interactive tables powered by AJAX and jQuery enable users to view and manipulate employee data dynamically without the need for page refreshes, enhancing usability and efficiency.

- **CSS, Animations, and Icons:** The application is visually appealing, leveraging CSS styling, animations, and iconography to create an engaging user interface that enhances user experience.

- **Error Handling with Toastr:** Error messages are displayed elegantly using Toastr, providing users with clear and concise feedback in case of any unexpected issues or errors.

- **Client-Side and Server-Side Validation:** Robust validation mechanisms have been implemented both on the client-side using jQuery and data annotations, and on the server-side, ensuring data integrity and security.




## Installation

### Clone the repository

```bash
git clone https://github.com/your-username/your-repository.git](https://github.com/mohamed653/EmployeeFormAddition_Task.git)
```

### Navigate into the project directory
```bash
dotnet restore
```

- Ensure you have SQL Server installed and running.
- Open the project in Visual Studio or Visual Studio Code.
- Run the following commands in Package Manager Console (PMC) or Terminal:
### Add migration
```bash
add-migration intialCreate
```
### Update the database
```bash
update-database
```
### Build the project
```bash
dotnet build
```
### Run the project
```bash
dotnet run
```



