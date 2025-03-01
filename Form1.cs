using Npgsql;
using System.Data;

namespace EdPractic_Alex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static NpgsqlConnection connection = new("Server=188.120.248.105; UserId = postgresql; Password=postgresql; Database=ed_practic;");
        public static DataSet VS = new();

        public static void UpdateCache(string name, string query)
        {
            if (VS.Tables[name] != null)
            {
                VS.Tables[name].Clear();
            }

            var DA = new NpgsqlDataAdapter(query, connection);
            DA.Fill(VS, name);
            connection.Close();
        }

        public static bool ExecuteQuery(string query)
        {
            NpgsqlCommand cmd = new(query, connection);
            connection.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Обновление базы не было выполнено из-за не указания обновляемых данных или несоответсвия типов!", "Ошибка!");
                connection.Close();
                return false;
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Обновление базы не было выполнено из-за попытки добавления (удаления) данных объекта с используемым кодом!", "Ошибка!");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query;

            query = "select company.id, company.name, company.short_name from company order by company.id";
            UpdateCache("Company", query);

            query = "select division.id, division.name, division.short_name, division.code, " +
                " division.acivity_type, division.email, division.changed_email, division.company_id, company.name as \"CompanyName\"" +
                " from division" +
                " join company on company.id = division.company_id" +
                " order by division.id";
            UpdateCache("Division", query);

            query = "select id, fcs, post from director order by id";
            UpdateCache("Director", query);
        }

        private void OpenCompanyForm(object sender, EventArgs e)
        {
            var CompanyForm = new Company();
            CompanyForm.Show();
        }

        private void OpenDivisionForm(object sender, EventArgs e)
        {
            var DivisionForm = new Division();
            DivisionForm.Show();
        }

        private void OpenDirectorForm(object sender, EventArgs e)
        {  
            var DirectorForm = new Director();
            DirectorForm.Show();
        }

        private void OpenPlacementPinnigForm(object sender, EventArgs e)
        {
            var PlacementPinningHistoryForm = new PlacementPinningHistory();
            PlacementPinningHistoryForm.Show();
        }

        private void OpenPhonePinnigForm(object sender, EventArgs e)
        {
            var PhonePinningHistoryForm = new PhonePinningHistory();
            PhonePinningHistoryForm.Show();
        }

        private void OpenDirectorPinnigForm(object sender, EventArgs e)
        {
            var DirectorPinningHistoryForm = new DirectorPinningHistory();
            DirectorPinningHistoryForm.Show();
        }

        private void OpenReportForm(object sender, EventArgs e)
        {
            var ReportForm = new Report();
            ReportForm.Show();
        }

        private void OpenAboutBoxForm(object sender, EventArgs e)
        {
            var AboutBoxForm = new AboutBox();
            AboutBoxForm.ShowDialog();
        }
    }
}
