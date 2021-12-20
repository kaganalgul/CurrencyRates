using CurrencyRatesModel;
using CurrencyRatesModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyWindowsFormsUI
{
    public partial class Form1 : Form
    {
        
        DateTime pickedTime;

        public Form1()
        {
            InitializeComponent();
            string[] currencies = { "TRY", "USD", "EUR", "AUD", "CAD", "PLN", "MXN", "JPY" };
            cboMainCurrency.Items.AddRange(currencies);
            cboTargetCurrency.Items.AddRange(currencies);
        }

        private async void btnSeeIt_Click(object sender, EventArgs e)
        {            
            pickedTime = dtpDatePicker.Value;

            Currency c = await CurrencyFactory.GetFactory().GetCurrenciesRecordingToTime(cboMainCurrency.Text, cboTargetCurrency.Text, pickedTime);

            lblResult.Text = $"{cboMainCurrency.Text} - {cboTargetCurrency.Text} = {c.ValueOfMainToTargetCurrency}";

        }
    }
}
