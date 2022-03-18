using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Class_Library
    {
    }
    internal class N28Building
    {
        public static List<Lab> labs = new List<Lab>();
        public static List<LecturerRoom> lecturerRooms = new List<LecturerRoom>();
        
        public static void setAllLabs()
        {
            int numberOfInputs;
            numberOfInputs = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < numberOfInputs; i++)
            {
                Lab dummy = new Lab();
                dummy.setLabName(Console.ReadLine());
                dummy.setCapacity(Convert.ToInt32(Console.ReadLine()));
                labs.Add(dummy);
            }
        }
        public static void setAllLecturerRooms()
        {
            int numberOfInputs;
            numberOfInputs = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfInputs; i++)
            {
                LecturerRoom dummy = new LecturerRoom();
                dummy.setRoomName(Console.ReadLine());
                dummy.setRoomNo(Console.ReadLine());
                dummy.setCapacity(Convert.ToInt32(Console.ReadLine()));
                lecturerRooms.Add(dummy);
            }
        }
        public static void showAllLabs()
        {
            for(int i = 0; i < labs.Count; i++)
            {
                Console.WriteLine(labs[i].getLabName() + " " + Convert.ToString(labs[i].getCapacity()));
            }
        }
        public static void showAllLecturerRooms()
        {
            for(int i = 0; i < lecturerRooms.Count; i++)
            {
                Console.WriteLine(lecturerRooms[i].getRoomName() + " " + lecturerRooms[i].getRoomNo() + " " + lecturerRooms[i].getCapacity());
            }
        }
    }
    internal class Lab
    {
        private string labName;
        private int capacity;
        public string getLabName()
        {
            return labName;
        }
        public int getCapacity()
        {
            return capacity;
        }
        public void setLabName(string labName)
        {
            this.labName = labName;
        }
        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }
    }
    internal class LecturerRoom
    {
        private string roomName;
        private string roomNo;
        private int capacity;
        public string getRoomName()
        {
            return roomName;
        }
        public string getRoomNo()
        {
            return roomNo;
        }
        public int getCapacity()
        {
            return capacity;
        }
        public void setRoomName(string roomName)
        {
            this.roomName = roomName;
        }
        public void setRoomNo(string roomNo)
        {
            this.roomNo = roomNo;
        }
        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }
    }
}
