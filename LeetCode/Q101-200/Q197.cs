namespace LeetCode.Q101_200
{
    class Q197
    {
        public void Sql()
        {
            string sql = @"SELECT a.id 
                            FROM Weather a
                            INNER JOIN Weather b ON DATEDIFF(a.recordDate, b.recordDate) = 1 AND a.Temperature > b.Temperature";
        }
    }
}