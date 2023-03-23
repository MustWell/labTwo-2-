

Console.Write("Введите число а: "); int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: "); int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Pow(a1-b1, 3));//1
Console.WriteLine(Math.Pow(a1 + b1, 3));//2
Console.WriteLine(Math.Pow(a1, 3) + Math.Pow(b1,3));//3
Console.WriteLine(Math.Pow(a1,3) - Math.Pow(b1,3));//4
Console.WriteLine(Math.Pow(a1,2) - Math.Pow(b1,2));//5
Console.WriteLine(Math.Pow(a1-b1,2));//6
Console.WriteLine(Math.Pow(a1+b1,2));//7
Console.WriteLine("\nНажмите Enter для продолжения...");
Console.ReadKey();
Console.Clear();


Console.Write("Введите число а: "); int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: "); int b = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число c: "); int c = Convert.ToInt32(Console.ReadLine());
// ((a^2 - 4bc)/(a - a^0.5 - a^c) - (abc)^3)/(a^2 - 2ab + b^2)")
Console.WriteLine(Convert.ToInt32(((Math.Pow(a, 2) - 4 * b * c)) / (a - 
    Math.Pow(a, 0.5) - Math.Pow(a, c)) - Math.Pow ((a * b * c), 3) / 
    (Math.Pow(a, 2)) - 2 * a * b + Math.Pow(b, 2)));
 