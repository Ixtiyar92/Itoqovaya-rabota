/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями лучше обойтись исключительно массивами.

Например:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "-2", "1567", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int size  = int.Parse(Console.ReadLine());

string[] array1 = new string[size];

for (int i = 0; i < size; i++){
	Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine();
	array1[i] = result;  
}

int count = 0;
int maxSymbols = 3;

for (int i = 0; i < array1.Length; i++){
	if(array1[i].Length <= maxSymbols){
		count++;
	}   
}

string[] array2 = new string[count];
int j = 0;
for (int i = 0; i < array1.Length; i++){
    if(array1[i].Length <= maxSymbols){
        array2[j] = array1[i];
        j++;
    }
}

Console.WriteLine();
Console.Write($"[{String.Join(", ", array1)}] -> [{String.Join(", ", array2)}]");