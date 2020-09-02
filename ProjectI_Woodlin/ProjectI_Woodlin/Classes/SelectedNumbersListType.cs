using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Ayanna Woodlin
 * Frank Friedman
 * Project 1: Bingo
 * 1/24/2019
 * Keeps track of the selectedNumbers
 * */

namespace ProjectI_Woodlin.Classes
{
    class SelectedNumbersListType
    {
        private Boolean[] usedNumbers = new Boolean[SIZE];
        private const int SIZE = 76;
        
        public SelectedNumbersListType()
        {
            reset();
        }
        public void setUsedNumber(int num)
        {
            Boolean isItUsed = isNumberUsed(num);
            if (isItUsed == false)
            {
                usedNumbers[num] = true;
            }

        }   //end setUsedNumber
        public Boolean isNumberUsed(int num)
        {
            if (usedNumbers[num])
            {
                return true;
            }
            else
            {
                return false;
            }
        }   //end isNumberUsed

        public void reset()
        {
            for (int x = 0; x < usedNumbers.Length; x++)
            {
                usedNumbers[x] = false;
            }
        }   //end reset
    }
}
