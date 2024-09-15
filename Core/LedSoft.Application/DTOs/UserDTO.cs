using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public string? Decleration { get; set; }

        public int? Groupid { get; set; }

        public bool? Aktif { get; set; }

        public bool? Showmenu { get; set; }

        public bool? AllowUsermanagement { get; set; }

        public bool? AllowMobileusermanagement { get; set; }

        public bool? AllowProjectmanagement { get; set; }

        public string? EmailSmtpServer { get; set; }

        public int? EmailSmtpPort { get; set; }

        public string? EmailUsername { get; set; }

        public string? EmailPassword { get; set; }

        public string? EmailAddress { get; set; }

        public string? EmailName { get; set; }

        public bool? EmailUsessl { get; set; }

        public bool? Mobileuser { get; set; }

        public long? Mobilelicenceid { get; set; }

        public bool? AllowViewlog { get; set; }

        public bool? Changepassword { get; set; }

        public bool? AllowDesktoplogin { get; set; }

        public bool? AllowWeblogin { get; set; }

        public string? Email { get; set; }

        public string? Gsm { get; set; }

        public bool? Enforcepasswordpolicy { get; set; }

        public bool? Enforcepasswordexpiration { get; set; }

        public string? Refcode { get; set; }

        public DateTime? Passworddate { get; set; }

        public string? Oldpassword { get; set; }

        public string? Oldpassword2 { get; set; }

        public bool? Disableafterfail { get; set; }

        public int? Failedcount { get; set; }

        public bool? AllowCrosslogin { get; set; }
    }
}
