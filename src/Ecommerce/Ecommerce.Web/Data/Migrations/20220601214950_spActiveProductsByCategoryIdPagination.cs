using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Web.Data.Migrations
{
    public partial class spActiveProductsByCategoryIdPagination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) {
            string storedProcedure = @"Create PROCEDURE GetActiveProductByCategoryId
                        @pageIndex int,
                        @pageSize int , 
                        @InputCategoryId nvarchar(50)
                        AS
                        BEGIN 
	                        SET NOCOUNT ON;
	                        SELECT ProductCategories.ProductId, ProductCategories.CategoryId FROM ProductCategories 
	                        INNER JOIN Products ON ProductCategories.ProductId=Products.Id 
	                        where @InputCategoryId = ProductCategories.CategoryId AND Products.ActiveStatus='true'
	                         Order by ProductId OFFSET @PageSize * (@PageIndex - 1) 
	                        ROWS FETCH NEXT @PageSize ROWS ONLY 
                        END";
            migrationBuilder.Sql(storedProcedure);
        
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string storedProcedure = @"Create PROCEDURE GetActiveProductByCategoryId";
            migrationBuilder.Sql(storedProcedure);
        }
        
    }
}
