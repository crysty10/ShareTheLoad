using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_FallowedRequests : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!this.IsPostBack)
        {
            InitializeFields();
        }
    }

    private void InitializeFields()
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        List<Suscription> allRequests = SubscriptionWrapper.getAllSuscriptions(3);

        table.Controls.Clear();
        foreach (Suscription suscription in allRequests)
        {
            TableRow rowNew = new TableRow();
            table.Controls.Add(rowNew);

            var reqID = suscription.RequestID;
            Request request = RequestWrapper.getById(reqID);
            TableCell cellNew = new TableCell();
            Label lblNew = new Label();

            lblNew.Text = request.Title + " " + request.StartDate + " " + request.EndDate + " "
                                    + request.MinUsers + " " + request.MaxUsers + " " + request.City + " "
                                    + request.State + " " + request.Sector + " " + request.Street + " "
                                    + request.Status + "<br />";

            cellNew.Controls.Add(lblNew);
            rowNew.Controls.Add(cellNew);
        }
    }
}