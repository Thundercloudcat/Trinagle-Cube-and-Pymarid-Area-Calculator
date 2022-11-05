Console.Write("Square, cube or pymarid? ");
string Shape = Console.ReadLine();
string ToLowerShape = Shape.ToLower();
double Length;
double Width;
double Height;
switch (ToLowerShape)
{
    case "square":
        Console.Write("Length? ");
        Length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Width? ");
        Width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The area of the square is " + Length * Width);
        break;

    case "cube":
        Console.Write("Length? ");
        Length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Width? ");
        Width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height? ");
        Height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The area of the cube is " + Length * Width * Height);
        break;

    case "pymarid":
        Console.Write("Length? ");
        Length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Width? ");
        Width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height? ");
        Height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The area of the pymarid is " + Length * Width * Height / 2);
        break;
        default: Console.WriteLine("Invalid shape!");
        break;
}
