
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelConsoleTest.Models
{
    public class BaseCardModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Classification { get; set; }
        public string[] Teams { get; set; }
        public string[] Classes { get; set; }
    }
}
