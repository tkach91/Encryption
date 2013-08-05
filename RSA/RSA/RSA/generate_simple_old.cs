using System;

namespace RSA
{

    public class simple_gen
    {
        const int rep = 10;

        public Int64 simple_num;
        Random Rand;

        public simple_gen(int sz) // В байтах
        {
            Rand = new Random();
            simple_num = get_simple(sz);
        }

        private bool miller_rabin(Int64 m, int r)
        {
                // Получем s и t, m - 1 = 2^s * t
            Int64 s = 0;
            Int64 tmp = m - 1;

            while (tmp != 0)
            {
                tmp /= 2;
                s++;
            }

            Int64 t = m - 1;

            for (int i = 0; i < r; i++)
            {
                Int64 a;

                if (m > 3)
                    a = get_random_num(m - 3);
                else
                    a = 1;
                a += 2;

                Int64 x = power(a, t, m);

                if (x == 1 || x == m - 1)
                    continue;

                for (Int64 j = 0; j < s; j++)
                {
                    x = x * x % m;
                    if (x == 1) return false;
                    if (x == m - 1) continue;

                    return false;
                }
            }

            return true;
        }

            // Получаем простое число
        public Int64 get_simple(Int64 max)
        {
            Int64 tmp = get_random_num(max);
                // Повторять, пока не получим простое число
            while (!miller_rabin(tmp, rep))
                tmp = get_random_num(max);

            return tmp;
        }

            // Случайное число
        private Int64 get_random_num(Int64 max)
        {
            Int64 res;
            for (; ; )
            {
                var buffer = new byte[sizeof(Int64)];
                Rand.NextBytes(buffer);
                res = BitConverter.ToInt64(buffer, 0);
                if (res <= max) return res;
            }
        }

        private Int64 power(Int64 m, Int64 a, Int64 b)
        {
            Int64 r = 1;
            while (a > 0)
            {
                if ((a % 2) == 1)
                {
                    r = (r * m) % b;
                }
                m = (m * m) % b;
                a >>= 1;
            }
            return r;
        }
    }
}