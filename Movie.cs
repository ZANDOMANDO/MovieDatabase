using System;
namespace MovieDatabase
{
    public class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }


        //Constructor
        public Movie(string titleArg, string categoryArg)
        {
            Title = titleArg;
            Category = categoryArg;
        }
    }
}

