using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLibrary.Models
{
    internal class GridSpotModels
    {
        public string SpotLetter { get; set; }
        public int SpotNumber { get; set; }
        public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty;
    }
}
