using AutomatedTellerMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Services
{
    public class CheckingAccountService
    {
        private ApplicationDbContext db;

        public CheckingAccountService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreatingCheckingAccount(string firstName, string lastName, string userId, decimal initialBalance)
        {
      
                var accountNumber = (123456 + db.CheckingAccounts.Count()).ToString().PadLeft(10, '0');
                var checkingAccount = new CheckingAccount { FirstName = firstName, LastName = lastName, AccountNumber = accountNumber, Balance = initialBalance, ApplicationUserId = userId };
                db.CheckingAccounts.Add(checkingAccount);
                db.SaveChanges();
          }

        internal void CreateCheckingAccount(string v1, string v2, string id, int v3)
        {
            throw new NotImplementedException();
        }
    }
}