//ZADACHA 1: 
//Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.


      // int M = 3; 
      // int N = 10;
      //  PrintNumbersInRange(m, n);
    

   // static void PrintNumbersInRange(int start, int end)
   // {
       // if (start <= end)
        //{
          //  Console.WriteLine(start);
          //  PrintNumbersInRange(start + 1, end);
       // }
  //  }

  //Этот код принимает начальное значение M и конечное значение N,
  // а затем вызывает рекурсивную функцию PrintNumbersInRange,
 //которая выводит числа в заданном диапазоне


//ZADACHA 2:
 //Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//int m = InputNumbers("Введите m: ");
//int n = InputNumbers("Введите n: ");

//int functionAkkerman = Ack(m, n);

//Console.Write($"Функция Аккермана = {functionAkkerman} ");

//int Ack(int m, int n)
//{
 // if (m == 0 || m == 1) 
  //   return n + 1;
  //else if (n == 0 || n == 1) 
  //   return Ack(m - 1, 1);
 // else return Ack(m - 1, Ack(m, n - 1));
//}

//int InputNumbers(string input) 
//{
//Console.Write(input);
//  int output = Convert.ToInt32(Console.ReadLine());
//  return output;
//}


//ZADACHA 3: 
//Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

    
        int[] arr = { 1, 2, 3, 4, 5 };
        PrintArrayInReverse(arr, 0); 
    
    static void PrintArrayInReverse(int[] arr, int index)
    {
        if (index < arr.Length) // проверяем, что индекс в пределах массива
        {
            PrintArrayInReverse(arr, index + 1); // вызываем функцию рекурсивно, передавая следующий индекс
            Console.Write(arr[index] + " "); // выводим текущий элемент массива
        }
    }
