
List<Movie> myMovies = new List<Movie>();

string[] data = GetDataFromMyFile();

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2], tempArray[1]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}. Rating: {movie.Rating}");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Users\User\source\repos\Week15OOPAndFiles\data\movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string item in someArray)
    {
        Console.WriteLine(item);
    }
}



class Movie
{
    private string title; // fields
    private string year;
    private string rating;

    public Movie (string _title, string _year, string _rating)
    {
        title = _title;
        year = _year;
        rating = _rating;
    } 

    // getter
     public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }
    
    public string Rating
    {
        get { return rating; }
    }
}