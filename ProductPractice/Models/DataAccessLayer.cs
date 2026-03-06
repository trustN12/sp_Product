using Microsoft.Data.SqlClient;

namespace ProductPractice.Models;

public class DataAccessLayer
{
    private string conString;
    SqlConnection _con;
    IConfiguration _config;
}