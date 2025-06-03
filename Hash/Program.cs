namespace Hash;

class Program
{
    static void Main()
    {
        ChainedHashTable<string, string> hashTable = new ChainedHashTable<string, string>(10);


        //? ini nih cara insertnya tuh "keynya", "valuenya", jadi ketika key nya di hash bakal keliatan value nya

        hashTable.Insert("key1", "value1");
        hashTable.Insert("key2", "value2");
        hashTable.Insert("key3", "value3");

        try
        {
            Console.WriteLine("Value for key1: " + hashTable.Get("key1"));
            Console.WriteLine("Value for key2: " + hashTable.Get("key2"));
            Console.WriteLine("Value for key3: " + hashTable.Get("key3"));
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        //! insert nya number karena dia array biasa
        Console.WriteLine("Linear Probing Insert");
        LinearProbing linearProbing = new LinearProbing(10);
        linearProbing.Insert(5);
        linearProbing.Insert(15);
        linearProbing.Insert(25);
        linearProbing.Insert(35);
        linearProbing.Display();

        Console.WriteLine("\nQuadratic Probing Insert");
        QuadraticProbing quadraticProbing = new QuadraticProbing(10);
        quadraticProbing.Insert(5);
        quadraticProbing.Insert(15);
        quadraticProbing.Insert(25);
        quadraticProbing.Insert(35);
        quadraticProbing.Display();

        Console.WriteLine("\nDouble Hashing Insert");
        DoubleHashing doubleHashing = new DoubleHashing(10);
        doubleHashing.Insert(5);
        doubleHashing.Insert(15);
        doubleHashing.Insert(25);
        doubleHashing.Insert(35);
        doubleHashing.Display();

        Console.WriteLine("\nGet for values:");
        Console.WriteLine($"Position of 15 in linear probing: {linearProbing.Get(15)}");
        Console.WriteLine($"Position of 25 in quadratic probing: {quadraticProbing.Get(25)}");
        Console.WriteLine($"Position of 35 in double hashing: {doubleHashing.Get(35)}");

    }
}
