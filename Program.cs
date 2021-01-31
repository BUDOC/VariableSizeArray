using System;

namespace NameSpace
{
    internal class Program
    {
        private static void Main()
        {
            // construit un tableau d'entiers de 4 lignes par 3 colonnes


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

                Console.WriteLine("Code d'erreur = " + intArray.GetErrorCodeNumber());
            }
            Console.WriteLine("How much rows for your array?");
            string nl = Console.ReadLine();
            Console.WriteLine("How much lines for your array?");
            string nr = Console.ReadLine();
            VariableSizeIntArray myArray = new VariableSizeIntArray(Convert.ToInt32(nl), Convert.ToInt32(nr));
            // affecte la valeur 56 en (1,2)
            myArray.SetValue(1, 2, 56);
            showArray(myArray);
            myArray.SetValue(Convert.ToInt32(nl)+1, 4, 56);
            showArray(myArray);
        }
    }
}
