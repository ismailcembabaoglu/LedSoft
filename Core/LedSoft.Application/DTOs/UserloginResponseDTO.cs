using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class UserloginResponseDTO
    {
        public string ApiToken { get; set; }
        public UserDTO User { get; set; }
    }
}
