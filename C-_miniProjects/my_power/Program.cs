
class myclass()
{
    public static void Main()
    {
        double result;
        //enter the number
        Console.WriteLine("Please enter the number");
        int num=int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the power");
        int power = int.Parse(Console.ReadLine());
        myPower(num, power, out result);
        //print the result
        Console.WriteLine($"the result equals to {result}");

    }
    public static void myPower(int num, int pow, out double result)
    {
        if (pow == 0)
            result = 1;
        else
        {
            if (pow < 0)
            {
                //Negative power
                myPower(num, ++pow, out result);
                result *= 1/(float)num;
            }
            else
            {
                //positive power
                myPower(num, --pow, out result);//result will be re-initialized
                result *= num;
            }
        }
    }
}
