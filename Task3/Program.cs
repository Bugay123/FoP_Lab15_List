namespace Task3;
class Program
{
    /*Створити 2 списки цілих чисел (класу List<T>), у яких є
    однакові елементи. Створити список intersectList, який містить
    елементи, які є в обох списках.*/
    static void Main(string[] args)
    {
        List<int> firstList = new List<int>();
        firstList.Add(1);
        firstList.Add(2);
        firstList.Add(3);
        firstList.Add(4);
        firstList.Add(5);
        List<int> secondList = new List<int>();
        secondList.Add(3);
        secondList.Add(4);
        secondList.Add(5);
        List<int> thirdList = new List<int>();
        thirdList.AddRange(firstList);
        for(int i = firstList.Count - 1; i >= 0; i--)
        {
            if (!secondList.Contains(firstList[i]))
            {
                thirdList.RemoveAt(i);
            }
        }
        foreach(var item in thirdList)
        {
            Console.WriteLine(item);
            }
        }
}

