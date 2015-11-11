0 
1 #include <stdio.h>
2 #include <stdlib.h>
3 #include <string.h>
4 #include <errno.h>
5 
6 void die(const char * msg);
7 
8 char * readLineFromFile(FILE * stream);
9 
10 int main(int argc, char** argv) {
11     FILE * source = fopen("03LineNumbers.c", "r");
12     if (!source) {
13         die(NULL);
14     }
15     FILE * dest = fopen("TestOutput.c", "w");
16     if (!dest) {
17         die(NULL);
18     }
19     int lineNumber = 0;
20     while (!feof(source)) {
21         char * line = readLineFromFile(source);
22         size_t len = strlen(line);
23         fprintf(dest, "%d %s\n", lineNumber, line);
24         lineNumber++;
25         free(line);
26     }
27     fclose(dest);
28     fclose(source);
29 
30     return (EXIT_SUCCESS);
31 }
32 
33 char * readLineFromFile(FILE * stream) {
34     char * buffer = malloc(60 * sizeof (char));
35     size_t size = 60;
36 
37     int counter = 0;
38     char c = fgetc(stream);
39 
40     while (c != '\n' && c != EOF) {
41 
42         buffer[counter] = c;
43         counter++;
44 
45         if (counter == size) {
46 
47             buffer = realloc(buffer, size * 2);
48             if (buffer == NULL) {
49                 printf("Cannot find sufficent free memory!");
50                 exit(1);
51             }
52             size = size * 2;
53         }
54         c = fgetc(stream);
55     }
56     char * result = realloc(buffer, counter + 1);
57     result[counter] = '\0';
58 
59     return result;
60 }
61 
62 void die(const char * msg) {
63     if (errno) {
64         perror(msg);
65     } else {
66         printf("ERROR %s\n", msg);
67     }
68 }
69 
70 
