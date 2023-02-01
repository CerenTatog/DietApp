using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.DAL.Entities;

namespace Diet.BLL
{
    public class UserManager
    {
        DietAppContext db = new DietAppContext();
        public static string EncryptoPassword() 
        {
            return null;
        
        }

        public static bool CheckEmailFormat() 
        {
            return true;
        
        }
    }
}
