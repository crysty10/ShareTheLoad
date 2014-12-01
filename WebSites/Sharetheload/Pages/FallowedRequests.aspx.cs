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
        List<Suscription> allRequests = SubscriptionWrapper.getAllSuscriptions(5);
        int rows = allRequests.Count;

        table.Controls.Clear();
        for (int i = 0; i < rows; i++)
        {
            TableRow rowNew = new TableRow();
            table.Controls.Add(rowNew);

            for (int j = 0; j < 1; j++)
            {
                foreach (Suscription suscription in allRequests)
                {
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
    }
}