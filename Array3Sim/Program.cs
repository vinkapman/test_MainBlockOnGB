Console.WriteLine("Введите количество элементов массива: "); 
int size = Int32.Parse(Console.ReadLine());

string elements;

string[] firstArray = new string[size];

for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент масива № {i+1}");
        firstArray[i] = Console.ReadLine();
    }

for(int i = 0; i < size; i++)
    {
        if(firstArray[i].Length < 3)
        {
            secondArray[i] = firstArray[i];
        }
    }

Console.WriteLine(String.Join(" ", firstArray));