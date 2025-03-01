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
    public partial class DirectorPinningHistory : Form
    {
        public int n = -1;

        public DirectorPinningHistory()
        {
            InitializeComponent();
        }

        private DataTable CurrentDataTable
        {
            get
            {
                return Form1.VS.Tables["PinnedDirector"];
            }
        }

        private void DirectorPinningHistory_Load(object sender, EventArgs e)
        {
            string query;

            query = "select dd.id as \"Номер\", dir.fcs as \"ФИО директора\"" +
                ", div.short_name as \"Наименование подразделения\", dd.created_at as \"Дата\"" +
                " from division_director as dd" +
                " left join director as dir on dir.id = dd.director_id" +
                " left join division as div on div.id = dd.division_id" +
                " order by dd.created_at";

            Form1.UpdateCache("PinnedDirector", query);

            dataGridView1.DataSource = CurrentDataTable;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void DirectorPinningHistoryActivated(object sender, EventArgs e)
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
                " division_director (id, director_id, division_id, created_at)" +
                $" values ({id}, NULL, NULL, '{currentDate}')";

            Form1.ExecuteQuery(query);

            CurrentDataTable.Rows.Add(new object[] { id, null, null, currentDate });
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = dataGridView1.Rows[n].Cells[0];

            PinDirector PinDirectorForm = new(n);
            PinDirectorForm.Show();
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

            PinDirector PinDirectorForm = new(n);
            PinDirectorForm.Show();
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
                $"Вы точно хотите удалить закрепление руководителя с номером {recordId}?",
                "Удаление закрепления руководителя",
                MessageBoxButtons.YesNo
            ) == DialogResult.No)
            {
                return;
            }

            string query = $"delete from division_director where id = {recordId}";
            Form1.ExecuteQuery(query);

            CurrentDataTable.Rows.RemoveAt(n);
            dataGridView1.CurrentCell = null;
            n = -1;
        }
    }
}
