using System;
using System.Collections.Generic;
using System.Text;

namespace NameSpace
{
    class LineOfArray
    {
        // Représente une ligne de tableau composée d'entiers
        public List<int> IntList = new List<int>();
        public int NumberOfLineValues;


        public void AddAvalue(int myIntValue)
        {
            IntList.Add(myIntValue);
            NumberOfLineValues = IntList.Count;
        }
    }

    class VariableSizeIntArray
    {
        // représente un tableau coposé de lignes d'entiers
        public int NumberOfLines;
        public List<LineOfArray> ListeOfLines = new List<LineOfArray>();

        public  void AddLine(LineOfArray myNewLine)
        {
            ListeOfLines.Add(myNewLine);
            NumberOfLines = ListeOfLines.Count;
        }

        

    }
}
