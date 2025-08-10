class MY_CLASS
{
    public static void Main()
    {
        //create jagged array for grades
        int[][] grades = new int[5][];

        //declare max number of subjects assigned
        int subjectMax = 0;

        for (int row = 0; row < 4; row++)
        {
            Console.WriteLine($"Student {row + 1}, Please enter the number of subjects:");
            int subjectNum = int.Parse(Console.ReadLine());
            grades[row] = new int[subjectNum + 1];

            //find max number of subjects assigned
            if (subjectNum > subjectMax)
            {
                subjectMax = subjectNum;
            }
        }
        //fill grades
        int grade = 0;
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < grades[row].Length - 1; col++)
            {
                grade += 10;
                grades[row][col] = grade;
            }
        }
        //calculate the students' total
        for (int row = 0; row < 4; row++)
        {
            int total = 0;
            for (int col = 0; col < grades[row].Length; col++)
            {
                total += grades[row][col];
            }
            grades[row][grades[row].Length - 1] = total;
        }

        //calculate AVG for each subject
        grades[4] = new int[subjectMax];
        //create students count for each subject
        int[] count = new int[subjectMax];
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < grades[row].Length - 1; col++)
            {
                grades[4][col] += grades[row][col];
                count[col]++;
            }
        }
        for (int col = 0; col < grades[4].Length; col++)
        {
            grades[4][col] /= count[col];
        }

        //display the array
        Console.Write("Student/SubjectID \t");
        for (int i = 1; i <= subjectMax; i++)
        {
            Console.Write($"{i}\t");
        }

        Console.WriteLine("Total");

        for (int row = 0; row < 4; row++)
        {
            if (row == 4)
            {
                Console.Write("Subject_AVG\t\t");
            }
            else
            {
                Console.Write($"{row + 1}\t\t\t");
            }
            for (int col = 0; col < grades[row].Length - 1; col++)
            {
                Console.Write($"{grades[row][col]}\t");
            }
            for (int tab = 0; tab < subjectMax - grades[row].Length + 1; tab++)
            {
                Console.Write("\t");
            }
            Console.WriteLine($"{grades[row][grades[row].Length - 1]}\t");
        }
        Console.Write("subjectAVG\t\t");
        for (int col = 0; col < subjectMax; col++)
        {
            Console.Write($"{grades[4][col]}\t");
        }
    }
}