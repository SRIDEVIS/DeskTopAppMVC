using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestSharp;

namespace WindowsFormsApplication1
{
    public partial class DesktopExe : Form
    {
        public DesktopExe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client =new  RestClient("http://localhost:23033/");
            var request = new RestRequest("Home/GetCustomers/{id}", Method.POST);
            request.AddParameter("id", 1);
            var response = client.Execute(request);
            MessageBox.Show(response.Content); // raw content as string
        }
    }
}
