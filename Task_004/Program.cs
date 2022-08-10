using Task_4;

Figure figure = new Figure(new Point("A", -5, -5), new Point("B", -1, 4), new Point("C", 4, 4), new Point("D", 3, -5));

Console.Write($"Получился {figure.Name} c площадью ");

figure.PerimeterCalculator();