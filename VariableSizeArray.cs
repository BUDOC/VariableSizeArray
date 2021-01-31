using System;
using System.Collections.Generic;
using System.Text;

namespace NameSpace
{
     public class LineOfIntArray
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
        // représente un tableau composé de lignes d'entiers
        private readonly int NumberOfLines ;
        private readonly int NumberOfColumns ;
        private int ErrorCode = 0;
        private readonly List<LineOfIntArray> ListeOfLines = new List<LineOfIntArray>();              

        public  int GetLinesNumber()
        {
            return this.NumberOfLines;
        }

        public int GetColumnsNumber()
        {
            return this.NumberOfColumns;
        }

        public int GetErrorCodeNumber()
        {
            return this.ErrorCode;
        }

        public VariableSizeIntArray(int rows, int columns)
        {
            this.NumberOfLines = rows;
            this.NumberOfColumns=columns;
            
            for( int i=0; i<rows;i++)
            {
                LineOfIntArray Line = new LineOfIntArray();
                for ( int j=0;j<columns; j++)
                {
                    Line.IntList.Add(0);
                }
                this.ListeOfLines.Add(Line);
            }            
        }

        public void SetValue(int row, int column, int value)
        {
            if( row<0 || row>this.NumberOfLines ||column<0 || column>this.NumberOfColumns)
            {
                this.ErrorCode = 1;
            }
            else
            {
                this.ListeOfLines[row].IntList[column] = value;
                this.ErrorCode = 0;
            }            
        }

        public int GetValue(int row, int column)
        {
          return  this.ListeOfLines[row].IntList[column] ;
        }
    }
}
