
#include <iostream>
#include <limits> 

using namespace std;


class Building
{
private:
    string _name;
    int _totalFloors;
    int _officeFloors;
    int _offices;
    int _employees;
    int _freeWorkingSeats;
public:
    inline Building(string name, int totalFloors, int officeFloors, int offices, int employees, int freeWorkingSeats)
    {
        setName(name);
        setTotalFloors(totalFloors);
        setOfficeFloors(officeFloors);
        setOffices(offices);
        setEmployees(employees);
        setFreeWorkingSeats(freeWorkingSeats);
    }
    inline ~Building()
    {
        cout << "Building has been destroyed!" << endl;
    }
    string name(){ return _name;};
    void setName(string name){ _name = name;};
    int totalFloors(){return _totalFloors;};
    void setTotalFloors(int totalFloors){_totalFloors = totalFloors;};
    int officeFloors(){return _officeFloors;};
    void setOfficeFloors(int officeFloors){_officeFloors = officeFloors;};
    int offices(){return _offices;};
    void setOffices(int offices){_offices = offices;};
    int employees(){return _employees;};
    void setEmployees(int employees){_employees = employees;};
    int freeWorkingSeats(){return _freeWorkingSeats;};
    void setFreeWorkingSeats(int freeWorkingSeats){_freeWorkingSeats = freeWorkingSeats;};  
};

void printBuilding(Building building);
void printMostEmployees(Building buildings[3],int size);
void printMostFreePlaces(Building buildings[3],int size);
void printHighestCoefficient(Building buildings[3],int size);
void printMostPeoplePerFloor(Building buildings[3],int size);
void printLeastPeoplePerFloor(Building buildings[3],int size);
void printMostOfficesPerFloor(Building buildings[3],int size);
void printLeastOfficesPerFloor(Building buildings[3],int size);
void printMostPeoplePerOffice(Building buildings[3],int size);
void printLeastPeoplePerOffice(Building buildings[3],int size);

int main(int argc, char** argv) {

    Building xyz = Building("XYZ industries",6,6,127,600,196);
    Building rapid = Building("Rapid Development Crew",8,7,210,822,85);
    Building softuni = Building("SoftUni",11,11,106,200,60);
    
    Building buildings[3] = {xyz, rapid, softuni}; 
    
    printMostEmployees(buildings,3);
    printMostFreePlaces(buildings,3);
    printHighestCoefficient(buildings,3);
    printMostPeoplePerFloor(buildings,3);
    printLeastPeoplePerFloor(buildings,3);
    printMostOfficesPerFloor(buildings,3);
    printLeastOfficesPerFloor(buildings,3);
    printMostPeoplePerOffice(buildings,3);
    printLeastPeoplePerOffice(buildings,3);
    
//    printBuilding(xyz);
//    printBuilding(rapid);
//    printBuilding(softuni);
    
    return 0;
}

void printBuilding(Building building)
{
     cout << "Name: " << building.name() 
            << "; Total Floors: " << building.totalFloors() 
            << "; Office Floors: " << building.officeFloors() 
            << "; Offices: " << building.offices()
            << "; Employees: " << building.employees()
            << "; Free Working Seats: " << building.freeWorkingSeats()
            << ";" << endl;
}

void printMostEmployees(Building buildings[], int size)
{
    int i,maxEmployees = 0;
    string name = "none";
    for(i = 0; i< size; i++){
        if(buildings[i].employees() > maxEmployees){
            maxEmployees = buildings[i].employees();
            name = buildings[i].name();
        }
    }
    
    cout << "Most employees: "<< maxEmployees << " - " << name << endl;
}

void printMostFreePlaces(Building buildings[3],int size){ 
    int i,maxFreeWorkingSeats = 0;
    string name = "none";
    for(i = 0; i< size; i++){
        if(buildings[i].freeWorkingSeats() > maxFreeWorkingSeats){
            maxFreeWorkingSeats = buildings[i].freeWorkingSeats();
            name = buildings[i].name();
        }
    }
    
    cout << "Most Free Places: " << maxFreeWorkingSeats << " - " << name << endl;
}

