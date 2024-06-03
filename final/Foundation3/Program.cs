using System;
public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "Anystate", "12345");
        Address address2 = new Address("456 Oak St", "Othertown", "Otherstate", "67890");
        Address address3 = new Address("789 Pine St", "Sometown", "Somestate", "54321");

        Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in tech.", new DateTime(2024, 6, 15), "10:00 AM", address1, "Jane Doe", 100);
        Reception reception = new Reception("Networking Event", "An opportunity to network with professionals.", new DateTime(2024, 6, 20), "6:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic in the Park", "A fun day out with family and friends.", new DateTime(2024, 6, 25), "12:00 PM", address3, "Sunny and warm");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}
