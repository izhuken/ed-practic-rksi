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
    public partial class PhonePinningHistory : Form
    {
        public static int n = -1;

        public PhonePinningHistory()
        {
            InitializeComponent();
        }

        private DataTable CurrentDataTable
        {
            get
            {
                return Form1.VS.Tables["PinnedPhone"];
            }
        }

        private void PhonePinningHistory_Load(object sender, EventArgs e)
        {
            string query;

            query = "select pp.id as \"Номер\", pp.phone as \"Номер телефона\"," +
                " d.short_name as \"Название подразделения\", pp.created_at \"Дата прикрепления\"" +
                " from pinned_phone as pp" +
                " left join division as d" +
                " on d.id = pp.division_id" +
                " order by pp.created_at;";

            Form1.UpdateCache("PinnedPhone", query);

            dataGridView1.DataSource = CurrentDataTable;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void PhonePinningHistoryActivated(object sender, EventArgs e)
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
                " pinned_phone (id, phone, created_at, division_id)" +
                $" values ({id}, NULL, '{currentDate}', NULL)";

            Form1.ExecuteQuery(query);

            CurrentDataTable.Rows.Add(new object[] { id, null, null, currentDate });
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = dataGridView1.Rows[n].Cells[0];

            PinPhone PinPhoneForm = new(n);
            PinPhoneForm.Show();
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

            PinPhone PinPhoneForm = new(n);
            PinPhoneForm.Show();
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
                $"Вы точно хотите удалить закрепленный телефон с номером {recordId}?",
                "Удаление закрепления телефона",
                MessageBoxButtons.YesNo
            ) == DialogResult.No)
            {
                return;
            }

            string query = $"delete from pinned_phone where id = {recordId}";
            Form1.ExecuteQuery(query);

            CurrentDataTable.Rows.RemoveAt(n);
            dataGridView1.CurrentCell = null;
            n = -1;
        }
    }
}
