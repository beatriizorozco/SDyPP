namespace SoapDemoApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstOutput;

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnAddInteger;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnLookupCity;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button btnGetByName;
        private System.Windows.Forms.Button btnGetListByName;
        private System.Windows.Forms.Button btnGetDataSetByName;
        private System.Windows.Forms.Button btnQueryByName;
        private System.Windows.Forms.Button btnMission;

        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();

            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnAddInteger = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnLookupCity = new System.Windows.Forms.Button();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.btnGetByName = new System.Windows.Forms.Button();
            this.btnGetListByName = new System.Windows.Forms.Button();
            this.btnGetDataSetByName = new System.Windows.Forms.Button();
            this.btnQueryByName = new System.Windows.Forms.Button();
            this.btnMission = new System.Windows.Forms.Button();

            this.btnClear = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(280, 23);
            this.txtInput.TabIndex = 0;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 15;
            this.lstOutput.Location = new System.Drawing.Point(12, 50);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(760, 214);
            this.lstOutput.TabIndex = 1;
            // 
            // Buttons layout
            // 
            int x = 12, y = 280, w = 150, h = 32, g = 10;

            this.btnSayHello.SetBounds(x, y, w, h);
            this.btnSayHello.Text = "SayHello";
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);

            this.btnAddInteger.SetBounds(x + (w + g), y, w, h);
            this.btnAddInteger.Text = "AddInteger";
            this.btnAddInteger.Click += new System.EventHandler(this.btnAddInteger_Click);

            this.btnDivide.SetBounds(x + 2 * (w + g), y, w, h);
            this.btnDivide.Text = "DivideInteger";
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);

            this.btnLookupCity.SetBounds(x + 3 * (w + g), y, w, h);
            this.btnLookupCity.Text = "LookupCity";
            this.btnLookupCity.Click += new System.EventHandler(this.btnLookupCity_Click);

            y += h + g;

            this.btnFindPerson.SetBounds(x, y, w, h);
            this.btnFindPerson.Text = "FindPerson";
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);

            this.btnGetByName.SetBounds(x + (w + g), y, w, h);
            this.btnGetByName.Text = "GetByName";
            this.btnGetByName.Click += new System.EventHandler(this.btnGetByName_Click);

            this.btnGetListByName.SetBounds(x + 2 * (w + g), y, w, h);
            this.btnGetListByName.Text = "GetListByName";
            this.btnGetListByName.Click += new System.EventHandler(this.btnGetListByName_Click);

            this.btnGetDataSetByName.SetBounds(x + 3 * (w + g), y, w, h);
            this.btnGetDataSetByName.Text = "GetDataSetByName";
            this.btnGetDataSetByName.Click += new System.EventHandler(this.btnGetDataSetByName_Click);

            y += h + g;

            this.btnQueryByName.SetBounds(x, y, w, h);
            this.btnQueryByName.Text = "QueryByName";
            this.btnQueryByName.Click += new System.EventHandler(this.btnQueryByName_Click);

            this.btnMission.SetBounds(x + (w + g), y, w, h);
            this.btnMission.Text = "Mission";
            this.btnMission.Click += new System.EventHandler(this.btnMission_Click);

            this.btnClear.SetBounds(x + 2 * (w + g), y, w, h);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.txtInput,
                this.lstOutput,
                this.btnSayHello,
                this.btnAddInteger,
                this.btnDivide,
                this.btnLookupCity,
                this.btnFindPerson,
                this.btnGetByName,
                this.btnGetListByName,
                this.btnGetDataSetByName,
                this.btnQueryByName,
                this.btnMission,
                this.btnClear
            });
            this.Name = "Form1";
            this.Text = "SOAP.Demo (asíncrono)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}



