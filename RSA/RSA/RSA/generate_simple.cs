using System;

namespace RSA
{
    public class simple_gen
    {
        const UInt64 rep = 10;

        private UInt64 simple_num;

        public UInt64 ChSiNm
        {
            get
            {
                return simple_num;
            }
            set
            {
                simple_num = value;
            }
        }
        private Random Rand;

            // Всегда генерирует 8ми байтовые значения
        public simple_gen() 
        {
            simple_num = get_simple();
        }

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

        private UInt64[] pow(UInt64 m, UInt64 s, UInt64 t)
        {
            UInt64[] tmp = new UInt64[2];
            for (t = 0, s = m; s % 2 == 0; t++)
                s /= 2;

            tmp[0] = s;
            tmp[1] = t;

            return tmp;
        }

            // Алгоритм Миллера-Рабина
        public bool miller_rabin(UInt64 m, UInt64 r)
        {
            UInt64 g;
            if (m <= 2)
                return true;
            if (m % 2 == 0)
                return false;
            if (r < 2)
                r = 2;
     
            for ( ; (g = Euclid(m, r)) != 1; ++r)
                if (m > g)
                    return false;

            UInt64 m_1 = m;
            --m_1;
            UInt64 s = 0, t = 0;
            UInt64[] tmp = new UInt64[2];
            tmp = pow(m_1, s, t);
            s = tmp[0]; t = tmp[1];
     
            UInt64 rem = power(r, s, m);
            if (rem == 1 || rem == m_1)
                return true;
     
            for (UInt64 i = 1; i < t; i++)
            {
                rem = (rem * rem) % m;
                if (rem == m_1)
                    return true;
            }
            return false;
        }

            // Получаем простое число
        private UInt64 get_simple()
        {
            Rand = new Random();
            Int64 tmp = Rand.Next(1, 12443);
                // Повторять, пока не получим простое число
            while (!miller_rabin(Convert.ToUInt64(tmp), rep))
                tmp = Rand.Next(1, 12443);

            return Convert.ToUInt64(tmp);
        }

        private UInt64 power(UInt64 m, UInt64 a, UInt64 b)
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
    }
}