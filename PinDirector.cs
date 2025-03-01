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
    public partial class PinDirector : Form
    {
        private int RowId;
        private DataTable CurrentDataTable
        {
            get
            {
                return Form1.VS.Tables["PinnedDirector"];
            }
        }

        public PinDirector(int RowId)
        {
            this.RowId = RowId;
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Form1.VS.Tables["Division"].DefaultView.Sort = "short_name";
            comboBox2.DataSource = Form1.VS.Tables["Division"].DefaultView;
            comboBox2.DisplayMember = "short_name";

            Form1.VS.Tables["Director"].DefaultView.Sort = "fcs";
            comboBox3.DataSource = Form1.VS.Tables["Director"].DefaultView;
            comboBox3.DisplayMember = "fcs";

            textBox1.Text = CurrentDataTable.Rows[RowId]["Номер"].ToString();
            dateTimePicker1.Value = DateTime.Parse(CurrentDataTable.Rows[RowId]["Дата"].ToString());
            comboBox2.Text = CurrentDataTable.Rows[RowId]["Наименование подразделения"].ToString();
            comboBox3.Text = CurrentDataTable.Rows[RowId]["ФИО директора"].ToString();
        }

        private void Save(object sender, EventArgs e)
        {
            string validatedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var selectedDivisionId = Convert.ToInt32(((DataRowView)comboBox2.SelectedItem).Row["id"]);
            var selectedDirectorId = Convert.ToInt32(((DataRowView)comboBox3.SelectedItem).Row["id"]);
            
            string query = "update division_director set" +
                $" director_id={selectedDirectorId}, division_id={selectedDivisionId}," +
                $" created_at='{validatedDate}'" +
                $" where id={textBox1.Text}";

            if (!Form1.ExecuteQuery(query)) return;

            CurrentDataTable.Rows[RowId].ItemArray = new object[] {
                textBox1.Text, comboBox3.Text, comboBox2.Text, validatedDate
            };

            Close();
        }
    }
}
