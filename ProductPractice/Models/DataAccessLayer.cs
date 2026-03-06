using System.Data;
using Microsoft.Data.SqlClient;

namespace ProductPractice.Models;

public class DataAccessLayer
{
    private string conString;
    SqlConnection _con;
    IConfiguration _config;


    public DataAccessLayer(IConfiguration config)
    {
        _config = config;
        conString = config.GetConnectionString("ProjectConfig");
        _con = new SqlConnection(conString);
    }



    public List<Product> FetchAll()
    {
        List<Product> productList = new List<Product>();

        try
        {
            SqlCommand cmd = new SqlCommand("spProduct_GetAll", _con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);  // don't need _con.Open() when using SqlDataAdapter because Fill() automatically handles the connection.


            foreach (DataRow dr in dt.Rows)
            {
                Product p = new Product();
                
                p.ProductId = Convert.ToInt32(dr["ProductID"]);
                p.ProductName = dr["ProductName"].ToString();
                p.Category = dr["Category"].ToString();
                p.Price = Convert.ToDecimal(dr["Price"]);
                p.Quantity = Convert.ToInt32(dr["Quantity"]);
                p.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
                
                productList.Add(p);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            _con.Close();
        }

        return productList;
    }
    
}