using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inkomstenbelasting
{
    public partial class Form1 : Form
    {
        private Tariffgroup _newTariffgroup1, _newTariffgroup2, _newTariffgroup3, _newTariffgroup4, _newTariffgroup5;
        private List<Tariffgroup> tariffgroupsList;
        private double taxableSum;
        private double incomeTax;
        private double incomeTaxLevel4 = 0.60;
        private double incomeTaxLevel3 = 0.50;
        private double incomeTaxLevel2 = 0.3705;
        private double incomeTaxLevel1 = 0.3575;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _newTariffgroup1 = new Tariffgroup("tariefgroep 1", 419, 0.12, 6704);
            _newTariffgroup2 = new Tariffgroup("tariefgroep 2", 8799, 0.12, 6704);
            _newTariffgroup3 = new Tariffgroup("tariefgroep 3", 17179, 0.12, 6704);
            _newTariffgroup4 = new Tariffgroup("tariefgroep 4", 15503, 0.12, 6704);
            _newTariffgroup5 = new Tariffgroup("tariefgroep 5", 15503, 0.12, 6704);

            tariffgroupsList = new List<Tariffgroup>();

            tariffgroupsList.Add(_newTariffgroup1);
            tariffgroupsList.Add(_newTariffgroup2);
            tariffgroupsList.Add(_newTariffgroup3);
            tariffgroupsList.Add(_newTariffgroup4);
            tariffgroupsList.Add(_newTariffgroup5);

            // Displays name property
            listBoxTariffgroup.DataSource = tariffgroupsList;
            listBoxTariffgroup.DisplayMember = "Info";
            

            // Displays calculation, total
            labelTicketsTotal.Text = $@"belastbaar inkomen - (tariefgroep + belastbaar inkomen * extra)";
            labelPriceTotal.Text = $@"belastbare som: € {Math.Round(incomeTax, 2):N2},-";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            Tariffgroup tempTariffgroup = (Tariffgroup)listBoxTariffgroup.SelectedItem;
            taxableSum = 0;
            incomeTax = 0;
            double extra = 0;
            double level = 0;
            double percentage = 1;
            bool level1 = false;
            bool level2 = false;
            bool level3 = false;

            // Checks if input is valid
            if (double.TryParse(textBoxIncome.Text, out double resultIncome) && resultIncome > 0)
            {
                // Checks if income is smaller then tariffgroup
                if (resultIncome > tempTariffgroup.TaxFreeSum)
                {
                    // Checks if income * extra = value if so sets value 
                    if (resultIncome * tempTariffgroup.Extra <= tempTariffgroup.ExtraMax)
                    {
                        extra = resultIncome * tempTariffgroup.Extra;
                    }
                    else
                    {
                        extra = tempTariffgroup.ExtraMax;
                    }
                    
                    taxableSum = resultIncome - (tempTariffgroup.TaxFreeSum + extra);

                    // Checks which level table sum is in and check which calculations must be made
                    if (taxableSum > 54001)
                    {
                        level3 = true;
                        level2 = true;
                        level1 = true;
                        level = 54000;
                        percentage = 0.60;

                        incomeTax += (taxableSum - level) * percentage;
                    }

                    if (taxableSum < 54000 && taxableSum >= 25001 || level3)
                    {
                        level2 = true;
                        level1 = true;
                        level = 25000;
                        percentage = 0.50;

                        if (level3)
                        {
                            incomeTax += (54001 - 25000) * percentage;
                        }
                        else
                        {
                            incomeTax += (taxableSum - level) * percentage;
                        }
                    }

                    if (taxableSum < 25000 && taxableSum >= 8001 || level2)
                    {
                        level1 = true;
                        level = 8000;
                        percentage = 0.3705;

                        if (level2)
                        {
                            incomeTax += (25000 - 8000) * percentage;
                        }
                        else
                        {
                            incomeTax += (taxableSum - level) * percentage;
                        }
                    }

                    if (taxableSum < 8000 || level1)
                    {
                        percentage = 0.3575;
                        
                        incomeTax += 8000 * percentage;
                    }

                    // Displays calculation, total
                    labelTicketsTotal.Text = $"((belastbaar inkomen € {resultIncome} - \n(tariefgroep € {tempTariffgroup.TaxFreeSum} + belastbaar inkomen € {resultIncome} * extra {tempTariffgroup.Extra*100}%)) - level € {level}) * percentage {percentage * 100}%";
                    labelPriceTotal.Text = $@"belastbare som: € {Math.Round(incomeTax, 2):0,00},-";
                }
                else
                {
                    MessageBox.Show($@"Income must be greater then tariffgroup");
                }
            }
            else
            {
                MessageBox.Show($@"Income must contain only numbers > 0");
            }
        }
    }
}
