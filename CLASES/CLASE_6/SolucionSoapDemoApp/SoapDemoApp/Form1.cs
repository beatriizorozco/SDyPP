using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using SoapDemoApp.SoapDemoService; 

namespace SoapDemoApp
{
    public partial class Form1 : Form
    {
        private SOAPDemoSoapClient client;

        public Form1()
        {
            InitializeComponent();
            client = new SOAPDemoSoapClient();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = txtInput.Text;
            string result = client.SayHello(name);
            lstOutput.Items.Add($"SayHello('{name}') → {result}");
        }

        private void btnAddInteger_Click(object sender, EventArgs e)
        {
            var result = client.AddInteger(5, 7);
            lstOutput.Items.Add($"AddInteger(5,7) → {result}");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            var result = client.DivideInteger(20, 3);
            lstOutput.Items.Add($"DivideInteger(20,3) → Quotient={result.Quotient}, Remainder={result.Remainder}");
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string result = client.ReverseString(input);
            lstOutput.Items.Add($"ReverseString('{input}') → {result}");
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Add($"Mission → {client.Mission()}");
        }

        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Add($"SystemInfo → {client.SystemInfo()}");
        }

        private void btnLookupCity_Click(object sender, EventArgs e)
        {
            string zip = txtInput.Text;
            lstOutput.Items.Add($"LookupCity('{zip}') → {client.LookupCity(zip)}");
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            var person = client.FindPerson(5);
            lstOutput.Items.Add($"FindPerson(5) → {person.Name}, {person.Title}");
        }

        private void btnGetByName_Click(object sender, EventArgs e)
        {
            var person = client.GetByName(txtInput.Text);
            lstOutput.Items.Add($"GetByName('{txtInput.Text}') → {person.Name}, {person.Title}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
        }
    }
}
