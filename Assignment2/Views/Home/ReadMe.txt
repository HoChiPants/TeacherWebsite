Author:    [Austin Stephens]
Partner:   [None]
Date:      [08/26/2019]
Course:    CS 4540, University of Utah, School of Computing
Copyright: CS 4540 and [Austin Stephens] - This work may not be copied for use in Academic Coursework.

Comments to Evaluators:

Repository Link - Currently not necessary

UI/UX choices - Some of the choices I made for this interface were the following
Navbar 
    Websites - Enables the user to switch between different pages this website has to
    offer. Added the readme as if it was an about page.
    Role/User - Remind the user of their permissions and to make sure they are signed
    in as the right person.
    Sign out - a necessary button for all things that you can sign in
    This was all done using bootstrap as well as the big red box at the top with 
    information in it. That is because
    it flows more and is much easier to change.
   
Body
    
    Index.html - There is a big welcome at the top to welcome the department head.
    Then each class is split into different sections, with the possibility to view each class
    in both raw and razor views. Then in each section under the table it gives you the
    information (department, Course Number, Description, Semester, and year). Then there
    is a progress bar to show the overall learning outcome completion of the class
    Then you have three options to Delete, Edit, or View the data of the class. This was 
    added for the usage of the department head. They should be able to change that sort
    of information. Then you finally have an option to add a new class. This is a big green
    button so it cant be missed.

    Course.html - At the start it welcomes you to the class you chose. Then it says your role
    (professor) and the options to add or remove learning outcomes. Then inside the 
    learning outcomes you have the head of the table (Learning Outcomes, Desciption, 
    Example, Assignment/Exam). Then inside it gives you the order of the learning outcomes,
    A small description of the assignment, the examples of students, and finally the 
    assignment/exam.

    Overall the tutorial found at 

    https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-2.2

    Was a great help and I used it as an example for most of the project. 


Footer
    The capability to easily switch back to the Department Chair Page

Files Changed:
    HomeController.cs
    CourseController.cs
    LearningOutcomeController.cs
    Data(folder)
    DbInitilizer.cs
    Migrations(folder)
    Models(folder)
    LearningModel.cs
    Course(folder)
    Create.cshtml
    Delete.cshtml
    Details.cshtml
    Edit.cshtml
    Index.cshtml
    Course.cshtml
    Index.cshtml
    RawCourse.cshtml
    ReadMe.txt
    LearningOutcome(folder)
    Create.cshtml
    Delete.cshtml
    Details.cshtml
    Edit.cshtml
    Index.cshtml
    _Layout.cshtml
    appsettings.json
    Program.cs
    Startup.cs


Consulted Peers:
    Coleman Dunn
    Evan Childs
    Ethan England
    Jonny Rallison
    The Whole Class (Aug 26)
    

References:
    https://www.w3schools.com/howto/howto_js_collapsible.asp
    https://stackoverflow.com/questions/7190898/progress-bar-with-html-and-css
    scrimba.com
    https://www.w3schools.com/html/html_tables.asp
    https://getbootstrap.com/docs/4.0/components/navbar/
    https://www.w3schools.com/howto/tryit.asp?filename=tryhow_website_bootstrap&stacked=h
    https://getbootstrap.com/docs/3.4/css/#tables-example
    https://www.yourhtmlsource.com/tables/nestingtables.html
    https://getbootstrap.com/docs/4.3/components/progress/
    https://getbootstrap.com/docs/4.0/components/buttons/
    https://getbootstrap.com/docs/4.0/components/jumbotron/
    https://mdbootstrap.com/docs/jquery/navigation/footer/
    https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-2.2
    https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/da1?view=aspnetcore-2.2
