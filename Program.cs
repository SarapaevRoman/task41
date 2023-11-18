//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел:");
string input = Console.ReadLine();
int PositiveCounting(string input){

    string[] number = input.Split(' ');
    int size = number.Length;
    int[] array = new int [size];
    int count = 0;
    for (int i = 0; i < size; i++) 
    {
        array[i] = Convert.ToInt32(number[i]);
        if (array[i] > 0) {count++;}
    }
    return count;
}
Console.WriteLine($"Пользователь ввел {PositiveCounting(input)} чисел больше нуля");
