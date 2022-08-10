using Task_3;

Console.Write("Введите автора : ");
string author = Console.ReadLine();

Console.Write("Введите содержание : ");
string content = Console.ReadLine();

Console.Write("Введите заголовок : ");
string title = Console.ReadLine();

Console.WriteLine($"\n{new String('-', 3)}\n");

Console.Write("Вы добавили книгу : ");

Book book = new Book();
book.BookInitializer(author, content, title);

Console.ForegroundColor = ConsoleColor.White;