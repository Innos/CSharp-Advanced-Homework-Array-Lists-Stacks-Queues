//Previous commands 
//jar cfm GeneratePDFByExternalLibrary.jar Manifest.txt GeneratePDFByExternalLibrary.class
//^ Generates a jar file with a manifest which can specify the entry point of the program(the main class) and 
//the class path to the dependancies (the external libraries used)
//Note GeneratePDFWithManifest.jar is the same jar but with the class path to dependancies added in the manifest
//thus it can run from the jar file directly and does not require being run from the console with a specified class path
//Note class Paths are relative to the .jar file so any change in the directory structure will cause them to stop working and throw an Error

java -cp GeneratePDFByExternalLibrary.jar;lib/* GeneratePDFByExternalLibrary

