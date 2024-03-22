class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insert students: ");

        List<string> students = new List<string>();

        string input;
        int presentCount = 0;
        int absentCount = 0;
        int unknownCount = 0;

        for(int i = 0; i < 10; i++)
        {
            input = Console.ReadLine();

            if (input == "present")
            {
                students.Add(input);
                presentCount++;
            }
            else if(input == "absent")
            {
                students.Add(input);
                absentCount++;
            }
            else
            {
                unknownCount++;
            }
        }

        Console.WriteLine($"Present students: {presentCount}");
        Console.WriteLine($"Absent students: {absentCount}");
        Console.WriteLine($"Unknown students: {unknownCount}");

    }
}
