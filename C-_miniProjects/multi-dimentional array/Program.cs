class myClass
{
    public static void Main()
    {   //declare+create 2D grades array
        int[,] grades = new int[5, 4];
        //fill grades
        int grade = 10;
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                grades[row, col] = grade;
                grade += 10;
            }
        }
        //calculate total for each student

        for (int row = 0; row < 4; row++)
        {
            int total = 0;
            for (int col = 0; col < 3; col++)
            {
                total += grades[row, col];
            }
            grades[row, 3] = total;
        }
        //calculate AVG for each subject
        for (int col = 0; col < 3; col++)
        {
            int AVG = 0;
            for (int row = 0; row < 4; row++)
            {
                AVG += grades[row, col];
            }
            AVG /= 4;
            grades[4, col] = AVG;
        }
        //display the array
        Console.WriteLine("Student/SubjectID \t 1\t2\t3\tTotal");
        
        for (int row = 0; row < 5; row++)
        {
            if (row == 4)
            {
                Console.Write("Subject_AVG\t\t");
            }
            else
            {
                Console.Write($"{row + 1}\t\t\t");
            }
            for (int col = 0; col < 4; col++)
            {
                Console.Write($"{grades[row,col]}\t");
            }

            Console.Write("\n");
        }
    }
}