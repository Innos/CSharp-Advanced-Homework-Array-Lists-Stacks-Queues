

#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <unistd.h>

#define BUFFER_SIZE 4096

void die(const char * msg);
void slice(const char* source, const char * destination, size_t parts);
void assemble(char ** parts, const char * destinationDirectory, size_t partsNumber);
void printHelp(char * program);

//If you're having trouble testing this program read the IMPORTANT Read This file
int main(int argc, char** argv) {
    if(argc == 1){
        printHelp(argv[0]);
        return 0;
    }
    
    if(strcmp(argv[1],"-s") == 0)
    {
        if(argc == 5){
            char * source = argv[2];
            char * sliceDest = argv[3];
            char * exBuffer;
            unsigned long parts = strtoul(argv[4],&exBuffer,10);
            if(exBuffer != NULL)
            {
                die("Could not parse number of parts correctly.");
            }
            if(errno)
            {
                die(NULL);
            }
            slice(source,sliceDest,parts);
        }
        else{
            printHelp(argv[0]);
        }
    }
    else if(strcmp(argv[1],"-a") == 0)
    {
        if(argc >= 5)
        {
            char ** files = argv + 3;
            size_t parts = argc - 3;
            char * assembleDest = argv[2];
            assemble(files,assembleDest,parts);
        }
        else{
            printHelp(argv[0]);
        }
    }
    else{
        printHelp(argv[0]);
    }
    return (EXIT_SUCCESS);
}

void slice(const char* source, const char * destination, unsigned long parts) {

    //open stream to source
    FILE * src = fopen(source, "r");
    if (!src) {
        die(NULL);
    }

    //find the extension of the source file
    char* ending = strrchr(source, '.');

    //find size of file and of parts with fseek
    fseek(src, 0L, SEEK_END);
    long size = ftell(src);
    fseek(src, 0L, SEEK_SET);
    long part = (size / parts) + 1;

    //for cycle for each part
    int i;
    for (i = 0; i < parts; i++) {

        //set the name of the part and copy it to files
        char * resultName = calloc(60, sizeof (char));
        if(resultName == NULL)
        {
            die("Cannot allocate memory!");
        }
        sprintf(resultName, "%s/Part-%d%s", destination, i, ending);

        //check if there a directory is given
        size_t directorySize = strlen(destination);
        if (directorySize > 0) {
            //if the directory given doesn't exist create it with read write open permissions for the owner
            struct stat st = {0};
            if (stat(destination, &st) == -1) {
                mkdir(destination, 0700);
            }
        }

        //open destination stream
        FILE * dest = fopen(resultName, "w");
        if (!dest) {
            die(NULL);
        }

        long currentBytes = 0;
        char buffer[BUFFER_SIZE];
        //read from the source file and write into the current destination stream
        while (!feof(src) && currentBytes < part) {
            int bytesRead = fread(buffer, 1, BUFFER_SIZE, src);
            fwrite(buffer, 1, bytesRead, dest);
            currentBytes += bytesRead;
        }
        fclose(dest);
        free(resultName);
    }
    fclose(src);
}

void assemble(char ** parts, const char * destinationDirectory, size_t partsNumber) {
    //check if a destination directory is given, if it is check if it exists, if it doesn't create it
    size_t directoryNameSize = strlen(destinationDirectory);
    if (directoryNameSize > 0) {
        struct stat st = {0};
        if (stat(destinationDirectory, &st) == -1) {
            mkdir(destinationDirectory, 0700);
        }
    }

    //set name
    char * extension = strrchr(parts[0], '.');
    char * name = calloc(60, sizeof (char));
    if(name == NULL)
    {
        die("Cannot allocate memory!");
    }
    sprintf(name, "%s/Assembled%s", destinationDirectory, extension);

    //open file stream to destination
    FILE * dest = fopen(name, "w");
    if (!dest) {
        die(NULL);
    }
    //freeing 
    free(name);

    //iterate over parts
    int i;
    for (i = 0; i < partsNumber; i++) {
        //open stream to the part
        FILE * src = fopen(parts[i], "r");
        if (!src) {
            die(NULL);
        }

        char buffer[BUFFER_SIZE];

        //until we reach the end of file for the part transfer all bytes with a buffer
        while (!feof(src)) {
            int readBytes = fread(buffer, 1, BUFFER_SIZE, src);
            fwrite(buffer, 1, readBytes, dest);
        }
        fclose(src);
    }
    fclose(dest);
}

void die(const char * msg) {
    if (errno) {
        perror(msg);
    } else {
        printf("ERROR %s\n", msg);
    }
    exit(1);
}

void printHelp(char * program)
{
    fprintf(stderr,"Error: Invalid arguments or commands for program %s\n",program);
    fprintf(stderr,"Available functions:\n");
    fprintf(stderr,"Slice: -s <sourceFile> <destinationDirectory> <numberOfParts>\n");
    fprintf(stderr,"Assemble: -a <destinationDirectory> <part-0> <part-1>...\n");
    fprintf(stderr,"Part names should be fully inputed with the extension ex: Part-2.jpg\n");
}

