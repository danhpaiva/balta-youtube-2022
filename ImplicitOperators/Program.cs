﻿using ImplicitOperators;
using static System.Console;

double x = 100.38;
int y = (int)x; //100

Phone phone = new Phone
{
  Area = "31",
  CountryCode = "55",
  Number = "31313131"
};

WriteLine(phone);
ReadLine();