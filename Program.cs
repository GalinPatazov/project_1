


using System.Data.SqlTypes;

Console.WriteLine("working days in the week");
int days = int.Parse(Console.ReadLine());
Console.WriteLine("money for one day");
double money = double.Parse(Console.ReadLine());
Console.WriteLine("dollars in lev");
double dollar = double.Parse(Console.ReadLine());

double salaryForMonth = days * money;
double yearsalsary = (salaryForMonth * 12) + (salaryForMonth * 2.5);
double taxes = yearsalsary * 0.25;
double netSalary = yearsalsary * dollar;
double inLeva = netSalary * dollar;
double avarage = inLeva / 365;

Console.WriteLine($"zaplata v leva - {avarage} leva ");











