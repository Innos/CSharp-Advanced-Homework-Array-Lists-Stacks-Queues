#include "UnitConverter.h"

using namespace Utility;

UnitConverter::UnitConverter() {};

float UnitConverter::convertKilometersperHourToMetersPerSecond(float kilometersPerHour) {
	return kilometersPerHour / 3.6f;
}