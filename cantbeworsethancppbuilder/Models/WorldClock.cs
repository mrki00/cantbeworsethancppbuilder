using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantbeworsethancppbuilder.Models
{
    public class WorldClock
    {
        [JsonProperty("currentDateTime")]
        public string CurrentDateTime { get; set; }

        [JsonProperty("utcOffset")]
        public DateTimeOffset UtcOffset { get; set; }

        [JsonProperty("isDayLightSavingsTime")]
        public bool IsDayLightSavingsTime { get; set; }

        [JsonProperty("dayOfTheWeek")]
        public string DayOfTheWeek { get; set; }

        [JsonProperty("ordinalDate")]
        public string OrdinalDate { get; set; }
    }
}
