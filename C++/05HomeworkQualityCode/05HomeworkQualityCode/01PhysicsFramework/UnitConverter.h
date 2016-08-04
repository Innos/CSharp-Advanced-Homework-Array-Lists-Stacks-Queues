#pragma once

namespace Utility {
	class UnitConverter {
	public:
		UnitConverter();

		static float convertKilometersperHourToMetersPerSecond(float kilometersPerHour);
	};
}