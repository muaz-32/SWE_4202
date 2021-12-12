using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS_Muaz_132
{
    public class Car
    {
        string Name;
        string Model;
        int Num;
        public string getName()
        {
            return Name;
        }
        public string getModel()
        {
            return Model;
        }
        public int getNum()
        {
            return Num;
        }
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public void setModel(string Model)
        {
            this.Model = Model;
        }
        public void setNum(int Num)
        {
            this.Num = Num;
        }
        public Car()
        {

        }
        public Car(string Name, string Model, int Num)
        {
            this.Name = Name;
            this.Model = Model;
            this.Num = Num;
        }
    }
}
