
namespace Linqmaster
{
    class Program
{
    static void Main()
    {
        List<Metro> Metro = GetStaffList();
        PrintNames(Metro);
        FilterStaff(Metro);
        SortStaffByAge(Metro);
        AggregateOperationsForStaff(Metro);
        GroupStaffByAge(Metro);
    }

    //Выборка по имени
    private static void PrintNames(List<Metro> Staff)
    {
        Console.WriteLine("\nВыборка:");
        var StaffNames = Staff.Select(s => s.Name);
        foreach (var name in StaffNames)
        {
            Console.WriteLine(name);
        }
    }

    //Фильтрация по условию
    private static void FilterStaff(List<Metro> Staff)
    {
        Console.WriteLine("\nФильтрация:");
        var filteredStaff = Staff.Where(s => s.Score > 8);
        foreach (var Worker in filteredStaff)
        {
            Console.WriteLine($"{Worker.Name} - {Worker.Score}");
        }
    }

    //Сортировка сотрудников по возрасту
    private static void SortStaffByAge(List<Metro> Staff)
    {
        var sortedStaff = Staff.OrderBy(s => s.Age);
        Console.WriteLine("Сотруднки, отсортированные по возрасту:");
        foreach (var Worker in sortedStaff)
        {
            Console.WriteLine($"{Worker.Name} - {Worker.Age}");
        }
    }


    //агрегатные операции
    private static void AggregateOperationsForStaff(List<Metro> Staff)
    {
        Console.WriteLine("\nМинимальная сумма за смену: " + Staff.Min(s => s.Score));
        Console.WriteLine("\nМаксимальная сумма за смену: " + Staff.Max(s => s.Score));
        Console.WriteLine("\nСредная сумма за смену: " + Staff.Average(s => s.Score));
        Console.WriteLine("\nСуммарная сумма за смену: " + Staff.Sum(s => s.Score));
    }

    //группировка по возврасту
    private static void GroupStaffByAge(List<Metro> Staff)
    {
        var groupByAge = Staff.GroupBy(s => s.Age);
        Console.WriteLine("\nГруппировка сотрудников по возрасту:");
        foreach (var work in groupByAge)
        {
            Console.WriteLine($"Возраст: {work.Key}");
            foreach (var Worker in work)
            {
                Console.WriteLine($"{Worker.Name} - {Worker.Score}");
            }
        }
    }

    //возвращает список сотрудников (коллекцию)
    private static List<Metro> GetStaffList()
    {
        List<Metro> Staff =
        [
            new Metro(1, "Kolokolov", 23, 4500),
            new Metro(2, "Mamiev", 22, 3200),
                new Metro(3, "Fredli", 34, 4100),
                new Metro(4, "Kovalev", 41, 2700),
                new Metro(5, "Ticunov", 45, 3900)
        ];

        return Staff;
    }
}
}