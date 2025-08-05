
    enum Interests
    {
        FOOTBALL=1,
        BASKETBALL,
        TENNIS
    }
    struct Std
    {
        public int id;
        public string name;
        public float total_grade;
        public Interests Interest;
    };
   
    
    class myclass
{
    public static void Main()
    {
        Std student = new Std();
        vFillData(100, "Mohamed", 180, Interests.FOOTBALL,ref student);
    }

    public static void vFillData(int id, string name, int total_grade, Interests interest,ref Std student)
    {
        student.id = id;
        student.name = name;
        student.total_grade = total_grade;
        student.Interest = interest;

        vPrintData( student);
    }
    public static void vPrintData(Std student)
    {
        Console.WriteLine($"id={student.id}");
        Console.WriteLine($"name={student.name}");
        Console.WriteLine($"Total_Grade={student.total_grade}");
        Console.WriteLine($"Interest={student.Interest}");

    }

}




