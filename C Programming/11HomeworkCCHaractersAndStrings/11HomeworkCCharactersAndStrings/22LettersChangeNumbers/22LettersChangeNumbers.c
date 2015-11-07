#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>
#include <math.h>

char * readLine();

char * readLine() {
	char * buffer = (char*)malloc(60 * sizeof(char));
	size_t size = 60;

	int counter = 0;
	char c = fgetc(stdin);

	while (c != '\n' && c != EOF) {

		buffer[counter] = c;
		counter++;

		if (counter == size) {
			buffer = (char*)realloc(buffer, size * 2);
			if (buffer == NULL) {
				printf("Cannot find sufficent free memory!");
				exit(1);
			}
			size = size * 2;
		}
		c = fgetc(stdin);
	}
	char * result = (char*)realloc(buffer, counter + 1);
	result[counter] = '\0';

	return result;
}

int main(int argc, char** argv) {
	char * line = readLine();
	char * match = strtok(line, " \t");
	double sum = 0;
	while (match) {
		size_t len = strlen(match);
		char firstLetter = match[0];
		char lastLetter = match[len - 1];
		long double number = strtod((match + 1), NULL);
		if (isupper(firstLetter)) {
			number = number / (firstLetter - ('A' - 1));
		}
		else {
			number = number * (firstLetter - ('a' - 1));
		}
		if (isupper(lastLetter)) {
			number = number - (lastLetter - ('A' - 1));
		}
		else {
			number = number + (lastLetter - ('a' - 1));
		}
		sum += number;
		match = strtok(NULL, " \t");
	}
	// hack those round ups :D, honestly Banker's rounding kinda sux
	// judge has no long double; by introducing a 5, 2 decimal places after cutoff
	// we ensure that if the decimal place after cutoff is a 5 it would be forced to
	// round up instead of rounding to the nearest even number as per banker's rounding rule
	// ex xxx.125 rounded to 2 decimal places would always round to xx.12 (banker's rounding
	// alwasy rounds to the nearest even number, likewise xxx.135 would always round to xx.14),
	// but since 5 is odd xx.1255 would round the 1st "5" up to xx.126 thereby 
	// forcing all situations where 3rd digit is 5 to round up
	printf("%.2f", (sum + 0.0005));
	free(line);
	return (EXIT_SUCCESS);
}