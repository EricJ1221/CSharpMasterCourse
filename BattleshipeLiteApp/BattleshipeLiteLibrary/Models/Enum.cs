using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipeLiteLibrary.Models
{
    
                                   // enum explanation -- 0 = empty, 1 = ship, 2 = miss, 3 = hit, 4 = sunk
        public enum GridSpotStatus // Could set empty = 5 to override the usual enum of 1,2,3 etc.
        {
            Empty,
            Ship,
            Miss,
            Hit,
            Sunk
        }
   
}
