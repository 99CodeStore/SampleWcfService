using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SampleWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DataContractService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DataContractService.svc or DataContractService.svc.cs at the Solution Explorer and start debugging.
    public class DataContractService : IDataContractService
    {
        public Address GetAddress(int? Id)
        {
            return new Address
            {
                Addressline = "Sherganj",
                City = "Sherganj",
                PostalCode = "485001",
                Country="India"
            };
        }
    }
}
