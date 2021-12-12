using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS_Muaz_132
{
    public class User
    {
        string ID;
        string Name;
        string Address;
        string Designation;
        string Rented_Car;
        public string getID()
        {
            return ID;
        }
        public string getName()
        {
            return Name;
        }
        public string getAddress()
        {
            return Address;
        }
        public string getDesignation()
        {
            return Designation;
        }
        public string getRented_Car()
        {
            return Rented_Car;
        }
        public void setID(string ID)
        {
            this.ID = ID;
        }
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public void setAddress(string Address)
        {
            this.Address = Address;
        }
        public void setDesignation(string Designation)
        {
            this.Designation = Designation;
        }
        public void setRented_Car(string Rented_Car)
        {
            this.Rented_Car = Rented_Car;
        }
        public User()
        {

        }
        public User(string ID, string Name, string Address, string Designation)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
            this.Designation = Designation;
        }
    }
}
