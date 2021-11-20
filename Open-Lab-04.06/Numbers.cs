using System;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        { 
            int a = 0;
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 2 == 0)
                    a++;
            int[] filter = new int[a];
            a = 0;
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 2 == 0)
                {
                    filter[a] = numbers[i];
                    a++;
                }
            return filter;     
        }
    }
}
