using System;

namespace NameSpace
{
    internal class Program
    {
        private static void Main()
        {
            // construit un tableau d'entiers de 4 lignes par 3 colonnes
            VariableSizeIntArray myArray = new VariableSizeIntArray(4, 3);

            // affecte la valeur 53 en (1,2)
            myArray.SetValue(1, 2, 56);
            Console.WriteLine("Code d'erreur = " + myArray.GetErrorCodeNumber());
            showArray(myArray);

            // Affiche les valeurs du tableau
            void showArray(VariableSizeIntArray intArray)
            {
                int a = intArray.GetLinesNumber();
                int b = intArray.GetColumnsNumber(); ;
                Console.WriteLine("Nb Lignes = " + a);
                Console.WriteLine("Nb colonnes = " + b);
                for (int lines = 0; lines < intArray.GetLinesNumber(); lines++)
                {
                    for (int place = 0; place < b; place++)
                    {
                        Console.Write(intArray.GetValue(lines, place) + " ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
