namespace Task2;
class Program
{
    /*Створити список рядків List<string>, який містить 5
    дисциплін цього семестру. Реалізувати методи додавання,
    видалення, сортування, пошуку. Результати вивести на
    консоль.*/
    static void Main(string[] args)
    {
        List<String> strings = new List<string>();
        strings.Add("Основи програмування");
        strings.Add("Алгебра");
        strings.Add("Іноземна мова");
        strings.Add("Вступ до спеціальності");
        strings.Add("Фізичне виховання");
        strings.Add("Методи");

        Console.WriteLine("Початковий список");
        foreach(var item in strings)
        {
            Console.WriteLine(item);
        }
        strings.Remove("Фізичне виховання");
        strings.Sort();
        Console.WriteLine("\nПісля видалення та сортування");
        foreach(var item in strings)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\nПошук в коллекції - " + strings.Find(x=>x.Contains("Методи")));
    }
}

