using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.Repositories
{
    public class CategoryRepository : Repository<Category, Guid>, ICategoryRepository
    {
        private readonly IStoreDbContext _context;
        public CategoryRepository(IStoreDbContext context) : base((DbContext)context)
        {
            _context = context;
        }

        public IList<ProductCategory> getActiveProductsByCategoryId(string storedProcedureName, int pageIndex, int pageSize, string InputCategoryId)
        {
            string sql = storedProcedureName + " @pageIndex, @pageSize, @InputCategoryId";
            var parameters = new SqlParameter[] {
                                                new SqlParameter() {
                                                    ParameterName = "@pageIndex",
                                                    SqlDbType =  System.Data.SqlDbType.Int,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = pageIndex
                                                }
                                                ,
                                                new SqlParameter() {
                                                    ParameterName = "@pageSize",
                                                    SqlDbType =  System.Data.SqlDbType.Int,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = pageSize
                                                },
                                                new SqlParameter() {
                                                    ParameterName = "@InputCategoryId",
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = InputCategoryId
                                                }
            };
            var result = _context.ProductCategories.FromSqlRaw<ProductCategory>
                (sql, parameters).ToList();

            return result;
        }
    }
}
