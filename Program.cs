// See https://aka.ms/new-console-template for more information
using MovieDatabase;

static bool textValidation(List<Movie> movieList, string textToCheck)
{

    try
    {
        var firstLongName = movieList.First(mov => mov.Category.ToLower() == textToCheck);
        return true;


    }
    catch (Exception e)
    {
        Console.WriteLine($"Oops! We do not have any movies of genre: {textToCheck}\nPlease enter a another category:");
        return false;
    }

   
}



static void programRun(List<Movie> movieList) {
    bool continueResult;
    bool validCategory = false;
    string categoryResponse;
    //animated, drama, horror, scifi
    Console.WriteLine("Welcome to the Blockbuster Movies!\n-------------------------------------");
    Console.WriteLine($"There are {movieList.Count()} movies in this store.\nWhat genre of movies are you interested in?\n--------------------------");


    
    do
    {
        do
        {
            categoryResponse = Console.ReadLine().ToLower();
            validCategory = textValidation(movieList, categoryResponse);

        } while (!validCategory);
        var moviesInGenreChosen = movieList.FindAll(mov => mov.Category.ToLower() == categoryResponse);

        Console.WriteLine($"-------------List of Movies Available for {categoryResponse}:------------------");
        foreach (Movie movie in moviesInGenreChosen)
        {
            Console.WriteLine($"{movie.Title}");
        }
        Console.WriteLine("-------------------------------");


        Console.WriteLine("Would you like to choose another movie category? (y/n)");
        string userAnswer = Console.ReadLine().ToLower();
        if (userAnswer == "y")
        {
            Console.WriteLine("What category are you interested in?");
            continueResult = true;
        }
        else { continueResult = false; }
    } while (continueResult);
}




List<Movie> movieList = new List<Movie>();
movieList.AddRange(new List<Movie>
{
    new Movie("Caroline", "Animated" ),
    new Movie("The Iron Giant", "Animated" ),
    new Movie("The Godfather", "Drama" ),
    new Movie("The Hurt Locker", "Drama" ),
    new Movie("Wall E", "Animated" ),
    new Movie("Monsters,INC", "Animated" ),
    new Movie("The Incredibles", "Animated" ),
    new Movie("Avatar", "Scifi" ),
    new Movie("The Martian", "Scifi" ),
    new Movie("Dunkirk", "Drama" ),
    new Movie("Forest Gump", "Drama" ),
    new Movie("Black Phone", "Horror" ),
    new Movie("Us", "Horror" ),
    new Movie("The Invisible Man", "Horror" ),
    new Movie("Inception", "Scifi" ),
    new Movie("Matrix", "Scifi" ),

 });


programRun(movieList);
Console.WriteLine("Thank You For visting Blockbuster movies!");

