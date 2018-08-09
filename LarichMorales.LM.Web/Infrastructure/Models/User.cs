using LarichMorales.LM.Web.Infrastructure.Enums;
using LarichMorales.LM.Web.Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LarichMorales.LM.Web.Infrastructure.Models
{
    public class User : BaseModels
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
        public Gender Gender { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public LoginStatus LoginStatus { get; set; }
        public string RegistrationCode { get; set; }
        public int LoginTrials { get; set; }
    }
}



