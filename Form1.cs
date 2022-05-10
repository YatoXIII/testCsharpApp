using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЦВД_тестовоеЗадание
{
    public partial class Form1 : Form
    {
        dataBaseTestData db;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new dataBaseTestData("db.accdb");
            refreshProperties();
        }

        private void refreshProperties()
        {
            addTestData.Enabled = !db.tablesExists();
        }

        private void addTestData_Click(object sender, EventArgs e)
        {
            db.createTestData();
            refreshProperties();
        }

        private void depSalaryButton_Click(object sender, EventArgs e)
        {
            DataTable tempData = db.getDepSalaryData(showChief.Checked);
            depSalary.DataSource = tempData;
            refreshHeaderTextColumns(depSalary);
        }

        private void maxDepSalaryButton_Click(object sender, EventArgs e)
        {
            DataTable tempData = db.getMaxDepSalaryData();
            maxDepSalary.DataSource = tempData;
            refreshHeaderTextColumns(maxDepSalary);
        }

        private void chiefSalaryButton_Click(object sender, EventArgs e)
        {
            DataTable tempData = db.getChiefsSalaryData();
            chiefSalary.DataSource = tempData;
            refreshHeaderTextColumns(chiefSalary);
        }

        private void refreshHeaderTextColumns(DataGridView dgv)
        {
            Dictionary<string, string> dictionaryColumnNames = new Dictionary<string, string>()
            {
                {"id", "ID"},
                {"name", "Имя сотрудника"},
                {"dep_name", "Наименование департамента"},
                {"salary", "З/П"},
                {"chief_name", "Имя руководителя"}
            };

            foreach (DataGridViewColumn dgvColumn in dgv.Columns)
            {
                dgvColumn.HeaderText = dictionaryColumnNames[dgvColumn.Name];  
            }
        }
    }
}
