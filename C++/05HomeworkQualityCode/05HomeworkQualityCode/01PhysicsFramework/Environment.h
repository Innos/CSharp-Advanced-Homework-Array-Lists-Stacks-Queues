#pragma once
#include "GameObject.h"

namespace Models {
	class Environment : public GameObject {
	private:
		float _gravity;
	public:
		Environment(unsigned int identifier, string name, float gravity);

		inline float gravity() const { return _gravity; }
	};
}