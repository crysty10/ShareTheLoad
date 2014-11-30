using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductWrapper prod = new ProductWrapper();
        prod.Category = "Bla";
        prod.Description = "Asa da!";
        prod.Name = "Nume";
        prod.Price = "100RON";
        prod.Save();
    }
}