// See https://aka.ms/new-console-template for more information
Console.WriteLine("Employee Wage");
Random random = new Random(); // using to generate the random numbers
const int present = 1,
          abcent = 0;

int ispresent = random.Next(2); // 0,1
if(ispresent == present)
{
    Console.WriteLine(" Employee is Present ");

}
else
{
    Console.WriteLine(" Employee is Abcent");
}
