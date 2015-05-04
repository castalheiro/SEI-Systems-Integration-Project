using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for InventoryService
/// </summary>
[WebService(Namespace = "http://Inventory/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class InventoryService : System.Web.Services.WebService
{

    public InventoryService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public void DecreaseStock(String category, String option)
    {
        using (SqlConnection connection = new SqlConnection("Data Source=localhost; Integrated Security=SSPI; Initial Catalog=Inventory"))
        {
            connection.Open();

            // 1.  create a command object identifying the stored procedure
            //DecreaseStock is the name of the store procedure
            SqlCommand command = new SqlCommand("DecreaseStock", connection);

            // 2. set the command object so it knows to execute a stored procedure
            command.CommandType = CommandType.StoredProcedure;

            // 3. add parameters to command, which will be passed to the stored procedure
            command.Parameters.Add(new SqlParameter("@Category", category));
            command.Parameters.Add(new SqlParameter("@Option", option));

            // execute the command
            command.ExecuteNonQuery();
        }
    }
}
