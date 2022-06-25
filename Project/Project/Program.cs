/**
 * This is a simple plain calculator.
 * It has 5 operations (+, -, *, /, %)
 */
double val1, val2, val3;
String v1, v2;
char op, ans;
bool isThere;
do
{
    Console.Clear();
    do
    {
        Console.WriteLine("Enter the first value");
        v1 = Console.ReadLine();
        Console.WriteLine("Enter the second value");
        v2 = Console.ReadLine();
        if (Double.TryParse(v1, out val1) == false || Double.TryParse(v2, out val2) == false)
        {
            Console.WriteLine("Please be sure to only enter numericals");
        }
    }while(Double.TryParse(v1, out val1) == false || Double.TryParse(v2, out val2) == false);

    val1 = double.Parse(v1);
    val2 = double.Parse(v2);

    do
    {
        isThere = true;
        Console.WriteLine("Please choose an operation of choice: ");
        Console.WriteLine("+  -   *  /  %");
        op = char.Parse(Console.ReadLine());
        if (op == '+')
        {
            val3 = val1 + val2;
            Console.WriteLine(val3.ToString());
        }
        else if (op == '-')
        {
            val3 = val1 - val2;
            Console.WriteLine(val3.ToString());
        }
        else if (op == '*')
        {
            val3 = val1 * val2;
            Console.WriteLine(val3.ToString());
        }
        else if (op == '/')
        {
            do
            {
                if (val2 == 0)
                {
                    Console.WriteLine("Please enter a number (other than 0) for the second value");
                    v2 = Console.ReadLine();
                    
                }
            } while (v2.Equals("0") || Double.TryParse(v2, out val2) == false);

            val2 = double.Parse(v2);
            val3 = val1 / val2;
            Console.WriteLine(val3.ToString());
        }
        else if (op == '%')
        {
            val3 = val1 % val2;
            Console.WriteLine(val3.ToString());
        }
        else
        {
            Console.WriteLine("Invalid input");
            isThere = false;
        }
    } while (!isThere);
    Console.WriteLine("Go again?(Y/y for yes)");
    ans = char.Parse(Console.ReadLine());
} while (ans == 'Y' || ans == 'y');


