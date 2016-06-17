#pragma once
#include <iostream>
#include <string>
using namespace std;

class Person
{

protected:
	string _name;
	string _currentCourse;
public:
	inline Person(string name, string currentCourse) {
		this->setName(name);
		this->setCurrentCourse(currentCourse);
	}
	~Person() {
		cout << "Person deleted" << endl;
	}

	inline void setName(string name) {	this->_name = name;	}

	inline string name() {	return this->_name;	}

	inline void setCurrentCourse(string currentCourse) {this->_currentCourse = currentCourse;}

	inline string currentCourse() { return this->_currentCourse; }
};