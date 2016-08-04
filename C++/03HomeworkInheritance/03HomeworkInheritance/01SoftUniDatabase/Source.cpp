#include <iostream>
#include "Student.h"
#include "GuestTeacher.h"
#include "SoftuniTeacher.h"

int main() 
{
	const int max = 65536;
	Student * students[max];
	GuestTeacher * guestTeachers[max];
	SoftuniTeacher * softuniTeachers[max];

	int studentId = 0;
	int guestTeacherId = 0;
	int softuniTeacherId = 0;


	while (1) {
		int choice;

		cout << "Choose a command from the list [1...6]?" << endl;

		cout << "1. Get data for student with ID" << endl;
		cout << "2. Get data for teacher with ID" << endl;
		cout << "3. Get data for guest teacher with ID" << endl;
		cout << "4. Add data for new student" << endl;
		cout << "5. Add data for new teacher" << endl;
		cout << "6. Add data for new guest teacher" << endl;

		cin >> choice;

		switch (choice)
		{
		case 1:
		{
			cout << "Enter student Id" << endl;
			int id;
			cin >> id;
			if (id >= studentId || id < 0) {
				cout << "No such student exists!" << endl << endl;
			}
			else {
				cout << students[id] << endl;
			}

			break;
		}
		case 2:
		{
			cout << "Enter teacher Id" << endl;
			int id;
			cin >> id;
			if (id >= softuniTeacherId || id < 0) {
				cout << "No such Teacher exists!" << endl << endl;
			}
			else {
				cout << softuniTeachers[id] << endl;
			}

			break;
		}
		case 3:
		{
			cout << "Enter guest teacher Id" << endl;
			int id;
			cin >> id;
			if (id >= guestTeacherId || id < 0) {
				cout << "No such guest teacher exists!" << endl << endl;
			}
			else {
				cout << guestTeachers[id] << endl;
			}

			break;
		}
		case 4:
		{
			if (studentId >= max) {
				cout << "Student Database filled, no more space!" << endl;
			}
			else {
				cout << "Enter student data in the format \'Name(string) Course(string) Points(int)\' with values seperated by a space" << endl;
				string name, course;
				int points;
				cin >> name >> course >> points;
				try {
					students[studentId] = new Student(name, course, points);
					cout << "Student " << name << " created with ID: " << studentId << endl;
					cout << students[studentId] << endl;
					studentId++;
				}
				catch (exception& ex){
					cout << ex.what() << endl;
				}
			}

			break;
		}
		case 5:
		{
			if (softuniTeacherId >= max) {
				cout << "Softuni Teacher Database filled, no more space!" << endl;
			}
			else {
				cout << "Enter teacher data in the format \'Name Course Salary DaysInSoftuni\' with values seperated by a space" << endl;
				string name, course;
				float salary;
				unsigned short days;
				cin >> name >> course >> salary >> days;
				softuniTeachers[softuniTeacherId] = new SoftuniTeacher(name, course, salary, days);
				cout << "Softuni Teacher " << name << " created with ID: " << softuniTeacherId << endl;
				softuniTeacherId++;
			}

			break;
		}
		case 6:
		{
			if (guestTeacherId >= max) {
				cout << "Guest Teacher Database filled, no more space!" << endl;
			}
			else {
				cout << "Enter guest Teacher data in the format \'Name Course salary\' with values seperated by a space" << endl;
				string name, course;
				float salary;
				cin >> name >> course >> salary;
				guestTeachers[guestTeacherId] = new GuestTeacher(name, course, salary);
				cout << "Guest Teacher " << name << " created with ID: " << guestTeacherId << endl;
				guestTeacherId++;
			}

			break;
		}
		default:
			break;
		}
	}
}
