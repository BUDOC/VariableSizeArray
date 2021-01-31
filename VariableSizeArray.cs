using System;
using System.Collections.Generic;
using System.Text;

namespace NameSpace
{
     public class LineOfArray
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
        public int NumberOfLines ;
        public int NumberOfColumns ;
        private readonly List<LineOfArray> ListeOfLines = new List<LineOfArray>();
      
        public VariableSizeIntArray(int rows, int columns)
        {
            this.NumberOfLines = rows;
            this.NumberOfColumns=columns;
            
            for( int i=0; i<rows;i++)
            {
                LineOfArray Line = new LineOfArray();
                for ( int j=0;j<columns; j++)
                {
                    Line.IntList.Add(-1);
                }
                this.ListeOfLines.Add(Line);
            }            
        }

        public void SetValue(int row, int column, int value)
        {
            this.ListeOfLines[row].IntList[column] = value;
        }

        public int GetValue(int row, int column)
        {
          return  this.ListeOfLines[row].IntList[column] ;
        }

    }
}
