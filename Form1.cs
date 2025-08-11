using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagerTab.Repositories;

namespace TaskManagerTab
{
    public partial class frmTaskManager : Form
    {
        private readonly ITaskRepository _taskRepo;

        const int showLeftPos = 367;
        public frmTaskManager()
        {
            InitializeComponent();
            _taskRepo = new SqlTaskRespository();

            dataGridView1.ReadOnly = true; // Make DataGridView read-only
            dataGridView1.RowHeadersVisible = false; // Hide row headers
            dataGridView1.AllowUserToAddRows = false; // Disable adding new rows
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select full rows
            dataGridView1.MultiSelect = true; // Allow multiple row selection

            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete; // Handle DataBindingComplete event to select the last row
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowGrid();
            btnhide.Enabled = true;
            btnShow.Enabled = false;
            var dt = _taskRepo.GetAll();
            dataGridView1.DataSource = dt;

            // hide all other columns

            dataGridView1.Columns["Description"].Visible = false;
            dataGridView1.Columns["Expected_Date"].Visible = false;
            dataGridView1.Columns["Expected_Hours"].Visible = false;
            dataGridView1.Columns[5].Width = 250;
        }
        public void ShowGrid()
        {
            while (gvpanel.Left > showLeftPos)
            {
                gvpanel.Left = gvpanel.Left - 10;
            }
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            HideGrid();
            btnhide.Enabled = false;
            btnShow.Enabled = true;
        }
        public void HideGrid()
        {
            while (gvpanel.Left < Mainpanel.Width + 20)
            {
                gvpanel.Left = gvpanel.Left + 10;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaskManager_Load(object sender, EventArgs e)
        {
            var dt = _taskRepo.GetAll();
            dataGridView1.DataSource = dt;

            // hide all other columns
            dataGridView1.Columns["Description"].Visible = false;
            dataGridView1.Columns["Expected_Date"].Visible = false;
            dataGridView1.Columns["Expected_Hours"].Visible = false;
            dataGridView1.Columns[5].Width = 250;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SelectLastRealRow();
        }
        private void SelectLastRealRow()
        {
            if (dataGridView1.Rows.Count == 0) return;

            int lastIndex = dataGridView1.Rows.Count - 1;

            // If the last row is the placeholder new row, step back
            if (dataGridView1.AllowUserToAddRows && dataGridView1.Rows[lastIndex].IsNewRow)
            {
                lastIndex--;
            }

            if (lastIndex < 0) return;

            dataGridView1.ClearSelection();
            dataGridView1.Rows[lastIndex].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = lastIndex;
        }
    }
}
