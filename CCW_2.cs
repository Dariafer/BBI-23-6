using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

abstract class Task

{
    private string text = "";
    public string Text
    {
        get => text;
        protected set => text = value;
    }
    public virtual void reshenie() { }
    ///public virtual void ToString () {}
    public Task(string text)
    { 
        this.text = text;
    }
}


   class Task1 : Task
{
    public Task1(string text) : base(text)
    {
    }

    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        string word1 = words[0];
        string word2 = words[1];

        string result = "";

        foreach (char c in word1)
        {
            if (word2.Contains(c.ToString()) && !result.Contains(c.ToString()))
            {
                result += c.ToString() + " ";
            }
        }

        Console.WriteLine("Common letters: " + result);
        Console.ReadLine();
    }
}

abstract class Task2: Task
{
    protected Task2(string text) : base(text)
    {
    }

    static void Main()
    {
        string input = Console.ReadLine();
        MatchCollection matches = Regex.Matches(input, @"-?d+(\.d+)?");

        double sum = 0;
        int count = 0;

        foreach (Match match in matches)
        {
            double number;
            if (double.TryParse(match.Value, out number))
            {
                sum += number;
                count++;
            }
        }

        if (count > 0)
        {
            double average = sum / count;
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}















































class MainClass1
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Regex regex = new Regex(@"-?\d+(\.\d+)?"); // Шаблон для поиска чисел
        MatchCollection matches = regex.Matches(input);

        double sum = 0;
        foreach (Match match in matches)
        {
            double number = double.Parse(match.Value);
            sum += number;
        }

        double average = sum / matches.Count;

        Console.WriteLine("Average: " + average);
        Console.ReadLine();
    }
}