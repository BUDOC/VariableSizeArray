using System;

namespace NameSpace
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            VariableSizeIntArray myArray = new VariableSizeIntArray();
            for (int k = 0; k < 4; k++)
            {
                LineOfArray maligne = new LineOfArray();
                for (int j = 0; j < 6; j++)
                {
                    maligne.AddAvalue(j + k * 10);
                }
                myArray.AddLine(maligne);
            }

            showArray(myArray);

            static void showArray(VariableSizeIntArray intArray)
            {
                int a = intArray.NumberOfLines;
                int b = intArray.ListeOfLines[0].IntList.Count;
                Console.WriteLine("Nb Lignes = " + a);
                Console.WriteLine("Nb colonnes = " + b);
                for (int lines = 0; lines < intArray.NumberOfLines; lines++)
                {
                    for (int place = 0; place < b; place++)
                    {
                        Console.Write(intArray.ListeOfLines[lines].IntList[place].ToString() + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
