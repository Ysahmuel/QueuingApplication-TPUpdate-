using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueingApplication
{
    public partial class CustomerView : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public CustomerView()
        {
            InitializeComponent();
            timer.Interval = (3 * 1000);
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        
         void timer1_tick(object sender, EventArgs e)
        {
                this.Close();
        }

            if (CashierClass.CashierQueue.Count > 0)
            {
                string Queue = CashierClass.CashierQueue.Peek();
                lblQueue.Text = Queue;
            }
            else
            {
                lblQueue.Text = "None";
            }
            

        }
    }
}
