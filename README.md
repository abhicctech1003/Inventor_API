# InventorAPI

This repository contains examples and resources for working with Autodesk Inventor API using C#.
## Table of Contents
- [Introduction](#introduction)
- [Getting Started](#getting-started)
- [Examples](#examples)
- [Documentation](#documentation)
- [My Implementation](#my-implementation)
## Introduction
Autodesk Inventor is a powerful 3D CAD software widely used in industries for product design and engineering. The Inventor API allows developers to extend the capabilities of Inventor using C# programming language.
This repository provides examples, tutorials, and resources to help developers get started with the Inventor API and build custom applications, plugins, or automation scripts.
## Getting Started
To get started with using the Inventor API with C#, follow these steps:
1. Install Autodesk Inventor on your machine.
2. Set up your development environment:
   - Install Visual Studio or any other preferred IDE for C# development.
   - Create a new C# project or open an existing one.
3. Reference the Inventor API assemblies:
   - Add references to the required Autodesk Inventor .NET assemblies to your project.
4. Start coding:
   - Use the provided examples and documentation to start writing code to interact with the Inventor API.
## Examples
This repository includes various examples demonstrating how to perform common tasks using the Inventor API, such as:
- Creating and modifying parts, assemblies, and drawings.
- Extracting data from Inventor files.
- Automating repetitive tasks.
- Integrating with other software or systems.
You can find these examples in the `Examples` directory of this repository.

### Form1.cs
This C# file is a Windows Forms application that utilizes the Autodesk Inventor API. It includes a form (Form1) with a button (myButton) click event handler. Upon button click, it interacts with the Inventor application by hiding selected component occurrences within an assembly document. The code also handles starting or obtaining a reference to the Inventor application.
### Form1.Designer.cs
This C# snippet defines a Windows Forms application named Form1 within the InventorAPI namespace. It includes:
1. Member variables: components for managing form components and myButton representing a button.
2. Override of the Dispose method for component disposal.
3. Windows Form Designer generated code for initializing form components, styling myButton, and setting its click event handler.
4. Form configuration specifying size, button placement, and title ("My Form").
<hr>

## Documentation
For detailed documentation on the Autodesk Inventor API, refer to the official documentation provided by Autodesk. Here are some useful resources:
- [Autodesk Inventor API Documentation](
https://knowledge.autodesk.com/support/inventor/learn-explore/caas/CloudHelp/cloudhelp/2022/ENU/Inventor-API/files/GUID-63FAA2AC-EE6C-46AC-BD22-15333C5E8F41-htm.html)