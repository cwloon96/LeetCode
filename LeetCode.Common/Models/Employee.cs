using System.Collections.Generic;

namespace LeetCode.Common.Models
{
    public class Employee
    {
        public Employee(int id, int importance, IList<int> subordinates)
        {
            this.id = id;
            this.importance = importance;
            this.subordinates = subordinates;
        }

        public int id { get; set; }
        public int importance { get; set; }
        public IList<int> subordinates { get; set; } = new List<int>();
    }
}