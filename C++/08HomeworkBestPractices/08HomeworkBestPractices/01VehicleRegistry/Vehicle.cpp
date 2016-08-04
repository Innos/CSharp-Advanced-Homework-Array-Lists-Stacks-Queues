#include "Vehicle.h"

using namespace Models;

Vehicle::Vehicle(
	string registrationNumber,
	float weight,
	unsigned short numberOfSeats,
	string chasisNumber,
	string engineNumber,
	string owner,
	Date firstRegistrationDate,
	Date countryRegistrationDate) {

	this->setRegistrationNumber(registrationNumber);
	this->setWeight(weight);
	this->setNumberOfSeats(numberOfSeats);
	this->setChasisNumber(chasisNumber);
	this->setEngineNumber(engineNumber);
	this->setOwner(owner);
	this->setFirstDateOfRegistration(firstRegistrationDate);
	this->setCountryRegistrationDate(countryRegistrationDate);
}