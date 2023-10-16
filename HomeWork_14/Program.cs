using System;
using System.Collections.Generic;

public class GenericCollection<T>
{
    private List<T> collection;

    public GenericCollection()
    {
        collection = new List<T>();
    }

    public T Add(T item)
    {
        collection.Add(item);
        return item;
    }
}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        GenericCollection<Person> result = new GenericCollection<Person>();

        Person Object = result.Add(new Person { Id = 1, Name = "Alim" });

        Console.WriteLine(Object.Id);
    }
}