using AlarmClockApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockApp.Models
{
    internal class ClockModel
    {
        public AlarmSettingsModel AlarmSettings { get; set; } = new AlarmSettingsModel();
        public TimeSpan CurrentTime => DateTime.Now.TimeOfDay;

        public bool AlarmOn
        {
            get => AlarmSettings.AlarmOn;
            set => AlarmSettings.AlarmOn = value;
        }

        public bool AlarmUser()
        {
            if (!AlarmOn)
            {
                return false;
            }

            var time = DateTime.Now.TimeOfDay;
            if (time.Hours == AlarmSettings.AlarmTime.Hours && time.Minutes == AlarmSettings.AlarmTime.Minutes)
            {
                return true;
            }
            return false;
        }

    }
}
