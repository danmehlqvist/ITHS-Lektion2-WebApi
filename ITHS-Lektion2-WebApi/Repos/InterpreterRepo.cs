using ITHS_Lektion2_WebApi.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ITHS_Lektion2_WebApi.Repos
{
    public class InterpreterRepo : IInterpreterRepo
    {
        private List<Language> _languages = new List<Language> {
            new Language{ ID=1, Name = "Swedish" },
            new Language{ ID=2, Name ="Finnish"},
            new Language{ ID=3, Name ="Danish"},
            new Language{ID=4, Name ="Norwegian "},
            new Language{ID=5, Name ="Icelandic"},
        };

        private readonly List<Interpreter> _interpreters;


        public InterpreterRepo()
        {
            // THIS SIMULATES A DATABASE!
            // IT CAN NOT BE TRUSTED TO PERFORM UNIT TESTS ON
            _interpreters = new List<Interpreter>()
            {
                new Interpreter
                {
                    ID=1,
                    FirstName="Adam",
                    LastName="Adamsson",
                    Languages=new List<Language>
                    {
                        GetLanguageByID(1),
                        GetLanguageByID(2),
                    }
                },
                 new Interpreter
                {
                    ID=2,
                    FirstName="Berit",
                    LastName="Beritsdotter",
                    Languages=new List<Language>
                    {
                        GetLanguageByID(2),
                        GetLanguageByID(3),
                    }
                },
                  new Interpreter
                {
                    ID=3,
                    FirstName="Cesar",
                    LastName="Cesarsson",
                    Languages=new List<Language>
                    {
                        GetLanguageByID(3),
                        GetLanguageByID(4),
                    }
                }, 
                new Interpreter
                {
                    ID=4,
                    FirstName="Daniella",
                    LastName="Daniellasdotter",
                    Languages=new List<Language>
                    {
                        GetLanguageByID(4),
                        GetLanguageByID(5),
                    }
                },
            };
        }

        public Interpreter GetInterpreterByID(int id)
        {
            return _interpreters.SingleOrDefault(x => x.ID == id);
        }

        public IEnumerable<Interpreter> GetInterpreters()
        {
            return _interpreters;
        }

        public IEnumerable<Interpreter> GetInterpreterByLanguageID(int languageID)
        {
            return _interpreters.Where(i => i.Languages.Any(l => l.ID == languageID));
        }

        private Language GetLanguageByID(int ID)
        {
            return _languages.Single(x => x.ID == ID);
        }

       
    }
}
