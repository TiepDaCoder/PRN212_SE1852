using System.Text;

class Program
{

    public delegate int[] MyDelagate(int n);
    static int[] listEven(int n)
    {
        List<int> list = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            list.Add(i);
        }
        return list.ToArray();
    }
    static int[] listPrime(int n)
    {
        List<int> list = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                list.Add(i);
            }
        }
        return list.ToArray();
    }
    public static void Main(String[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        MyDelagate d1 = new MyDelagate(listEven);
        int[] result1 = d1(10);
        Console.WriteLine("Danh sách các số chẵn: ");
        foreach (int i in result1) Console.WriteLine(i);

        d1 = new MyDelagate(listPrime);
        int[] result2 = d1(10);
        Console.WriteLine("Danh sách các số nguyên tố:");
        foreach (int i in result2) Console.WriteLine(i);
    }
}


