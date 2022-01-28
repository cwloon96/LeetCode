namespace LeetCode.Q201_300
{
    public class WordDictionary
    {
        class TrieNode
        {
            public TrieNode[] children { get; set; }
            public bool End { get; set; }

            public TrieNode()
            {
                children = new TrieNode[26];
            }
        }

        private TrieNode root;

        public WordDictionary()
        {
            root = new TrieNode();
        }

        public void AddWord(string word)
        {
            var temp = root;

            foreach (var c in word)
            {
                if (temp.children[c - 'a'] == null)
                    temp.children[c - 'a'] = new TrieNode();

                temp = temp.children[c - 'a'];
            }

            temp.End = true;
        }

        public bool Search(string word)
        {
            return Search(word, root, 0);
        }

        private bool Search(string word, TrieNode node, int index)
        {
            if (node == null)
                return false;

            if (index == word.Length)
                return node.End;

            var character = word[index];

            if (character == '.')
            {
                for(int i = 0; i < node.children.Length; i++)
                {
                    if (node.children[i] != null && Search(word, node.children[i], index + 1))
                        return true;
                }

                return false;
            }

            return Search(word, node.children[character - 'a'], index + 1);
        }
    }
}