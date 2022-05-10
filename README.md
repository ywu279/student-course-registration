# Student Course Registration
The purpose of the project is to implement a web application that adds students to the system and shows the selected student’s registration summary.

<*CST8253 Web Programming II - lab 8*>

## Built with
- ASP.NET Web Application(.NET framework) - [Web Forms](https://docs.microsoft.com/en-us/aspnet/web-forms/)
- [Bootstrap 4.5.2](https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css)

## Get started
1. Download Visual Studio 2022
2. Double-click `lab8.sln` to open the solution in Visual Studio
3. Right-click AddStudent.aspx > View in Browser

## Features
### 1. Object Oriented Programming implemented in this web application:
  - **Encapsulation** - wrap a list of available courses inside the class *Helper* 
  - **Inheritance** - define base class *Student* and its derived class *FulltimeStudent*, *ParttimeStudent*, and *CoopStudent*
  - **Polymorphism** - *Student* class's method `RegisterCourse()` and `ToString()` are implemented in different ways in child classes

### 2. AddStudent.aspx
  - A TextBox for student's Name and a DropDownList for selecting student's type from *Fulltime*, *Parttime*, *Coop*
  - Display a table showing ID and Name of the students currently added in the system
  - Use ASP.NET Validation controls `asp:RequiredFieldValidator` for the required fields
  - Temporarily hold user inputs by storing a list of students objects into `Session` so that the inputs can be retrieved later in *RegisterCourse.aspx*
    ![image](https://user-images.githubusercontent.com/58931129/162603021-b132ba88-d578-4cca-923b-079966ad2595.png)

### 3. RegisterCourse.aspx
  - Retrieve and display a dropdown list of students added from AddStudent.aspx page
  - Display all available courses from the class *Helper*
  - After the user selected a student from the dropdown list, the web page shows the selected student’s registration summary and **pre-check** the courses the student has already registered 
  - Error message will be displayed if total course numbers/hours doesn't meet certain requirements
    ![image](https://user-images.githubusercontent.com/58931129/162603085-beedfc96-dffa-45a0-8c5d-8238960f66f5.png)

## Contributing
Any contributions are more than welcome. If you have a suggestion that would make this better, please fork the repo and create a pull request. Don't forget to give the project a star!🌟
