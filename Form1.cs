using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_Click(object sender, EventArgs e)
        {
            //DataService ds = new DataService();
            //ds.TestConnection();
            //ds.Dispose();
            using (DataService ds = new DataService())
            {
                // ds.TestConnection();
                foreach(var a in ds.GetActors())
                {
                    lst.Items.Add(String.Format("{0}: {1}", a.Id, a.LastName));
                }
            }
        }
    }
}
