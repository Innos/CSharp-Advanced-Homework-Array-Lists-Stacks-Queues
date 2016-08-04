#pragma once
#include "Character.h"
#include "Environment.h"
#include "UnitConverter.h"
#include <iostream>

using namespace Models;
using namespace Utility;
using namespace std;

namespace Physics {
	class PhysicsEngine
	{
	public:
		PhysicsEngine();

		static float calculateMaximumJumpHeight(const Environment &environment, const Character &character);
		static float calculateJumpDuration(const Environment &environment, const Character &character);
		static bool canJump5Meters(const Environment &environment, const Character &character);
	};
}
