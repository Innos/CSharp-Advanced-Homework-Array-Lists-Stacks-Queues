#pragma once
#include <stdexcept>

namespace Time {

	class Date {
	private:
		unsigned short _day;
		unsigned short _month;
		unsigned short _year;
	public:
		//constructor
		Date();
		Date(unsigned short day, unsigned short month, unsigned short year);

		//getters
		unsigned short day() {
			return _day;
		}

		unsigned short month() {
			return _month;
		}

		unsigned short year() {
			return _year;
		}

		//setters
		void setDay(unsigned short day) {
			if (day == 0 || day > 31) {
				throw new std::invalid_argument("Day has to be between 1 and 31");
			}

			this->_day = day;
		}

		void setMonth(unsigned short month) {
			if (month == 0 || month > 12) {
				throw new std::invalid_argument("Month has to be between 1 and 12");
			}

			this->_month = month;
		}

		void setYear(unsigned short year) {

			this->_year = year;
		}
	};
}