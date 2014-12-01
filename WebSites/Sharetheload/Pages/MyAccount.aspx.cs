using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_MyAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            InitializeFields();
        }
        user = StorageManager.user;
        add = StorageManager.add;
    }

    private UserAccount user;
    private Address add;

    private void InitializeFields()
    {
        StorageManager.user = UserAccountsWrapper.getById(3);
        user = StorageManager.user;

        UserFirstName.Text = user.FirstName;
        UserLastName.Text = user.LastName;
        UserPassword.Text = user.Password;
        UserEmail.Text = user.Email;
        UserPhone.Text = user.Phone;

        StorageManager.add = AddressWrapper.getById(user.AddressID);
        add = StorageManager.add;

        AddressCountry.Text = add.Country;
        AddressState.Text = add.State;
        AddressCity.Text = add.City;
        AddressSector.Text = add.Sector;
        AddressStreet.Text = add.Street;
        AddressNumber.Text = add.StreetNo;
        AddressBuilding.Text = add.Building;
        AddressStaircase.Text = add.Staircase;
        AddressApartment.Text = add.Apartment;
        AddressFloor.Text = add.Floor;
    }

    protected void Modify_Data(object sender, EventArgs e)
    {
        UserAccountsWrapper userWrapper = new UserAccountsWrapper();
        AddressWrapper addWrapper = new AddressWrapper();

        user.FirstName = UserFirstName.Text;
        user.LastName = UserLastName.Text;
        user.Password = UserPassword.Text;
        user.Email = UserEmail.Text;
        user.Phone = UserPhone.Text;

        add.Country = AddressCountry.Text;
        add.State = AddressState.Text;
        add.City = AddressCity.Text;
        add.Sector = AddressSector.Text;
        add.Street = AddressStreet.Text;
        add.StreetNo = AddressNumber.Text;
        add.Building = AddressBuilding.Text;
        add.Staircase = AddressStaircase.Text;
        add.Apartment = AddressApartment.Text;
        add.Floor = AddressFloor.Text;

        userWrapper.update(user);
        addWrapper.update(add);
    }
}