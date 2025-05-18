using FastFood.Config;
using FastFood.DAL;
using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class AccountBLL
    {
        private static readonly AccountDAL ad = new AccountDAL();

        private void CheckPassword(string password, string confirmPassword)
        {
            // Kiểm tra rỗng hoặc chỉ chứa khoảng trắng
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                throw new Exception("Password and Confirm password cannot be empty");
            }

            // Kiểm tra khớp mật khẩu
            if (!password.Equals(confirmPassword))
            {
                throw new Exception("Confirm password must be matched to password");
            }

            // Kiểm tra độ dài tối thiểu
            if (password.Trim().Length < 6)
            {
                throw new Exception("Password must be more than 6 characters");
            }

            // Kiểm tra không chứa khoảng trắng
            if (password.Any(char.IsWhiteSpace))
            {
                throw new Exception("Password cannot contain space");
            }
        }

        private void CheckAccount(Account account)
        {
            // Kiểm tra rỗng hoặc chỉ chứa khoảng trắng
            if (string.IsNullOrWhiteSpace(account.Username))
            {
                throw new Exception("Username cannot be empty");
            }
            // Kiểm tra không chứa khoảng trắng
            if (account.Username.Any(char.IsWhiteSpace))
            {
                throw new Exception("Username cannot contain space");
            }
        }

        public ResponseDTO Login(string username, string password)
        {
            try
            {
                Account account = ad.GetAccountByUsername(username);

                if (account == null || string.IsNullOrWhiteSpace(account.Password) || !account.Password.StartsWith("$2"))
                {
                    return new ResponseDTO
                    {
                        success = false,
                        data = null,
                        message = "Wrong username or password"
                    };
                }


                Session.SetSession(account.AccountId, account.Name, account.Role);

                return new ResponseDTO
                {
                    success = true,
                    data = null,
                    message = "Login successful"
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }

        }

        public ResponseDTO AddNewAccount (Account account, string password)
        {
            try
            {
                CheckPassword(account.Password, password);

                if (ad.IsExistUsername(account.Username))
                {
                    throw new Exception("Username is already existed");
                }
                CheckAccount(account);
                account.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(account.Password);

                int rowsAffected = ad.AddAccount(account);
                if (rowsAffected == 0)
                {
                    throw new Exception("Add account failed");
                }

                return new ResponseDTO
                {
                    success = true,
                    data = null,
                    message = "Add account successfully"
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }

        }

        public ResponseDTO UpdateAccount(Account account)
        {
            try
            {
                CheckAccount(account);
                ad.UpdateAccount(account);

                return new ResponseDTO
                {
                    success = true,
                    data = null,
                    message = "Update account successfully"
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }
        }

        public ResponseDTO DeleteAccount(Account account)
        {
            try
            {
                bool isDelete = ad.DeleteAccount(account) > 0;
                return new ResponseDTO
                {
                    success = isDelete,
                    message = isDelete ? "Delete account successfully" : "Delete account failed",
                    data = null,
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO
                {
                    success = false,
                    message = e.Message,
                    data = null
                };
            }
        }

        public ResponseDTO ChangePassword(Account account, string confirmPassword)
        {
            try
            {
                CheckPassword(account.Password, confirmPassword);
                account.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(account.Password);
                ad.ChangePassword(account);

                return new ResponseDTO
                {
                    success = true,
                    data = null,
                    message = "Change password successfully"
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }
        }
        public ResponseDTO GetAccountByNameAndPhoneNumber(string name, string phoneNumber)
        {
            try
            {
                var accounts = ad.GetAccountsByNameAndPhoneNumber(name, phoneNumber);

                return new ResponseDTO
                {
                    success = true,
                    data = accounts,
                    message = "Get account successfully"
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }
        }

        public ResponseDTO GetAccountByAccountId(int accountId)
        {
            try
            {
                var account = ad.GetAccountById(accountId);

                return new ResponseDTO
                {
                    success = true,
                    data = account,
                    message = "Get account successfully"
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }
        }

    }
}
