namespace ConditionStatements3
{
    public static class Tasks
    {
        public static (int a, int b, int c) Task1(int a, int b, int c)
        {
            int min = Math.Min (Math.Min(a, b), c);
            int max = Math.Max (Math.Max(b, c), a);
            a= min;
            c= max;
            return (a, b, c);
        }


        public static (int a, int b, int c) Task2(int a, int b, int c)
        {
            if ((a <= b & b <= c))
            {


                a = a * 2;
                b = b * 2;
                c = c * 2;
            }
            else
            {
                a = a * (-1);
                b = b * (-1);
                c = c * (-1);
            }


                return (a, b, c);
            }
        
        public static (int a, int b, int c) Task3(int a,  int b, int c)
        {
            if (((a <= b & b <= c)) || ((a >= b & b >= c)))
            {


                a = a * 2;
                b = b * 2;
                c = c * 2;
            }
            else
            {
                a = a * (-1);
                b = b * (-1);
                c = c * (-1);
            }


            return (a, b, c);
        }
    }  
}

