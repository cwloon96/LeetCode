using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Q1401_1500
{
    public class Q1496
    {
        public bool IsPathCrossing(string path)
        {
            List<int[]> list = new List<int[]>();
            int[] origin = new[] { 0, 0 };

            list.Add(new[] { 0, 0 });
            foreach (var character in path)
            {
                int[] movement = null;

                if (character == 'N')
                    movement = new[] { 0, 1 };
                else if (character == 'E')
                    movement = new[] { 1, 0 };
                else if (character == 'S')
                    movement = new[] { 0, -1 };
                else if (character == 'W')
                    movement = new[] { -1, 0 };

                origin[0] += movement[0];
                origin[1] += movement[1];

                if (list.Any(x => x.SequenceEqual(origin)))
                    return true;

                list.Add(new[] { origin[0], origin[1] });
            }

            return false;
        }
    }
}