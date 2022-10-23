using System;
class Arge
{

    public static int NbYear(int p0, double percent, int aug, int p)
    {
        // your code
        int count = 0;
        percent = percent * 0.01;

        while (p0 < p)
        {
            p0 += (int)(p0 * percent) + aug;
            count++;
        }
        return count;

    }

}