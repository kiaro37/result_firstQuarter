// Задача. Написать программу,
// которая из имеющегося массива строк сформирует массив из строк, 
// длина которых меньше либо равна 3 символам.


string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine(); //записываем в массив числа введенные пользователем
    }
    return array;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}


Console.WriteLine("Какое количество чисел вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числа через нажатие клавиши Enter");

string[] array = CreateArray(size);
PrintArray(array);

Console.Write(" ---> ");
