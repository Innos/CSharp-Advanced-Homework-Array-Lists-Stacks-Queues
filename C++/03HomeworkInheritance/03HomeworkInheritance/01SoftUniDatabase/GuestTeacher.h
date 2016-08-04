#pragma once
#include "Person.h"

class GuestTeacher : public Person
{

protected:
	float _salary;

public:
	inline GuestTeacher(string name, string currentCourse, float salary) : Person(name, currentCourse)
	{
		this->setSalary(salary);
	}

	~GuestTeacher()
	{
		cout << "Guest Teacher deleted" << endl;
	}

	inline void setSalary(float salary)
	{
		this->_salary = salary;
	}

	inline float salary() { return this->_salary; }
};

inline ostream & operator<<(ostream & Str, GuestTeacher * v) {
	Str << "Name: " << v->name() << " Course: " << v->currentCourse() << " Salary: " << v->salary() << endl;
	return Str;
}