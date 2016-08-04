#pragma once
#include "GameObject.h"

using namespace std;

namespace Models {
	class Character : public GameObject {
	private:
		unsigned int _kilograms;
		float _jumpSpeed; //in kilometers per hour
	public:
		Character(unsigned int identifier, string name, unsigned int kilograms, float jumpSpeed);

		unsigned int kilograms() const { return _kilograms; }
		float jumpSpeed() const { return _jumpSpeed; }
	};
}
