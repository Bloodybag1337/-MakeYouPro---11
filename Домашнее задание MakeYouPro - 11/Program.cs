/*
Задание:
Ресторан быстрого питания планирует обновить меню,
однако для того, чтобы оставить наиболее популярные блюда,
администраторы хотят увидеть аналитику количества заказов каждой позиции за последний год. 
Напишите метод, который получает на вход массив целых чисел
(количество заказов блюда за последний год)
и возвращает его отсортированным в порядке убывания.
*/

int[] orderQuantity = Generate(10, 0, 50);
Write(orderQuantity);

orderQuantity = SortBy(orderQuantity);
Write(orderQuantity);

int[] Generate(int n, int a, int b)
{
    int[] testArray = new int[n];

    Random random = new Random();

    for (int i = 0; i < n; i++)
    {
        testArray[i] = random.Next(a, b + 1);
    }
    return testArray;
}

int[] SortBy(int[] testArray)
{
    for (int i = 0; i < testArray.Length - 1; i++)
    {
        int maxValue = i;
        for (int j = i; j < testArray.Length; j++)
        {
            if (testArray[maxValue] < testArray[j])
            {
                maxValue = j;
            }
        }
        int temp = testArray[maxValue];
        testArray[maxValue] = testArray[i];
        testArray[i] = temp;
    }

    return testArray;

}

void Write(int[]testArray)
{
    for (int i = 0; i < testArray.Length; i++)
    {
        Console.Write($"{testArray[i]} ");
    }
    Console.WriteLine("\n");
}

Console.ReadKey();
