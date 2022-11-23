using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dichloroethane
{
    public class Program
    {
        static void Main() {}
    }
    public partial class Message : Form
    {
        public Message()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Run Malware?", "Dichloroethane.exe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                 MessageBox.Show("Are you sure? It overwrite the mbr so ur pc wont boot.");
        }
    }
}
