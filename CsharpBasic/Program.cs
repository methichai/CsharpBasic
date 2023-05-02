
#region sec1
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Welcome to A-host");

//Console.Write("Hello, World!");
//Console.Write("Welcome to A-host");

//int num1 = 0;
//long num2 = 10;

//Console.WriteLine("num1 = {0}",num1);
//Console.WriteLine("num2 = {0}",num2);
//Console.WriteLine($"num1 = {num1}");

//long num1 = 3000000000;
//string text = 'asdasd';
//char text1 = "a";

//double d1 = 700;
//int d2 = Convert.ToInt32(d1);

//string num1 = "1000";
//string num2 = "500";

//int num3 = int.Parse(num1);
//int num4 = int.Parse(num2);

//Console.WriteLine(num3 + num4);

//Console.WriteLine("---Student 1---");
//Console.Write("Name : ");
//string Name1 = Console.ReadLine();
//Console.Write("Input Weight(kg) : ");
//double W1 = double.Parse(Console.ReadLine());
//Console.Write("Input Height(cm) : ");
//double H1 = double.Parse(Console.ReadLine());

//Console.WriteLine("---Student 2---");
//Console.Write("Name : ");
//string Name2 = Console.ReadLine();
//Console.Write("Input Weight(kg) : ");
//double W2 = double.Parse(Console.ReadLine());
//Console.Write("Input Height(cm) : ");
//double H2 = double.Parse(Console.ReadLine());

//double BMI1 = Math.Round(W1 / Math.Pow(H1 / 100, 2), 2);
//double BMI2 = Math.Round(W2 / Math.Pow(H2 / 100, 2), 2);

//Console.WriteLine($"\n{Name1.ToUpper()} BMI = {BMI1}");
//Console.WriteLine($"{Name2.ToUpper()} BMI = {BMI2}");

//Console.WriteLine($"\nMax BMI = {Math.Max(BMI1, BMI2)}");

#endregion

#region sec2
//Console.WriteLine("Your Position : ");
//string position = Console.ReadLine();

//Console.WriteLine("Your Salary : ");
//float salary = float.Parse(Console.ReadLine());

//switch (position) { 
//    case "Assistant Developer":
//        salary *= 1.05f;
//        break;
//    case "IT Support":
//        salary *= 1.07f;
//        break;
//    case "Senior Developer":
//        salary *= 1.1f;
//        break;
//    case "Administrator":
//        salary *= 1.08f;
//        break;
//    default:
//        salary *= 1.03f;
//        break;
//}

//Console.WriteLine($"Your Salary = {Math.Round(salary)}");

#endregion

#region sec3
// Loop

// while loop 

//int num = 0;

//while (num <= 5)
//{
//    ++num;
//    Console.WriteLine(num);
//}

//Console.WriteLine("Exit Loop");

// do while loop

//do
//{
//    ++num;
//    Console.WriteLine(num);
//} while (num <= 5);

//Console.WriteLine("Exit Loop");

// for loop

//for (int i = 0;i <= 5;i++)
//{
//    Console.WriteLine(i);
//}

// foreach

//string name = "Peach";
//foreach (char character in name)
//{
//    Console.WriteLine(character);
//}


////Array
//string[] cars = new string[] {"ford","toyota","lambogini"};

//Array.Resize(ref cars, 4);
//cars[3] = "BMW";

//foreach (string car in cars)
//{
//    Console.WriteLine(car);
//}

//Console.WriteLine("-------------------");
//Array.Sort(cars);

//foreach (string car in cars)
//{
//    Console.WriteLine(car);
//}


//Console.WriteLine("-------------------");
//Array.Reverse(cars);

//foreach (string car in cars)
//{
//    Console.WriteLine(car);
//}

//string[] cars2 = new string[4];
//Console.WriteLine("-------------------");
//Array.Copy(cars, cars2, 3);

//foreach (string car in cars2)
//{
//    Console.WriteLine(car);
//}

//Console.WriteLine("-------------------");
//Console.WriteLine(Array.IndexOf(cars2,"ford"));

//Console.WriteLine("-------------------");
//Console.WriteLine(cars2.Length);

//foreach (string car in cars2)
//{
//    Console.WriteLine(car);
//}

