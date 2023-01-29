public class LFUCache {
    private class Node
    {
        public int Key {get; set; }
        public int Val {get; set; }
        public int Count {get; set;}
    }
    Dictionary<int, LinkedListNode<Node>> NodeDictionary;
    Dictionary<int, LinkedList<Node>> CountDictionary;
    int Capacity;
    int CurrentSize;
    int Min;
    public LFUCache(int capacity) {
        NodeDictionary = new Dictionary<int, LinkedListNode<Node>>();
        CountDictionary = new Dictionary<int, LinkedList<Node>>();
        Capacity = capacity;
        CurrentSize = 0;
        Min =1;
    }
    
    public int Get(int key) {
        if(!NodeDictionary.ContainsKey(key)) return -1;
        var currentNode = NodeDictionary[key];
        updateNodeCountAndFrequency(currentNode);
        return currentNode.Value.Val;
    }
    
    public void Put(int key, int value) {
        if(Capacity == 0) return;
        if(NodeDictionary.ContainsKey(key))
        {
            var currentNode = NodeDictionary[key];
            currentNode.Value.Val = value;   
            updateNodeCountAndFrequency(currentNode);
            return;
        }
        if(CurrentSize == Capacity)
        {
            var minCountList = CountDictionary[Min];
            NodeDictionary.Remove(minCountList.Last.Value.Key);
            minCountList.RemoveLast();
            CurrentSize--;
        }
        Min=1;
        LinkedList<Node> countList;
        if(!CountDictionary.ContainsKey(Min))
        {
            countList = new LinkedList<Node>();
            CountDictionary.Add(Min, countList);
        }
        else countList = CountDictionary[Min];
        countList.AddFirst(new Node{Key = key, Val = value, Count = 1});
        NodeDictionary.Add(key, countList.First);
        CurrentSize++;
    }
    private void updateNodeCountAndFrequency(LinkedListNode<Node> currNode)
    {
        var currCountList = CountDictionary[currNode.Value.Count];
        currCountList.Remove(currNode);
        if(currCountList.Count ==0 && currNode.Value.Count == Min) Min++;
        currNode.Value.Count++;
        LinkedList<Node> countList;
        if(!CountDictionary.ContainsKey(currNode.Value.Count))
        {
           countList = new LinkedList<Node>();
           CountDictionary.Add(currNode.Value.Count, countList); 
        }
        else countList = CountDictionary[currNode.Value.Count];
        countList.AddFirst(currNode.Value);
        NodeDictionary[currNode.Value.Key] = countList.First;
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
