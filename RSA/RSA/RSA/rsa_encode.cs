using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSA
{
    class rsa_encode
    {
        Random Rand;
        public UInt64 ex, d, n;

        public rsa_encode()
        {
            Rand = new Random();
            generate_keys(8);
        }

        private bool test_keys(UInt64 n, UInt64 e, UInt64 d)
        {
            UInt64 tmp = Convert.ToUInt64(Rand.Next(1, Convert.ToInt32(n - 1)));

            UInt64 c = power(tmp, e, n);
            
            return power(c, d, n) == tmp;

        }

        private void generate_keys(int size)
        {
            do
            {
                simple_gen p = new simple_gen();
                simple_gen q = new simple_gen();

                UInt64 tmp_n = p.ChSiNm * q.ChSiNm;
                UInt64 phi = (p.ChSiNm - 1) * (q.ChSiNm - 1);

                UInt64 tmp_e = Convert.ToUInt64(Rand.Next(1, Convert.ToInt32(phi - 1))) + 1;

                do
                {
                    tmp_e++;
                } while (Euclid(tmp_e, phi) != 1);

                n = tmp_n;
                ex = tmp_e;
                d = Convert.ToUInt64(Euclid2(Convert.ToInt64(tmp_e), Convert.ToInt64(phi)));

            } while (!test_keys(n, ex, d));
        }

        static public UInt64 power(UInt64 m, UInt64 a, UInt64 b)
        {
            UInt64 r = 1;
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

            // Алгоритм Евклида для поиска НОД
        private UInt64 Euclid(UInt64 a, UInt64 b)
        {
            UInt64 c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }

            // Расширенный алгоритм Евклида
        private Int64 Euclid2(Int64 x, Int64 n)
        {
            if (x == 1)
                return x + n;
            Int64 p;

            Int64 p0 = 0;
            Int64 p1 = 1;
            Int64 q0, q1;
            Int64 r;
            Int64 y = n;
            r = y % x;
            q0 = y / x;
            y = x;
            x = r;
            r = y % x;
            q1 = y / x;
            y = x;
            x = r;

            while (r > 0)
            {
                r = y % x;
                p = p0 - p1 * q0;
                if (p < 0)
                    p = n - (-p % n);
                else
                    p %= n;
                p0 = p1;
                p1 = p;
                q0 = q1;
                q1 = y / x;
                y = x;
                x = r;
            }
            p = p0 - p1 * q0;
            if (p < 0)
                return (Int64)(n - (-p % n));
            else
                return (Int64)(p % n);
        }
    }
}