class Film
{
    private string name;
    private string director;
    private int year;
    private string genre;
    public List<decimal> ratings;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Director
    {
        get { return director; }
        set { director = value; }
    }
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    public string Genre
    {
        get { return genre; }
        set { genre = value; }
    }

    public Film() {}

    public Film(string name, string director, int year, string genre, List<decimal> ratings)
    {
        Name = name;
        Director = director;
        Year = year;
        Genre = genre;
        this.ratings = ratings;
    }

    ~Film() {}

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Director: {Director}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Genre: {Genre}");

    }

    public virtual void CalculateAverageRating(List<decimal> allRatings) { }
}



class Rating : Film
{
	public Rating(string name, string director, int year, string genre, List<decimal> ratings)
		: base(name, director, year, genre, ratings) {}

	public Rating() {}

	public override void PrintInfo() { }

	public override void CalculateAverageRating(List<decimal> ratings)
	{
		decimal sum = ratings.Sum();
		decimal average = sum / ratings.Count();
		Console.WriteLine($"Rating: {average}");
	}
}



class Program
{
    public static void Main(string[] args)
    {

        Film film = new Film();

        Console.Write("Please insert Film Name: ");
        film.Name = Console.ReadLine();

        Console.Write("Please insert Film Director: ");
        film.Director = Console.ReadLine();

        Console.Write("Please insert Film Year: ");
        film.Year = int.Parse(Console.ReadLine());

        Console.Write("Please insert Film Genre: ");
        film.Genre = Console.ReadLine();

        List<decimal> ratings = new List<decimal>();

        Console.WriteLine("Please start inserting film ratings between 0 and 5. To stop, please insert \"/\"");

        string input;
        while ((input = Console.ReadLine()) != "/")
        {
            try
            {
                film.ratings.Add(decimal.Parse(input));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        Rating r = new Rating();

        Console.WriteLine();
        film.PrintInfo();
        r.CalculateAverageRating(film.ratings);
    }
}
