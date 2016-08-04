#include "Environment.h"
#include "Character.h"
#include "UnitConverter.h"
#include "PhysicsEngine.h"

using namespace Models;
using namespace Utility;
using namespace Physics;

int main() {

	Environment earth = Environment(1, "Earth", 9.81f);
	Character pesho = Character(10, "Pesho", 75, 3096.0f);

	cout << "Jump Speed in meters per second: " << UnitConverter::convertKilometersperHourToMetersPerSecond(pesho.jumpSpeed()) << endl;
	cout << "Maximum jump height: " << PhysicsEngine::calculateMaximumJumpHeight(earth, pesho) << endl;;
	cout << "Jump duration is : " << PhysicsEngine::calculateJumpDuration(earth, pesho) << endl;
	bool canJump5Meters = PhysicsEngine::canJump5Meters(earth, pesho);
	if (canJump5Meters) {
		cout << "Pesho can jump 5 meters!" << endl;
	}
	else {
		cout << "Pesho can't jump 5 meters :("<< endl;
	}

	return 0;
}