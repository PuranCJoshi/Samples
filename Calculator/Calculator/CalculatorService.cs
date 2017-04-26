using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Calculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CalculatorService : ICalculatorService
    {
        public string Add(string text1, string text2)
        {
            return text1 + text2;
        }

        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public User Get(User user)
        {
            switch (user.EmpId)
            {
                case 823:
                    return new User { Name = "Puran Joshi", EmpId = 823, Date_Of_Birth = new DateTime(1988, 07, 30) };
                default:
                    throw new Exception("User doesn't exists");
            }
        }
    }
}
