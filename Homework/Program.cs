using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //homework 1
            //Verilmis n ededinin 3-e bolunub, bolunmemesini tapin
            //int n = 21;
            //if (n % 3 == 0 && n % 7 == 0) 
            //{
            //    Console.WriteLine("bolunur");
            //}  
            //else  
            //{
            //    Console.WriteLine("bolunmur");
            //}




            //homework 2
            //n və m ədədləri verilir.Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
            //int n = 20, m = 5;
            //if (n % 2 == 0 && m % 2 == 0) 
            //{ 
            //    Console.WriteLine(n + m); 
            //}
            //else
            //{
            //    Console.WriteLine("cut deyil");
            //}



            //homework 3
            //Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
            //int n = 4, m = 13;
            //int sum = 0;
            //for (int i = n; i <= m; i ++ )
            //    if (i % 2 == 1)
            //    {
            //        sum += i;
            //    }
            //Console.WriteLine(sum);



            //Homework 4
            //Verilmish arrayin icindeki tek ededlerin cemini tapin.


            //int[] array = { 5, 10, 15, 20 };
            //int sum = 0;

            //for (int i = 0; i < array.Length; i++)
            //    if (array[i] % 2 != 0)
            //{
            //        sum += array[i];

            //}
            //Console.WriteLine(sum);


            //Homework 5
            //Verilmish arrayin icindeki cut ededlerin sayini tapin.

            int[] array = { 5, 10, 15, 20, 25 };
            int a = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)
                {
                    a++;

                }
            Console.WriteLine(a);


           



           
















        }
    }

}





