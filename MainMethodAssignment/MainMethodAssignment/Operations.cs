using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssignment
{
    class Operations
    {
        public int math(decimal num)
        {
            int total = Convert.ToInt32(num) / 10;
            return total;
        }

        public int math(string num)
        {
            int total = Convert.ToInt32(num) * 7;
            return total;
        }

        public int math(int num)
        {
            int total = num + 32;
            return total;
        }

    }
}
