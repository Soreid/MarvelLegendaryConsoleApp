using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelConsoleTest.Models
{
    public class MastermindModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public BaseCardModel CardInfo { get; set; }
        public string UnderlingName { get; set; }
    }
}
