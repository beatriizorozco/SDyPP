namespace SoapDemoApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnAddInteger = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSystemInfo = new System.Windows.Forms.Button();
            this.btnLookupCity = new System.Windows.Forms.Button();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.btnGetByName = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnMission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(43, 26);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(43, 63);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(120, 95);
            this.lstOutput.TabIndex = 1;
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(217, 93);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(75, 23);
            this.btnSayHello.TabIndex = 2;
            this.btnSayHello.Text = "SayHello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnAddInteger
            // 
            this.btnAddInteger.Location = new System.Drawing.Point(333, 93);
            this.btnAddInteger.Name = "btnAddInteger";
            this.btnAddInteger.Size = new System.Drawing.Size(75, 23);
            this.btnAddInteger.TabIndex = 3;
            this.btnAddInteger.Text = "AddInteger";
            this.btnAddInteger.UseVisualStyleBackColor = true;
            this.btnAddInteger.Click += new System.EventHandler(this.btnAddInteger_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(217, 135);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "DivideInteger";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnSystemInfo
            // 
            this.btnSystemInfo.Location = new System.Drawing.Point(333, 185);
            this.btnSystemInfo.Name = "btnSystemInfo";
            this.btnSystemInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSystemInfo.TabIndex = 7;
            this.btnSystemInfo.Text = "SystemInfo";
            this.btnSystemInfo.UseVisualStyleBackColor = true;
            this.btnSystemInfo.Click += new System.EventHandler(this.btnSystemInfo_Click);
            // 
            // btnLookupCity
            // 
            this.btnLookupCity.Location = new System.Drawing.Point(217, 243);
            this.btnLookupCity.Name = "btnLookupCity";
            this.btnLookupCity.Size = new System.Drawing.Size(75, 23);
            this.btnLookupCity.TabIndex = 8;
            this.btnLookupCity.Text = "LookupCity";
            this.btnLookupCity.UseVisualStyleBackColor = true;
            this.btnLookupCity.Click += new System.EventHandler(this.btnLookupCity_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Location = new System.Drawing.Point(333, 243);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(75, 23);
            this.btnFindPerson.TabIndex = 9;
            this.btnFindPerson.Text = "FindPerson";
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // btnGetByName
            // 
            this.btnGetByName.Location = new System.Drawing.Point(217, 296);
            this.btnGetByName.Name = "btnGetByName";
            this.btnGetByName.Size = new System.Drawing.Size(75, 23);
            this.btnGetByName.TabIndex = 10;
            this.btnGetByName.Text = "GetByName";
            this.btnGetByName.UseVisualStyleBackColor = true;
            this.btnGetByName.Click += new System.EventHandler(this.btnGetByName_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(333, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(333, 135);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 12;
            this.btnReverse.Text = "ReverseString";
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // btnMission
            // 
            this.btnMission.Location = new System.Drawing.Point(217, 185);
            this.btnMission.Name = "btnMission";
            this.btnMission.Size = new System.Drawing.Size(75, 23);
            this.btnMission.TabIndex = 13;
            this.btnMission.Text = "Mission";
            this.btnMission.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMission);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetByName);
            this.Controls.Add(this.btnFindPerson);
            this.Controls.Add(this.btnLookupCity);
            this.Controls.Add(this.btnSystemInfo);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnAddInteger);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnAddInteger;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSystemInfo;
        private System.Windows.Forms.Button btnLookupCity;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button btnGetByName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnMission;
    }
}

