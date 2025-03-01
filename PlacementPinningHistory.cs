using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdPractic_Alex
{
    public partial class PlacementPinningHistory : Form
    {
        public static int n = -1;

        public PlacementPinningHistory()
        {
            InitializeComponent();
        }

        private DataTable CurrentDataTable
        {
            get
            {
                return Form1.VS.Tables["PinnedPlacement"];
            }
        }

        private void PlacementPinningHistory_Load(object sender, EventArgs e)
        {
            string query;

            query = "select pp.id as \"Номер\", pp.placement as \"Местоположение\"," +
                " d.short_name as \"Название подразделения\", pp.created_at \"Дата прикрепления\"" +
                " from pinned_placement as pp" +
                " left join division as d" +
                " on d.id = pp.division_id" +
                " order by pp.created_at;";

            Form1.UpdateCache("PinnedPlacement", query);

            dataGridView1.DataSource = CurrentDataTable;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;

            var idColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Idddd" // Maps to the Id property of the Person class
            };

            dataGridView1.Columns.Add(idColumn);
        }

        private void CellFormatter(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Местоположение")
            {
                if (e.Value != null || e.Value != "")
                {
                    e.Value = PlacementManager.Normalize(e.Value.ToString());
                    e.FormattingApplied = true; 
                }
            }
        }

        private void PlacementPinningHistoryActivated(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
        }

        private void CreateNewRow(object sender, EventArgs e)
        {
            int id;
            var currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            n = dataGridView1.Rows.Count;

            if (n > 0)
            {
                id = Convert.ToInt32(dataGridView1.Rows[n - 1].Cells["Номер"].Value) + 1;
            }
            else
            {
                id = 1;
            }

            string query = "insert into" +
                " pinned_placement (id, placement, created_at, division_id)" +
                $" values ({id}, NULL, '{currentDate}', NULL)";

            Form1.ExecuteQuery(query);

            CurrentDataTable.Rows.Add(new object[] { id, null, null, currentDate });
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = dataGridView1.Rows[n].Cells[0];

            PinOffice PinPlacementForm = new(n);
            PinPlacementForm.Show();
        }

        private void UpdateRow(object sender, EventArgs e)
        {
            try
            {
                n = dataGridView1.SelectedCells[0].RowIndex;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не указана редактируемая запись таблицы!", "Ошибка!");
                return;
            }

            PinOffice PinPlacementForm = new(n);
            PinPlacementForm.Show();
        }

        private void DeleteRow(object sender, EventArgs e)
        {
            try
            {
                n = dataGridView1.SelectedCells[0].RowIndex;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не указана редактируемая запись таблицы!", "Ошибка!");
                return;
            }

            int recordId = Convert.ToInt32(dataGridView1.Rows[n].Cells["Номер"].Value);

            if (MessageBox.Show(
                $"Вы точно хотите удалить закрепленное местоположение с номером {recordId}?",
                "Удаление закрепления местоположения",
                MessageBoxButtons.YesNo
            ) == DialogResult.No)
            {
                return;
            }

            string query = $"delete from pinned_placement where id = {recordId}";
            Form1.ExecuteQuery(query);

            CurrentDataTable.Rows.RemoveAt(n);
            dataGridView1.CurrentCell = null;
            n = -1;
        }
    }
}
