namespace Hash;

public class ChainedHashTable<K, V>
{
    private List<HashNode<K, V>> bucketArray;
    private int number; // ini number di bucket buat nyari index
    private int size;

    public ChainedHashTable(int capacity)
    {
        bucketArray = new List<HashNode<K, V>>();
        number = capacity;
        size = 0;

        for (int i = 0; i < number; i++)
            bucketArray.Add(null);
    }

    private int GetBucketIndex(K key)
    {
        int hashCode = key.GetHashCode();
        return Math.Abs(hashCode % number);
    }

    public void Insert(K key, V value)
    {
        int bucketIndex = GetBucketIndex(key);
        HashNode<K, V> head = bucketArray[bucketIndex];

        while (head != null)
        {
            if (head.Key.Equals(key))
            {
                head.Value = value;
                return;
            }
            head = head.Next;
        }

        size++;
        head = bucketArray[bucketIndex];
        HashNode<K, V> newNode = new HashNode<K, V>(key, value);
        newNode.Next = head;
        bucketArray[bucketIndex] = newNode;
    }

    public V Get(K key)
    {
        int bucketIndex = GetBucketIndex(key);
        HashNode<K, V> head = bucketArray[bucketIndex];

        while (head != null)
        {
            if (head.Key.Equals(key))
                return head.Value;
            head = head.Next;
        }

        throw new KeyNotFoundException("Key not found");
    }
}