//Array.Clear(cars2);
//Console.WriteLine(cars2.Length);
//foreach (string car in cars2)
//{
//    Console.WriteLine(car);
//}

//List<int> ListNumber = new List<int>();

//foreach(int n in ListNumber) {
//    Console.WriteLine(n);
//}

//Console.WriteLine("-------------");
//ListNumber.Add(0);
//ListNumber.Add(1);

//foreach (int n in ListNumber)
//{
//    Console.WriteLine(n);
//}

//Console.WriteLine("-------------");
//ListNumber.Remove(0);

//foreach (int n in ListNumber)
//{
//    Console.WriteLine(n);
//}

//if (ListNumber.Contains(1))
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

// Set

//HashSet<int> SetOfNumber1 = new HashSet<int>();
//SetOfNumber1.Add(50);
//SetOfNumber1.Add(100);
//SetOfNumber1.Add(150);

//HashSet<int> SetOfNumber2 = new HashSet<int>();
//SetOfNumber2.Add(150);
//SetOfNumber2.Add(200);
//SetOfNumber2.Add(250);


//foreach (int i in SetOfNumber1)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("----------------");

//foreach (int i in SetOfNumber2)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("----------------");


//Console.WriteLine(SetOfNumber1.Count);
//Console.WriteLine(SetOfNumber2.Count);


//Console.WriteLine("----------------");

//SetOfNumber1.ExceptWith(SetOfNumber2);

//foreach (int i in SetOfNumber1)
//{
//    Console.WriteLine(i);
//}

// Dictionary

//Dictionary<string, int> citiesPopulation = new Dictionary<string, int>();

//citiesPopulation.Add("Bangkok", 1000000);
//citiesPopulation.Add("Pattaya", 500000);

//int num = 0;
//if (citiesPopulation.TryGetValue("Bangkok1",out num))
//{
//    Console.WriteLine(num);
//}
//else
//{
//    Console.WriteLine(num);
//}
#endregion


//class person
//{
//    private String name; // Peach
//    private int age; //23

//    public string Name { 
//        get { return name; } 
//        set { name = value; }
//    }

//    public int Age
//    {
//        get { return age; }
//        set { age = value; }
//    }

//    public void PrintInfo()
//    {
//        Console.WriteLine("Name : {0}", Name);
//        Console.WriteLine("Age : {0}", Age);
//    }
//}

//class Employee:person
//{
//    public string phone = "023423442";
//    public void Salary(int salary)
//    {
//        Console.WriteLine(phone);
//        Console.WriteLine("{0} salary = {1}",Name,salary);
//        Employee.GetEmployeeNumber(18000);
//    }

//    // instance Method
//    public double SalaryPerYear (int salary)
//    {
//        return salary*12;
//    }

//    // static Method
//    public static void GetEmployeeNumber(int empid)
//    {
//        Console.WriteLine("My Employee ID = {0}",empid);
//    }

//}

class Calculator
{
    private int Num1;
    private int Num2;


    public Calculator()
    {
        this.Num1 = 0;
        this.Num2 = 0;
    }

    public Calculator(int num1, int num2)
    {
        this.Num1 = num1;
        this.Num2 = num2;
    }

    public int Add()
    {
        return this.Num1 + this.Num2;
    }

    //public double Add( double num1 , double num2)
    //{
    //    return num1 + num2;
    //}
    //public int Add(int num1, int num2)
    //{
    //    return num1 + num2;
    //}

    //public int Add(int num1, int num2, int num3)
    //{
    //    return num1 + num2 + num3;
    //}
}

class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator(2,4);
        Calculator calculator2 = new Calculator();
        Console.WriteLine(calculator.Add());
        Console.WriteLine(calculator2.Add());



        //person P1 = new person();
        //P1.Name = "Peach";
        //P1.Age = 23;
        //P1.PrintInfo();

        //person P2 = new person();
        //P2.Name = "Book";
        //P2.Age = 24;
        //P2.PrintInfo();

        //Employee E1 = new Employee();
        //E1.Name = "Peach";
        //E1.Age = 23;
        ////E1.PrintInfo();
        //E1.Salary(240000);


        //Console.WriteLine("My Salary Per Year = {0}",E1.SalaryPerYear(240000));
    }
}

