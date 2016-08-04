#pragma once
#include "GuestTeacher.h"

class SoftuniTeacher : public GuestTeacher
{

protected:
	unsigned short _daysInSoftuni;

	inline void setDaysInSoftuni(unsigned short daysInSoftuni)
	{
		this->_daysInSoftuni = daysInSoftuni;
	}
public:
	inline SoftuniTeacher(string name, string currentCourse, float monthlySalary, unsigned short daysInSoftuni) : GuestTeacher(name, currentCourse, monthlySalary)
	{
		this->setDaysInSoftuni(daysInSoftuni);
	}

	~SoftuniTeacher()
	{
		cout << "Softuni Teacher deleted" << endl;
	}

	inline unsigned short daysInSoftuni() {
		return this->_daysInSoftuni;
	}
};

inline ostream & operator<<(ostream & Str, SoftuniTeacher * v) {
	Str << "Name: " << v->name() << " Course: " << v->currentCourse() << " Salary: " << v->salary() << " Days in SoftUni: " << v->daysInSoftuni() << endl;
	return Str;
}