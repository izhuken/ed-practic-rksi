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
    public partial class Director : Form
    {

        int n = 0;

        public Director()
        {
            InitializeComponent();
        }

        private DataTable CurrentDataTable
        {
            get
            {
                return Form1.VS.Tables["Director"];
            }
        }

        private void ClearFields()
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Enabled = true;
        }

        private void RenderFieldValues()
        {
            textBox1.Text = CurrentDataTable.Rows[n]["id"].ToString();
            textBox2.Text = CurrentDataTable.Rows[n]["fcs"].ToString();
            textBox3.Text = CurrentDataTable.Rows[n]["post"].ToString();
            textBox1.Enabled = false;
        }


        private void Director_Load(object sender, EventArgs e)
        {
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

            if (n < CurrentDataTable.Rows.Count)
            {
                query = "update director set"
                    + $" fcs='{textBox2.Text}', post='{textBox3.Text}'"
                    + $" where id={textBox1.Text}";

                if (!Form1.ExecuteQuery(query)) return;

                CurrentDataTable.Rows[n].ItemArray = new object[] {
                    textBox1.Text, textBox2.Text, textBox3.Text
                };
                return;
            }

            query = "insert into director (id, fcs, post)"
                + $" values ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}')";

            if (!Form1.ExecuteQuery(query)) return;

            CurrentDataTable.Rows.Add(new object[] {
                textBox1.Text, textBox2.Text, textBox3.Text
            });

            textBox1.Enabled = false;
        }

        private void DeleteRow(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Вы точно хотите удалить из картотеки директоров с кодом {textBox1.Text}?",
                "Удаление предприятия",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.No) return;

            string query = $"delete from director where id={textBox1.Text}";

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
