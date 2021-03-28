using System.Collections.Generic;

namespace LeetCode.Q701_800
{
    public class Q796
    {
        public bool RotateString(string A, string B)
        {
            if (A.Length != B.Length)
                return false;

            if (A.Length == 0)
                return true;

            // store possible shifts
            List<int> shifts = new List<int>();
            for (int i = 0; i < A.Length; i++)
                if (A[i] == B[0])
                    shifts.Add(i);

            foreach (var shift in shifts)
            {
                int i = 0;
                for (; i < A.Length; i++)
                {
                    // calculate shifted position
                    int shifted = i - shift >= 0 ? i - shift : A.Length - shift + i;

                    if (A[i] != B[shifted])
                        break;
                }

                if (i == A.Length)
                    return true;
            }

            return false;
        }
    }
}