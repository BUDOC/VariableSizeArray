using System;

namespace NameSpace
{
    internal class Program
    {
        private static void Main()
        {
            VariableSizeIntArray myArray = new VariableSizeIntArray(4,3);


         
            Console.WriteLine(myArray.GetValue(0, 2));
            showArray(myArray);

             void showArray(VariableSizeIntArray intArray)
            {
                int a = myArray.NumberOfLines;
                int b = myArray.NumberOfColumns;
                Console.WriteLine("Nb Lignes = " + a);
                Console.WriteLine("Nb colonnes = " + b);
                for (int lines = 0; lines < intArray.NumberOfLines; lines++)
                {
                    for (int place = 0; place < b; place++)
                    {
                        Console.Write(myArray.GetValue(lines,place) + " ");
                    }
                    Console.WriteLine();
                }
             
            }
        }
    }
}
