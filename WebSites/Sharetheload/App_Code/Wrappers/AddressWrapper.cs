using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddressWrapper
/// </summary>
public class AddressWrapper : Address
{
    public void Save()
    {
        DataClassesDataContext dc = new DataClassesDataContext();

        Address add = new Address();
        add.Country = this.Country;
        add.State = this.State;
        add.City = this.City;
        add.Sector = this.Sector;
        add.Street = this.Street;
        add.StreetNo = this.StreetNo;
        add.Building = this.Building;
        add.Staircase = this.Staircase;
        add.Apartment = this.Apartment;
        add.Floor = this.Floor;

        dc.Addresses.InsertOnSubmit(add);
        dc.SubmitChanges();
    }

    public void update(Address add)
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        Address addDate = dc.Addresses.Single(u => u.ID == add.ID);

        addDate.Country = add.Country;
        addDate.State = add.State;
        addDate.City = add.City;
        addDate.Sector = add.Sector;
        addDate.Street = add.Street;
        addDate.StreetNo = add.StreetNo;
        addDate.Building = add.Building;
        addDate.Staircase = add.Staircase;
        addDate.Apartment = add.Apartment;
        addDate.Floor = add.Floor;

        dc.SubmitChanges();
    }

    public static Address getById(int id)
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        var add = dc.Addresses.Single(u => u.ID == id);
        return add;
    }

    public static List<Address> getAll()
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        IEnumerable<Address> enume = from p in dc.Addresses select p;

        return enume.ToList();
    }
}