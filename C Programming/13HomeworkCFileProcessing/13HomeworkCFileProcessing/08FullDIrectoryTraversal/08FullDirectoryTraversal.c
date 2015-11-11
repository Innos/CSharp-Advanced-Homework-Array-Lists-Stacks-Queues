
#include <stdio.h>
#include <stdlib.h>
#include <sys/types.h>
#include <dirent.h>
#include <sys/stat.h>
#include <errno.h>
#include <unistd.h>
#include <string.h>
#include <ftw.h>
#include <stdint.h>

#define _XOPEN_SOURCE 500

static FILE * report;

struct FTW {
    int base;
    int level;
};

void die(const char * msg);
void TraverseDirectory(char * directory);
int print(const char * fpath, const struct stat *sb, int tflag, struct FTW * ftwbuf);

int main(int argc, char** argv) {
    report = fopen("report.txt", "w");
    if (!report) {
        die(NULL);
    }

    TraverseDirectory(".");
    fclose(report);
    return (EXIT_SUCCESS);
}

void TraverseDirectory(char * directory) {
    nftw(directory, &print, 20, 0);
}

int print(const char * fpath, const struct stat *sb, int tflag, struct FTW * ftwbuf) {
    int size = (ftwbuf->level * 2);
    char offset[size + 1];
    memset(offset, ' ', sizeof (offset));
    offset[size] = '\0';
    if (strcmp(fpath, ".") == 0) {
        char cwd[1024];
        getcwd(cwd, sizeof (cwd));
        fprintf(report, "%s\n", cwd);
    } else {
        fprintf(report, "%s%s %.2fKB\n", offset, (fpath + ftwbuf->base), sb->st_size / (double) 1024);
    }

    return 0;
}

//void TraverseDirectory(char * directory, int printOffset, FILE * stream) {
//    char * a = directory;
//    DIR * dir = opendir(directory);
//    struct stat st;
//    struct dirent * dirInfo;
//    dirInfo = readdir(dir);
//    while(dirInfo != NULL)
//    {
//        if (strcmp(dirInfo->d_name, ".") != 0 && strcmp(dirInfo->d_name, "..") != 0 && strcmp(dirInfo->d_name,"Debug")!=0) {
//            stat(dirInfo->d_name, &st);
//            int i;
//            char offset[printOffset+1];
//            memset(offset,' ',sizeof(offset));
//            offset[printOffset] = '\0';
//            printf("%s%s %0.2fKB\n",offset, dirInfo->d_name, st.st_size / (double) 1024);
//            //fprintf(stream, "%s%s %0.2fKB\n",offset, dirInfo->d_name, st.st_size / (double) 1024);
//            if(dirInfo->d_type == DT_DIR)
//            {
//                TraverseDirectory(dirInfo->d_name,printOffset + 2,stream);
//            }
//        }
//        dirInfo = readdir(dir);
//    }
//}

void die(const char * msg) {
    if (errno) {
        perror(msg);
    } else {
        printf("ERROR %s\n", msg);
    }
    exit(1);
}

