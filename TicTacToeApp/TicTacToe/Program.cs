using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLibrary;
using TicTacToeLibrary.Models;

// I need to create two players
// Create a 3x3 grid
// Each player will have enough markers
// Players will then take turns moving
// The first to 3 in a row wins

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");
            PlayerInfoModel winner = null;

            do
            {
                // Display the grid from activePlayer on where they placed their marker
                DisplayMarkerGrid(activePlayer);

                // Ask active player for move
                // Determine if its a valid move
                // Determine the move results
                RecordPlayerShot(activePlayer, opponent);

                // Determine if the game is over
                // The game is over if your opponent has 3 in a row
                // check if your opponent
                // I need to make a GameLogic method, because this has noting to with
                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                // If over, set activeplayer as the winner
                // else, swap positions (activePlayer to opponent)
                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                if (doesGameContinue == true)
                {
                    // Swapping player position with temp variable
                    // PlayerInfoModel tempHolder = opponent;
                    // opponent = activePlayer;
                    // activePlayer = tempHolder;

                    // swapping player position with a tuple
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

        private static void DisplayMarkerGrid(PlayerInfoModel activePlayer)
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
            Console.WriteLine("Welcome to my Tic-Tac-Toe");
            Console.WriteLine("Created by Eric Oliver");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player information for {playerTitle}");

            output.UsersName = AskForUserName();

            GameLogic.InitializeGrid(output);

            PlaceMarker(output);

            return output;
        }

        private static object AskForUserName()
        {
            Console.WriteLine("What is your name?");

            string output = Console.ReadLine();

            return output;
        }
        private static void PlaceMarker(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place your marker {model.ShipLocations.Count + 1}: ");
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
