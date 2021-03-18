namespace LeetCode.Q101_200
{
    public class Q183
    {
        public void Sql()
        {
            string sql = @"SELECT Name AS Customers FROM Customers a
                           WHERE NOT EXISTS (
                               SELECT * FROM Orders b WHERE a.Id = b.CustomerId
                           );";
        }
    }
}