using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserAccountsWrapper
/// </summary>
public class UserAccountsWrapper : UserAccount
{
    public void Save()
    {
        DataClassesDataContext dc = new DataClassesDataContext();

        UserAccount user = new UserAccount();
        user.FirstName = this.FirstName;
        user.LastName = this.LastName;
        user.Email = this.Email;
        user.Password = this.Password;
        user.Phone = this.Phone;
        user.Address = this.Address;

        dc.UserAccounts.InsertOnSubmit(user);
        dc.SubmitChanges();
    }

    public void update(UserAccount user)
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        UserAccount userAcc = dc.UserAccounts.Single(u => u.UserID == user.UserID);

        userAcc.FirstName = user.FirstName;
        userAcc.LastName = user.LastName;
        userAcc.Email = user.Email;
        userAcc.Password = user.Password;
        userAcc.Phone = user.Phone;
        userAcc.Address = user.Address;

        dc.SubmitChanges();
    }

    public static UserAccount getById(int id)
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        var user = dc.UserAccounts.Single(u => u.UserID == id);
        return user;
    }

    public static List<UserAccount> getAll()
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        IEnumerable<UserAccount> enume = from p in dc.UserAccounts select p;

        return enume.ToList();
    }
}