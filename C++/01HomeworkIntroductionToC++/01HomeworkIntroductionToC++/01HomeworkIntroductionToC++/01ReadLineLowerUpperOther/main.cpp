
#include <iostream>
#include <cstdlib>
#include <string>
#include <stdio.h>

using namespace std;

int main(int argc, char** argv) {
    string line;
    getline(cin,line);
    
    int lower = 0;
    int upper = 0;
    int other = 0;
    
    int i;
    char c;
    while(line[i] != '\0'){
        c = line[i++];
        if(islower(c)){
            lower++;
        }else if(isupper(c)){
            upper++;
        }
        else{
            other++;
        }
    }
    
    cout << "Upper: " << upper << endl;
    cout << "Lower: " << lower << endl;
    cout << "Other: " << other << endl;
    
    return 0;
}

