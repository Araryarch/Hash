namespace Hash;

public class HashNode<K, V>
{
    public K Key { get; set; }
    public V Value { get; set; }
    public HashNode<K, V> Next { get; set; }

    public HashNode(K key, V value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}