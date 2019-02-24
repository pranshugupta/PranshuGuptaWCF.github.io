using System.Collections.Generic;

namespace GeoLibRespositories
{
    public class StateRepository : IStateRepository
    {
        public IEnumerable<string> GetStates(bool primaryOnly)
        {
            List<string> states = new List<string>
            {
                "State 1",
                "State 2",
                "State 3",
                "State 4",
                "State 5",
            };

            return states;
        }
    }
}
