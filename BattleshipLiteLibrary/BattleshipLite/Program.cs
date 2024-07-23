using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;

namespace BattleshipLite
{
    class program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");
            PlayerInfoModel winner = null;

            do
            {
                // Display the grid from activePlayer on where they fired
                DisplayShotGrid(activePlayer);

                // Ask activePlayer for a shot
                // Determine if it is a valid shot
                // Determine shot results
                RecordPlayerShot(activePlayer, opponent);

                // Determine if the game is over
                // The game is over if your opponent has no more ships
                // I need to check if the ship locations for the opponent are sunk
                // I need to make a GameLogic method, because this has nothing to do with the user interface
                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                // If over, set activeplayer as the winner
                // else, swap positions (activePlayer to opponent)
                if (doesGameContinue == true)
                {
                    // Swapping player position with temp variable
                    // PlayerInfoModel tempHolder = opponent; 
                    // opponent = activePlayer;
                    // activePlayer = tempHolder;

                    // Swapping player position with a tuple
                    (activePlayer, opponent) = (opponent, activePlayer);

                }
                else
                {
                    winner = activePlayer;
                }

            } while (winner == null);

            IdentifyWinner(winner);

            Console.ReadLine();
        }

        private static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.WriteLine($"Congratulations to {winner.UsersName} for winning!");
            Console.WriteLine($"{winner.UsersName} took {GameLogic.GetShotCount(winner)} shots.");
        }

        private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            // Asks for a shot (We ask for "B2")
            // Determine what row and column that is = split it apart
            // Determine if that is a valid shot
            // Go back to the beginning if not a valid shot
            bool isValidShot = false;
            string row = "";
            int column = 0;

            do
            {
               string shot = AskForShot(activePlayer);
                try
                {
                    (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                    isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: "+ ex.Message);
                    isValidShot=false;
                }

                if (isValidShot == false)
               {
                    Console.WriteLine("Invalid shot location. Please try again.");
               }
            } while (isValidShot == false);

            // Determine Shot Results
            bool isAhit = GameLogic.IdentifyShotResult(opponent, row, column);

            // Record results
            GameLogic.MarkShotResult(activePlayer, row, column, isAhit);

            DisplayShotGrid(activePlayer); // show the results of the shot

            // If we want to refresh the shot grid everytime, just add in the DisplayShotGrid Method
        }

        private static string AskForShot(PlayerInfoModel activePlayer)
        {
            Console.Write($"Please enter your shot selection {activePlayer.UsersName}: ");
            Console.WriteLine();
            string output = Console.ReadLine();

            return output;
        }

        private static void DisplayShotGrid(PlayerInfoModel activePlayer)
        {
            Console.WriteLine($"---{activePlayer.UsersName}'s Shot Grid---");
            string currentRow = activePlayer.ShotGrid[0].SpotLetter;

            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.SpotLetter;
                }

                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber} ");
                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    Console.Write(" X  ");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    Console.Write(" O  ");
                }
                else
                {
                    Console.Write(" ?  ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my BattlshipLite App");
            Console.WriteLine("Created by Eric Oliver");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player information for {playerTitle} ");

            // ask the user for their name
            output.UsersName = AskForUsersname();

            // load up the shot grid
            GameLogic.InitializeGrid(output);

            // ask the user for their 5 ship placements
            PlaceShips(output);

            //Clear the screen
            Console.Clear();

            return output;  
        }

        private static string AskForUsersname()
        {
            Console.WriteLine("What is your name?");

            string output = Console.ReadLine();

            return output;
        }

        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place ship number {model.ShipLocations.Count + 1}: ");
                string location = Console.ReadLine();

                bool isValidLocation = false;

                try
                {
                    isValidLocation = GameLogic.PlaceShip(model, location);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                if (isValidLocation == false)
                {
                    Console.WriteLine("That was not a valid location. Please try again.");
                }
            } while (model.ShipLocations.Count < 5);
        }
    }
}