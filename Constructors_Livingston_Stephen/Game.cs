using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Livingston_Stephen
{
    class Game // Class.
    {
        public string title, genre; // creates 2 public string field.

        public Game(string titleParam = "Unknown Title", string genreParam = "Casual") // creates class cunstructors that takes two string parameters.
        {
            title = titleParam; // sets the initial values for "title" and "genre".
            genre = genreParam;        
        }
    }
}
