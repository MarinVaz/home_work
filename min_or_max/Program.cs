string input_1 = Console.ReadLine();
string input_2 = Console.ReadLine();
double a = Convert.ToInt32(input_1);
double b = Convert.ToInt32(input_2);
if (a>b)
{
  Console.WriteLine("max = " +a); 
  Console.WriteLine("min = " +b); 
}
else
Console.WriteLine("max = " + b);
Console.WriteLine("min = " +a);
/*string input_1 = Console.ReadLine();
string input_2 = Console.ReadLine();

int number_1 = Convert.ToInt32(input_1);
int number_2 = Convert.ToInt32(input_2);
int result = number_2 * number_2;
if (result == number_1)
{
Console.Write("ДА");
}
else
Console.Write("НЕТ");*/
