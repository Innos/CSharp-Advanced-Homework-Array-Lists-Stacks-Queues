
#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>

void die(const char * msg);
void printHelp(char * program);
void OffsetSubtitles(unsigned long offset, const char * source);
void OffsetTime(int offset, int * hours, int * minutes, int* seconds, int* miliseconds);
char * readLineFromFile(FILE * stream);

int main(int argc, char** argv) {
    // read arguments
    if (argc == 1) {
        printHelp(argv[0]);
    }
    if (argc == 3) {
        char * exBuffer;
        unsigned long offset = strtoul(argv[1], &exBuffer, 10);
        if (*exBuffer != '\0') {
            die("Offset could not be parsed correctly.");
        }
        if (errno) {
            die(NULL);
        }
        char * source = argv[2];
        OffsetSubtitles(offset, source);
    } else {
        printHelp(argv[0]);
    }

    return (EXIT_SUCCESS);
}

void OffsetSubtitles(unsigned long offset, const char * source) {
    FILE * src = fopen(source, "r+");
    if (!src) {
        die(NULL);
    }
    while (!feof(src)) {
        long currentPosition = ftell(src);
        char * line = readLineFromFile(src);
        if (strstr(line, " --> ") != NULL) {
            char * startPtr;
            char * start = strtok_r(line, " --> ", &startPtr);
            char * numbersPtr;
            int startHours = atoi(strtok_r(start, ":,", &numbersPtr));
            int startMinutes = atoi(strtok_r(NULL, ":,", &numbersPtr));
            int startSeconds = atoi(strtok_r(NULL, ":,", &numbersPtr));
            int startMiliseconds = atoi(strtok_r(NULL, ":,", &numbersPtr));
            OffsetTime(offset, &startHours, &startMinutes, &startSeconds, &startMiliseconds);

            char * end = strtok_r(NULL, " --> ", &startPtr);
            char * endNumbersPtr;
            int endHours = atoi(strtok_r(end, ":,", &endNumbersPtr));
            int endMinutes = atoi(strtok_r(NULL, ":,", &endNumbersPtr));
            int endSeconds = atoi(strtok_r(NULL, ":,", &endNumbersPtr));
            int endMiliseconds = atoi(strtok_r(NULL, ":,", &endNumbersPtr));
            OffsetTime(offset, &endHours, &endMinutes, &endSeconds, &endMiliseconds);

            fseek(src, currentPosition, SEEK_SET);
            fprintf(src, "%02d:%02d:%02d,%03d --> %02d:%02d:%02d,%03d\n",
                    startHours, startMinutes, startSeconds, startMiliseconds,
                    endHours, endMinutes, endSeconds, endMiliseconds);
        }
        free(line);
    }
    fclose(src);
}

void OffsetTime(int offset, int * hours, int * minutes, int* seconds, int* miliseconds) {
    int milisecondsOffset = offset % 1000;
    offset = offset / 1000;
    int secondsOffset = offset % 60;
    offset = offset / 60;
    int minutesOffset = offset % 60;
    offset = offset / 60;
    int hoursOffset = offset;

    *miliseconds = *miliseconds + milisecondsOffset;
    if (*miliseconds >= 1000) {
        *seconds = *seconds + (*miliseconds / 1000);
        *miliseconds = *miliseconds % 1000;
    }
    *seconds = *seconds + secondsOffset;
    if (*seconds >= 60) {
        *minutes = *minutes + (*seconds / 60);
        *seconds = *seconds % 60;
    }
    *minutes = *minutes + minutesOffset;
    if (*minutes >= 60) {
        *hours = *hours + (*minutes / 60);
        *minutes = *minutes % 60;
    }
    *hours = *hours + hoursOffset;
    if (*hours > 99) {
        die("Hours are above 99.");
    }
}

char * readLineFromFile(FILE * stream) {
    char * buffer = malloc(60 * sizeof (char));
    size_t size = 60;

    int counter = 0;
    char c = fgetc(stream);

    while (c != '\n' && c != EOF) {

        buffer[counter] = c;
        counter++;

        if (counter == size) {

            buffer = realloc(buffer, size * 2);
            if (buffer == NULL) {
                printf("Cannot find sufficient free memory!");
                exit(1);
            }
            size = size * 2;
        }
        c = fgetc(stream);
    }
    char * result = realloc(buffer, counter + 1);
    result[counter] = '\0';

    return result;
}

void die(const char * msg) {
    if (errno) {
        perror(msg);
    } else {
        printf("ERROR %s\n", msg);
    }
    exit(1);
}

void printHelp(char * program) {
    fprintf(stderr, "Error: Invalid arguments or commands for program %s\n", program);
    fprintf(stderr, "Available commands:\n");
    fprintf(stderr, "Offset Subtitles: <offset> <subtitlesFile> \n");
}

