namespace Hash;

public abstract class OpenAdressing
{
  protected int[] table;
  protected int size;
  protected int capacity;

  public OpenAdressing(int capacity)
  {
    this.capacity = capacity;
    this.table = new int[capacity];
    this.size = 0;
    
    for (int i = 0; i < capacity; i++)
    {
      table[i] = -1;
    }
  }

  protected int Hash(int key)
  {
    return key % capacity;
  }

  protected abstract int GetNextProbe(int originalHash, int i, int key);

  public void Insert(int key)
  {
    if (size >= capacity)
    {
      Console.WriteLine("Hash table is full");
      return;
    }

    int originalHash = Hash(key);
    int i = 0;

    while (i < capacity)
    {
      int currentPos = GetNextProbe(originalHash, i, key);
      
      if (table[currentPos] == -1)
      {
        table[currentPos] = key;
        size++;
        Console.WriteLine($"Inserted {key} at position {currentPos}");
        return;
      }
      i++;
    }
  }

  public int Get(int key)
  {
    int originalHash = Hash(key);
    int i = 0;

    while (i < capacity)
    {
      int currentPos = GetNextProbe(originalHash, i, key);
      
      if (table[currentPos] == key)
      {
        return currentPos;
      }
      
      if (table[currentPos] == -1)
      {
        break;
      }
      
      i++;
    }
    
    return -1;
  }

  public void Display()
  {
    Console.WriteLine("\nHash Table:");
    for (int i = 0; i < capacity; i++)
    {
      Console.WriteLine($"Position {i}: {(table[i] == -1 ? "Empty" : table[i].ToString())}");
    }
  }
}

public class LinearProbing : OpenAdressing
{
  public LinearProbing(int capacity) : base(capacity) { }

  protected override int GetNextProbe(int originalHash, int i, int key)
  {
    return (originalHash + i) % capacity;
  }
}

public class QuadraticProbing : OpenAdressing
{
  public QuadraticProbing(int capacity) : base(capacity) { }

  protected override int GetNextProbe(int originalHash, int i, int key)
  {
    return (originalHash + i * i) % capacity;
  }
}

public class DoubleHashing : OpenAdressing
{
  public DoubleHashing(int capacity) : base(capacity) { }

  private int SecondaryHash(int key)
  {
    return 7 - (key % 7);
  }

  protected override int GetNextProbe(int originalHash, int i, int key)
  {
    return (originalHash + i * SecondaryHash(key)) % capacity;
  }
}
