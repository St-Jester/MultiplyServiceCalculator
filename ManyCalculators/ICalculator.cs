using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ManyCalculators
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double Sum(double x, double y);

        [OperationContract]
        double Sub(double x, double y);

        [OperationContract]
        double Divide(double x, double y);

        [OperationContract]
        double Mult(double x, double y);
    }

    [ServiceContract]
    public interface ITimeCalc
    {
        [OperationContract]
        string AddMinutesToNow(double mins);
    }
}
