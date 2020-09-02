using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Queue
{
    public class Guest
    {
        public string Name;
        public int Age;
        public Guest()
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Queue<Guest> guests = new Queue<Guest>();
            guests.Enqueue(new Guest() { Age = 22, Name = "Sara" });
            guests.Enqueue(new Guest() { Age = 55, Name = "John" });
            guests.Enqueue(new Guest() { Age = 31, Name = "Beatrice" });
            guests.Enqueue(new Guest() { Age = 27, Name = "Steward" });

            Console.WriteLine("Full guest list in the queue to the party");

            foreach (Guest guest in guests) 
            {
                Console.WriteLine("{0}, {1}", guest.Name, guest.Age);
            }
            Console.WriteLine("");

            Guest firstToLeave = guests.Dequeue();
            Console.WriteLine(string.Format("First to leave: {0}", firstToLeave.Name));

            Console.WriteLine("\n Guest list after the first guest say goodbye and leaves the party:\n ");
            foreach (Guest guest in guests)
            {
                Console.WriteLine("{0},{1}", guest.Name, guest.Age);
            }

            Guest soonToLeave = guests.Peek();
            Console.WriteLine(string.Format("\n checking to see who will be the next person to leave: {0}", soonToLeave.Name));
        }

    }
}
