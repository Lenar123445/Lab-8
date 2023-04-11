
using System.Text.RegularExpressions;

static double Cq(double x)
{
    return Math.Cos(x);
}
static double Squrtle(double x)
{
    return 2*Math.Sqrt(Math.Abs(x + 1)) + 1;
}
static double Pishka(double x)
{
    return -1 * Math.Pow((double)x / Math.PI, 2) - 2 * x + 5 * Math.PI;
}
static double InfnitySum(double x)
{
    double sum = 0;
    for (int i = 1; i <= 100; i++)
    {
        sum += Math.Pow((double)x/(Math.PI*i) - 1, 2);
    }
    return sum;
}
static double Vilka(double x)
{
    if (x < 0)
    {
        return 0.25 * Math.Pow(Math.Sin(x), 2) + 1;
    }
    else
    {
        return 0.5 * Math.Cos(x) - 1;
    }
}
static void PrintFunc(double a, double b, double step, Value del)
{
    Console.WriteLine("\nзначение функции {3} на отрезке [{0}, {1}] с шагом {2}", a, b, step, del.Method.Name);
    for (double x = a; x <= b; x += step)
        Console.WriteLine("x={0}\t f(x) = {1:f5}", x, del(x));
}


Value FuncLenar;

FuncLenar = Cq;

double a, b, step;
Console.Write("a = ");
a = double.Parse(Console.ReadLine());
Console.Write("\nb = ");
b = double.Parse(Console.ReadLine());
Console.Write("\nstep = ");
step = double.Parse(Console.ReadLine());
PrintFunc(a, b, step, FuncLenar);
Console.WriteLine("--------------------------------------");
FuncLenar = Squrtle;
PrintFunc(a, b, step, FuncLenar);
Console.WriteLine("--------------------------------------");
FuncLenar = Pishka;
PrintFunc(a, b, step, FuncLenar);
Console.WriteLine("--------------------------------------");
FuncLenar = InfnitySum;
PrintFunc(a, b, step, FuncLenar);
Console.WriteLine("--------------------------------------");
FuncLenar = Vilka;
PrintFunc(a, b, step, FuncLenar);
Console.WriteLine("--------------------------------------");

delegate double Value(double x);




//Задание 2

using System.Text.RegularExpressions;

string[] strings = { "vegetables", "ONION", "level", "1234567890", "wheat", "sweet-potato" };

// количество строк без заглавных букв
int NoUpper = strings.Count(s => Regex.IsMatch(s, "[a-z]"));
Console.WriteLine($"Количество строк без заглавных букв: {NoUpper}");

// количество десятибуквенных строк
int TenChar = strings.Count(s => Regex.IsMatch(s, "^.{10}$"));
Console.WriteLine($"Количество десятибуквенных строк: {TenChar}");

// количество пятибуквенных слов
int FiveLetter = strings.Count(s => Regex.IsMatch(s, "\\b\\w{5}\\b"));
Console.WriteLine($"Количество пятибуквенных слов: {FiveLetter}");

//Слова, начинающиеся на W
List<string> wWords = strings.Where(s => Regex.IsMatch(s, @"\b[Ww]\w*\b")).ToList();
Console.WriteLine($"Слова, начинающиеся на 'W': {string.Join(", ", wWords)}");

// все составные слова, включающие дефис
List<string> defis = strings.Where(s => Regex.IsMatch(s, @"\b\w+-\w+\b")).ToList();
Console.WriteLine($"Слова с дефисом: {string.Join(", ", defis)}");