public class Node
{
    public int key;
    public int value;
    
    public Node (int k, int v)
    {
        key = k;
        value = v;
    }
}
public class LRUCache {
    Dictionary<int, LinkedListNode<Node>> dict;
    LinkedList<Node> list;
    int cap;
    int count;
    public LRUCache(int capacity) {
         dict = new Dictionary<int, LinkedListNode<Node>>();
         list = new LinkedList<Node>();
         cap = capacity;
         count = 0;
    }

    public int Get(int key) {
        LinkedListNode<Node> node;
        if(!dict.TryGetValue(key, out node))
            return -1;
        
        int value = node.Value.value;
        list.Remove(node);
        list.AddLast(node);
        return value;
    }

    public void Set(int key, int value) {
        LinkedListNode<Node> node;
        if(dict.TryGetValue(key, out node))
        {
            list.Remove(node);
            node.Value.value = value;
            list.AddLast(node);
            dict[key] = node;
        }
        else{
            Console.WriteLine("Set key {0} to val: {1}", key, value);
            node = new LinkedListNode<Node> (new Node(key, value));
            if(count < cap)
            {
                count++;
                list.AddLast(node);
                dict.Add(key, node);
            }
            else{
                LinkedListNode<Node> n2 = list.First;
                dict.Remove(n2.Value.key);
                list.RemoveFirst();
                
                list.AddLast(node);
                dict[key] = node;
            }
            Console.WriteLine("Count: {0}", count);
            
        }
    }
}
