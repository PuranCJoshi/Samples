﻿using System;
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
        [OperationContract(Name = "AddInteger")]
        int Add(int num1, int num2);
    }
}
