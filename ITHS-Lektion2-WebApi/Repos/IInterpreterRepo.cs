using ITHS_Lektion2_WebApi.Entities;
using System.Collections.Generic;

namespace ITHS_Lektion2_WebApi.Repos
{
    public interface IInterpreterRepo
    {
        IEnumerable<Interpreter> GetInterpreters();
        Interpreter GetInterpreterByID(int interpreterId);
        IEnumerable<Interpreter> GetInterpreterByLanguageID(int languageID);
    }
}
