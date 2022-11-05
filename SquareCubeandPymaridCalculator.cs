    Console.Write("Square, cube or pymarid? ");
    string Shape = Console.ReadLine();
    string ToLowerShape = Shape.ToLower();
int Length;
int Width;
int Height;
switch (ToLowerShape)
{
    case "square":
        Console.Write("Length? ");
        Length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Width? ");
        Width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The area of the square is " + Length * Width);
        break;

    case "cube":
        Console.Write("Length? ");
        Length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Width? ");
        Width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Height? ");
        Height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The area of the cube is " + Length * Width * Height);
        break;

    case "pymarid":
        Console.Write("Length? ");
        Length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Width? ");
        Width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Height? ");
        Height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The area of the pymarid is " + Length * Width * Height / 2);
        break;
}