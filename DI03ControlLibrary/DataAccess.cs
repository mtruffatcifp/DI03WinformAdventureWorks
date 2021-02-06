using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DI03ControlLibrary
{
    class DataAccess
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdventureWorks2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static ProductModel getProductModel(int productModelId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $"SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, ProductPhoto.LargePhoto, Product.ListPrice FROM Production.ProductModel INNER JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID INNER JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID INNER JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID WHERE Product.ProductModelID = {productModelId} ORDER BY Product.ListPrice;";
                var productModel = conn.Query<ProductModel>(sql).FirstOrDefault();
                return productModel;
            }
        }

        public static int getRandomId()
        {
            List<int> ids = new List<int>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT DISTINCT Production.Product.ProductModelID FROM Production.Product WHERE Production.Product.ProductModelID IS NOT NULL;";
                ids = conn.Query<int>(sql).ToList();
                Random rnd = new Random();
                return ids[rnd.Next(ids.Count)];
            }
        }

        public static List<Product> getProductSizes(int id)
        {
            List<Product> productSizes = new List<Product>();
            List<string> tam = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $"SELECT Production.Product.ProductID, Production.Product.Size FROM Production.Product WHERE Production.Product.ProductModelID = {id};";
                List<Product> sizes = conn.Query<Product>(sql).ToList();
                foreach (var s in sizes)
                {
                    bool duplicate = false;
                    foreach (Product product in productSizes)
                    {
                        if (s.Size == product.Size)
                        {
                            duplicate = true;
                            break;
                        }
                    }
                    if (!duplicate)
                    {
                        productSizes.Add(s);
                    }
                }
                return productSizes;
            }
        }
    }
}
