using AddressBook;

SortedList<int, Person> people = new SortedList<int, Person>();

people.Add(29, new Person()
{
    Name = "Marcin",
    Country = CountryEnum.PL,
    Age = 29
});
people.Add(25, new Person()
{
    Name = "Sabine",
    Country = CountryEnum.DE,
    Age = 25
}); 
people.Add(31, new Person()
{
    Name = "Ann",
    Country = CountryEnum.PL,
    Age = 31
});
foreach (KeyValuePair<int, Person> person in people)
{
    Console.WriteLine($"{person.Value.Name} ({person.Value.Age} years) from { person.Value.Country}.");
}