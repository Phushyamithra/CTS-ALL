using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_Await_usage_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btn_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(getCount);
            task.Start();

            label1.Text = "Loading and Counting Letters !!!";
            int count = await task;
            label1.Text = count.ToString();

        }

        public static int getCount()
        {

            int count = 0;
            string path = "C:\\Users\\Captain CW10\\Desktop\\TestText.txt";
            using(StreamReader reader = new StreamReader(path))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
            }
            Thread.Sleep(5000);
            return count;
        }
    }
}
