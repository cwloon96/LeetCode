namespace LeetCode.Q701_800
{
    public class MyLinkedList
    {
        class ListNode
        {
            public ListNode(int val, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }

            public int val { get; set; }
            public ListNode next { get; set; }
        }

        private ListNode head;
        private ListNode tail;
        private int length = 0;

        public MyLinkedList()
        {

        }

        public int Get(int index)
        {
            var node = GetIndex(index);

            return node == null ? -1 : node.val;
        }

        public void AddAtHead(int val)
        {
            head = new ListNode(val, head);
            length++;
        }

        public void AddAtTail(int val)
        {
            if (length == 0)
            {
                AddAtHead(val);
            }
            else
            {
                if (tail == null)
                {
                    var last = GetIndex(length - 1);
                    last.next = new ListNode(val);
                    tail = last.next;
                }
                else
                {
                    tail.next = new ListNode(val);
                    tail = tail.next;
                }

                length++;
            }
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == length)
            {
                AddAtTail(val);
            }
            else if (index == 0)
            {
                AddAtHead(val);
            }
            else
            {
                var node = GetIndex(index - 1);

                if (node == null)
                    return;

                node.next = new ListNode(val, node.next);
                length++;
            }
        }

        public void DeleteAtIndex(int index)
        {
            if (index >= length)
                return;

            if (index == 0)
            {
                if (head != null)
                {
                    head = head.next;
                    length--;
                }
            }
            else
            {
                var node = GetIndex(index - 1);

                if (node == null)
                    return;

                node.next = node.next?.next;

                if (index == length - 1)
                    tail = node;

                length--;
            }
        }

        private ListNode GetIndex(int index)
        {
            if (index < 0 || index >= length)
                return null;

            if (index == 0 && head != null)
                return head;

            if (index == length - 1 && tail != null)
                return tail;

            int current = 0;
            var result = head;
            while (current != index && result != null)
            {
                result = result.next;
                current++;
            }

            return result;
        }
    }
}