using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockApp.Models
{
    public class AlarmSettingsModel
    {
        public TimeSpan AlarmTime { get; set; } = DateTime.Now.TimeOfDay;

        public string AlarmMessage { get; set; } = string.Empty;

        public bool AlarmOn { get; set; }

        public Action AlarmOff { get; set;}
    }
}
