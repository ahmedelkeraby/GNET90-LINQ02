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

            #region Q3
            var result3 = ProductList.OrderByDescending(p => p.UnitPrice)
                                     .TakeWhile(p => p.UnitPrice < 25);
            #endregion

            #region Q4
            bool result4 = ProductList.Where(p => p.Category == "Seafood")
                                      .All(p => p.UnitPrice > 0);
            #endregion

            #region Q5
            int[] ids = { 3, 9, 13, 18 };
            bool result5 = ids.Contains(9);
            #endregion

            #region Q6
            var result6 = ProductList.GroupBy(p => p.Category);
            foreach (var g in result6)

            {
                Console.WriteLine($"{g.Key}: {g.Count()} products");
            }
            #endregion

            #region Q7
            var result7 = ProductList.GroupBy(p => p.Category)
                                    .Select(g => new
                                    {
                                        Category = g.Key,
                                        Names = g.Select(p => p.ProductName)
                                    });
            #endregion

            #region Q8
            var result8 = ProductList.GroupBy(p => p.Category)
                                    .Where(g => g.Count() > 3)
                                    .Select(g => new
                                    {
                                        Category = g.Key,
                                        Count = g.Count()
                                    });
            #endregion

            #region Q9  
            var result9 = from c in CustomerList
                     group c by c.Country into g
                     select new
                     {
                         Country = g.Key,
                         Count = g.Count(),
                         TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
                     };
            #endregion
            #region Q10
            var result10 = ProductList.Sum(p => p.UnitsInStock);
            #endregion




        }
    }
}
