namespace Homework_5_Structs_Records
{
    struct Vector3D
    {
        public double x;
        public double y;
        public double z;
        public Vector3D(double X, double Y, double Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public Vector3D Mult(double n)
        {
            return new Vector3D(x * n, y * n, z * n);
        }
        public Vector3D Add(Vector3D v)
        {
            return new Vector3D(x + v.x, y + v.y, z + v.z);
        }
        public Vector3D Sub(Vector3D v)
        {
            return new Vector3D(x - v.x, y - v.y, z - v.z);
        }
        public void Print()
        {
            Console.WriteLine($"{x} {y} {z}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3D v1 = new Vector3D(1, 2, 3);
            Vector3D v2 = new Vector3D(4, 5, 6);

            Console.WriteLine("Vector 1");
            v1.Print();
            Console.WriteLine("Vector 2");
            v2.Print();

            Console.WriteLine("Mult vector 1 by 5");
            Vector3D v1m = v1.Mult(5);
            v1m.Print();

            Console.WriteLine("Add vectors");
            Vector3D va = v1.Add(v2);
            va.Print();

            Console.WriteLine("Sub vectors");
            Vector3D vb = v1.Sub(v2);
            vb.Print();
        }
    }
}
