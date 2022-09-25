using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SampleWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataContractService" in both code and config file together.
    [ServiceContract]
    public interface IDataContractService
    {
        [OperationContract]
        Address GetAddress(int? Id);
    }

    [DataContract(Name = "Place", Namespace = "")]
    public class Address
    {

        [DataMember(Name = "Addressline", Order = 1, IsRequired = true)]
        public string Addressline;
        [DataMember(Name = "City", Order = 2)]
        public string City;
        [DataMember(Name = "Country", Order = 3)]
        public string Country;
        [DataMember(Name = "PostalCode", Order = 4, IsRequired = true)]
        public string PostalCode;
    }

}
