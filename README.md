# Student Course Registration
- Web Form ASP.NET Web Application (.NET framework)
- use [Bootstrap 4.5.2](https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css) to style pages
- Object Oriented Programming implemented in this web application:
  - **Encapsulation** - wrap a list of available courses inside the class *Helper* 
  - **Inheritance** - define base class *Student* and its derived class *FulltimeStudent*, *ParttimeStudent*, and *CoopStudent*
  - **Polymorphism** - *Student* class's method `RegisterCourse()` and `ToString()` are implemented in different ways in child classes

## AddStudent.aspx
- A TextBox for student's Name and a DropDownList for selecting student's type from *Fulltime*, *Parttime*, *Coop*
- display a table showing ID and Name of the students currently added in the system
- use ASP.NET Validation controls `asp:RequiredFieldValidator` for the required fields
- temporarily hold user inputs by storing a list of students objects into `Session`

![image](https://user-images.githubusercontent.com/58931129/162603021-b132ba88-d578-4cca-923b-079966ad2595.png)

## RegisterCourse.aspx
- retrieve and display a dropdown list of students added from AddStudent.aspx page
- display all available courses from the class *Helper*
- After the user selected a student from the dropdown list, the web page shows the selected student’s registration summary and **pre-check** the courses the student has already registered 
- Error message will be displayed if total course numbers/hours doesn't meet certain requirements

![image](https://user-images.githubusercontent.com/58931129/162603085-beedfc96-dffa-45a0-8c5d-8238960f66f5.png)

<*CST8253 Web Programming II - lab 8*>
