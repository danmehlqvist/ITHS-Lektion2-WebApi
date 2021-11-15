using System.Collections;
using System.Collections.Generic;

namespace ITHS_Lektion2_WebApi.Entities
{
    public class Interpreter
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Language> Languages { get; set; } = new List<Language>();

    }
}
