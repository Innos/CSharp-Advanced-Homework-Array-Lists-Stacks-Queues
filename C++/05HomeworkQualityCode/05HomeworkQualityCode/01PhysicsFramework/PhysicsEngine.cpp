#include "PhysicsEngine.h"
#include "UnitConverter.h"

using namespace Physics;
using namespace Models;

const float JUMP_THRESHOLD = 5;

PhysicsEngine::PhysicsEngine() {};

//converts the input parameters to correct units and calculates maximum jump height in meters
float PhysicsEngine::calculateMaximumJumpHeight(const Environment &environment, const Character &character) {

	float jumpSpeedInMetresPerSecond = UnitConverter::convertKilometersperHourToMetersPerSecond(character.jumpSpeed());
	float maximumHeight = (jumpSpeedInMetresPerSecond * jumpSpeedInMetresPerSecond) / (2 * environment.gravity());

	return maximumHeight;
}

//converts the input parameters to correct units, calculates the up travel times doubles it and returns it
float PhysicsEngine::calculateJumpDuration(const Environment &environment, const Character &character) {

	float jumpSpeedInMetresPerSecond = UnitConverter::convertKilometersperHourToMetersPerSecond(character.jumpSpeed());
	float timeToReachMaximumHeight = jumpSpeedInMetresPerSecond / environment.gravity();

	return 2 * timeToReachMaximumHeight;
}

bool PhysicsEngine::canJump5Meters(const Environment &environment, const Character &character) {
	float maximumJumpHeight = PhysicsEngine::calculateMaximumJumpHeight(environment, character);

	if (maximumJumpHeight > JUMP_THRESHOLD) {
		return true;
	}

	return false;
}