namespace DealGrabber
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.gpDetails = new System.Windows.Forms.GroupBox();
            this.btnConfigureCategories = new System.Windows.Forms.Button();
            this.btn5Search = new System.Windows.Forms.Button();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.btn4Search = new System.Windows.Forms.Button();
            this.btn3Search = new System.Windows.Forms.Button();
            this.btn2Search = new System.Windows.Forms.Button();
            this.btn1Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to deal grabber!";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(193, 20);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(238, 15);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Please enter your postal code(Canada only):";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(433, 17);
            this.txtPostalCode.MaxLength = 7;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.PlaceholderText = "PostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(110, 23);
            this.txtPostalCode.TabIndex = 2;
            this.txtPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPostalCode.TextChanged += new System.EventHandler(this.txtPostalCode_TextChanged);
            // 
            // gpDetails
            // 
            this.gpDetails.Controls.Add(this.btnConfigureCategories);
            this.gpDetails.Controls.Add(this.btn5Search);
            this.gpDetails.Controls.Add(this.btnSearchItem);
            this.gpDetails.Controls.Add(this.txtSearchItem);
            this.gpDetails.Controls.Add(this.btn4Search);
            this.gpDetails.Controls.Add(this.btn3Search);
            this.gpDetails.Controls.Add(this.btn2Search);
            this.gpDetails.Controls.Add(this.btn1Search);
            this.gpDetails.Controls.Add(this.label1);
            this.gpDetails.Enabled = false;
            this.gpDetails.Location = new System.Drawing.Point(12, 54);
            this.gpDetails.Name = "gpDetails";
            this.gpDetails.Size = new System.Drawing.Size(946, 116);
            this.gpDetails.TabIndex = 3;
            this.gpDetails.TabStop = false;
            this.gpDetails.Text = "Deal Details";
            // 
            // btnConfigureCategories
            // 
            this.btnConfigureCategories.Location = new System.Drawing.Point(798, 29);
            this.btnConfigureCategories.Name = "btnConfigureCategories";
            this.btnConfigureCategories.Size = new System.Drawing.Size(142, 23);
            this.btnConfigureCategories.TabIndex = 8;
            this.btnConfigureCategories.Text = "Configure Categories";
            this.btnConfigureCategories.UseVisualStyleBackColor = true;
            this.btnConfigureCategories.Click += new System.EventHandler(this.btnConfigureCategories_Click);
            // 
            // btn5Search
            // 
            this.btn5Search.Location = new System.Drawing.Point(737, 78);
            this.btn5Search.Name = "btn5Search";
            this.btn5Search.Size = new System.Drawing.Size(170, 23);
            this.btn5Search.TabIndex = 7;
            this.btn5Search.UseVisualStyleBackColor = true;
            this.btn5Search.Click += new System.EventHandler(this.btnSearchType_Click);
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Location = new System.Drawing.Point(561, 29);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(170, 23);
            this.btnSearchItem.TabIndex = 6;
            this.btnSearchItem.Text = "Search";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Location = new System.Drawing.Point(130, 29);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.PlaceholderText = "Enter a item name";
            this.txtSearchItem.Size = new System.Drawing.Size(415, 23);
            this.txtSearchItem.TabIndex = 5;
            this.txtSearchItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn4Search
            // 
            this.btn4Search.Location = new System.Drawing.Point(561, 78);
            this.btn4Search.Name = "btn4Search";
            this.btn4Search.Size = new System.Drawing.Size(170, 23);
            this.btn4Search.TabIndex = 4;
            this.btn4Search.UseVisualStyleBackColor = true;
            this.btn4Search.Click += new System.EventHandler(this.btnSearchType_Click);
            // 
            // btn3Search
            // 
            this.btn3Search.Location = new System.Drawing.Point(385, 78);
            this.btn3Search.Name = "btn3Search";
            this.btn3Search.Size = new System.Drawing.Size(170, 23);
            this.btn3Search.TabIndex = 3;
            this.btn3Search.UseVisualStyleBackColor = true;
            this.btn3Search.Click += new System.EventHandler(this.btnSearchType_Click);
            // 
            // btn2Search
            // 
            this.btn2Search.Location = new System.Drawing.Point(209, 78);
            this.btn2Search.Name = "btn2Search";
            this.btn2Search.Size = new System.Drawing.Size(170, 23);
            this.btn2Search.TabIndex = 2;
            this.btn2Search.UseVisualStyleBackColor = true;
            this.btn2Search.Click += new System.EventHandler(this.btnSearchType_Click);
            // 
            // btn1Search
            // 
            this.btn1Search.Location = new System.Drawing.Point(33, 78);
            this.btn1Search.Name = "btn1Search";
            this.btn1Search.Size = new System.Drawing.Size(170, 23);
            this.btn1Search.TabIndex = 1;
            this.btn1Search.UseVisualStyleBackColor = true;
            this.btn1Search.Click += new System.EventHandler(this.btnSearchType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by name:";
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreName,
            this.ItemName,
            this.DateValid,
            this.DateExpired,
            this.Image,
            this.Price,
            this.Details});
            this.dgvMain.Location = new System.Drawing.Point(12, 176);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 50;
            this.dgvMain.Size = new System.Drawing.Size(946, 404);
            this.dgvMain.TabIndex = 4;
            // 
            // StoreName
            // 
            this.StoreName.DataPropertyName = "StoreName";
            this.StoreName.HeaderText = "Store Name";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            this.StoreName.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // DateValid
            // 
            this.DateValid.DataPropertyName = "DateValid";
            this.DateValid.HeaderText = "Valid";
            this.DateValid.Name = "DateValid";
            this.DateValid.ReadOnly = true;
            this.DateValid.Width = 65;
            // 
            // DateExpired
            // 
            this.DateExpired.DataPropertyName = "DateExpired";
            this.DateExpired.HeaderText = "Expire";
            this.DateExpired.Name = "DateExpired";
            this.DateExpired.ReadOnly = true;
            this.DateExpired.Width = 65;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 150;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 50;
            // 
            // Details
            // 
            this.Details.DataPropertyName = "SaleDescription";
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Location = new System.Drawing.Point(666, 20);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(42, 15);
            this.lblStatusTitle.TabIndex = 5;
            this.lblStatusTitle.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(711, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 15);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "~";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 592);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusTitle);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.gpDetails);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deal Grabber";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.gpDetails.ResumeLayout(false);
            this.gpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lbl;
        private TextBox txtPostalCode;
        private GroupBox gpDetails;
        private TextBox txtSearchItem;
        private Button btn4Search;
        private Button btn2Search;
        private Button btn1Search;
        private Label label1;
        private Button btn3Search;
        private DataGridView dgvMain;
        private Button btnSearchItem;
        private Label lblStatusTitle;
        private Label lblStatus;
        private Button btn5Search;
        private Button btnConfigureCategories;
        private DataGridViewTextBoxColumn StoreName;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn DateValid;
        private DataGridViewTextBoxColumn DateExpired;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Details;
    }
}