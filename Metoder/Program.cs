//lad os udregne areal
PrintStylish("tast længde");
string lengthString = Console.ReadLine();
double length = Convert.ToDouble(lengthString);


PrintStylish("tast bredde");
string widthString = Console.ReadLine();
double width = Convert.ToDouble(widthString);

//double area = length * width;

//Console.WriteLine(area);

double methodResult = CalculateArea(length, width);

Console.WriteLine(methodResult);

string printThis = "hello John Connor";

PrintStylish(printThis);

double CalculateArea(double length, double width)
{
    double area = length * width;
    return area;
}

void PrintStylish(string toPrint)
{
    foreach (char letter in toPrint)
    {
        Console.Write(letter);
        Thread.Sleep(60);
    }
}