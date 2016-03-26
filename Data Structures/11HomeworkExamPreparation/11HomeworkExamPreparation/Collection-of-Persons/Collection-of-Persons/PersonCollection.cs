
using System.Collections.Generic;
using Wintellect.PowerCollections;

public class PersonCollection : IPersonCollection
{
    private Dictionary<string, Person> peopleByEmail = new Dictionary<string, Person>();
    private Dictionary<string, SortedSet<Person>> peopleByDomain = new Dictionary<string, SortedSet<Person>>();
    private Dictionary<string, SortedSet<Person>> peopleByNameAndTown = new Dictionary<string, SortedSet<Person>>();
    private OrderedDictionary<int, SortedSet<Person>> peopleByAge = new OrderedDictionary<int, SortedSet<Person>>();
    private OrderedDictionary<string, OrderedDictionary<int, SortedSet<Person>>> peopleByTownAndAge = new OrderedDictionary<string, OrderedDictionary<int, SortedSet<Person>>>();

    public bool AddPerson(string email, string name, int age, string town)
    {
        if (this.FindPerson(email) != null)
        {
            return false;
        }

        var person = new Person() { Age = age, Email = email, Name = name, Town = town };
        var nameTown = name + "|!|" + town;
        var domain = email.Split('@')[1];
        this.peopleByEmail.Add(email, person);
        this.peopleByDomain.AppendValueToKey(domain, person);
        this.peopleByNameAndTown.AppendValueToKey(nameTown, person);
        this.peopleByAge.AppendValueToKey(age, person);
        this.peopleByTownAndAge.EnsureKeyExists(town);
        this.peopleByTownAndAge[town].AppendValueToKey(age, person);
        return true;
    }

    public int Count
    {
        get { return this.peopleByEmail.Count; }
    }

    public Person FindPerson(string email)
    {
        if (this.peopleByEmail.ContainsKey(email))
        {
            return this.peopleByEmail[email];
        }
        return null;
    }

    public bool DeletePerson(string email)
    {
        if (!this.peopleByEmail.ContainsKey(email))
        {
            return false;
        }
        var domain = email.Split('@')[1];
        var person = this.peopleByEmail[email];
        this.peopleByEmail.Remove(email);
        this.peopleByAge[person.Age].Remove(person);
        this.peopleByDomain[domain].Remove(person);
        this.peopleByNameAndTown[person.Name + "|!|" + person.Town].Remove(person);
        this.peopleByTownAndAge[person.Town][person.Age].Remove(person);
        return true;
    }

    public IEnumerable<Person> FindPersons(string emailDomain)
    {
        return this.peopleByDomain.GetValuesForKey(emailDomain);
    }

    public IEnumerable<Person> FindPersons(string name, string town)
    {
        return this.peopleByNameAndTown.GetValuesForKey(name + "|!|" + town);
    }

    public IEnumerable<Person> FindPersons(int startAge, int endAge)
    {
        var personsInRange = this.peopleByAge.Range(startAge, true, endAge, true);
        foreach (var persons in personsInRange)
        {
            foreach (var person in persons.Value)
            {
                yield return person;
            }
        }
    }

    public IEnumerable<Person> FindPersons(
        int startAge, int endAge, string town)
    {
        if (!this.peopleByTownAndAge.ContainsKey(town))
        {
            yield break;
        }

        var peopleInRange = this.peopleByTownAndAge[town].Range(startAge, true, endAge, true);
        foreach (var peopleAge in peopleInRange)
        {
            foreach (var person in peopleAge.Value)
            {
                yield return person;
            }
        }
    }
}
