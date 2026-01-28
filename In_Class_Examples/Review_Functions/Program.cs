
double yVal1 = LineValueForY(2.0, 3.0, 4.0);

int fact5 = Factorial(5);


static double LineValueForY (double m, double x, double b)
{
    double yValue = m * x + b;
    return yValue;
}

static int Factorial(int n)
{
    int result = 1;

    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }

    return result;
}