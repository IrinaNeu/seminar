// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Console.WriteLine("Введите длину массива");
// int num = Convert.ToInt32 (Console.ReadLine());

// int [] array = new int[num];
// int Count= 0;
// for (int i = 0; i < array.Length; i++)
//     {
//     array[i]=new Random().Next(100,1000);
//     if (array[i]%2==0)
//     {
//         Count= Count+1;
//     }
//  }
// Console.WriteLine(String.Join(",",array));
// Console.WriteLine();
// Console.WriteLine(Count);
//___________________________________________________________________________
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите длину массива");
// int num = Convert.ToInt32 (Console.ReadLine());

// int [] array = new int[num];
// int sum =0;
// for (int i = 0; i < array.Length; i++)
//     {
//     array[i]=new Random().Next(0,100);

//     if (i%2 == 1)
//     {   
//         sum = sum + array[i];
        
//      }
    
//  }
// Console.WriteLine(String.Join(",",array));
// Console.WriteLine();
// Console.WriteLine(sum);
//_______________________________________________________-

// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.WriteLine("Введите длину массива");
// int num = Convert.ToInt32 (Console.ReadLine());
// int [] array = new int[num];
// int min = array[0];
// int max = array[0];
// int minIndex = 0;
// int maxIndex = 0;
// int res = 0;
// for (int i = 0; i < array.Length; i++)
//     {
//     array[i]=new Random().Next(10,100);

//     if (array[i]<min)
//         {
//              min = array[i];
//              minIndex= i;
//              i++;
//                       }
//     else if (array[i]>max)
//          {  
//             max = array[i];
//             maxIndex = i;
//             i++;
//          }
        
//          res = max-min;
//       }
      
//     Console.WriteLine(String.Join(",",array));
// Console.WriteLine();
// Console.WriteLine(res);

