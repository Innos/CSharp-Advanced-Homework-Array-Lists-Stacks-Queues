#include "Environment.h"
#include <iostream>

using namespace Models;

Environment::Environment(unsigned int identifier, string name, float gravity) : GameObject(identifier,name) {
	_gravity = gravity;
}