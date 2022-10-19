// Strutynska Katerina KI-20009Б
// 19.10.2022 
//
// Лабораторна робота №7
// 
// Організація, страхова компанія, будівна компанія, метробуд. Поліморфна функція для страхової компанії виводить прізвище страхового
// агента, кількість полісів і загальну суму, для будівної компанії - прізвище прораба, загальну смету(суму в грн) і метраж(загальну площу кв.м), 
// для метробуд – назва маршруту, кількість пасажирів, відстань в км.
//
#include <iostream>
using namespace std;
//Базовий клас Організація
class Organization
{
public:
	// Віртуальна функція
	virtual void PrintInfo()
	{
		cout << "Organization." << endl;
	}
};
// Клас Страхова компанія - прізвище страхового агента, кількість полісів і загальну суму.
class Insurance_Company : public Organization
{
public:
	virtual void PrintInfo() override
	{
		cout << "Insurance Company: Last name of the insured agent - Himars, number of polices - 258, total amount - 500 000 UAH" << endl;
	}
};
// Клас Будівна компанія - прізвище прораба, загальну смету(суму в грн) і метраж(загальну площу кв.м).
class Construction_Company : public Organization
{
public:
	virtual void PrintInfo() override
	{
		cout << "Construction Company: The name of the foreman - Himars, the totals estimate - 200 000 UAH, the square footage - 90sq m" << endl;
	}
};
// Клас Метро буд - назва маршруту, кількість пасажирів, відстань в км.
class Metrobud : public Organization
{
public:
	virtual void PrintInfo() override
	{
		cout << "Metrobud: Rout name - russian military ship go to the bottom, number of passengers - 680, distance in km - 150km" << endl;
	}
};

int main()
{
	Organization* A[3]; // Вказівник на базовий клас Організація.
	Insurance_Company B; Construction_Company C; Metrobud D; // Зазначення класам відповідних значень (букв).
	A[0] = &B;// Вказівник на базовий клас посилається на об'єкт класу Insurance_Company.
	A[1] = &C;// Вказівник на базовий клас посилається на об'єкт класу Construction_Company.
	A[2] = &D;// Вказівник на базовий клас посилається на об'єкт класу Metrobud.
	for (int i = 0; i < 3; i++)
		A[i]->PrintInfo();// Поліморфний виклки
}