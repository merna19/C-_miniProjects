int oper;
do
{    //ask the User to Enter an operation
    Console.WriteLine("Enter the operation\n1)Add\n2)Subtract\n3)Multiply\n4)Divide\n5)Exit");
    do
    {
        oper = int.Parse(Console.ReadLine());
        if ((oper > 5) && (oper < 1))
        {
            Console.WriteLine("please enter the index of the operation from 1-6");
        }
    } while ((oper > 5) && (oper < 1));
    //if picked the Exit option break the loop
    if(oper==5)
    {
        break;
    }
    //map operator indeces into symbols
    switch (oper)
    {
        case 1:
            oper = '+';
            break;

        case 2:
            oper = '-';
            break;
        case 3:
            oper = '*';
            break;

        case 4:
            oper = '/';
            break;
    }
    //ask user to enter the expression
    Console.WriteLine("Please enter your expression");
    String expression = Console.ReadLine();

    //split the expression
    string num1 = "", num2 = "";
    int result = 0;
    //get first operand
    int i;
    for (i = 0; expression[i] != (char)oper; i++)
    {
        num1 += expression[i];
    }
    //get the second operand
    for (i++; i < expression.Length; i++)
    {
        num2 += expression[i];
    }
    Console.WriteLine($"num1={int.Parse(num1)}\t{(char)(oper)}\tnum2={int.Parse(num2)}");
    //calculate the result
    switch (oper)
    {
        case '+':
            if (int.Parse(num1) == int.Parse(num2))
            {
                Console.WriteLine("Warning!! You have entered two equal values");
            }
            result = (int.Parse(num1) + int.Parse(num2));
            Console.WriteLine($"the result is{result}");
            break;
        case '-':
            Console.WriteLine($"num1={int.Parse(num1)}\tchar(op)\tnum2={int.Parse(num2)}");
            //check -ve result
            if (int.Parse(num2) > int.Parse(num1))
            {
                Console.WriteLine("Warning!! you're subtracting a big number from a small one");
            }
            result = int.Parse(num1) - int.Parse(num2);
            Console.WriteLine($"the result is{result}");
            break;
        case '*':
            //check multiplication by 1
            if ((int.Parse(num1) == 1) || (int.Parse(num2) == 1))
            {
                Console.WriteLine("Warning!! You are multiplying by one");
            }
            result = int.Parse(num1) * int.Parse(num2);
            Console.WriteLine($"the result is equal to {result}");
            break;
        case '/':
            //check division by 0
            if (int.Parse(num2) == 0)
            {
                Console.WriteLine("Error you are dividing by 0 START OVER PLEASE");
                Console.WriteLine($"the result is undefined");
                break;
            }
            else 
            {   result = int.Parse(num1) / int.Parse(num2);
                Console.WriteLine($"The result is equal to {result}");
                break;
            }
    }
    
} while (oper != 5);

