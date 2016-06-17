#pragma once
#include <exception>
#include "Person.h"

class Student : public Person
{
protected:
	int _points;
	double _totalScore;
	unsigned int _totalCourses;
public:
	inline Student(string name, string currentCourse, int points) : Person(name, currentCourse)
	{
		this->setPoints(points);
		this->_totalScore = points;
		this->_totalCourses = 1;
	}

	~Student() 
	{
		cout << "Student deleted" << endl;
	}

	inline void setPoints(int points)
	{ 
		if (points > 100 || points < 0) 
		{
			throw exception("Points must be between 0 and 100");
		}
		else
		{
			this->_points = points;
		}

	}

	inline int points() { return this->_points; }

	inline double averageMark() {
		if (this->_totalCourses == 1) {
			return 0;
		}
		else {
			//keep all points for all passed courses since the min mark is 2 and the max is 6 we can move 2 to the front,
			//we get the average mark by dividing all points by the amount of courses taken * 25 (because 
			//100 / 25 = 4 + the 2 infront = 6 max grade for  a course)

			//ironically the above doesn't matter because we don't have to implement a function that adds
			//more courses to a student
			return 2 + (this->_totalScore / (25 * this->_totalCourses));
		}
	}
};


inline ostream & operator<<(ostream & Str, Student * v) {
	Str << "Name: " << v->name() << " Course: " << v->currentCourse() << " Points: " << v->points() << " AverageMark: " << v->averageMark() << endl;
	return Str;
}

