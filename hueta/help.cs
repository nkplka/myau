namespace hueta;

public class Help
{
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("┌─────────┬─────┬────────────────────┬──────────────────────────────────────┐");
        Console.WriteLine("│ (index) │ id  │      command       │             description              │");
        Console.WriteLine("├─────────┼─────┼────────────────────┼──────────────────────────────────────┤");
        Console.WriteLine("│    0    │  1  │  minecraft parser  │  парсит сервер майнкрафт через json  │");
        Console.WriteLine("├─────────┼─────┼────────────────────┼──────────────────────────────────────┤");
        Console.WriteLine("│    0    │  2  │  discord webhook   │  отправляет сообщение в дискорд      │");
        Console.WriteLine("├─────────┼─────┼────────────────────┼──────────────────────────────────────┤");
        Console.WriteLine("│    0    │  3  │  task manager      │  мини диспетчер задач                │");
        Console.WriteLine("├─────────┼─────┼────────────────────┼──────────────────────────────────────┤");
        Console.WriteLine("│    0    │  4  │  kdmapper          │  запуск дравера через kdmapper       │");
        Console.WriteLine("├─────────┼─────┼────────────────────┼──────────────────────────────────────┤");
        Console.WriteLine("│    0    │  5  │  stop faceit       │  останавливает драйвер фейсита       │");
        Console.WriteLine("└─────────┴─────┴────────────────────┴──────────────────────────────────────┘");
        Console.ReadKey();
    }
}