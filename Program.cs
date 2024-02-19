// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо 
// равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При 
// решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] FillArray(int num)
{
    string[] array = new string[num];
    // char wordStr = new char();
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите элемент {i+1} и нажмите Enter: ");
        // char wordStr = Convert.ToChar(Console.ReadLine());
        // string wordStrToLower = wordStr.ToLower();
        array[i] = Console.ReadLine(); 
    }
    return array;
}


// Меняем кодировку:
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

// Уточняем размер массива, для ручного ввода элементов:
Console.Write("Введите количество элементов массива: ");
int numOfElements = int.Parse(Console.ReadLine());

// Заполняем массив вручную элементами
string[] filledArr = FillArray(numOfElements);

Console.WriteLine($"Массив: [ {string.Join(" ;", filledArr)} ]");

// string wordStr = Console.ReadLine();
// string wordStrToLower = wordStr.ToLower();

// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// // Наполняем массив случайными числами
// char[,] createMatrix = FillMatrix(rows, columns);
// PrintMatrix(createMatrix); // Массив ДО
// Console.WriteLine("Результат: ");
// string matrToStr = UnionCharElements(createMatrix);
// Console.WriteLine(matrToStr); // Строка ПОСЛЕ