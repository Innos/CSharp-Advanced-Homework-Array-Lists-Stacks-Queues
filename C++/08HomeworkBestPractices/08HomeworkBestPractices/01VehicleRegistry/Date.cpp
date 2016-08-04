#include "Date.h"

using namespace Time;

Date::Date() {
	this->setDay(1);
	this->setMonth(1);
	this->setYear(0);
}

Date::Date(unsigned short day, unsigned short month, unsigned short year)
{
	this->setDay(day);
	this->setMonth(month);
	this->setYear(year);
}