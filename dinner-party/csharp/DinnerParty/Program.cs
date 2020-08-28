using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guest> guests = GetGuests();
            List<DinnerTable> tables = new List<DinnerTable>();
            DinnerTable table1 = new DinnerTable()
            {
                Name = "Table 1",
                Guests = new List<Guest>()
            };
            DinnerTable table2 = new DinnerTable()
            {
                Name = "Table 2",
                Guests = new List<Guest>()
            };
            tables.Add(table1);
            tables.Add(table2);

            guests.ForEach(guest =>
            {
                List<string> table1Occupations = table1.Guests.Select(g => g.Occupation).ToList();
                if (table1Occupations.Contains(guest.Occupation))
                {
                    table2.Guests.Add(guest);
                }
                else
                {
                    table1.Guests.Add(guest);
                }
            });

            foreach (DinnerTable table in tables)
            {
                Console.WriteLine(table.Name);
                foreach (Guest guest in table.Guests)
                {
                    Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
                };
            };

        }

        static List<Guest> GetGuests()
        {
            List<Guest> allGuests = new List<Guest>()
            {
                new Guest()
                    {
                        Name = "Marilyn Monroe",
                            Occupation = "entertainer",
                            Bio = "(1926 - 1962) American actress, singer, model"
                    },
                    new Guest()
                    {
                        Name = "Abraham Lincoln",
                            Occupation = "politician",
                            Bio = "(1809 - 1865) US President during American civil war"
                    },
                    new Guest()
                    {
                        Name = "Martin Luther King",
                            Occupation = "activist",
                            Bio = "(1929 - 1968)  American civil rights campaigner"
                    },
                    new Guest()
                    {
                        Name = "Rosa Parks",
                            Occupation = "activist",
                            Bio = "(1913 - 2005)  American civil rights activist"
                    },
                    new Guest()
                    {
                        Name = "Peter Sellers",
                            Occupation = "entertainer",
                            Bio = "(1925 - 1980) British actor and comedian"
                    },
                    new Guest()
                    {
                        Name = "Alan Turing",
                            Occupation = "computer scientist",
                            Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                    },
                    new Guest()
                    {
                        Name = "Admiral Grace Hopper",
                            Occupation = "computer scientist",
                            Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                    },
                    new Guest()
                    {
                        Name = "Indira Gandhi",
                            Occupation = "politician",
                            Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
                    }
            };

            return allGuests;
        }
    }
    public class Guest
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Bio { get; set; }
    }

    public class DinnerTable
    {
        public string Name { get; set; }
        public List<Guest> Guests { get; set; }
    }

}