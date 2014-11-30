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
        Product prod = new Product();
        prod.Category = "Bla";
        prod.Description = "Asa da!";
        prod.ID = 1;
        prod.Name = "Nume";
        prod.Price = "100RON";
        prod.save();
    }
}