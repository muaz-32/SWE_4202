using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Class_Library
    {
    }
    internal class Car
    {
        public Seat seats = new Seat();
        public Wheel wheels = new Wheel();
        public Engine engines = new Engine();
        public Door doors = new Door();
        private int maxAcceleration;
        private int fuelCapacity;
        public int getMaxAcceleration()
        {
            return maxAcceleration;
        }
        public int getFuelCapacity()
        {
            return fuelCapacity;
        }
        public void setMaxAcceleration(int maxAcceleration)
        {
            this.maxAcceleration = maxAcceleration;
        }
        public void setFuelCapacity(int fuelCapacity)
        {
            this.fuelCapacity = fuelCapacity;
        }
        public void setSpecification()
        {
            Console.WriteLine("Enter the inputs:");
            setFuelCapacity(Convert.ToInt32(Console.ReadLine()));
            setMaxAcceleration(Convert.ToInt32(Console.ReadLine()));
            
            seats.setComfortability(Console.ReadLine());
            seats.setNumOfSeats(Convert.ToInt32(Console.ReadLine()));
            seats.setWarmer(Console.ReadLine());
            
            wheels.setCircumference(Convert.ToInt32(Console.ReadLine()));
            
            engines.setAverageRPM(Convert.ToInt32(Console.ReadLine()));
            engines.setMaxEnergyProductionRate(Convert.ToInt32(Console.ReadLine()));
            engines.setMaxFuelConsumptionRate(Convert.ToInt32(Console.ReadLine()));

            doors.setOpeningMode(Console.ReadLine());
        }
        public void dislplaySpecification()
        {
            Console.WriteLine(Convert.ToString(getFuelCapacity ()) + " " + Convert.ToString(getMaxAcceleration()));
            Console.WriteLine(Convert.ToString(seats.getNumOfSeats()) + " " + Convert.ToString(seats.getComfortability()) + " " + Convert.ToString(seats.getWarmer()));
            Console.WriteLine(Convert.ToString(wheels.getCircumference()));
            Console.WriteLine(Convert.ToString(engines.getAverageRPM()) + " " + Convert.ToString(engines.getMaxEnergyProductionRate()) + " " + Convert.ToString(engines.getMaxFuelConsumptionRate()));
            Console.WriteLine(Convert.ToString(doors.getOpeningMode()));
            Console.ReadLine();
        }
    }
    internal class Seat
    {
        private int numOfSeats;
        private string comfortability;
        private string warmer;
        public string getComfortability()
        {
            return comfortability;
        }
        public string getWarmer()
        {
            return warmer;
        }
        public int getNumOfSeats()
        {
            return numOfSeats;
        }
        public void setComfortability(string comfortability)
        {
            this.comfortability = comfortability;
        }
        public void setWarmer(string warmer)
        {
            this.warmer = warmer;
        }
        public void setNumOfSeats(int numOfSeats)
        {
            this.numOfSeats = numOfSeats;
        }
        public void addSeat(int numOfSeats)
        {
            if (numOfSeats <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.numOfSeats+=numOfSeats;
            }
        }

    }
    internal class Wheel
    {
        private int circumference;
        public int getCircumference()
        {
            return circumference;
        }
        public void setCircumference(int circumference)
        {
            this.circumference = circumference;
        }
    }
    internal class Engine
    {
        private int maxFuelConsumptionRate;
        private int maxEnergyProductionRate;
        private int averageRPM;
        public int getMaxFuelConsumptionRate()
        {
            return maxFuelConsumptionRate;
        }
        public int getMaxEnergyProductionRate()
        {
            return maxEnergyProductionRate;
        }
        public int getAverageRPM()
        {
            return averageRPM;
        }
        public void setMaxFuelConsumptionRate(int maxFuelConsumptionRate)
        {
            this.maxFuelConsumptionRate = maxFuelConsumptionRate;
        }
        public void setMaxEnergyProductionRate(int maxEnergyProductionRate)
        {
            this.maxEnergyProductionRate = maxEnergyProductionRate;
        }
        public void setAverageRPM(int averageRPM)
        {
            this.averageRPM = averageRPM;
        }
    }
    internal class Door
    {
        private string openingMode;
        public string getOpeningMode()
        {
            return openingMode;
        }
        public void setOpeningMode(string openingMode)
        {
            this.openingMode = openingMode;
        }
    }
}
