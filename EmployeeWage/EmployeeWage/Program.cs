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
Console.WriteLine("isPresent" + ispresent);

switch(ispresent)   
{
    case present:
    Console.WriteLine("Employee is Present");
        empWage = perHrWage * fulltime;                               
    break;

    case Halfday:
    Console.WriteLine("Employee is Present");
        empWage = perHrWage * Parttime;
    break;

    default:
        Console.WriteLine("Employee is Absent");
    break;
}
Console.WriteLine("Employee Wage : " + empWage);

















