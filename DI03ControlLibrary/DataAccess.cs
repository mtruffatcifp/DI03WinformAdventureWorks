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
                var productModel = conn.Query<ProductModel>($"EXEC spGetProductModelById {productModelId}").FirstOrDefault();
                return productModel;
            }
        }

        public static int getRandomId()
        {
            List<int> ids = new List<int>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                ids = conn.Query<int>("EXEC spGetAllProductModelId;").ToList();
                Random rnd = new Random();
                return ids[rnd.Next(ids.Count)];
            }
        }

        public static List<Product> getProductSizes(int productModelId)
        {
            List<Product> productSizes = new List<Product>();
            List<string> tam = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                List<Product> sizes = conn.Query<Product>($"EXEC spGetProductModelSizes {productModelId};").ToList();
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
