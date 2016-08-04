#pragma once
#include <iostream>

using namespace std;

namespace Models {
	class GameObject
	{
	private:
		unsigned int _identifier;
		string _name;

	public:
		GameObject(unsigned int identifier, string name);

		inline unsigned int identifier() { return _identifier; }
		inline string name() { return _name; }
	};
}
