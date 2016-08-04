#pragma once

#include "Vehicle.h"

namespace Models {
	class Car : public Vehicle {
	public:
		Car(string registrationNumber,
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