namespace Mobile_Pricing
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSKU = new System.Windows.Forms.ComboBox();
            this.cmbLabor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRepairPrice = new System.Windows.Forms.Label();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.wBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnGetPrice = new System.Windows.Forms.Button();
            this.lblPartPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Site:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repair Type:";
            // 
            // cmbSKU
            // 
            this.cmbSKU.FormattingEnabled = true;
            this.cmbSKU.Items.AddRange(new object[] {
            "MobileSentrix",
            "InjuredGadgets",
            "eBay",
            "WholesaleGadgetParts"});
            this.cmbSKU.Location = new System.Drawing.Point(81, 12);
            this.cmbSKU.Name = "cmbSKU";
            this.cmbSKU.Size = new System.Drawing.Size(121, 21);
            this.cmbSKU.TabIndex = 5;
            // 
            // cmbLabor
            // 
            this.cmbLabor.FormattingEnabled = true;
            this.cmbLabor.Items.AddRange(new object[] {
            "iPhone/Android Screen",
            "iPhone/Android Battery",
            "iPhone Charging Port",
            "Android Charging Port",
            "Other"});
            this.cmbLabor.Location = new System.Drawing.Point(81, 39);
            this.cmbLabor.Name = "cmbLabor";
            this.cmbLabor.Size = new System.Drawing.Size(121, 21);
            this.cmbLabor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Repair Price:";
            // 
            // lblRepairPrice
            // 
            this.lblRepairPrice.AutoSize = true;
            this.lblRepairPrice.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairPrice.Location = new System.Drawing.Point(123, 92);
            this.lblRepairPrice.Name = "lblRepairPrice";
            this.lblRepairPrice.Size = new System.Drawing.Size(48, 28);
            this.lblRepairPrice.TabIndex = 8;
            this.lblRepairPrice.Text = "price";
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(206, 10);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(75, 23);
            this.btnPrice.TabIndex = 9;
            this.btnPrice.Text = "Navigate";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(459, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForward.Location = new System.Drawing.Point(540, 10);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 12;
            this.btnForward.Text = "-->";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // wBrowser
            // 
            this.wBrowser.AllowExternalDrop = true;
            this.wBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wBrowser.CreationProperties = null;
            this.wBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wBrowser.Location = new System.Drawing.Point(206, 39);
            this.wBrowser.Name = "wBrowser";
            this.wBrowser.Size = new System.Drawing.Size(409, 281);
            this.wBrowser.Source = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.wBrowser.TabIndex = 13;
            this.wBrowser.ZoomFactor = 1D;
            this.wBrowser.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.wBrowser_CoreWebView2InitializationCompleted);
            // 
            // btnGetPrice
            // 
            this.btnGetPrice.Enabled = false;
            this.btnGetPrice.Location = new System.Drawing.Point(3, 66);
            this.btnGetPrice.Name = "btnGetPrice";
            this.btnGetPrice.Size = new System.Drawing.Size(199, 23);
            this.btnGetPrice.TabIndex = 14;
            this.btnGetPrice.Text = " Get Price";
            this.btnGetPrice.UseVisualStyleBackColor = true;
            this.btnGetPrice.Click += new System.EventHandler(this.btnGetPrice_Click);
            // 
            // lblPartPrice
            // 
            this.lblPartPrice.AutoSize = true;
            this.lblPartPrice.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartPrice.Location = new System.Drawing.Point(123, 120);
            this.lblPartPrice.Name = "lblPartPrice";
            this.lblPartPrice.Size = new System.Drawing.Size(48, 28);
            this.lblPartPrice.TabIndex = 16;
            this.lblPartPrice.Text = "price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Part Price:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 80);
            this.label4.TabIndex = 17;
            this.label4.Text = "*Note: If the repair type is not \r\nlisted then select \"Other\" in the \r\ndropdown a" +
    "nd you will be \r\nprompted to enter a labor price\r\nwhen needed.\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 331);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPartPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetPrice);
            this.Controls.Add(this.wBrowser);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.lblRepairPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLabor);
            this.Controls.Add(this.cmbSKU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(643, 370);
            this.Name = "frmMain";
            this.Text = "Mobile Inventory Pricer";
            ((System.ComponentModel.ISupportInitialize)(this.wBrowser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSKU;
        private System.Windows.Forms.ComboBox cmbLabor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRepairPrice;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private Microsoft.Web.WebView2.WinForms.WebView2 wBrowser;
        private System.Windows.Forms.Button btnGetPrice;
        private System.Windows.Forms.Label lblPartPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

