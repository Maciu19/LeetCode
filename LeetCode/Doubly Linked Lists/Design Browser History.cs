namespace LeetCode.Doubly_Linked_Lists;

// Link: https://leetcode.com/problems/design-browser-history/description/
public class Design_Browser_History
{
    static void Main(string[] args)
    {
        // Example 1
        BrowserHistory browserHistory = new BrowserHistory("leetcode.com");
        browserHistory.Visit("google.com");
        browserHistory.Visit("facebook.com");
        browserHistory.Visit("youtube.com");
        browserHistory.Back(1);
        browserHistory.Back(1);
        browserHistory.Forward(1);
        browserHistory.Visit("linkedin.com");
        browserHistory.Forward(2);
        browserHistory.Back(2);
        browserHistory.Back(7);
    }

    private class Node
    {
        public Node Prev { get; set; }
        public string Val { get; set; }
        public Node Next { get; set; }

        public Node(
            Node prev = null,
            string val = "",
            Node next = null)
        {
            Prev = prev;
            Val = val;
            Next = next;
        }
    }

    private class BrowserHistory
    {
        private Node CurrentNode;
        private Node Head;
        private Node Tail;

        public BrowserHistory(string homepage)
        {
            Head = CurrentNode = Tail = new Node(null, homepage, null);
        }

        public void Visit(string url)
        {
            Node newNode = new(CurrentNode, url, null);

            CurrentNode.Next = newNode;

            CurrentNode = newNode;
            Tail = CurrentNode;
        }

        public string Back(int steps)
        {
            int i = 0;
            while (i < steps && CurrentNode != Head)
            {
                CurrentNode = CurrentNode.Prev;
                i++;
            }

            return CurrentNode.Val; 
        }

        public string Forward(int steps)
        {
            int i = 0;
            while(i < steps && CurrentNode != Tail)
            {
                CurrentNode = CurrentNode.Next;
                i++;
            }

            return CurrentNode.Val;
        }
    }
}
