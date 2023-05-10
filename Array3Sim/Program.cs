Console.Write("Введите количество элементов массива: ");
int size = Int32.Parse(Console.ReadLine());
string [] firstArray = new string [size];

void EnterSymArray (string [] newArray)
    {
        for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива №{i+1}: ");
                newArray[i] = Console.ReadLine();
            }
    }

string [] ThreeMinSymArray (string [] newArray)
    {
        int count = 0;
        for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i].Length <= 3)
                count++;
            }
        string [] secondArray = new string[count];
        count = 0;
        for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i].Length <= 3)
                    {
                        secondArray[count] = firstArray[i];
                        count++;
                    }
            }
        return secondArray;
    }

void printArray (string [] newArray)
    {
        Console.WriteLine(String.Join("\t", newArray));
    }

EnterSymArray(firstArray);
printArray(firstArray);
printArray(ThreeMinSymArray(firstArray));