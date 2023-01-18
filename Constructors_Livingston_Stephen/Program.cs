using System;

namespace Constructors_Livingston_Stephen
{
    class Program
    {
        static void Main(string[] args) // Main Method.
        {
            Game myGame = new Game("The Isle", "T"); // Creates new object 

            Console.WriteLine($"My favorite game is {myGame.title} and it is rated {myGame.genre}");    // Prints game title and game genre to console.

            Game myOtherGame = new Game();

            Console.WriteLine($"My favorite game is {myOtherGame.title} and it is rated {myOtherGame.genre}");
        }
    }
}
