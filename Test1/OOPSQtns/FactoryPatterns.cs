using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSQtns
{
    /// <summary>
    /// Definition:uses interface to create object and let sub class decide which class to intantiate
    /// this patterns creates objects without exposing the creational logicto the client
    /// Uses when:
    /// 1.Object need to be extended to subclasses
    /// 2.the class doesnt know what exact it subclasses to create
    /// </summary>
    class FactoryPatterns
    {
        IEmployee employee = null;
        public IEmployee GetEmployeeBasedOnType(int typeId)
        {
            if (typeId == 1)
            {
                employee =  new PermanantEmployee();
            }
            else if(typeId == 2)
            {
                employee = new ContractEmployee();
            }
            return employee;
        }
    }

    class PermanantEmployee : IEmployee
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 10;
        }
    }

    class ContractEmployee : IEmployee
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 14;
        }
    }

    interface IEmployee
    {
        decimal GetBonus();
        decimal GetPay();        
    }
    enum employeeTypes
    {
        permenant = 1,
        contract
    }
    class client
    {
        public void getEmployeeDetails()
        {
            var factory = new FactoryPatterns();
            IEmployee contractemployee = factory.GetEmployeeBasedOnType(Convert.ToInt32(employeeTypes.contract));
            var bonus = contractemployee.GetBonus();
        }

    }
}
