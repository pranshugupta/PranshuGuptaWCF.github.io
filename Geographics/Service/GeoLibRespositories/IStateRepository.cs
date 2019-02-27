using System.Collections.Generic;

namespace GeoLibRespositories
{
    public interface IStateRepository
    {
        IEnumerable<string> GetStates(bool primaryOnly);
    }
}
