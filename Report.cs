using System;
using System.Collections;
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
    // 1. на заданную дату список контактных телефонов подразделений предприятия
    // 2. на заданную дату количество подразделений, не имеющих электронные адреса
    // 3. название подразделения, у которого за заданный период сменилось наибольшее число руководителей.

    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void UpdateDivisionPhonesReport()
        {
            string validatedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string query = "select pp.id as \"Номер\", pp.phone as \"Номер телефона\"," +
                " d.short_name as \"Название подразделения\", pp.created_at \"Дата прикрепления\"" +
                " from pinned_phone as pp" +
                " left join division as d" +
                " on d.id = pp.division_id" +
                $" where pp.created_at = '{validatedDate}'" +
                " order by pp.created_at;";

            Form1.UpdateCache("PinnedPhoneReport", query);

            dataGridView1.DataSource = Form1.VS.Tables["PinnedPhoneReport"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
        }

        private void UpdateNullableEmailReport()
        {
            string validatedDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            string query = "" +
                "select count(dv.id) as \"Количетсво подразделений, не имеющих Email\"" +
                " from division as dv" +
                " where dv.changed_email is NULL" +
                $" or dv.changed_email <= '{validatedDate}';";

            Form1.UpdateCache("NullableEmailCountReport", query);

            dataGridView1.DataSource = Form1.VS.Tables["NullableEmailCountReport"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
        }

        private void UpdateDivisionWithMaxDirectorTurnover()
        {
            string validatedDateFrom = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            string validatedDateTo = dateTimePicker4.Value.ToString("yyyy-MM-dd");

            string query = "select d.id as \"Номер\", d.name as \"Наименование\", gd.changing_count as \"Кол-во смененных руководителей\"" +
                " from division as d" +
                " join (" +
                "  select " +
                "    dd.division_id," +
                "    count(dd.id) as changing_count" +
                "  from division_director as dd" +
                $"  where dd.created_at >= '{validatedDateFrom}'" +
                $"      and dd.created_at <= '{validatedDateTo}'" +
                "  group by dd.division_id" +
                "  order by changing_count desc" +
                "  limit 1" +
                " ) as gd" +
                " on gd.division_id = d.id";

            Form1.UpdateCache("MaxDirectorTurnoverReport", query);

            dataGridView1.DataSource = Form1.VS.Tables["MaxDirectorTurnoverReport"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
        }

        private void DivisionPhonesDateOnChange(object sender, EventArgs e)
        {
            this.UpdateDivisionPhonesReport();
        }

        private void ShowDivisionPhones(object sender, EventArgs e)
        {
            this.UpdateDivisionPhonesReport();
        }

        private void ShowDivisionNullableEmails(object sender, EventArgs e)
        {
            this.UpdateNullableEmailReport();
        }

        private void DivisionNullableEmailsDateOnChange(object sender, EventArgs e)
        {
            this.UpdateNullableEmailReport();
        }

        private void ShowDivisionMaxDirectorTurnover(object sender, EventArgs e)
        {
            this.UpdateDivisionWithMaxDirectorTurnover();
        }

        private void DivisionMaxDirectorTurnoverRangeOnChange(object sender, EventArgs e)
        {
            this.UpdateDivisionWithMaxDirectorTurnover();
        }

    }
}
