using System;
using System.Linq.Expressions;

// initialize variables - graded assignments 
int currentAssignments = 5;

// int[] allSophiaScores = [90, 86, 87, 98, 100];
// int[] allAndrewScores = [92, 89, 81, 96, 90];
// int[] allEmmaScores = [90, 85, 87, 98, 68];
// int[] allLoganScores = [90, 95, 87, 88, 96];
string[] allStudentNames = ["", "", "", "", "", "", "", ""];
// allStudentNames[0] = "sophia";
// allStudentNames[1] = "andrew";
// allStudentNames[2] = "emma";
// allStudentNames[3] = "logan";

decimal[] average = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
Console.Write("Enter the number of students: ");
string input1 = Console.ReadLine();
int numOfStudents = int.Parse(input1);
for (int i = 0; i < numOfStudents; i++)
{
    Console.Write($"Enter student{i} name: ");
    string name = Console.ReadLine();
    allStudentNames[i] = name;

    foreach (string student in allStudentNames)
    {
        int[] assignmentScores = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
        if (student == name)
        {
            for (int j = 0; j < currentAssignments; j++)
            {
                Console.Write($"Enter student{i} assignment grade no{j}: ");
                string temp = Console.ReadLine();
                assignmentScores[j] = int.Parse(temp);
            }

            Dictionary<string, int[]> studentAssignmentGrades = new Dictionary<string, int[]>();

            studentAssignmentGrades.Add(student, assignmentScores);


            for (int j = 0; j < currentAssignments; j++)
            {
                Console.WriteLine($"assignment{j}score:" + assignmentScores[j]);
            }

            int sum = 0;
            foreach (int assignment in assignmentScores)
            {
                sum += assignment;
            }

            average[i] = (decimal)sum / currentAssignments;
            //average = (decimal)0.10 * average + average;

        }
    }

}
string[] letterGrade = ["", "", "", "", "", "", "", ""];

Console.WriteLine("Student\t\tGrade\n");
foreach (string student in allStudentNames)
{

    for (int i = 0; i < allStudentNames.Length; i++)
    {

        if (average[i] <= 100 && average[i] >= 97)
        {
            letterGrade[i] = "A+";
        }
        else if (average[i] <= 96 && average[i] >= 93)
        {
            letterGrade[i] = "A";

        }
        else if (average[i] <= 92 && average[i] >= 90)
        {
            letterGrade[i] = "A-";

        }
        else if (average[i] <= 89 && average[i] >= 87)
        {
            letterGrade[i] = "B+";

        }
        else if (average[i] <= 86 && average[i] >= 83)
        {
            letterGrade[i] = "B";

        }
        // 97 - 100   A+
        // 93 - 96    A
        // 90 - 92    A-
        // 87 - 89    B+
        // 83 - 86    B
    }

}

for (int i = 0; i < numOfStudents; i++)
    Console.WriteLine(allStudentNames[i] + ":\t\t" + average[i] + "\t" + letterGrade[i]);
