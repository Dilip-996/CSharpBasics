using System;

namespace NumberBetween1and100
{
    public static class DivisibleByThreeCounter
    {
        public static int Count()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
