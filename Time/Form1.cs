using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer tim = new Timer();
            tim.Interval = 1000;
            tim.Tick += new EventHandler(content_Tick);
            tim.Start();
        }

        public void content_Tick(object sender,EventArgs e)
        {
            if (TimeLoop.Display() != "")
                label1.Text = TimeLoop.Display();
            else
                label1.Text = "No time";
            
        }

        
    }
}
