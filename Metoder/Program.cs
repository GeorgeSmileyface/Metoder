//lad os udregne areal


PrintStylish("tast længde",500);
string lengthString = Console.ReadLine();
double length = Convert.ToDouble(lengthString);


PrintStylish("tast bredde", 10);
string widthString = Console.ReadLine();
double width = Convert.ToDouble(widthString);

//double area = length * width;

//Console.WriteLine(area);

double methodResult = CalculateArea(length, width);

Console.WriteLine(methodResult);

string printThis = "hello John Connor";

PrintStylish(printThis, 60);

double CalculateArea(double length, double width)
{
    if (length > 0)
    {
        double area = length * width;
        return area;
    }
    return 0;
}

double CalculateAreaOfCircle(double radius)
{
    double area = Math.Pow(radius, 2) * Math.PI;
    return area;
}

void PrintStylish(string toPrint, int waitTime)
{
    foreach (char letter in toPrint)
    {
        Console.Write(letter);
        Thread.Sleep(waitTime);
    }
}