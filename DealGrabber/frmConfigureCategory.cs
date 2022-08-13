using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealGrabber
{
    public partial class frmConfigureCategory : Form
    {
        public frmConfigureCategory()
        {
            InitializeComponent();
        }

        public string Button1CategetoryName { get; set; }
        public string Button2CategetoryName { get; set; }
        public string Button3CategetoryName { get; set; }
        public string Button4CategetoryName { get; set; }
        public string Button5CategetoryName { get; set; }

        private void frmConfigureCategory_Load(object sender, EventArgs e)
        {
            gbButton1Name.Text = string.Format("Current: {0}",Button1CategetoryName);
            gbButton2Name.Text = string.Format("Current: {0}",Button2CategetoryName);
            gbButton3Name.Text = string.Format("Current: {0}",Button3CategetoryName);
            gbButton4Name.Text = string.Format("Current: {0}",Button4CategetoryName);
            gbButton5Name.Text = string.Format("Current: {0}",Button5CategetoryName);
            txtButton1Name.Text = Button1CategetoryName;
            txtButton2Name.Text = Button2CategetoryName;
            txtButton3Name.Text = Button3CategetoryName;
            txtButton4Name.Text = Button4CategetoryName;
            txtButton5Name.Text = Button5CategetoryName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmMain parent = (frmMain)this.Owner;
            parent.UpdateCategoryNames(txtButton1Name.Text, txtButton2Name.Text, txtButton3Name.Text,
                txtButton4Name.Text, txtButton5Name.Text);
            parent.SaveSettings();
            this.Close();
        }
    }
}
