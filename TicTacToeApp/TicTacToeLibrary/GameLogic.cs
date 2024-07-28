﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TicTacToeLibrary.Models.Enum;

namespace TicTacToeLibrary.Models
{
    internal class GameLogic
    {

        public static void InitializeGrid(PlayerInfoModel model)
        {
            List<string> letters = new List<string>
            {
                "A",
                "B",
                "C",
            };

            List<int> numbers = new List<int>
            {
                1,
                2,
                3,
            };

            foreach (string letter in letters)
            {
                foreach (int number in numbers)
                {
                    AddGridSpot(model, letter, number);
                }

            }
        }
        private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
        {
            GridSpotModel spot = new GridSpotModel
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = GridSpotStatus.Empty
            };
            model.ShotGrid.Add(spot);
        }
        public static bool PlaceMarker(PlayerInfoModel model, string location)
        {
            bool output = false;
            (string row, int column) = SplitShotIntoRowAndColumn(location);

            bool isValidLocation = ValidateGridLocation(model, row, column);
            bool isSpotOpen = ValidateMarkerLocation(model, row, column);

            if (isValidLocation && isSpotOpen)
            {
                model.MarkerLocations.Add(new GridSpotModel
                {
                    SpotLetter = row.ToUpper(),
                    SpotNumber = column,
                    Status = GridSpotStatus.Marker
                });

                output = true;
            }

            return output;
        }

        private static bool ValidateMarkerLocation(PlayerInfoModel model, string row, int column)
        {
            bool isValidLocation = true;

            foreach (var marker in model.MarkerLocations)
            {
                if (marker.SpotLetter == row.ToUpper() && marker.SpotNumber == column)
                {
                    isValidLocation = false;
                }
            }
            return isValidLocation;
        }

        private static bool ValidateGridLocation(PlayerInfoModel model, string row, int column) // This validates that the grid location is on the grid
        {
            bool isValidLocation = false;

            foreach (var ship in model.ShotGrid) // Think of a way to rename this
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isValidLocation = true;
                }
            }
            return isValidLocation; ;
        }

        public static bool PlayerStillActive(PlayerInfoModel player)
        {
            bool isActive = false;

            foreach (var ship in player.markerLocations)
            {
                if (ship.Status != GridSpotStatus.Sunk) // I will need to adjust this logic 
                {
                    return isActive = true;
                }
            }
            return isActive = false;
        }

        public static int GetShotCount(PlayerInfoModel player)
        {
            int shotCount = 0;

            foreach (var shot in player.ShotGrid)
            {
                if (shot.Status != GridSpotStatus.Empty)
                {
                    shotCount += 1;
                }
            }
            return shotCount;
        }
        public static (string row, int column) SplitShotIntoRowAndColumn(string shot)
        {
            string row = "";
            int column = 0;

            if (shot.Length != 2)
            {
                throw new ArgumentException("This was an invalid shot type", "shot");
            }

            char[] shotArray = shot.ToArray();

            row = shotArray[0].ToString();
            column = int.Parse(shotArray[1].ToString());

            return (row, column);

        }
        public static bool ValidateShot(PlayerInfoModel player, string row, int column) // Checks every spot in the ShotGrid until it matches the row and column,
                                                                                        // if the shot is on the grid, check if the spot is empty, if not empty = hit, if empty = miss
        {
            bool isValidShot = false;

            foreach (var GridSpot in player.ShotGrid)
            {
                if (GridSpot.SpotLetter == row.ToUpper() && GridSpot.SpotNumber == column)
                {
                    if (GridSpot.Status == GridSpotStatus.Empty)
                    {
                        isValidShot = true;
                    }
                }
            }
            return isValidShot;
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column) // Refactor in the future with ValidateShipLocation and have one method do both things
        {
            bool isAHit = false;

            foreach (var ship in opponent.ShipLocations)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    Console.WriteLine("Nice shot, that was a hit, enemy ship sunk.");

                    isAHit = true;
                    ship.Status = GridSpotStatus.Sunk;
                }
            }
            return isAHit;
        }

        public static void MarkShotResult(PlayerInfoModel player, string row, int column, bool isAhit)
        {
            bool isValidLocation = true;

            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
                {
                    if (isAhit)
                    {
                        gridSpot.Status = GridSpotStatus.Hit;

                    }
                    else
                    {
                        gridSpot.Status = GridSpotStatus.Miss;
                    }
                }
            }
        }
    }
}
