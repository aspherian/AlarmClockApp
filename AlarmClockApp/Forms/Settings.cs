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

namespace AlarmClockApp.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        public AlarmSettingsModel Model { get; set; }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Model == null)
            {
                return;
            }
            timeBox.Text = Model.AlarmTime.ToString(@"hh\:mm");
            AlarmText.Text = Model.AlarmMessage;
            AlarmCheckbox.Checked = Model.AlarmOn;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (TimeSpan.TryParse(timeBox.Text, out var time))
            {
                Model.AlarmTime = time;
            }
            else
            {
                MessageBox.Show("Время введено неправильно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timeBox.Focus();
                timeBox.SelectAll();
                return;
            }

            Model.AlarmMessage = AlarmText.Text;
            Model.AlarmOn = AlarmCheckbox.Checked;

            DialogResult = DialogResult.OK;
        }
    }
}
