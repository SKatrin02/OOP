//
// Created by Strutynska Katerina on 09.10.2022
// Laboratory work №6
// Variant №16-1
// Student, Teacher, Perona, Zav_Kafedru
//

#include <iostream>
using namespace std;
//Базовий клас персона.
class Persona
{
	int year_of_birth; // Рік народження.
	string name; // Ім'я.
public:
	void set_year(int year) 
	{ 
		year_of_birth = year; 
	}
	int get_year()
	{
		return year_of_birth;
	}
	void set_name(string text)
	{
		name = text;
	}
	string get_name()
	{
		return name;
	}
};
// Визначаємо клас студент.
class Student : public Persona
{
	int kurs; // курс.
	string group; // група.
public:
	void set_kurs(int num)
	{
		kurs = num;
	}
	int get_kurs()
	{
		return kurs;
	}
	void set_group(string text)
	{
		group = text;
	}
	string get_group()
	{
		return group;
	}
	void show();
};
// Визначаємо клас Викладача.
class Teacher : public Persona
{
	int hours; // педнавантаження в год.
	string discipline; // дисципліна.
public:
	void set_hours(int num)
	{
		hours= num;
	}
	int get_hours()
	{
		return hours;
	}
	void set_discipline(string text)
	{
		discipline = text;
	}
	string get_discipline()
	{
		return discipline;
	}
	void show();
};
// Визначення клас зав кафедри.
class Zav_Kafedru :public Persona
{
	string kafedra; // назва кафедри.
	string university; // назва університету
public:
	void set_kafedra(string text)
	{
		kafedra = text;
	}
	string get_kafedra()
	{
		return kafedra;
	}
	void set_university(string text)
	{
		university = text;
	}
	string get_university()
	{
		return university;
	}
	void show();
};

void Student::show()
{
	cout << "Stydent grypu " << group << " \n" << get_name() << endl;
	cout << "Navchaetsia na " << kurs << " kyrsi \n";
	cout << "Rik narodjenia " << get_year() << endl << endl;
}

void Teacher::show()
{
	cout << get_name() << "\nvukladae duscupliny " << discipline << endl;
	cout << "Z pednavantajeniam " << hours << " godun" << endl << endl;
}

void Zav_Kafedru::show()
{
	cout << get_name() << " Zav kafedru " << kafedra << endl;
	cout << "V " << university << endl << endl;
}

int main()
{
	Student s;
	Teacher t;
	Zav_Kafedru z;
	s.set_name("Astronaut");
	s.set_year(2002);
	s.set_group("Polet na mars");
	s.set_kurs(2);
	t.set_name("Belka");
	t.set_year(1999);
	t.set_hours(1);
	t.set_discipline("teoria zagovora");
	z.set_name("Neptun");
	z.set_year(1846);
	z.set_kafedra("Kosmos");
	z.set_university("NUBIP");
	s.show();
	t.show();
	z.show();
}
