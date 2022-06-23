/**
 * This is a simple plain calculator.
 * It has 5 operations (+, -, *, /, %)
 */
double val1, val2, val3;
String v1, v2, v3;
int op;
char ans;
do
{
    do
    {
        Console.WriteLine("Enter the first value");
        v1 = Console.ReadLine();
        Console.WriteLine("Enter the second value");
        v2 = Console.ReadLine();
        if (Double.TryParse(v1, out val1) == false || Double.TryParse(v2, out val2) == false)
        {
            Console.WriteLine("Please be sure to only enter numbericals");
        }
    }while(Double.TryParse(v1, out val1) == false || Double.TryParse(v2, out val2) == false);

    val1 = double.Parse(v1);
    val2 = double.Parse(v2);

    Console.WriteLine("Please choose an operation of choice: ");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Modulo");
    op = int.Parse(Console.ReadLine());
    if (op == 1)
    {
        val3 = val1 + val2;
        v3 = val3.ToString();
        Console.WriteLine(v1 + " + " + v2 + " = " + v3);
    }
    else if (op == 2)
    {
        val3 = val1 - val2;
        v3 = val3.ToString();
        Console.WriteLine(v1 + " - " + v2 + " = " + v3);
    }
    else if (op == 3)
    {
        val3 = val1 * val2;
        v3 = val3.ToString();
        Console.WriteLine(v1 + " * " + v2 + " = " + v3);
    }
    else if (op == 4)
    {
        do
        {
            if (val2 == 0)
            {
                Console.WriteLine("Please enter a number other than 0 for the second value");
                v2 = Console.ReadLine();
                val2 = double.Parse(v2);
            }
        } while (val2 == 0);
        val3 = val1 / val2;
        Console.WriteLine(v1 + " * " + v2 + " = " + val3);
    }
    else if (op == 5)
    {
        val3 = val1 % val2;
        v3 = val3.ToString();
        Console.WriteLine(v1 + " % " + v2 + " = " + v3);
    }
    Console.WriteLine("Do you want to go again?(Y/y for yes, any other character for no");
    ans = char.Parse(Console.ReadLine());
} while (ans == 'Y' || ans == 'y');


