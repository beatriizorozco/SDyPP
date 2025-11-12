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
            client = new SOAPDemoSoapClient();   // SIN "Dot"
        }

        private async void btnSayHello_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtInput.Text;
                string result = await Task.Run(() => client.SayHello(name));
                lstOutput.Items.Add($"SayHello('{name}') → {result}");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async void btnAddInteger_Click(object sender, EventArgs e)
        {
            try
            {
                long a = 5, b = 7;
                long sum = await Task.Run(() => client.AddInteger(a, b)); // long
                lstOutput.Items.Add($"AddInteger({a},{b}) → {sum}");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                long a = 20, b = 3;
                long div = await Task.Run(() => client.DivideInteger(a, b)); // long
                lstOutput.Items.Add($"DivideInteger({a},{b}) → {div}");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async void btnLookupCity_Click(object sender, EventArgs e)
        {
            try
            {
                string zip = txtInput.Text;
                var addr = await Task.Run(() => client.LookupCity(zip)); // Address
                lstOutput.Items.Add("LookupCity → " + DumpObject(addr));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async void btnGetByName_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = await Task.Run(() => client.GetByName(txtInput.Text)); // DataSet
                lstOutput.Items.Add("GetByName → " + DumpDataSet(ds));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async void btnFindPerson_Click(object sender, EventArgs e)
        {
            try
            {
                var p = await Task.Run(() => client.FindPerson(5)); // Person-like
                lstOutput.Items.Add("FindPerson → " + DumpObject(p));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async void btnGetListByName_Click(object sender, EventArgs e)
        {
            try
            {
                var list = await Task.Run(() => client.GetListByName(txtInput.Text)); // array/list
                // Imprime elementos de la lista
                if (list == null) { lstOutput.Items.Add("GetListByName → (null)"); return; }
                var pretty = string.Join(" | ", list.Select(DumpObject));
                lstOutput.Items.Add("GetListByName → " + pretty);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async void btnGetDataSetByName_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = await Task.Run(() => client.GetDataSetByName(txtInput.Text)); // DataSet
                lstOutput.Items.Add("GetDataSetByName → " + DumpDataSet(ds));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async void btnQueryByName_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = await Task.Run(() => client.QueryByName(txtInput.Text)); // DataSet
                lstOutput.Items.Add("QueryByName → " + DumpDataSet(ds));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async void btnMission_Click(object sender, EventArgs e)
        {
            try
            {
                string result = await Task.Run(() => client.Mission());
                lstOutput.Items.Add($"Mission → {result}");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
        }

        // ===== Helpers =====

        private static string DumpObject(object obj)
        {
            if (obj == null) return "(null)";
            var t = obj.GetType();
            var props = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (props.Length == 0) return obj.ToString();
            var sb = new StringBuilder();
            sb.Append('{');
            sb.Append(string.Join(", ", props.Select(p =>
            {
                object v;
                try { v = p.GetValue(obj); } catch { v = "(error)"; }
                return $"{p.Name}={v}";
            })));
            sb.Append('}');
            return sb.ToString();
        }

        private static string DumpDataSet(DataSet ds, int maxRowsPerTable = 3)
        {
            if (ds == null) return "(null DataSet)";
            var sb = new StringBuilder();
            foreach (DataTable tbl in ds.Tables)
            {
                sb.Append($"[Table {tbl.TableName}]");
                var rows = tbl.Rows.Cast<DataRow>().Take(maxRowsPerTable);
                foreach (var r in rows)
                {
                    var cells = tbl.Columns.Cast<DataColumn>()
                         .Select(c => $"{c.ColumnName}={r[c]}");
                    sb.Append(" { " + string.Join(", ", cells) + " }");
                }
                sb.Append("  ");
            }
            return sb.ToString();
        }
    }
}
