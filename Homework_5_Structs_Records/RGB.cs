namespace Homework_5_Structs_Records
{
    struct RGBColor
    {
        public int r;
        public int g;
        public int b;
        public RGBColor(int R, int G, int B)
        {
            r = R;
            g = G;
            b = B;
        }
        public string ToHex()
        {
            return $"#{r:X2}{g:X2}{b:X2}";
        }
        public string ToHSL()
        {
            double rd = r / 255.0;
            double gd = g / 255.0;
            double bd = b / 255.0;

            double min = rd;
            if (gd < min)
            {
                min = gd;
            }
            if (bd < min)
            {
                min = bd;
            }

            double max = rd;
            if (gd > max)
            {
                max = gd;
            }
            if (bd > max)
            {
                max = bd;
            }

            double h = 0;
            double s = 0;
            double l = (max + min) / 2.0;

            if (max != min)
            {
                double d = max - min;
                if (l > 0.5)
                {
                    s = d / (2.0 - max - min);
                }
                else
                {
                    s = d / (max + min);
                }

                if (max == rd)
                {
                    if (gd < bd)
                    {
                        h = (gd - bd) / d + 6.0;
                    }
                    else
                    {
                        h = (gd - bd) / d;
                    }
                }
                else if (max == gd)
                {
                    h = (bd - rd) / d + 2;
                }
                else
                {
                    h = (rd - gd) / d + 4;
                }
                h *= 60;
            }
            s *= 100;
            l *= 100;
            return $"{h:F0} {s:F0}% {l:F0}%";
        }
        public string ToCMYK()
        {
            double rd = r / 255.0;
            double gd = g / 255.0;
            double bd = b / 255.0;

            double k = 1.0;
            if (rd > k)
            {
                k = rd;
            }
            if (gd > k)
            {
                k = gd;
            }
            if (bd > k)
            {
                k = bd;
            }
            k = 1.0 - k;

            double c = 0;
            double m = 0;
            double y = 0;
            if (k != 1.0)
            {
                c = (1.0 - rd - k) / (1.0 - k);
                m = (1.0 - gd - k) / (1.0 - k);
                y = (1.0 - bd - k) / (1.0 - k);
            }
            c *= 100;
            m *= 100;
            y *= 100;
            k *= 100;

            return $"{c:F0}% {m:F0}% {y:F0}% {k:F0}%";
        }
    }
    internal class RGB
    {
        static void Main(string[] args)
        {
            RGBColor color = new RGBColor(164, 107, 19);
            Console.WriteLine($"RGB: {color.r} {color.g} {color.b}");
            Console.WriteLine($"HEX: {color.ToHex()}");
            Console.WriteLine($"HSL: {color.ToHSL()}");
            Console.WriteLine($"CMYK: {color.ToCMYK()}");
        }
    }
}
