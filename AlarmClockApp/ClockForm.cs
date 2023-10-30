using AlarmClockApp.Forms;
using AlarmClockApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClockApp
{
    public partial class ClockForm : Form
    {
        ClockModel _model = new ClockModel();

        private string _initialText;

        private Awake _awake;

        public ClockForm()
        {
            InitializeComponent();
        }

        private void ClockForm_Load(object sender, EventArgs e)
        {
            _initialText = Text;
            _model.AlarmSettings.AlarmOff = () => AlarmMode();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings();
            settingsForm.Model = _model.AlarmSettings;

            if (settingsForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            AlarmMode();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            AlarmMode();
            if (_model.AlarmOn)
            {
                Text = _initialText + "(будильник заведён)";
            }
            else
            {
                Text = _initialText;
            }
            DisplayLabel.Text = _model.CurrentTime.ToString(@"hh\:mm\:ss");

            if (_model.AlarmUser())
            {
                if (_awake == null || _awake.IsDisposed)
                {
                    _awake = new Awake();
                    _awake.Model = _model.AlarmSettings;
                }

                _awake.Show();
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void AlarmMode()
        {
            if (_model.AlarmOn)
            {
                Text = _initialText + "(будильник заведён)";
            } else
            {
                Text = _initialText;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _model.AlarmOn = false;
            AlarmMode();
        }

        public void name(string name)
        {
            this.Text = name;
        }

    }
}
