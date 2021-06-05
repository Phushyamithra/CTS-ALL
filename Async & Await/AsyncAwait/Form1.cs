using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<string> task = new Task<string>(getText);
            task.Start();

            text1.Text = "Proceeding....";
            string t1 = await task;
            
            text1.Text = t1;

        }

        public static string getText()
        {
            Thread.Sleep(5000);
            return "Boom Boom, Ciao !!";

        }
    }
}
