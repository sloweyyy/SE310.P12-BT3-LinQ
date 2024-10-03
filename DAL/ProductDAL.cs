using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ProductDAL
    {
        private readonly string connectionString =
            @"data source=SloWeysLegion\MSSQLSERVER01;initial catalog=SE310.P12-LinQ;trusted_connection=true";

        public void AddProduct(ProductDTO product)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query =
                    "INSERT INTO Product (ProductId, ProductName, Quantity, Price, Origin, ExpiryDate) VALUES (@ProductId, @ProductName, @Quantity, @Price, @Origin, @ExpiryDate)";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Origin", product.Origin);
                cmd.Parameters.AddWithValue("@ExpiryDate", product.ExpiryDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool CheckIfProductCodeExists(int productId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = "SELECT COUNT(*) FROM Product WHERE ProductId = @ProductId";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                conn.Open();
                var count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }


        // Sửa sản phẩm
        public void EditProduct(ProductDTO product)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query =
                    "UPDATE Product SET ProductName=@ProductName, Quantity=@Quantity, Price=@Price, Origin=@Origin, ExpiryDate=@ExpiryDate WHERE ProductId=@ProductId";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Origin", product.Origin);
                cmd.Parameters.AddWithValue("@ExpiryDate", product.ExpiryDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int productId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = "DELETE FROM Product WHERE ProductId = @ProductId";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteExpiredProduct()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = "DELETE FROM Product WHERE ExpiryDate <= GETDATE()";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public DataTable GetProductList()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Product";
                var adapter = new SqlDataAdapter(query, conn);
                var dt = new DataTable();

                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetExpiredProductList()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Product WHERE ExpiryDate <= GETDATE()";
                var adapter = new SqlDataAdapter(query, conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable FindProductWithHighestPrice()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = "SELECT TOP 1 * FROM Product ORDER BY Price DESC";
                var adapter = new SqlDataAdapter(query, conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable FindProductsFromJapan()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Product WHERE Origin = 'Japan'";
                var adapter = new SqlDataAdapter(query, conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetProductsInPriceRange(decimal min, decimal max)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Product WHERE Price BETWEEN @Min AND @Max";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Min", min);
                cmd.Parameters.AddWithValue("@Max", max);
                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}