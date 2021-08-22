namespace LeetCode.Q901_1000
{
    public class Q925
    {
        public bool IsLongPressedName(string name, string typed)
        {
            if (typed.Length < name.Length)
                return false;

            int i = 0;

            for (int j = 0; j < typed.Length; j++)
            {
                if (i < name.Length && name[i] == typed[j])
                    i++;
                else
                {
                    if (j == 0 || typed[j - 1] != typed[j])
                        return false;
                }
            }

            return i == name.Length;
        }
    }
}