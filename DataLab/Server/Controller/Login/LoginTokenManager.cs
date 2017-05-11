using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Server.Controller.Login
{
    public class LoginTokenManager : TokenManager<LoginToken>
    {
        public LoginTokenManager() : base(TimeSpan.FromDays(1))
        {

        }

        public int clearTokens(string username)
        {
            return Tokens.RemoveAll(t => t.ValidUntil < DateTime.Now);
        }

        public bool isValid(string username, int tokenID, string deviceID)
        {
            return Tokens.Where(t => t.UserName == username && t.ID == tokenID && t.DeviceID == deviceID ).Count() == 1;
        }

        public List<LoginToken> getActiveTokens(string username)
        {
            return Tokens.Where(t => t.UserName == username).ToList();
        }

        public LoginToken createToken(string deviceID, string username)
        {
            LoginToken token = new LoginToken(getUID(), _standardLeaseTime, username, deviceID);
            Tokens.Add(token);

            return token;
        }
        
    }
}
