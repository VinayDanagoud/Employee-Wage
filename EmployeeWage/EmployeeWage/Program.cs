// See https://aka.ms/new-console-template for more information
Console.WriteLine("Employee Wage");
Random random = new Random(); // using to generate the random numbers
const int present = 1,
             Abcent = 0,
             perHrWage = 20,
             fulltime = 8,
             Parttime = 4,
             Halfday = 2;


int ispresent = random.Next(3), // 0 = Absent, 1 = Present/Fulltime, 2 = Parttime
    empWage = 0;

if(ispresent == present)
{
    Console.WriteLine(" Employee is Present ");
    empWage = perHrWage * fulltime;
}
else if (ispresent == Halfday)
{
    Console.WriteLine("Employee is Present Halfday");
    empWage=perHrWage * Parttime;
}
else
{
    Console.WriteLine(" Employee is Abcent");
}
Console.WriteLine("Employee Wage : "+ empWage);