using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Constants
    {
        public class Urls
        {
            public class Goodreads
            {
                public static string Domain = "https://www.goodreads.com/";
                public static string Login = $"{Domain}/user/sign_in";
                public static string SignUp = $"{Domain}/user/sign_up";
            }
        }
    }
}
