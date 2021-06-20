using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPOC.Domain.Models
{
    public class TokenModel
    {
        public string token { get; set; }
        public DateTime expiration { get; set; }
    }

}
