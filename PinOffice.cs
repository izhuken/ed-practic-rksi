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
    public partial class PinOffice : Form
    {

        private int RowId;

        private DataTable CurrentDataTable
        {
            get
            {
                return Form1.VS.Tables["PinnedPlacement"];
            }
        }

        public PinOffice(int RowId)
        {
            this.RowId = RowId;
            InitializeComponent();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            Form1.VS.Tables["Division"].DefaultView.Sort = "short_name";
            comboBox2.DataSource = Form1.VS.Tables["Division"].DefaultView;
            comboBox2.DisplayMember = "short_name";

            var placement = PlacementManager.Parse(CurrentDataTable.Rows[RowId]["Местоположение"].ToString());

            textBox1.Text = CurrentDataTable.Rows[RowId]["Номер"].ToString();
            dateTimePicker1.Value = DateTime.Parse(CurrentDataTable.Rows[RowId]["Дата прикрепления"].ToString());
            comboBox2.Text = CurrentDataTable.Rows[RowId]["Название подразделения"].ToString();
            textBox2.Text = placement.city;
            textBox6.Text = placement.street;
            textBox4.Text = placement.number;
            textBox3.Text = placement.flat;
            textBox5.Text = placement.room;
        }
        
        private void Save(object sender, EventArgs e)
        {
            string validatedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var selectedDivisionId = Convert.ToInt32(((DataRowView)comboBox2.SelectedItem).Row["id"]);
            var combinedPlacement = PlacementManager.Combine(
                textBox2.Text,
                textBox6.Text,
                textBox4.Text,
                textBox3.Text,
                textBox5.Text
            );

            string query = "update pinned_placement set" +
                $" created_at='{validatedDate}', division_id={selectedDivisionId}, placement='{combinedPlacement}'" +
                $" where id={textBox1.Text}";

            if (!Form1.ExecuteQuery(query)) return;

            CurrentDataTable.Rows[RowId].ItemArray = new object[] {
                textBox1.Text, combinedPlacement, comboBox2.Text, validatedDate
            };

            Close();
        }
    }
}
