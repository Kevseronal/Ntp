using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtpAutomation2
{
    public partial class EventProcesss : Form
    {
        public EventProcesss()
        {
            InitializeComponent();
        }

        private void EventProcesss_Load(object sender, EventArgs e)
        {
            tbxEventName.Text = a;
            tbxEventDate.Text = b;
            tbxEventFree.Text = c;
            tbxEventUnitPrice.Text = d;
            tbxEventCapacity.Text = e;
            tbxEventFaculty.Text = f;
            tbxEventDepartment.Text = g;
            tbxEventInformation.Text = h;
            tbxEventImage.Text = i;
            pbxEventImage.ImageLocation = i;
        }

        public string a, b, c, d, e, f, g, h, i,k;
    }
}
