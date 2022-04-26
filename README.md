# Csharp-Uni-project
This is a project of a family Task Planner. It has different levels of privacy and employs OOP principles.  
First of all, the program creates a .txt database at path set at the top of Database.cs file (default is C:\db.txt), please change that to whatever you'd like.  
To access the program you need to pass the login screen, by default password for "Dad" is 0, "Mom" is 1, "Boy" is 2, "Girl" is 3.  
Parents create "Adult", "Kids" and "Family" tasks, as well as their personal tasks.  
Kids can only see "Family" and "Kids" tasks, as well as create and see their own personal tasks.  
If anyone from the family creates a personal task they are the only ones that can see it.  
Everyone sees "Kids" and "Family" type tasks. Only adults see the "Parents" group of tasks and mark tasks as "Done"  
