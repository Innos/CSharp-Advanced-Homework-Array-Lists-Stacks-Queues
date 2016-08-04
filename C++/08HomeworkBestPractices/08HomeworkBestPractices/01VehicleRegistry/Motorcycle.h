#pragma once
#include "Vehicle.h"

namespace Models {
	class Motorcycle : public Vehicle {
	public:
		Motorcycle(string registrationNumber,
			float weight,
			unsigned short numberOfSeats,
			string chasisNumber,
			string engineNumber,
			string owner,
			Date firstRegistrationDate,
			Date countryRegistrationDate)
			: Vehicle(registrationNumber,
				weight,
				numberOfSeats,
				chasisNumber,
				engineNumber,
				owner,
				firstRegistrationDate,
				countryRegistrationDate)
		{};
	};
}