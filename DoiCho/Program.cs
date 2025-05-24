void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine("in function a = " + a);
    Console.WriteLine("in function b = " + b);
}

int a = 4, b = 9;

Console.WriteLine("Before swap a = " + a);
Console.WriteLine("Before swap b = " + b);

swap(ref a, ref b);

Console.WriteLine("outside function a = " + a);
Console.WriteLine("outside function b = " + b);

Console.ReadLine();