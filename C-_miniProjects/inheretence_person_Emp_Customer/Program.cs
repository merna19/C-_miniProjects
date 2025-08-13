//enum definition
enum JobType
{
    FULL_TIME,
    PART_TIME
}
//parent class definition
class person
{
    protected int id;
    protected String name;
    //define objects counter
    static int Count=0;
    //default constructor
    public person()
    {
        this.id = 0;
        this.name = "NO_NAME";
        Count++;
    }
    //parametrized constructor
    public person(int id, string name)
    {
        this.id = id;
        this.name = name;
        Count++;
    }
    //counter method
    public int u32getCount()
    {
        return Count;
    }
    //modifiers
    public int u32getId()
    {
        return this.id;
    }
    public string sgetName()
    {
        return this.name;
    }
    public void vsetId(int id)
    {
        this.id = id;
    }
    public void vsetName(String name)
    {
        this.name = name;
    }

    //fill data method
    public virtual void vFillData()
    {
        Console.WriteLine("Please enter the new person id");
        vsetId(int.Parse(Console.ReadLine()));

        Console.WriteLine("Please enter the new person name");
        vsetName(Console.ReadLine());
    }
    //print data method
    public virtual void vprintData()
    {
        Console.WriteLine($"the person data:\n1.ID={u32getId()}\n2.Name={sgetName()}");
    }
}
    class Employee:person
{
    JobType jobType;
    double salary;
    //constructor
    public Employee(int id, string name, JobType jobType, double salary):base(id,name)
    {
        this.jobType = jobType;
        this.salary = salary;
    }
    public JobType EgetJobType()
    {
        return this.jobType;
    }
    public double dgetSalary()
    {
        return this.salary;
    }
    public void vsetJobtype(JobType jobType)
    {
        this.jobType = jobType;
    }
    public void vsetSalary(double salary)
    {
        this.salary = salary;
    }
    //overriding fill data
    public override void vFillData()
    {
            Console.WriteLine("Please enter the new employee id");
            vsetId(int.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter the new employee name");
            vsetName(Console.ReadLine());

            Console.WriteLine("Please enter the new employee salary");
            vsetSalary(float.Parse(Console.ReadLine()));
            int job;
            do
            {
                Console.WriteLine("Please enter the new employee job type\n1.FULL_TIME=0\n2.PART_TIME=1");
                job = int.Parse(Console.ReadLine());

            } while (job != 0 && job != 1);
            vsetJobtype((JobType)job);
    }
    //overriding print data method
    public override void vprintData()
    {
        Console.WriteLine($"the Employee data:\n1.ID={u32getId()}\n2.Name={sgetName()}\n3.Salary={dgetSalary()}\n4.Job Type={EgetJobType()}\n");
    }
}

//customer class definition
class Customer : person
{
    int account_number;
    //constructor
    public Customer()
    {
        this.account_number = 0;
    }
    public Customer(int id, String name,int account_number):base(id,name)
    {
        this.account_number = account_number;
    }
    public int u32getAccountnumber()
    {
        return (this.account_number);
    }
    public void vsetAccountnumber(int AccNum)
    {
        this.account_number = AccNum;
    }
    public override void vFillData()
    {
        Console.WriteLine("Please enter the new customer id");
        vsetId(int.Parse(Console.ReadLine()));

        Console.WriteLine("Please enter the new customer name");
        vsetName(Console.ReadLine());

        Console.WriteLine("Please enter the new customer account number");
        vsetAccountnumber(int.Parse(Console.ReadLine()));

    }
    public override void vprintData()
    {
        Console.WriteLine($"the Customer data:\n1.ID={u32getId()}\n2.Name={sgetName()}\n3.Account Number={u32getAccountnumber()}\n");
    }

}

 class myClass
{  
    //main function
    public static void Main()
    {
        Employee e1 = new Employee(52,"Ahmed",JobType.FULL_TIME, 5500.25);

        e1.vFillData();
        e1.vprintData();

        Customer c1 = new Customer(55, "mena", 12558);
        
        c1.vFillData();
        c1.vprintData();

        Console.WriteLine($"object counts={c1.u32getCount()}");

    }
}