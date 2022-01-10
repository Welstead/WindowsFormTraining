using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurricanes
{
    public partial class frmMain : Form
    {
        private BindingSource MyDataSource = new BindingSource();
        private BindingList<CityModel> DataList = new BindingList<CityModel>();
        private string[] csvLines;


        private string filepath = string.Empty;
        public frmMain()
        {
            InitializeComponent();
            MyDataSource.DataSource = DataList;
            dataGridView.DataSource = MyDataSource;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                LoadFile(ofd);
                PopulateDataGridView();
            }
            catch
            {
                MessageBox.Show("Please select a valid file","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //test change
            
        }

        private void LoadFile(OpenFileDialog file)
        {
            filepath = file.FileName;
            csvLines = System.IO.File.ReadAllLines(filepath);
        }
        private void PopulateDataGridView()
        {
            for (int i = 1; i < csvLines.Length - 1; i++)
            {
                string row = csvLines[i];
                string[] data = row.Split(',');
                DataList.Add(new CityModel()
                { 
                    LatD = Convert.ToInt32(data[0]),
                    LatM = Convert.ToInt32(data[1]),
                    LatS = Convert.ToInt32(data[2]),
                    NS = data[3],
                    LonD = Convert.ToInt32(data[4]),
                    LonM = Convert.ToInt32(data[5]),
                    LonS = Convert.ToInt32(data[6]),
                    EW = data[7],
                    CityName = data[8],
                    State = data[9]
                });
            }
        }
    }
}
