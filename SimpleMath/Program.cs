using System.Text;
Console.OutputEncoding = Encoding.UTF8;

string do_math(double a, double b, string op)
{
    string result = "";
    switch (op)
    {
        case "+":
            result = a + "+" + b + "=" + (a + b);
            break;
        case "-":
            result = a + "-" + b + "=" + (a - b);
            break;
        case "*":
            result = a + "*" + b + "=" + (a * b);
            break;
        case "/":
            if (b == 0)
                result = "Mẫu số không hợp lệ";
            else
                result = a + "/" + b + "=" + (a / b);
            break;
        default:
            result = "Nhập tào lao nữa rồi";
            break;
    }
    return result;
}

Console.WriteLine("Nhập số a:");
double a = Double.Parse(Console.ReadLine());

Console.WriteLine("Nhập số b:");
double b = Double.Parse(Console.ReadLine());

Console.WriteLine("Nhập phép toán:+,-,*,/:");
string op = Console.ReadLine();

string result = do_math(a, b, op);
Console.WriteLine(result);
Console.ReadLine();