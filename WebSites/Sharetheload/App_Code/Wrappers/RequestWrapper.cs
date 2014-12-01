using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RequestWrapper
/// </summary>
public class RequestWrapper : Request
{
    public void Save()
    {
        DataClassesDataContext dc = new DataClassesDataContext();

        Request req = new Request();
        req.Title = this.Title;
        req.StartDate = this.StartDate;
        req.EndDate = this.EndDate;
        req.MinUsers = this.MinUsers;
        req.MaxUsers = this.MaxUsers;
        req.City = this.City;
        req.State = this.State;
        req.Sector = this.Sector;
        req.Street = this.Street;
        req.Status = this.Status;

        dc.Requests.InsertOnSubmit(req);
        dc.SubmitChanges();
    }

    public void update(Request req)
    {
        DataClassesDataContext dc = new DataClassesDataContext();

        req.Title = this.Title;
        req.StartDate = this.StartDate;
        req.EndDate = this.EndDate;
        req.MinUsers = this.MinUsers;
        req.MaxUsers = this.MaxUsers;
        req.City = this.City;
        req.State = this.State;
        req.Sector = this.Sector;
        req.Street = this.Street;
        req.Status = this.Status;

        dc.SubmitChanges();
    }

    public static Request getById(int id)
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        var req = dc.Requests.Single(u => u.ID == id);
        return req;
    }

    public static List<Request> getAll()
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        IEnumerable<Request> enume = from p in dc.Requests select p;

        return enume.ToList();
    }
}