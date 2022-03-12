// See https://aka.ms/new-console-template for more information
Console.WriteLine("Employee Wage");
Random random = new Random(); // using to generate the random numbers
const int present = 1,
             Abcent = 0,
             perHrWage = 20,
             fulltime = 8;



int ispresent = random.Next(2), // 0,1
    empWage = 0;

if(ispresent == present)
{
    Console.WriteLine(" Employee is Present ");
    empWage = perHrWage * fulltime;
}
else
{
    Console.WriteLine(" Employee is Abcent");
}
Console.WriteLine("Employee Wage : "+ empWage);