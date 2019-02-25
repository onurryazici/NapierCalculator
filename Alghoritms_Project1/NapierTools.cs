using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghoritms_Project1
{
    class NapierTools
    {
        public int get1s(int number)
        {
            return number % 10;
        }
        public int get10s(int number)
        {
            return number / 10 % 10;
        }
        public int get100s(int number)
        {
            return number / 100;
        }

        public int getNumberLength(int number)
        {
            int result = 0;
            if (number >= 100)
            {
                result = 3;
            }
            else if (number >= 10)
            {
                result = 2;
            }
            else
            {
                result = 1;
            }
            return result;
        }
        public void fillDigitsToArray(int[] array, int number)
        {
            int arraySize = getNumberLength(number);
            switch (arraySize)
            {
                case 1:
                    array[0] = get1s(number);
                    break;
                case 2:
                    array[0] = get10s(number);
                    array[1] = get1s(number);
                    break;
                case 3:
                    array[0] = get100s(number);
                    array[1] = get10s(number);
                    array[2] = get1s(number);
                    break;
            }
        }
    }
}
