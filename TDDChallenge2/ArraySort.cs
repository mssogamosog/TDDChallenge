﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TDDChallenge2
{
    public class ArraySort
    {
        public static int[] Sort(int[] array)
        {

            int length = array.Length;
            if(length == 0)
            {
                return array;
            }
            else
            {
                int temp = array[0];

                for (int i = 0; i < length; i++)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];

                            array[i] = array[j];

                            array[j] = temp;
                        }
                    }
                }

                return array;
            }
            
        }


    }
}
