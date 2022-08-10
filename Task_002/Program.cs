using Task_2;

Console.Write("Введите длину перывой стороны : ");
double side1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите длину второй стороны : ");
double side2 = Convert.ToDouble(Console.ReadLine());

Rectangle rectangleArea = new Rectangle(side1, side2);
Console.WriteLine($"Площадь прямоугольника равна: {rectangleArea.AreaCalculator()}");

Rectangle rectanglePerimeter = new Rectangle(side1, side2);
Console.WriteLine($"Периметр прямоугольника равна: {rectanglePerimeter.PerimtereCalculator()}");

Console.WriteLine($"\n{new string('-', 33)}");