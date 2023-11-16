using System;

class Student
{
    private static int lastStudentAge = 0;
    public int Age { get; private set; }

    public Student()
    {
        Age = ++lastStudentAge;
    }
}

class Program
{
    static void Main()
    {
        Student tural = new Student();
        Console.WriteLine(tural.Age);

        Student suleiman = new Student();
        Console.WriteLine(suleiman.Age);

        Student gafar = new Student();
        Console.WriteLine(gafar.Age); 

        Student semed = new Student();
        Console.WriteLine(semed.Age); 
    }
}