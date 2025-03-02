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
    public partial class Division : Form
    {
        int n = 0;

        public Division()
        {
            InitializeComponent();
        }

        private DataTable CurrentDataTable
        {
            get
            {
                return Form1.VS.Tables["Division"];
            }
        }

        private void ClearFields()
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            maskedTextBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;

            textBox1.Enabled = true;
        }

        private void RenderFieldValues()
        {
            textBox1.Text = CurrentDataTable.Rows[n]["id"].ToString();
            textBox2.Text = CurrentDataTable.Rows[n]["name"].ToString();
            textBox3.Text = CurrentDataTable.Rows[n]["short_name"].ToString();
            textBox4.Text = CurrentDataTable.Rows[n]["code"].ToString();
            textBox5.Text = CurrentDataTable.Rows[n]["acivity_type"].ToString();
            maskedTextBox1.Text = CurrentDataTable.Rows[n]["email"].ToString();
            comboBox1.Text = CurrentDataTable.Rows[n]["CompanyName"].ToString();
            textBox1.Enabled = false;

            if (CurrentDataTable.Rows[n]["changed_email"].ToString() == "")
            {
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker1.Checked = false;
                dateTimePicker1.ShowCheckBox = true;
            }
            else {
                dateTimePicker1.Value = DateTime.Parse(CurrentDataTable.Rows[n]["changed_email"].ToString());
            }
        }

        private void Division_Load(object sender, EventArgs e)
        {
            Form1.VS.Tables["Company"].DefaultView.Sort = "name";
            comboBox1.DataSource = Form1.VS.Tables["Company"].DefaultView;
            comboBox1.DisplayMember = "name";

            if (CurrentDataTable.Rows.Count > 0)
            {
                n = 0;
                RenderFieldValues();
            }
            else
            {
                textBox1.Enabled = true;
            }
        }

        private void GoToStart(object sender, EventArgs e)
        {
            this.n = 0;
            this.RenderFieldValues();
        }

        private void GoToPrevious(object sender, EventArgs e)
        {
            if (n > 0)
            {
                n--;
                this.RenderFieldValues();
            }
        }

        private void GoToNext(object sender, EventArgs e)
        {
            if (n < CurrentDataTable.Rows.Count)
            {
                n++;
            }
            if (CurrentDataTable.Rows.Count > n)
            {
                this.RenderFieldValues();
            }
            else
            {
                this.ClearFields();
            }
        }

        private void GoToEnd(object sender, EventArgs e)
        {
            this.n = CurrentDataTable.Rows.Count;
            this.ClearFields();
        }

        private void UpdateOrCreate(object sender, EventArgs e)
        {
            string query;
            string validatedDate = "NULL";
            var selectedCompanyId = Convert.ToInt32(((DataRowView)comboBox1.SelectedItem).Row["id"]);

            if (!dateTimePicker1.Checked && maskedTextBox1.Text.Trim() != "")
            {
                validatedDate = DateTime.Now.ToString("yyyy-MM-dd");
            }

            if (dateTimePicker1.Checked || maskedTextBox1.Text != "")
            {
                validatedDate = $"'{dateTimePicker1.Value.ToString("yyyy-MM-dd")}'";
                
            }

            if (n < CurrentDataTable.Rows.Count)
            {
                query = "update division set"
                    + $" name='{textBox2.Text}', short_name='{textBox3.Text}', code='{textBox4.Text}',"
                    + $" acivity_type='{textBox4.Text}', email='{maskedTextBox1.Text}', changed_email={validatedDate}, company_id={selectedCompanyId}"
                    + $" where id={textBox1.Text}";

                if (!Form1.ExecuteQuery(query)) return;

                CurrentDataTable.Rows[n].ItemArray = new object[] {
                    textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                    textBox5.Text, maskedTextBox1.Text, dateTimePicker1.Text, selectedCompanyId, comboBox1.Text
                };

                if (validatedDate != "NULL")
                {
                    dateTimePicker1.Checked = true;
                }

                return;
            }

            query = "insert into division (id, name, short_name, code, acivity_type, email, changed_email, company_id)"
                + $" values ({textBox1.Text}, '{textBox2.Text}', '{textBox3.Text}',"
                + $"'{textBox4.Text}', '{textBox5.Text}', '{maskedTextBox1.Text}', {validatedDate}, {selectedCompanyId})";

            if (!Form1.ExecuteQuery(query)) return;

            CurrentDataTable.Rows.Add(new object[] {
                textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                textBox5.Text, maskedTextBox1.Text, dateTimePicker1.Text, selectedCompanyId, comboBox1.Text
            });


            if (validatedDate != "NULL")
            {
                dateTimePicker1.Checked = true;
            }

            textBox1.Enabled = false;
        }

        private void DeleteRow(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Вы точно хотите удалить из картотеки подразделение с кодом {textBox1.Text}?",
                "Удаление предприятия",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.No) return;

            string query = $"delete from division where id={textBox1.Text}";

            if (!Form1.ExecuteQuery(query)) return;

            try
            {
                CurrentDataTable.Rows.RemoveAt(n);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Удаление не было выполнено из-за указания несуществующего экземпляра!", "Ошибка!");
                return;
            }

            if (CurrentDataTable.Rows.Count > n)
            {
                RenderFieldValues();
            }
            else
            {
                ClearFields();
            }
        }
    }
}
