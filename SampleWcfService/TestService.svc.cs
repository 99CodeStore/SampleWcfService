using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SampleWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class TestService : ITestService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }

            if (composite.BoolValue == false && string.IsNullOrEmpty(composite.StringValue))
            {
                FaultInfo fi = new FaultInfo();
                fi.Reason = "Unassigned Input Object";
                throw new FaultException<FaultInfo>(fi, new FaultReason(fi.Reason));
            }
            return composite;
        }

        void ITestService.ChangeStatus(string newStatus)
        {
            Console.Write($"Set the IsOneWay property of OperationContractAttribute to true for a OneWay message exchange pattern. Suppose you send a message to a service. This pattern is used when the service does some operation and you do not want a response back. For example, you want to change the status of a transaction from pending to completed and you do not want to get a confirmation from the service that the status is changed. You can use a OneWay pattern.");
        }
    }
}
