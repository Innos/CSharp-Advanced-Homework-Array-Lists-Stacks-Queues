#include "Character.h"
#include <iostream>

using namespace Models;

Character::Character(unsigned int identifier, string name, unsigned int kilograms, float jumpSpeed) : GameObject(identifier, name) {
	_kilograms = kilograms;
	_jumpSpeed = jumpSpeed;
}