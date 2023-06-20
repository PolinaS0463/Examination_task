//I. Способ:

int amount;
GetLength();
string[] array = new string[amount];

FillArray(array, amount);
PrintArray(array);
PrintArray(CreateNewArray(array));


int GetLength(){
    Console.Write("Введите количество элементов массива: ");
    bool result = int.TryParse(Console.ReadLine(), out var number);
    if(result) {
        amount = number;
    }
    else {
        Console.WriteLine("Пожалуйста, введите число!");
        GetLength();
    }
    return amount;
}

string Prompt(string message){
    Console.Write(message);
    string? elem = Console.ReadLine();
    return elem ?? Prompt(message);
}

void FillArray(string[] array, int amount){
    for(int index = 0; index < amount; index++){
        array[index] = Prompt($"Введите {index + 1}-й элемент массива: ");
    }
}

string[] CreateNewArray(string[] array){
    int result = 0;
    foreach(string element in array){
        if (element.Length <= 3){
            result++;
        }
    }
    if(result == 0){
        Console.WriteLine("В массиве нет строк длиной равной 3 или менее");
        Environment.Exit(0);
    }
    string[] newArray = new string[result];
    int count = 0;
    foreach(string element in array){
        if (element.Length <= 3){
            newArray[count] = element;
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] array){
    Console.WriteLine("Массив: " + string.Join(", ", array));
}

//II. Способ:

GetLength();
string[] array2 = new string[amount];
string[] doubleArray = new string[amount];
FillArray(array2, amount);
FillDoubleArray(array2, doubleArray);
PrintDoubleArray(doubleArray);

string[] FillDoubleArray(string[] array2, string[] doubleArray){
    int count = 0;
    foreach(string element in array2){
        if(element.Length <= 3){
            doubleArray[count] = element;
            count++;
        }
    }
    return doubleArray;
}

void PrintDoubleArray(string[] doubleArray){
    Console.Write("[");
    foreach(string element in doubleArray){
        if(element == null){
            break;
        }
        Console.Write($"{element}, ");
    }
    Console.Write("]");
}
