using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("01 Broadway Str", "New York", "NY", "USA");
        Address address2 = new Address("10 Aj Str", "Lagos", "LAG", "NGN");
        Address address3 = new Address("20 Holloway Rd", "London", "LDN", "UK");

        DateTime date = DateTime.Now.AddDays(7);

        Lecture lecture = new Lecture("IT in space", "Learn about IT space", date, "8:00 PM", address1, "Elon musk", 100);
        Reception reception = new Reception("Wedding Reception", "A Traditonal Wedding Reception to entertain guests", date, "2:00 PM", address2, "nigerianweddings@gmail.com");
        OutdoorGathering gathering = new OutdoorGathering("Outdoor Concert", "Enjoy live outdoor music concert", date, "6:00 PM", address3, "Sunny, 75°F");

        List<Event> events = new List<Event> { lecture, reception, gathering };

        foreach (Event eventItem in events)
        {
            Console.WriteLine("Standard Details:\n" + eventItem.StandardDetails() + "\n");
            Console.WriteLine("Full Details:\n" + eventItem.FullDetails() + "\n");
            Console.WriteLine("Short Description:\n" + eventItem.ShortDescription() + "\n");
            Console.WriteLine("========================================\n");
        }
    }
}