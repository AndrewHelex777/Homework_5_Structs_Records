namespace Homework_5_Structs_Records
{
    struct DecimalNumber
    {
        public int num;
        public DecimalNumber(int n)
        {
            num = n;
        }
        public string ToBinary()
        {
            return Convert.ToString(num, 2);
        }
        public string ToOctal()
        {
            return Convert.ToString(num, 8);
        }
        public string ToHexadecimal()
        {
            return Convert.ToString(num, 16);
        }
    }
    internal class Decimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number:");
            int n = int.Parse(Console.ReadLine());
            DecimalNumber num = new DecimalNumber(n);
            Console.WriteLine($"Binary: {num.ToBinary()}");
            Console.WriteLine($"Octal: {num.ToOctal()}");
            Console.WriteLine($"Hexadecimal: {num.ToHexadecimal()}");
        }
    }
}
