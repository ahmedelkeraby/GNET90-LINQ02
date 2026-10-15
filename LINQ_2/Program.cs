namespace LINQ_2
{
    using static Source;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            var result = ProductList.OrderByDescending(p => p.UnitPrice)
                                    .Take(3);
            #endregion

            #region Q2
            int pageNumber = 2, pageSize = 5;
            var result2 = ProductList.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            #endregion


        }
    }
}
