using System;
using System.Collections.Generic;

List<string> Names = new List<string>();
List<double> Grades1 = new List<double>();
List<double> Grades2 = new List<double>();
List<double> Grades3 = new List<double>();

while (true)
{
    Console.WriteLine("===== STUDENT SYSTEM =====");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View All Students");
    Console.WriteLine("3. Compute Average Grade");
    Console.WriteLine("4. Find Highest Grade");
    Console.WriteLine("5. Exit");
    Console.WriteLine("==========================");
    Console.Write("Choose an option: ");

    int Option = Convert.ToInt32(Console.ReadLine());

    if (Option == 1)
    {
        Console.WriteLine("\nAdd Student");
        Console.Write("Enter student name: ");
        string Name = Console.ReadLine();

        Console.Write("\nEnter grade 1: ");
        double G1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\nEnter grade 2: ");
        double G2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\nEnter grade 3: ");
        double G3 = Convert.ToDouble(Console.ReadLine());

        Names.Add(Name);
        Grades1.Add(G1);
        Grades2.Add(G2);
        Grades3.Add(G3);

        Console.WriteLine("\nStudent added successfully!\n");
    }
    else if (Option == 2)
    {
        Console.WriteLine("\nView Students");

        for (int i = 0; i < Names.Count; i++)
        {
            double studentSum = Grades1[i] + Grades2[i] + Grades3[i];
            double studentAverage = studentSum / 3;

            Console.WriteLine("\nName: " + Names[i]);
            Console.WriteLine("Grades: " + Grades1[i] + ", " + Grades2[i] + ", " + Grades3[i]);
            Console.WriteLine("Average: " + studentAverage.ToString("0.00\n"));
        }
    }
    else if (Option == 3)
    {
        Console.WriteLine("\nClass Average");
        Console.WriteLine("\n===== CLASS AVERAGE =====");

        double totalSumAllGrades = 0;
        int totalNumberOfGrades = Names.Count * 3;

        for (int i = 0; i < Names.Count; i++)
        {
            totalSumAllGrades = totalSumAllGrades + Grades1[i] + Grades2[i] + Grades3[i];
        }

        double classAverage = totalSumAllGrades / totalNumberOfGrades;
        Console.WriteLine("\nOverall Average Grade: " + classAverage.ToString("0.00\n"));
    }
    else if (Option == 4)
    {
        Console.WriteLine("\nHighest Grade");
        Console.WriteLine("\n===== HIGHEST GRADE =====");

        double highestGrade = 0;
        string topStudent = "";

        for (int i = 0; i < Names.Count; i++)
        {
            if (Grades1[i] > highestGrade)
            {
                highestGrade = Grades1[i];
                topStudent = Names[i];
            }
            if (Grades2[i] > highestGrade)
            {
                highestGrade = Grades2[i];
                topStudent = Names[i];
            }
            if (Grades3[i] > highestGrade)
            {
                highestGrade = Grades3[i];
                topStudent = Names[i];
            }
        }

        Console.WriteLine("\nTop Student: " + topStudent);
        Console.WriteLine("\nHighest Grade: " + highestGrade);
        Console.WriteLine("");
    }
    else if (Option == 5)
    {
        Console.WriteLine("\nExiting program...");
        Console.WriteLine("\nGoodbye");
        break;
    }
    else
    {
        Console.WriteLine("\nInvalid option. Please try again.");
    }
}