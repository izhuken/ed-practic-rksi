using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EdPractic_Alex
{
    public partial class PinPhone : Form
    {
        private int RowId;
        private DataTable CurrentDataTable
        {
            get
            {
                return Form1.VS.Tables["PinnedPhone"];
            }
        }
        public PinPhone(int RowId)
        {
            InitializeComponent();
            this.RowId = RowId;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Form1.VS.Tables["Division"].DefaultView.Sort = "short_name";
            comboBox2.DataSource = Form1.VS.Tables["Division"].DefaultView;
            comboBox2.DisplayMember = "short_name";

            textBox1.Text = CurrentDataTable.Rows[RowId]["Номер"].ToString();
            maskedTextBox1.Text = CurrentDataTable.Rows[RowId]["Номер телефона"].ToString();
            dateTimePicker1.Value = DateTime.Parse(CurrentDataTable.Rows[RowId]["Дата прикрепления"].ToString());
            comboBox2.Text = CurrentDataTable.Rows[RowId]["Название подразделения"].ToString();
        }

        private void Save(object sender, EventArgs e)
        {
            string validatedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var selectedDivisionId = Convert.ToInt32(((DataRowView)comboBox2.SelectedItem).Row["id"]);
            string query = "update pinned_phone set" +
                $" phone='{maskedTextBox1.Text}', created_at='{validatedDate}'," +
                $" division_id={selectedDivisionId}" +
                $" where id={textBox1.Text}";

            if (!Form1.ExecuteQuery(query)) return;

            CurrentDataTable.Rows[RowId].ItemArray = new object[] {
                textBox1.Text, maskedTextBox1.Text, comboBox2.Text, validatedDate
            };

            Close();
        } 

    }
}
