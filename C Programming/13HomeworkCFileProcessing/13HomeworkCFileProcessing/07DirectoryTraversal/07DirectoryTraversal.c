

#include <stdio.h>
#include <stdlib.h>
#include <sys/types.h>
#include <dirent.h>
#include <sys/stat.h>
#include <errno.h>
#include <unistd.h>

void die(const char * msg);

int main(int argc, char** argv) {
    DIR * dir = opendir(".");
    struct stat st;
    struct dirent * dirInfo;

    FILE * report = fopen("report.txt", "w");
    if (!report) {
        die(NULL);
    }

    dirInfo = readdir(dir);
    while (dirInfo != NULL) {
        if (strcmp(dirInfo->d_name, ".") != 0 && strcmp(dirInfo->d_name, "..") != 0) {
            stat(dirInfo->d_name, &st);
            fprintf(report, "%s %0.2fKB\n", dirInfo->d_name, st.st_size / (double) 1024);
        }
        dirInfo = readdir(dir);
    }

    return (EXIT_SUCCESS);
}

void die(const char * msg) {
    if (errno) {
        perror(msg);
    } else {
        printf("ERROR %s\n", msg);
    }
    exit(1);
}

