using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Calculator
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract(Name ="AddInteger")]
        int Add(int num1, int num2);

        [OperationContract(Name = "AddFloat")]
        float Add(float num1, float num2);

        [OperationContract(Name = "AddString")]
        string Add(string text1, string text2);
    }
}
