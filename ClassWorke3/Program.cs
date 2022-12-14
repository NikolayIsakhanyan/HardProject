using ClassWorke3;

internal class Program
{
    private static void Main(string[] args)
    {

        //Try Catch
        string n = Console.ReadLine();
        try
        {
            int x = Convert.ToInt32(n);
            int xx = Fibonacci(x);
            Console.WriteLine(xx);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine(n);
        }



        // Class Ctor
        Person p = new Person();
        Person p1 = new Person("Vladimir", 18);



        // Struct Ctor
        Car c = new Car();
        Car c1 = new Car(CarBrand.Opel, 2000);



        // Method OVerloading
        int aa = 2;
        int bb = 3;
        int cc = 4;
        double aaa = 1.5;
        Sum(aa, bb);
        Sum(aa, bb, cc);
        Sum(aaa, bb);






        //ref out in
        int sh = 4;
        Console.WriteLine(sh);
        Sum(ref sh, 5, out int k);
        Console.WriteLine(sh);
        Console.WriteLine(k);

    }
        static int Fibonacci(int n)
    {
        if (n == 0 || n == 1)
        {
            return n;
        }
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }



    static int Sum(ref int sh,in int kat,out int k)
    {
        k = 0;
        // kat++; //Error
        sh++;
        int S = sh + kat+k;
        return S;
    }




    static int Sum(int a,int b)
    {
        return a + b;
    }
    static int Sum(int a, int b,int c)
    {
        return a + b + c;
    }
    static double Sum(double a, int b)
    {
        return a + b;
    }
   
}
