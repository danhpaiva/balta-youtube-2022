using ImplicitOperators;
using static System.Console;

double x = 100.38;
int y = (int)x; //100

Phone phone = new Phone
{
  Area = "31",
  CountryCode = "55",
  Number = "31313131"
};

var telefone = "55 31 99999999";
telefone = phone;

var telefoneDois = "55 31 99999997";
phone = telefoneDois;

var user = new User
{
  Active = true,
  Id = 7,
  Password = "12345",
  UserName = "danhpaiva"
};

UserViewModel userViewModel = user;

ReadLine();