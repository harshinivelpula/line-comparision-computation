

Console.WriteLine("Enter x1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter x2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter y2");
double y2 = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine("length of this line is " + length);

double l1 = 33;
double l2 = 40;
if (l1 == l2)
    Console.WriteLine("Equal Lines");
else if 
    (l1 > l2)
    Console.WriteLine("Line 1 greater than line 2");
else
    Console.WriteLine("Line 2 is greater than line 1");