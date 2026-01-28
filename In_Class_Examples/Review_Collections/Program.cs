List<double> examGrades = new List<double>();
int counter = 1;
string answer;

do
{
    Console.WriteLine($"Please enter your score for Exam {counter.ToString("N0")}");
    string input = Console.ReadLine();
    if (double.TryParse(input, out double grade))
    {
        examGrades.Add(grade);
        counter++;
    }
    else
    {
        Console.WriteLine("Sorry that was not an Exam score.  Please try again");
    }


    Console.WriteLine("Do you have another exam score to enter, yes or no? <<");
    answer = Console.ReadLine();
} while (answer == "yes");

Console.WriteLine($"You entered {counter-1} grades");

//double sum = 0;

//for(int i = 0; i < examGrades.Count; i++)
//{
//    double grade = examGrades[i];
//    if (grade < 0)
//    {
//        grade = 0;
//        examGrades[i] = 0;
//    }
//    sum += grade;
//}

//foreach (double grade in examGrades)
//{
//    sum += grade;
//}

//double average = sum / examGrades.Count;

double average = CalculateAverage(examGrades);
Console.WriteLine($"Your exam average is {average.ToString("P")}");

counter = 1;
List<double> homeworkGrades = new List<double>();
do
{
    Console.WriteLine($"Please enter your score for Homework {counter.ToString("N0")}");
    string input = Console.ReadLine();
    if (double.TryParse(input, out double grade))
    {
        homeworkGrades.Add(grade);
        counter++;
    }
    else
    {
        Console.WriteLine("Sorry that was not an Homework score.  Please try again");
    }


    Console.WriteLine("Do you have another homework score to enter, yes or no? <<");
    answer = Console.ReadLine();
} while (answer == "yes");


double homeworkAverage = CalculateAverage(homeworkGrades);
Console.WriteLine($"Your homework average is {homeworkAverage}");


static double CalculateAverage(List<double> values)
{
    double total = 0;
    foreach (double value in values)
    {
        total += value;
    }
    return total / values.Count;
}