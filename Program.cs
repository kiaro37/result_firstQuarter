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

string[] ThreeChar(string[] arr)
{
    int lenght = 3;
    int j = 0;
    string[] array = new string [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= lenght)
        {
            array[j] = arr[i];
            j++;
        }
    }
    string[] ar = new string[array.Length];
    int count = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if(array[k] != null)
        count++;
    }
    string[]newArr = new string[count];
    for (int m = 0; m < newArr.Length; m++)
    {
        newArr[m] = array[m];
    }
    return newArr;
}



Console.WriteLine("Какое количество элементов вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите элементы через нажатие клавиши Enter");

string[] array = CreateArray(size);
PrintArray(array);

Console.Write(" ---> ");

string[] newArray = ThreeChar(array);
PrintArray(newArray);
