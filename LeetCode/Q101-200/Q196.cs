namespace LeetCode.Q101_200
{
    public class Q196
    {
        public void Sql()
        {
            string sql = @"DELETE a FROM Person a
                           INNER JOIN Person b
                           WHERE
                              a.Id > b.Id AND
                              a.Email = b.Email;";
        }
    }
}