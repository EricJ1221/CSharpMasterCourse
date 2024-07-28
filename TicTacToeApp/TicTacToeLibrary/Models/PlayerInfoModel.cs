using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLibrary.Models
{
    internal class PlayerInfoModel
    {
        public string UserName { get; set; }
        public List<GridSpotModels> MarkerLocations { get; set; }
        public List<GridSpotModels> MarkerGrid { get; set; }
    }
}
