namespace Lab15Var2;
class Program
{
    /*Створити порожній список цілих чисел List<int>. Додати до
    нього 4 числа. Знайти суму чисел списку і вивести її на консоь.
    Перетворити список в масив.*/
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        int sum = 0;
        foreach (var item in list)
        {
            sum += item;
        }
        Console.WriteLine(sum);
        list.ToArray();
    }
}

