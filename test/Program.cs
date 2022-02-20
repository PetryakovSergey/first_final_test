/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритм*/


string[] Array = {"hello", "world", "2", ":-)"};
void PrintStringArray(string[] Array)
{
    Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"\"{Array[i]}\"");
        if (i != Array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


int StringSize(string[] Array)
{
  int count = 0;
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i].Length < 4)
    {
      count++;
    }
  }
  return count;
}


string[] NewArray (string[] Array, int SizeNewArr)
{
  string[] NewArr = new string[SizeNewArr];
  int j = 0;
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i].Length < 4)
    {
      NewArr[j] = Array[i];
      j++; 
    }
  }
  return NewArr;
}

PrintStringArray(Array);

int LengthNewArray = StringSize(Array); 
string[] NewArr = NewArray(Array, LengthNewArray); 
Console.Write(" --> ");
PrintStringArray(NewArr);
