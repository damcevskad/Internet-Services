Console.WriteLine("Please start insert students presence: \n");

string[] attendance = new string[10];
int present = 0;
int absent = 0;
int unknown = 0;

for(int s =0; s < attendance.Length; s++)
{
    attendance[s] = Console.ReadLine().ToLower();
}

foreach (string student in attendance)
{
    if (student == "present")
    {
        present++;
    }
    else if (student == "absent")
    {
        absent++;
    }
    else
    {
        unknown++;
    }
}

Console.WriteLine($"\n{present} students are present");
Console.WriteLine($"{absent} students are absent");
Console.WriteLine($"{unknown} students presence unknown");
