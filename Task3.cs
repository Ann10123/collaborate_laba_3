﻿using System;
using static System.Console;
using static System.Array;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{

    public class Listtask3
    {
        public void Main2()
        {
            Write("\nInput the length");
            int length = int.Parse(ReadLine());
            List<int[]> list=new List<int[]>(length);
            
            for(int i = 0; i < length; i++)
            {
                list[i] =ConvertAll(ReadLine().Split(), int.Parse);
            }
        }
        public void Minimum( )
        {

        }
    }
    internal class Task3
    {
        public int[][] Filling()
        {
            WriteLine("\nEnter the number of arrays:");
            int numberOfArrays = int.Parse(ReadLine());

            int[][] jaggedArray = new int[numberOfArrays][];

            for (int i = 0; i < numberOfArrays; i++)
            {
                WriteLine($"Enter the number of elements for array {i + 1}:");
                int numberOfElements = int.Parse(ReadLine());
                jaggedArray[i] = new int[numberOfElements];

                WriteLine($"Enter {numberOfElements} elements for array {i + 1}:");
                string[] data = ReadLine().Split();
                for (int j = 0; j < numberOfElements; j++)
                {
                    jaggedArray[i][j] = int.Parse(data[j]);
                }
            }
            WriteLine("\nJagged array:");
            for (int i = 0; i < numberOfArrays; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Write(jaggedArray[i][j] + " ");
                }
                WriteLine();
            }
            return jaggedArray;
        }
        public int Minimum(int[][] array)
        {
            int min = int.MaxValue;
            int arrayIndex = -1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] arrayNow= array[i];
                
                for(int j = 0;j < arrayNow.Length; j++)
                {
                    if (arrayNow[j] < min)
                    {
                        min = arrayNow[j];
                        arrayIndex = i;
                    }
                }
            }
            return arrayIndex;
        }
        public void Changing(int[][] array,int indexOfArray)
        {
            int[] addedArray = new int[10] {0,6,3,6,4,7,4,7,2,9};
            Array.Resize(ref array, array.Length+1);
            for(int i =array.Length-1; i >indexOfArray; i--)
            {
                array[i]= array[i - 1];
            }
            array[indexOfArray] = addedArray;
            WriteLine("\nNew jagged array");
            Print(array);
        }
        public void Print(int[][] arrayJagged)
        {
            foreach (int[] arr in arrayJagged)
            {
                foreach(int i in arr)
                {
                    Write(i + " ");
                }
                WriteLine();
            }
        }
        public void Main()
        {
            WriteLine("\nChoose the array or list");
            string chooce = ReadLine();
            switch (chooce)
            {
                case "list":
                    new Listtask3();
                    break;
                case "array":
                    int[][] array = Filling();

                    int arrayIndex = Minimum(array);
                    Changing(array, arrayIndex);
                    break;
            } 
           

        }
    }
}
