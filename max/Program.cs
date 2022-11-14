string input_1 = Console.ReadLine();
string input_2 = Console.ReadLine();
string input_3 = Console.ReadLine();
double a = Convert.ToInt32(input_1);
double b = Convert.ToInt32(input_2);
double c = Convert.ToInt32(input_3);
if (a > b && a > c)
    Console.WriteLine("Max = " + a); 
    else if (b > c)
    Console.WriteLine("Max = " + b); 
        else
        Console.WriteLine("Max = " + c); 
