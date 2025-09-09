namespace InteractiveLINQconsoleApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                Console.WriteLine("Enter the data of one person:");
                Console.WriteLine("Name:");
                string personName = Console.ReadLine();
                Console.WriteLine("Age:");
                int personAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Salary:");
                int personSalary = int.Parse(Console.ReadLine());

                people.Add(new Person(personName, personAge, personSalary));

                Console.WriteLine("Do you want to add more people? (yes) or (no)");

                string response = Console.ReadLine();

                if (response == "yes")
                {
                    continue;
                }
                else if (response == "no") {

                    // Query 1: Complete list of people
                    var peopleLINQ = from p in people
                                     select p;
                    Console.WriteLine("The complete list of people is:");
                    foreach (var p in peopleLINQ)
                    {
                        Console.WriteLine(p);
                    }

                    // Query 2: Filter based on age greater than 30
                    var peopleGreater30 = people.Where(
                                          p => p.Age >= 30);
                    Console.WriteLine("The number of people on age greater than 30 is: " + peopleGreater30.Count());

                    // Query 3: Sort by initial name
                    Console.WriteLine("The people whose name starts with 'a' are:");
                    var initialA = people.Where(
                                        p => p.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
                    foreach (var p in initialA)
                    {
                        Console.WriteLine(p);
                    }

                    // Query 4: Calculate average salary
                    var averageSalary = people.Average(
                                        p => p.Salary);
                    Console.WriteLine("The average salary is: " + averageSalary);

                    // Query 5: Calculate average age
                    var averageAge = people.Average(
                                        p => p.Age);
                    Console.WriteLine("The average age of people is: " + averageAge);

                    break;
                }
            }
        }
    }
}
