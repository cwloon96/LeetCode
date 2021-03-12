using LeetCode.Common.Models;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Q601_700
{
    public class Q690
    {
        public int GetImportance(IList<Employee> employees, int id)
        {
            int result = 0;
            var employee = employees.First(x => x.id == id);

            result += employee.importance;
            foreach (var sub in employee.subordinates)
                result += GetImportance(employees, sub);

            return result;
        }
    }
}