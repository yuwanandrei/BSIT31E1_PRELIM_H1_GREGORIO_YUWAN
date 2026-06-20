using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public double Grade1;
    public double Grade2;
    public double Grade3;
}

class Program
{
    static void Main()
    {
        Program program = new Program();

        List<Student> students = new List<Student>();

        while (true)
        {
            Console.WriteLine("===== STUDENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Compute Average Grade");
            Console.WriteLine("4. Find Highest Grade");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Student student = new Student();

                Console.Write("Enter student name: ");
                student.Name = Console.ReadLine();

                Console.Write("Enter grade 1: ");
                student.Grade1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter grade 2: ");
                student.Grade2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter grade 3: ");
                student.Grade3 = Convert.ToDouble(Console.ReadLine());

                students.Add(student);

                Console.WriteLine("Student added successfully!\n");
            }
            else if (option == 2)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    double average = program.GetStudentAverage(
                        students[i].Grade1,
                        students[i].Grade2,
                        students[i].Grade3);

                    Console.WriteLine("\nName: " + students[i].Name);
                    Console.WriteLine("Grades: " +
                        students[i].Grade1 + ", " +
                        students[i].Grade2 + ", " +
                        students[i].Grade3);

                    Console.WriteLine("Average: " +
                        average.ToString("0.00"));
                }

                Console.WriteLine();
            }
            else if (option == 3)
            {
                double classAverage =
                    program.GetClassAverage(students);

                Console.WriteLine("\nClass Average: " +
                    classAverage.ToString("0.00") + "\n");
            }
            else if (option == 4)
            {
                string topStudent = "";

                double highestGrade =
                    program.GetHighestGrade(
                        students,
                        ref topStudent);

                Console.WriteLine("\nTop Student: " + topStudent);
                Console.WriteLine("Highest Grade: " + highestGrade);
                Console.WriteLine();
            }
            else if (option == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.\n");
            }
        }
    }

    private double GetStudentAverage(
        double g1,
        double g2,
        double g3)
    {
        return (g1 + g2 + g3) / 3;
    }

    private double GetClassAverage(
        List<Student> students)
    {
        double total = 0;

        for (int i = 0; i < students.Count; i++)
        {
            total += students[i].Grade1;
            total += students[i].Grade2;
            total += students[i].Grade3;
        }

        return total / (students.Count * 3);
    }

    private double GetHighestGrade(
        List<Student> students,
        ref string topStudent)
    {
        double highest = 0;

        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Grade1 > highest)
            {
                highest = students[i].Grade1;
                topStudent = students[i].Name;
            }

            if (students[i].Grade2 > highest)
            {
                highest = students[i].Grade2;
                topStudent = students[i].Name;
            }

            if (students[i].Grade3 > highest)
            {
                highest = students[i].Grade3;
                topStudent = students[i].Name;
            }
        }

        return highest;
    }
}