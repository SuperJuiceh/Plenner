using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.ExchangeActiveSyncProvisioning;

namespace DataLab.Server.Controller.Login
{
    public abstract class TokenManager<T> where T: Token
    {
        protected TimeSpan _standardLeaseTime;

        public List<T> Tokens = new List<T>();

        public TokenManager(TimeSpan sLeaseTime)
        {
            _standardLeaseTime = sLeaseTime;

            new Eas​Client​Device​Information().Id.ToString(); 
        }

        public virtual T createToken(string deviceID)
        {
            T token = (T)Activator.CreateInstance(typeof(T), getUID(), _standardLeaseTime, deviceID);
            Tokens.Add(token);

            return token;
        }

        public int getUID()
        {
            int counter = 0;

            while (Tokens.Where(t => t.ID == counter).Count() == 0)
            {
                counter++;
            }

            return counter;
        }

        public bool releaseID(T t)
        {
            return Tokens.Remove(t);
        }

    }
}
