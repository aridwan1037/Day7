// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to Calculator Apps");
Console.WriteLine("1. Circle");
Console.WriteLine("2. Rectangle");
Console.WriteLine("3. Triagle");
Console.WriteLine("4. parallelogram");
Console.WriteLine("5. Trapezoid");
Console.WriteLine("Please select the Menu :");
int menu = int.Parse(Console.ReadLine());

Menu(menu);

static void Menu(int menu)
{
    switch (menu)
    {
        case 1:
            Console.WriteLine("Wellcome to Circle Menu");
            Console.Write("Please insert radius of circle : ");
            int radius = int.Parse(Console.ReadLine());
            double area = Math.PI * (radius * radius);
            Console.Write($"The area of circle is : {area}");
            break;
        case 2:
            Console.WriteLine("Wellcome to Rectangle Menu");
            Console.Write("Please insert length of rectangle : ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Please insert width of rectangle : ");
            int width = int.Parse(Console.ReadLine());
            double area = length * width;
            Console.Write($"The area of circle is : {area}");
            break;
        case 3:
            Console.WriteLine("Wellcome to Trianle Menu");
            Console.Write("Please insert base of rectangle : ");
            int base = int.Parse(Console.ReadLine());
            Console.Write("Please insert height of rectangle : ");
            int width = int.Parse(Console.ReadLine());
            double area = base * width;
            Console.Write($"The area of circle is : {area}");
            break;
        // case 4:
        //     Console.WriteLine("Wellcome to Circle Menu");
        //     Console.Write("Please insert radius of circle : ");
        //     int radius = int.Parse(Console.ReadLine());
        //     double area = Math.PI*(radius*radius);
        //     Console.Write($"The area of circle is : {area}");
        // break;
        default:
            Console.WriteLine("you entered the wrong menu !!!");
    }
}
