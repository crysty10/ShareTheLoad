using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_MyRequests : System.Web.UI.Page
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

        //Request req = RequestWrapper.getById(1);

        List<Request> allRequests = RequestWrapper.getAllRequests(3);
        int rows = allRequests.Count;


        table.Controls.Clear();
        for (int i = 0; i < rows; i++)
        {
            TableRow rowNew = new TableRow();
            table.Controls.Add(rowNew);

            TableCell cellNew = new TableCell();
            Label lblNew = new Label();
            foreach (Request req in allRequests)
            {
                lblNew.Text = req.Title + " " + req.StartDate + " " + req.EndDate + " "
                                    + req.MinUsers + " " + req.MaxUsers + " " + req.City + " "
                                    + req.State + " " + req.Sector + " " + req.Street + " "
                                    + req.Status + "<br />";

                cellNew.Controls.Add(lblNew);
                rowNew.Controls.Add(cellNew);
            }
        }
    }
}