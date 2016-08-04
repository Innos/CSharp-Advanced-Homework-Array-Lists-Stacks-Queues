#pragma once
#include <string>
#include "Date.h"

using namespace std;
using namespace Time;

namespace Models {
	class Vehicle {
	private:
		string _registrationNumber;
		float _weight;
		unsigned short _numberOfSeats;
		string _chasisNumber;
		string _engineNumber;
		string _owner;
		Date _firstRegistrationDate;
		Date _countryRegistrationDate;
	public:
		Vehicle(
			string registrationNumber,
			float weight,
			unsigned short numberOfSeats,
			string chasisNumber,
			string engineNumber,
			string owner,
			Date firstRegistrationDate,
			Date countryRegistrationDate);

		string registrationNumber() const {
			return this->_registrationNumber;
		}

		float weight() const {
			return this->_weight;
		}

		unsigned short numberOfSeats()const {
			return this->_numberOfSeats;
		}

		string chasisNumber() const {
			return this->_chasisNumber;
		}

		string engineNumber() const {
			return this->_engineNumber;
		}

		string owner() const {
			return this->_owner;
		}

		Date firstRegistrationDate() const {
			return this->_firstRegistrationDate;
		}

		Date countryRegistrationDate() const {
			return this->_countryRegistrationDate;
		}

		//setters
		void setRegistrationNumber(string registrationNumber) {
			this->_registrationNumber = registrationNumber;
		}
		void setWeight(float weight) {
			this->_weight = weight;
		}
		void setNumberOfSeats(unsigned numberOfSeats) {
			this->_numberOfSeats = numberOfSeats;
		}
		void setChasisNumber(string chasisNumber) {
			this->_chasisNumber = chasisNumber;
		}
		void setEngineNumber(string engineNumber) {
			this->_engineNumber = engineNumber;
		}
		void setOwner(string owner) {
			this->_owner = owner;
		}
		void setFirstDateOfRegistration(Date firstRegistrationDate) {
			this->_firstRegistrationDate = firstRegistrationDate;
		}
		void setCountryRegistrationDate(Date countryRegistrationDate) {
			this->_countryRegistrationDate = countryRegistrationDate;
		}
	};
}
