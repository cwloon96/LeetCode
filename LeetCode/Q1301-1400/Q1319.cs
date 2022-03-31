namespace LeetCode.Q1301_1400
{
    public class Q1319
    {
        public int MakeConnected(int n, int[][] connections)
        {
            if (connections.Length < n - 1) return -1; // To connect all nodes need at least n-1 edges
            int[] parent = new int[n];
            for (int i = 0; i < n; i++) parent[i] = i;
            int components = n;
            foreach (int[] c in connections)
            {
                int p1 = FindParent(parent, c[0]);
                int p2 = FindParent(parent, c[1]);
                if (p1 != p2)
                {
                    parent[p1] = p2; // Union 2 component
                    components--;
                }
            }

            int FindParent(int[] parent, int i) {
                //while (i != parent[i]) i = parent[i];
                //return i; // Without Path Compression

                if (i == parent[i]) return i;
                return parent[i] = FindParent(parent, parent[i]);
            };

            return components - 1; // Need (components-1) cables to connect components together
        }
    }
}