void printHighestCoefficient(Building buildings[3],int size){
    int i;
    double maxCoefficient = 0;
    string name = "none";
    for(i = 0; i< size; i++){
        double coefficient = (double)buildings[i].employees()/(buildings[i].employees() + buildings[i].freeWorkingSeats());
        if(coefficient > maxCoefficient){
            maxCoefficient = coefficient;
            name = buildings[i].name();
        }
    }
    
    cout << "Highest Coefficient: " << maxCoefficient << " - " << name << endl;
}

void printMostPeoplePerFloor(Building buildings[3],int size){
    int i;
    double maxPeoplePerFloor = 0;
    string name = "none";
    for(i = 0; i< size; i++){
        //here we use total floors as there are people working in the restaurant too
        double peoplePerFloor = (double)buildings[i].employees() / buildings[i].totalFloors();
        if(peoplePerFloor > maxPeoplePerFloor){
            maxPeoplePerFloor = peoplePerFloor;
            name = buildings[i].name();
        }
    }
    
    cout << "Most People Per Floor: " << maxPeoplePerFloor << " - " << name << endl;
}
void printLeastPeoplePerFloor(Building buildings[3],int size){
    int i;
    double minPeoplePerFloor = numeric_limits<double>::max();
    string name = "none";
    for(i = 0; i< size; i++){
        //here we use total floors as there are people working in the restaurant too
        double peoplePerFloor = (double)buildings[i].employees() / buildings[i].totalFloors();
        if(peoplePerFloor < minPeoplePerFloor){
            minPeoplePerFloor = peoplePerFloor;
            name = buildings[i].name();
        }
    }
    
    cout << "Least People Per Floor: " << minPeoplePerFloor << " - " << name << endl;
}

void printMostOfficesPerFloor(Building buildings[3],int size){
    int i;
    double maxOfficesPerFloor = 0;
    string name = "none";
    for(i = 0; i< size; i++){
        //here we use office floors as the restaurant takes one floor
        double officesPerFloor = (double)buildings[i].offices() / buildings[i].officeFloors();
        if(officesPerFloor  > maxOfficesPerFloor){
            maxOfficesPerFloor = officesPerFloor;
            name = buildings[i].name();
        }
    }
    
    cout << "Most Offices Per Floor: " << maxOfficesPerFloor << " - " << name << " \\\\TAKES INTO ACCOUNT RAPID CREW's Restaurant" << endl;
}
void printLeastOfficesPerFloor(Building buildings[3],int size){
    int i;
    double minOfficesPerFloor = numeric_limits<double>::max();
    string name = "none";
    for(i = 0; i< size; i++){
        //here we use office floors as the restaurant takes one floor
        double officesPerFloor = (double)buildings[i].offices() / buildings[i].officeFloors();
        if(officesPerFloor < minOfficesPerFloor){
            minOfficesPerFloor = officesPerFloor;
            name = buildings[i].name();
        }
    }
    
    cout << "Least Offices Per Floor: " << minOfficesPerFloor << " - " << name << endl;
}

void printMostPeoplePerOffice(Building buildings[3],int size){
    int i;
    double maxPeoplePerOffice = 0;
    string name = "none";
    for(i = 0; i< size; i++){
        double peoplePerOffice = (double)buildings[i].employees() / buildings[i].offices();
        if(peoplePerOffice > maxPeoplePerOffice){
            maxPeoplePerOffice  = peoplePerOffice;
            name = buildings[i].name();
        }
    }
    
    cout << "Most People Per Office: " << maxPeoplePerOffice << " - " << name << endl;
}
void printLeastPeoplePerOffice(Building buildings[3],int size){
    int i;
    double minPeoplePerOffice = numeric_limits<double>::max();
    string name = "none";
    for(i = 0; i< size; i++){
        double peoplePerOffice = (double)buildings[i].employees() / buildings[i].offices();
        if(peoplePerOffice < minPeoplePerOffice){
            minPeoplePerOffice = peoplePerOffice;
            name = buildings[i].name();
        }
    }
    
    cout << "Least People Per Office: " << minPeoplePerOffice << " - " << name << endl;
}

