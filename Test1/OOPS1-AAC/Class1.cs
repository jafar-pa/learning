using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS1_AAC
{
    public class Class1
    {
    }
    /// <summary>
    /// An association is a "using" relationship between two or more objects in which the objects
    /// have their own life time and there is no owner.
    /// As an example, imagine the relationship between a doctor and a patient.
    /// A doctor can be associated with multiple patients and at the same time, 
    /// one patient can visit multiple doctors for treatment and/or consultation.
    /// Each of these objects have their own life-cycle and there is no owner. 
    /// In other words, the objects that are part of the association relationship can be created and destroyed independently.
    /// </summary>
    class Doctor
    {
        public Patient[] patients { get; set; }
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// Aggregation is a special type of Association. Aggregation is "*the*" or has a relationship among objects
    /// Aggregation is a specialized form of association between two or more objects in which the objects have
    /// their own life-cycle but there exists an ownership as well.
    /// As an example, an employee may belong to multiple departments in the organization. 
    /// However, if the department is deleted, the employee object wouldn't be destroyed.
    /// </summary>
    class Address
    {
        string _city, _zip;
        public Address(string city , string zip)
        {
            _city = city;
            _zip = zip;
        }
    }
    class Employee
    {
        private dynamic _address;
        string _name;
        int _id;

        public Employee(string name, int id, Address address)
        {
            _name = name;_id = 1;_address = address;
        }
    }
    class TestAggregation
    {
        //private readonly Address address;
        public TestAggregation()
        {
            Address address = new Address("Bangalore", "123456");
            Employee employee = new Employee("Jafar", 12, address);
        }
    }

    /// <summary>
    /// Composition is a specialized form of aggregation in which if the parent object is destroyed, 
    /// the child objects would cease to exist. It is actually a strong type of aggregation and is also referred to
    /// as a "death" relationship. 
    /// As an example, a house is composed of one or more rooms. If the house is destroyed, 
    /// all the rooms that are part of the house are also destroyed as they cannot exist by themselves.
    ///  If we delete the parent object then the child object(s) will also be deleted
    /// </summary>
    class Composition
    {

    }
    class House
    {
        private Room room;
        public House()
        {
            room = new Room();
        }
    }
    class Room
    {

    }
}
