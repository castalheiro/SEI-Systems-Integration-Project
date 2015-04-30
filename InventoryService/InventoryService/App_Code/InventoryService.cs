using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for InventoryService
/// </summary>
[WebService(Namespace = "http://InventoryService/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class InventoryService : System.Web.Services.WebService {

    public InventoryService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public void DecreaseStock(string category, string option)
    {
        //TODO

        while (true) { DecreaseStock("a", "b"); }
    }
    
}
