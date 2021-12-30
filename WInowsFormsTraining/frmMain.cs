using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInowsFormsTraining
{
    public partial class frmMain : Form
    {
        private BindingSource MyDataSource = new BindingSource();
        private BindingList<ExampleModel> DataList = new BindingList<ExampleModel>();


        public frmMain()
        {
            DataList.Add(new ExampleModel() { Name = "AgeOfEmpires4", InstallFootprintGB = 50.0, ReleaseDate = new DateTime(2021, 10, 28), MetaCriticRating = 7.9 });
            DataList.Add(new ExampleModel() { Name = "Phasmaphobia", InstallFootprintGB = 18, ReleaseDate = new DateTime(2020, 9, 18), MetaCriticRating = null });
            DataList.Add(new ExampleModel() { Name = "StreetFighter5", InstallFootprintGB = 12.4, ReleaseDate = new DateTime(2016,2,16), MetaCriticRating = 3.6 });

            InitializeComponent();

            MyDataSource.DataSource = DataList;
            dgvExample.DataSource = MyDataSource;
        }

        private void btnPopupMsg_Click(object sender, EventArgs e)
        {
            var txt = txtPopupMsg.Text;

            if(string.IsNullOrWhiteSpace(txt))
            {
                MessageBox.Show( "Empty Text :(", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(txt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPopupMsg.Text = string.Empty;
            }

        }

        private void btnRadioSelect_Click(object sender, EventArgs e)
        {
            if(rdbCheese.Checked)
            {
                MessageBox.Show( "Cheese, not a bad choice", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(rdbChocolate.Checked)
            {
                MessageBox.Show("Chocolate eh? Must have a sweet tooth.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(rdbWIne.Checked)
            {
                var result = MessageBox.Show("Wine... oh.. okay", "Why?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if(result == DialogResult.Retry)
                {
                    // we can do some stuff depending on what they say
                }
                else
                {

                }
            }
            else
            {
                // This shouldn't be able to happen xD
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
