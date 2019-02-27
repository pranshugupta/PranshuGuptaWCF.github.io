﻿using System.Collections.Generic;
using System.ServiceModel;

namespace GeoLibContracts
{
    [ServiceContract]
    public interface IGeoService
    {
        [OperationContract]
        ZipCodeData GetZipInfo(string zip);

        [OperationContract]
        IEnumerable<string> GetStates(bool primaryOnly);

        [OperationContract(Name = "GetZipByState")]
        IEnumerable<ZipCodeData> GetZips(string state);


        [OperationContract(Name = "GetZipForRange")]
        IEnumerable<ZipCodeData> GetZips(string zip, int range);
    }
}
