using System;

namespace MyHashtable
{
    public class Program
    {
        static void Main(string[] args)
        {
            var hashtable = new SuperHashTable<Person>(100);
            var person = new Person() { Name = "Vasia", Age = 25, Gender = 0 };
            hashtable.Add(new Person() { Name = "Misha", Age = 35, Gender = 0 });
            hashtable.Add(new Person() { Name = "Olia", Age = 20, Gender = 1 });
            hashtable.Add(new Person() { Name = "Sasha", Age = 18, Gender = 1 });
            hashtable.Add(person);
            Console.WriteLine(hashtable.Search(new Person() { Name = "Masha", Age = 35, Gender = 1 }));
            Console.WriteLine(hashtable.Search(person));

            Console.WriteLine();
            var hashTable = new HashTable<int, string>(100);
            hashTable.Add(5, "Hello");
            hashTable.Add(18, "world");
            hashTable.Add(777, "friend");
            hashTable.Add(7, "programmer");
            Console.WriteLine(hashTable.Search(6, "Hello"));
            Console.WriteLine(hashTable.Search(18, "world"));

            Console.WriteLine();
            var badHashtable = new BadHashtable<int>(100);
            badHashtable.Add(5);
            badHashtable.Add(18);
            badHashtable.Add(777);
            Console.WriteLine(badHashtable.Search(6));
            Console.WriteLine(badHashtable.Search(18));

        }
    }
}
