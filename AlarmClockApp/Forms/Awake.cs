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
    public partial class Awake : Form
    {
        public AlarmSettingsModel Model { get; set; }
       
        public Awake()
        {
            InitializeComponent();
        }

        private void Awake_Load(object sender, EventArgs e)
        {
            AwakeText.Text = Model.AlarmMessage;
        }

        private void awakenButton_Click(object sender, EventArgs e)
        {
            Model.AlarmOn = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.AlarmTime += TimeSpan.FromMinutes(5);
            Close();
        }
    }
}
