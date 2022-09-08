using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelConsoleTest.Models
{
    public class PlayerOverrideModel
    {
        public GameInfoModel OnePlayer { get; set; }
        public GameInfoModel TwoPlayer { get; set; }
        public GameInfoModel ThreePlayer { get; set; }
        public GameInfoModel FourPlayer { get; set; }
        public GameInfoModel FivePlayer { get; set; }
    }
}
