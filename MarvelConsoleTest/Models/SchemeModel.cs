using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelConsoleTest.Models
{
    public class SchemeModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public BaseCardModel CardInfo { get; set; }
        public GameInfoModel GameInfo { get; set; }
        public PlayerOverrideModel PlayerOverride { get; set; }
        public string[] RequiredCards { get; set; }
        public string[] MiscInfo { get; set; }
        public int HeroesAsVillains { get; set; }
    }
}
