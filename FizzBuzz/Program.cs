
static void FizzBuzz(int num)
{
    if (num % 3 == 0 && num % 5 == 0)
    {
        Console.WriteLine($"fizzbuzz! {num} is divisible by both 3 and 5");
    }
    else if (num % 3 == 0)
    {
        Console.WriteLine($"fizz! {num} is divisible by 3 but not 5");
    }
    else if (num % 5 == 0)
    {
        Console.WriteLine($"buzz! {num} is divisible by 5 but not 3");
    }
    else
    {
        Console.WriteLine("strikeout, try again");
    }
    return;
}
var number = "";
Console.WriteLine("Input a number: ");
number = Console.ReadLine();
FizzBuzz(int.Parse(number));

