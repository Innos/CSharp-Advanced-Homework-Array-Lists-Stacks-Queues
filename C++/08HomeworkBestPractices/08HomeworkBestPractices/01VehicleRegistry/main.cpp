#include <iostream>
#include <vector>
#include <memory>
#include <thread>
#include <mutex>
#include "Car.h"
#include "Truck.h"
#include "Motorcycle.h"

using namespace std;
using namespace Models;
using namespace Time;

mutex mtx;

static vector<thread> threads;

void searchAndPrintVehicle(vector<shared_ptr<Vehicle>> & vehicles, string regNumber, void(*func)(const Vehicle & vehicleToPrint)) {
	for each (shared_ptr<Vehicle> vehicle in vehicles)
	{
		if ((*vehicle).registrationNumber() == regNumber) {
			func((*vehicle));
		}
	}
}

void searchAndPrintCar(vector<shared_ptr<Vehicle>> & vehicles, string registrationNumber, void(*func)(const Vehicle & vehicleToPrint)) {
	threads.push_back(thread{ searchAndPrintVehicle, vehicles, registrationNumber, func });
}

void searchAndPrintTruck(vector<shared_ptr<Vehicle>> & vehicles, string registrationNumber, void(*func)(const Vehicle & vehicleToPrint)) {
	threads.push_back(thread{ searchAndPrintVehicle, vehicles, registrationNumber, func });
}

void searchAndPrintMotorcycle(vector<shared_ptr<Vehicle>> & vehicles, string registrationNumber, void(*func)(const Vehicle & vehicleToPrint)) {
	threads.push_back(thread{ searchAndPrintVehicle, vehicles, registrationNumber, func });
}

int main() {
	vector<shared_ptr<Vehicle>> cars;
	vector<shared_ptr<Vehicle>> trucks;
	vector<shared_ptr<Vehicle>> motorcycles;
	Vehicle * car1 = new Car("C1", 1.0f, 4, "C1", "C1", "Pesho", Date(10, 10, 2000), Date(1, 1, 1990));
	Vehicle * car2 = new Car("C2", 1.5f, 3, "C2", "C2", "Gosho", Date(10, 10, 2001), Date(1, 1, 1991));

	Vehicle * truck1 = new Truck("T1", 3.0f, 2, "T1", "T1", "Stamat", Date(10, 10, 2010), Date(1, 1, 2000));
	Vehicle * truck2 = new Truck("T2", 4.0f, 3, "T2", "T2", "Pencho", Date(10, 10, 2011), Date(1, 1, 2001));

	Vehicle * motorcycle1 = new Motorcycle("M1", 0.5f, 1, "M1", "M1", "Traqn", Date(10, 10, 2020), Date(1, 1, 2010));
	Vehicle * motorcycle2 = new Motorcycle("M2", 0.8f, 1, "M2", "M2", "Ivan", Date(10, 10, 2021), Date(1, 1, 2011));

	cars.push_back(shared_ptr<Vehicle>(car1));
	cars.push_back(shared_ptr<Vehicle>(car2));

	trucks.push_back(shared_ptr<Vehicle>(truck1));
	trucks.push_back(shared_ptr<Vehicle>(truck2));

	motorcycles.push_back(shared_ptr<Vehicle>(motorcycle1));
	motorcycles.push_back(shared_ptr<Vehicle>(motorcycle2));


	auto printLambda = [](const Vehicle & vehicle)-> void {
		mtx.lock();
		cout << "Registration: " << vehicle.registrationNumber() << " Owner: " << vehicle.owner() << endl;
		mtx.unlock();
	};

	searchAndPrintCar(cars, "C1", printLambda);
	searchAndPrintCar(cars, "C1", printLambda);
	searchAndPrintCar(cars, "C2", printLambda);
	searchAndPrintCar(cars, "C2", printLambda);
	searchAndPrintTruck(trucks, "T1", printLambda);
	searchAndPrintTruck(trucks, "T1", printLambda);
	searchAndPrintTruck(trucks, "T2", printLambda);
	searchAndPrintTruck(trucks, "T2", printLambda);
	searchAndPrintMotorcycle(motorcycles, "M1", printLambda);
	searchAndPrintMotorcycle(motorcycles, "M1", printLambda);
	searchAndPrintMotorcycle(motorcycles, "M2", printLambda);
	searchAndPrintMotorcycle(motorcycles, "M2", printLambda);

	//try a couple of times and you'll see that the execution order is random because they're on different threads
	for (size_t i = 0; i < threads.size(); i++)
	{
		threads[i].join();
	}

	return 0;
}