For problem 3 and 4 to display the suits correctly you must set the encoding of the project to
UTF-8. This can be done from File->Settings->Editor->File Encodings. There set the 
Project Encoding to UTF-8.

IMPORTANT: None of the mandatory problems use dependencies or Java 8 syntax, so
if you only want to check those you can just create a new project from the existing source 
and delete the Excel folder. In order to keep pathing to files relevant the project main folder
must be the folder that contains the Input.txt (i.e. you must select the folder containing input.txt
as the source when creating the project).

For Problem 11 Excel, the project uses Maven dependancies since
the libraries used to read from .xlsx were too large to fit into the 2MB .zip,
to correctly open the project you can follow these steps:

1.Start IntelliJ and chose Import new project / Alternatively from 
inside IntelliJ choose File->New Project from existing sources
2. Choose the Folder with the src folder, pom file and .iml file
3. Choose import from external model -> Maven
4. Just click next on the next slides until project is created.
5. The project uses Java 8 lambda expressions, so we have to set
the target bytecode version to 1.8 and the language level of the modules to
Java 8*
6. The Target bytecode version can be set by going to File->Settings->
Build, Execution, Deployment -> Compiler -> Java Compiler and setting 
the Target bytecode version to 1.8 there
7. The modules language level can be set by going to File-> Project Structure->
Project Settings->Modules and chosing the Language level as 8

*Steps 6 and 7 are also required, because lambda expressions are used in multiple problems
and in order for lambda expressions to be accepted by the compiler Language level must be 
set to Java 8.

If you're using Eclipse there should be similiar steps. The above steps 
are needed only if your IDE sets the language levels and output
levels to less than Java 8 by default.
