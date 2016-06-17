
#include <iostream>
#include <cstdlib>
#include <stdio.h>
#include <string>
#include <sstream>

using namespace std;

void PrintChar(char someChar);
void PrintString(string someString);
int checkAge(short age);
string ReadLine();
void Print(string line);

/*
 Project should be compiled using C++ 11 because of to_string function
 */

int main(int argc, char** argv) {
    PrintChar('a');
    PrintString("Random Text");
    int result = checkAge(23);
    int result2 = checkAge(51);
    
    Print("Result1: " + to_string(result));
    Print("Result2: " + to_string(result2));
    
    
    Print("Write some text:");
    string line = ReadLine();
    Print(line);
    
    return 0;
}

void PrintChar(char someChar){
    cout << someChar << endl;
}

void PrintString(string someString){
    cout << someString << endl;
}

int checkAge(short age){
    if(age < 18){
        return 0;
    }
    else if(age > 50){
        return 1;
    }
    return 2;
}

string ReadLine(){
    string line;
    getline(cin,line);
    return line;
}

void Print(string line){
    cout << line << endl;
}

