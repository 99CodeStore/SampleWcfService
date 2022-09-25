using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SampleWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITestService
    {

        [OperationContract(IsOneWay = false)]
        string GetData(int value);

        [OperationContract]
        [FaultContract(typeof(FaultInfo))]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract(IsOneWay = true)]
        void ChangeStatus(string newStatus);
         
    }

    [DataContract()]
    public class FaultInfo
    {
        [DataMember()]
        public string Reason = null;
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
