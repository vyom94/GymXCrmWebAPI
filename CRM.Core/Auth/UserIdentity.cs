using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Web;

namespace CRM.Core.Auth
{
    public static class UserIdentity
    {
  
        public static IIdentity User
        {
            get
            {
                return null;
                    
                    //HttpContext.Current.User.Identity;
            }
        }

        public static bool IsAuthenticated
        {
            get
            {
                return User.IsAuthenticated;
            }
        }

        public static int? UserId
        {
            get
            {
                if (IsAuthenticated)
                {
                    ClaimsIdentity claimIdentity = new ClaimsIdentity(User);
                    var userId = claimIdentity.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value;
                    return int.Parse(userId);
                }
                else
                {
                    return null;
                }
            }
        }

        public static int? CompanyId
        {
            get
            {
                if (IsAuthenticated)
                {
                    ClaimsIdentity claimIdentity = new ClaimsIdentity(User);
                    var companyId = claimIdentity.Claims.Where(x => x.Type == "CompanyId").FirstOrDefault().Value;
                    return int.Parse(companyId);
                }
                else
                {
                    return null;
                }
            }
        }

        public static int? PersonnelId
        {
            get
            {
                if (IsAuthenticated)
                {
                    ClaimsIdentity claimIdentity = new ClaimsIdentity(User);
                    var companyId = claimIdentity.Claims.Where(x => x.Type == "PersonnelId").FirstOrDefault().Value;
                    return int.Parse(companyId);
                }
                else
                {
                    return null;
                }
            }
        }

        public static string UserName
        {
            get
            {
                if (IsAuthenticated)
                {
                    return User.Name;
                }
                else
                {
                    return "Anonymous";
                }
            }
        }

        public static string FullName
        {
            get
            {
                if (IsAuthenticated)
                {
                    ClaimsIdentity claimIdentity = new ClaimsIdentity(User);
                    var fullname = claimIdentity.Claims.Where(x => x.Type == "FullName").FirstOrDefault().Value;
                    return fullname;
                }
                else
                {
                    return "Anonymous";
                }
            }
        }



        public static int? LoginLevelId
        {
            get
            {
                if (IsAuthenticated)
                {
                    ClaimsIdentity claimIdentity = new ClaimsIdentity(User);
                    var loginLevel = claimIdentity.Claims.Where(x => x.Type == ClaimTypes.Role).FirstOrDefault().Value;
                    return int.Parse(loginLevel);
                }
                else
                {
                    return null;
                }
            }
        }

        public static string LoginLevel
        {
            get
            {
                if (IsAuthenticated)
                {
                    ClaimsIdentity claimIdentity = new ClaimsIdentity(User);
                    var loginLevel = claimIdentity.Claims.Where(x => x.Type == "LoginLevel").FirstOrDefault().Value;
                    return loginLevel;
                }
                else
                {
                    return null;
                }
            }

        }




    }
}
