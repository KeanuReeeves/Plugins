using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins
{
    internal class JsonEncode
    {
        string email;
        bool valid;
        string token;

        public JsonEncode(string email, bool valid, string token)
        {
            this.Email = email;
            this.Valid = valid;
            this.Token = token;
        }

        public string Email { get => email; set => email = value; }
        public bool Valid { get => valid; set => valid = value; }
        public string Token { get => token; set => token = value; }
    }
}
