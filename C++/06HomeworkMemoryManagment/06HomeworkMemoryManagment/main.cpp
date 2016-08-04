#include <iostream>
#include <cstdlib>
#include "Voter.h"
#include <map>

using namespace Enums;
using namespace std;

static map<string, Vote> voteEnum = map<string,Vote>();
static map<string, Gender> genderEnum = map<string,Gender>();
static map<string, Ethnos> ethnosEnum = map<string,Ethnos>();

static map<Vote, string> voteToString = map<Vote,string>();
static map<Gender, string> genderToString = map<Gender,string>();
static map<Ethnos, string> ethnosToString = map<Ethnos,string>();

static map<Vote, int> votesByNumber = map<Vote, int>();
static map<string, tuple<int, int>> votesByName = map<string, tuple<int, int>>();
static map<int, tuple<int, int>> votesByAge = map<int, tuple<int, int>>();
static map<string, tuple<int, int>> votesByCity = map<string, tuple<int, int>>();
static map<Gender, tuple<int, int>> votesByGender = map<Gender, tuple<int, int>>();
static map<Ethnos, tuple<int, int>> votesByEthnos = map<Ethnos, tuple<int, int>>();

void fillMaps() {
    voteEnum["Stay"] = Enums::Vote::Stay;
    voteEnum["Leave"] = Enums::Vote::Leave;
    genderEnum["Male"] = Enums::Gender::Male;
    genderEnum["Female"] = Enums::Gender::Female;
    ethnosEnum["Muslim"] = Enums::Ethnos::Muslim;
    ethnosEnum["NonMuslim"] = Enums::Ethnos::NonMuslim;
    
    voteToString[Enums::Vote::Stay] = "Stay";
    voteToString[Enums::Vote::Leave] = "Leave";
    genderToString[Enums::Gender::Male] = "Male";
    genderToString[Enums::Gender::Female] = "Female";
    ethnosToString[Enums::Ethnos::Muslim] = "Muslim";
    ethnosToString[Enums::Ethnos::NonMuslim] = "NonMuslim";
}

void fillExampleDatabase() {
    votesByName["Mary"] = tuple<int, int>(13000, 17000);
    votesByName["Thomas"] = tuple<int, int>(25000, 23000);
    votesByCity["London"] = tuple<int, int>(13000, 4000);
    votesByCity["Manchester"] = tuple<int, int>(6200, 6500);
    votesByCity["Leeds"] = tuple<int, int>(9200, 10700);
    votesByAge[19] = tuple<int, int>(7500, 1500);
    votesByAge[20] = tuple<int, int>(6800, 1700);
    votesByAge[21] = tuple<int, int>(7150, 2200);
    votesByEthnos[Enums::Ethnos::Muslim] = tuple<int, int>(143000, 147500);
    votesByEthnos[Enums::Ethnos::NonMuslim] = tuple<int, int>(683000, 709000);
    votesByGender[Enums::Gender::Male] = tuple<int, int>(1435000, 1480500);
    votesByGender[Enums::Gender::Female] = tuple<int, int>(1485000, 1500500);
    votesByNumber[Enums::Vote::Stay] = 19300500;
    votesByNumber[Enums::Vote::Leave] = 20100500;
}

void VoteForReferendum() {
    int age;
    string name, city;
    Gender gender;
    Ethnos ethnos;
    Vote vote;
    string genderString, ethnosString, voteString;
    cout << "Enter your Age:";
    cin >> age;
    cout << "Enter your Name:";
    cin >> name;
    cout << "Enter your City:";
    cin >> city;
    cout << "Enter your Gender(Male/Female):";
    cin >> genderString;
    cout << "Enter your Ethnos(Muslim/NonMuslim):";
    cin >> ethnosString;
    cout << "Enter your Vote(Stay/Leave):";
    cin >> voteString;
    gender = genderEnum[genderString];
    ethnos = ethnosEnum[ethnosString];
    vote = voteEnum[voteString];
    Voter voter = Voter(name, age, city, gender, ethnos, vote);
    if (votesByName.count(name) == 0) {
        votesByName[name] = tuple<int, int>(0, 0);
    }
    if (votesByAge.count(age) == 0) {
        votesByAge[age] = tuple<int, int>(0, 0);
    }
    if (votesByCity.count(city) == 0) {
        votesByCity[city] = tuple<int, int>(0, 0);
    }
    if (votesByGender.count(gender) == 0) {
        votesByGender[gender] = tuple<int, int>(0, 0);
    }
    if (votesByEthnos.count(ethnos) == 0) {
        votesByEthnos[ethnos] = tuple<int, int>(0, 0);
    }
    if (votesByNumber.count(vote) == 0) {
        votesByNumber[vote] = 0;
    }
    if (vote == Enums::Vote::Stay) {
        get<0>(votesByName[name])++;
        get<0>(votesByAge[age])++;
        get<0>(votesByCity[city])++;
        get<0>(votesByGender[gender])++;
        get<0>(votesByEthnos[ethnos])++;
    } else if (vote == Enums::Vote::Leave) {
        get<1>(votesByName[name])++;
        get<1>(votesByAge[age])++;
        get<1>(votesByCity[city])++;
        get<1>(votesByGender[gender])++;
        get<1>(votesByEthnos[ethnos])++;
    }
    votesByNumber[vote] = votesByNumber[vote] + 1;
}

