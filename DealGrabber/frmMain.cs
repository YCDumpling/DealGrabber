//using DealGrabber.Model;
using Newtonsoft.Json;
using DealGrabber.Model;
using DealGrabber.ViewModel;
using System.Text.RegularExpressions;

namespace DealGrabber
{
    public partial class frmMain : Form
    {
        HttpClient HttpClient = new HttpClient();
        ReebeeViewModel ReebeeModel = new ReebeeViewModel();
        public frmMain()
        {
            InitializeComponent();
            InitialSetup();
        }


        private void InitialSetup()
        {
            // Add a authorization cookie to be able to send get requests.
            HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("Cookie", String.Format("Authorization={0}", "deviceID%3D%22137337599%22%2CuserID%3D%22135464679%22%2CuserSessionKey%3D%22QlJw4X1mz79VmSufkOeOE0snVNc45MUU01LAVvu1sBTZlePEqSsoiI7ctEWVE4kX%22%2CuserSessionID%3D%22135603233%22"));
            lblStatus.Text = "Please enter a valid POSTAL CODE.";
            if (txtPostalCode.Text.Length > 0)
            {
                EnableForm(true);
            }
            LoadSettings();
        }

        public void EnableForm(bool status)
        {
            if (status)
            {
                gpDetails.Enabled = true;
                dgvMain.Enabled = true;
            }
            else
            {
                gpDetails.Enabled = false;
                dgvMain.Enabled = false;
            }

        }

        private async void btnSearchItem_Click(object sender, EventArgs e)
        {
            if (txtSearchItem.TextLength == 0)
            { MessageBox.Show("Enter an valid item name!");  return; }
            await PopulateReeBeeData(txtSearchItem.Text);
        }

        public async Task PopulateReeBeeData(string searchName)
        {
            lblStatus.Text = "Loading results, please wait.";
            string url = string.Format(@"https://api.reebee.com/application/2.11/item/search?contentType=image%2Fwebp&postalCode={0}&searchTerm={1}&languageID=0", txtPostalCode.Text, searchName);
            var response = await HttpClient.GetStringAsync(url);
            var reebeeData = JsonConvert.DeserializeObject<ReebeeModel>(response);
            if (reebeeData == null)
            {
                lblStatus.Text = string.Format("Loaded. Failed to find any items of {0}",searchName);
            }
            else
            {
                ReebeeModel.ReebeeItems = reebeeData.itemSearch.search
                    .Where(x => x.item.priceInfo != null && x.item.priceInfo.price != null && x.item.priceInfo.price > 0)
                    .Select(x => new ReebeeItemViewModel(x)).ToList();
                dgvMain.DataSource = ReebeeModel.ReebeeItems.OrderByDescending(x => x.Price).ToList();
                lblStatus.Text = string.Format("Loaded. Found {0} item(s) of {1}", ReebeeModel.ReebeeItems.Count, searchName);
            }
        }

        private void btnSearchType_Click(object sender, EventArgs e)
        {
            PopulateReeBeeData(((Button)sender).Text);

        }

        private void btnConfigureCategories_Click(object sender, EventArgs e)
        {
            using (frmConfigureCategory newForm = new frmConfigureCategory())
            {
                newForm.Button1CategetoryName = btn1Search.Text;
                newForm.Button2CategetoryName = btn2Search.Text;
                newForm.Button3CategetoryName = btn3Search.Text;
                newForm.Button4CategetoryName = btn4Search.Text;
                newForm.Button5CategetoryName = btn5Search.Text;
                newForm.ShowDialog(this);
            }
        }

        public void UpdateCategoryNames(string btn1, string btn2, string btn3, string btn4, string btn5)
        {
            btn1Search.Text = btn1;
            btn2Search.Text = btn2;
            btn3Search.Text = btn3;
            btn4Search.Text = btn4;
            btn5Search.Text = btn5;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.Button1Name = btn1Search.Text;
            Properties.Settings.Default.Button2Name = btn2Search.Text;
            Properties.Settings.Default.Button3Name = btn3Search.Text;
            Properties.Settings.Default.Button4Name = btn4Search.Text;
            Properties.Settings.Default.Button5Name = btn5Search.Text;
            Properties.Settings.Default.PostalCode = txtPostalCode.Text;
            Properties.Settings.Default.Save();
        }

        public void LoadSettings()
        {
            btn1Search.Text = Properties.Settings.Default.Button1Name;
            btn2Search.Text = Properties.Settings.Default.Button2Name;
            btn3Search.Text = Properties.Settings.Default.Button3Name;
            btn4Search.Text = Properties.Settings.Default.Button4Name;
            btn5Search.Text = Properties.Settings.Default.Button5Name;
            txtPostalCode.Text = Properties.Settings.Default.PostalCode;
        }

        /// <summary>
        /// From https://stackoverflow.com/a/14942826
        /// </summary>
        /// <param name="zipCode"></param>
        /// <returns></returns>
        private bool IsCanadianZipCode(string zipCode)
        {
            var formatZipCode = zipCode.ToUpper().Trim();
            var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
            var validZipCode = true;
            if (!Regex.Match(formatZipCode, _caZipRegEx).Success)
            {
                validZipCode = false;
            }
            return validZipCode;
        }

        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (!IsCanadianZipCode(txtPostalCode.Text))
            {
                lblStatus.Text = "Invalid Postal Code.";
                EnableForm(false);
            }
            else
            {
                lblStatus.Text = "Valid Postal Code.";
                EnableForm(true);
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }
    }
}