using FastFood.Config;
using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DAL
{
    public class AccountDAL
    {
        private static readonly FastFoodDB db = new FastFoodDB();

        public int AddAccount(Account account)
        {
            db.Accounts.Add(account);
            return db.SaveChanges();
        }

        public int UpdateAccount(Account account)
        {
            Account existingAccount = db.Accounts.FirstOrDefault(a => a.AccountId == account.AccountId);
            if (existingAccount != null)
            {
                existingAccount.Name = account.Name;
                existingAccount.Username = account.Username;
                existingAccount.PhoneNumber = account.PhoneNumber;
                return db.SaveChanges();
            }
            else
            {
                throw new Exception("Account not found");
            }
        }

        public int DeleteAccount(Account account)
        {
            Account existingAccount = db.Accounts.FirstOrDefault(f => f.AccountId == account.AccountId);
            if (existingAccount != null)
            {
                db.Accounts.Remove(existingAccount);
                return db.SaveChanges();
            }
            else
            {
                throw new Exception("Account not found");
            }
        }

        public int ChangePassword(Account account)
        {
            Account existingAccount = db.Accounts.FirstOrDefault(a => a.AccountId == account.AccountId);
            if (existingAccount != null)
            {
                existingAccount.Password = account.Password;
                return db.SaveChanges();
            }
            return 0;
        }

        public Account GetAccountById(int accountId)
        {
            return db.Accounts.FirstOrDefault(a => a.AccountId == accountId);
        }
        public Account GetAccountByUsername(string username)
        {
            return db.Accounts.FirstOrDefault(a => a.Username == username);
        }

        public List<FindAccount> GetAccountsByNameAndPhoneNumber(string name, string phoneNumber)
        {
            return db.Accounts.Where(a => (string.IsNullOrEmpty(name)
            || a.Name.Contains(name)) && (string.IsNullOrEmpty(phoneNumber)
            || a.PhoneNumber.Contains(phoneNumber)))
            .Select(a => new FindAccount
            {
                AccountId = a.AccountId,
                UserName = a.Username,
                Name = a.Name,
                PhoneNumber = a.PhoneNumber,
                CreatedAt = a.CreatedAt,
                Role = a.Role
            }).ToList();
        }

        public bool IsExistUsername(string username)
        {
            return db.Accounts.FirstOrDefault(a => a.Username == username) != null;
        }
    }
}