void ShowPercentResults() {
    double total = 0;
    for (map<Vote, int>::iterator it = votesByNumber.begin(); it != votesByNumber.end(); ++it) {
        total = total + it->second;
    }

    double stayPercent = votesByNumber[Enums::Vote::Stay] / total * 100;
    double leavePercent = votesByNumber[Enums::Vote::Leave] / total * 100;

    cout << "Stay: " << stayPercent << "%" << endl;
    cout << "Leave: " << leavePercent << "%" << endl;

}

void ShowNumberResults() {
    cout << "Stay: " << votesByNumber[Enums::Vote::Stay] << "  Leave: " << votesByNumber[Enums::Vote::Leave] << endl;
}

void ShowAgeResults() {
    cout << "Enter age: ";
    int age;
    cin >> age;
    cout << age << "y" << " - Stay: " << get<0>(votesByAge[age]) << " Leave: " << get<1>(votesByAge[age]) << endl;
}

void ShowNameResults() {
    cout << "Enter name: ";
    string name;
    cin >> name;
    cout << "Name:" << name << " - Stay: " << get<0>(votesByName[name]) << " Leave: " << get<1>(votesByName[name]) << endl;
}

void ShowEthnosResults() {
    cout << "Enter ethnos(Muslim/NonMuslim): ";
    Ethnos ethnos;
    string ethnosString;
    cin >> ethnosString;
    ethnos = ethnosEnum[ethnosString];
    cout << "Ethnos:" << ethnosToString[ethnos] << " - Stay: " << get<0>(votesByEthnos[ethnos]) << " Leave: " << get<1>(votesByEthnos[ethnos]) << endl;
}

void ShowCityResults() {
    cout << "Enter City: ";
    string city;
    cin >> city;
    cout << "City:" << city << " - Stay: " << get<0>(votesByCity[city]) << " Leave: " << get<1>(votesByCity[city]) << endl;
}

void ShowGenderResults() {
    cout << "Enter gender(Male/Female): ";
    Gender gender;
    string genderString;
    cin >> genderString;
    gender = genderEnum[genderString];
    cout << "Gender:" << genderToString[gender] << " - Stay: " << get<0>(votesByGender[gender]) << " Leave: " << get<1>(votesByGender[gender]) << endl;
}

void ChooseOption(bool & isCollector, bool & exit) {
    cout << "Enter your choice:" << endl;
    cout << "1.Vote" << endl;
    if (isCollector) {
        cout << "2.Results in percent" << endl;
        cout << "3.Results in numbers" << endl;
        cout << "4.Results based on Age" << endl;
        cout << "5.Results based on Name" << endl;
        cout << "6.Results based on Ethnos" << endl;
        cout << "7.Results based on City" << endl;
        cout << "8.Results based on Gender" << endl;
    }
    cout << "9.Exit" << endl;

    int choice;
    cin >> choice;

    switch (choice) {
        case 1: VoteForReferendum();
            break;
        case 2: ShowPercentResults();
            break;
        case 3: ShowNumberResults();
            break;
        case 4: ShowAgeResults();
            break;
        case 5: ShowNameResults();
            break;
        case 6: ShowEthnosResults();
            break;
        case 7: ShowCityResults();
            break;
        case 8: ShowGenderResults();
            break;
        case 9: exit = true;
            break;
        case 12344321: isCollector = true;
            break;
    }
}

int main(int argc, char** argv) {
    fillMaps();
    // this method loads a premade database of voters for testing, comment it out if you want to test
    // on an empty database.
    fillExampleDatabase();
    bool isCollector = false;
    bool exit = false;
    
    //Enter the secret code "12344321" in the main menu as a choice to unlock the extra features
    while (!exit) {
        ChooseOption(isCollector, exit);
    }

    return 0;
}

