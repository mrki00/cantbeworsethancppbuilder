using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantbeworsethancppbuilder.Models
{
    public class GetIp
    {
        [JsonProperty("ip")]
        public string IP { get; set; }
    }
}
