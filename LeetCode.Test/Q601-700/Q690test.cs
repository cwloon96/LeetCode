using LeetCode.Common.Models;
using LeetCode.Q601_700;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Test.Q601_700
{
    class Q690Test
    {
        [Test]
        public void Test()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1, 5, new[] { 2, 3}),
                new Employee(2, 3, new int[] { }),
                new Employee(3, 3, new int[] { }),
            };

            int result = new Q690().GetImportance(employees, 1);
            Assert.AreEqual(11, result);
        }
    }
}