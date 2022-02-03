using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal static class Hotel_Management_System
    {
        public static int money = 0;
        public static List<User> users = new List<User>();
        public static List<Booking> bookings = new List<Booking>();
        public static Room Single = new Room(100, "Single");
        public static Room Double = new Room(200, "Double");
        public static Room Suite = new Room(300, "Suite");
        public static Room Deluxe = new Room(400, "Deluxe");
        public static int booking_id = 1;
        public static void users_add(User dummy)
        {
            users.Add(dummy);
        }
        public static void bookings_add(Booking dummy)
        {
            bookings.Add(dummy);
        }
        public static void set_status(int booking_id, string status)
        {
            if(status == "Pending")
            {
                for(int i = 0; i < bookings.Count; i++)
                {
                    if(bookings[i].id == booking_id)
                    {
                        bookings[i].booking_confirmation = false;
                    }
                }
            }
            else if(status == "Confirmed")
            {
                for (int i = 0; i < bookings.Count; i++)
                {
                    if (bookings[i].id == booking_id)
                    {
                        bookings[i].booking_confirmation = true;
                    }
                }
            }
            else
            {

            }
        }
        public static int get_money()
        {
            return money;
        }
        public static Booking get_booking(int booking_id)
        {
            for(int i=0; i<bookings.Count; i++)
            {
                if(bookings[i].id == booking_id)
                {
                    return bookings[i];
                }
            }
            return null;
        }
        public static void set_money(int booking_id)
        {
            for (int i = 0; i < bookings.Count; i++)
            {
                if (bookings[i].id == booking_id)
                {
                    money += bookings[i].amount;
                }
            }
        }

    }
    internal class User
    {
        public string name;
        public int id;
        public string contact;
        public string address;
        public User(string name, int id, string contact, string address)
        {
            this.name = name;
            this.id = id;
            this.contact = contact;
            this.address = address;
        }
    }
    internal class Booking
    { 
        public int id;
        public string room_choice;
        public int qty;
        public DateTime entry;
        public DateTime departure;
        public int user_id;
        public bool booking_confirmation;
        public int amount;
        public Booking(string room_choice, int qty, DateTime entry, DateTime departure, int user_id, bool booking_confirmation)
        {
            this.id = Hotel_Management_System.booking_id;
            Hotel_Management_System.booking_id++;
            this.room_choice = room_choice;
            this.qty = qty;
            this.entry = entry;
            this.departure = departure;
            this.user_id = user_id;
            this.booking_confirmation = booking_confirmation;
            if(this.room_choice == "Single")
            {
                this.amount = (departure - entry).Days * 100 * qty;
            }
            else if(this.room_choice == "Double")
            {
                this.amount = (departure - entry).Days * 200 * qty;
            }
            else if (this.room_choice == "Suite")
            {
                this.amount = (departure - entry).Days * 300 * qty;
            }
            else if (this.room_choice == "Deluxe")
            {
                this.amount = (departure - entry).Days * 400 * qty;
            }
            else
            {

            }
        }
        public int get_days()
        {
            TimeSpan days = departure - entry;
            return days.Days;
        }
        public int get_amount()
        {
            return this.amount;
        }
        public string get_info()
        {
            return this.room_choice + " " + this.qty + " " + this.amount;
        }
    }
    class Room
    {
        public int price;
        public string name;
        public Room(int price, string name)
        {
            this.price = price;
            this.name = name;
        }
    }
}
