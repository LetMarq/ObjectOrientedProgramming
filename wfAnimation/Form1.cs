using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace wfAnimation
{
    public partial class Form1 : Form
    { // Realiza a conexão com o banco de dados
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "animation";
        private static string Password = "0501001161";
        private static string Port = "5432";

        string connString =
                String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);

        public DataTable ExecuteSelectQuery(string sql)
        {   //Executa Query para o "Read / Select"
            var conn = new NpgsqlConnection(connString); //Pega a conexão com o banco de dados pelo NpgsqlConnection
            var command = new NpgsqlCommand(sql,conn);
            try
            {
                if (conn == null)
                {
                    return null; //caso a conexão não exista
                }

                DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet();
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataSet.Reset(); 
                dataAdapter.Fill(dataSet); //Devolve a resposta do banco
                
                if (dataSet.Tables[0] != null)
                {
                    
                    dataTable = dataSet.Tables[0];
                }

                conn.Close();
                return dataTable.Rows.Count <= 0 ? null : dataTable; //retorna a tabela 
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool ExecuteSelectQueryAll(string sql)
        { //Executa Query para o "Insert, Delete e Update"

            try
            {
                var conn = new NpgsqlConnection(connString);
                var command = new NpgsqlCommand(sql, conn);
                if (conn == null)
                {
                    
                    return false;
                }
                conn.Open();
                command.ExecuteNonQuery(); // Executa o comando no SQL
                conn.Close();
                return true;
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }



        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            dgvAnimation.DataSource = ExecuteSelectQuery("SELECT *from \"Animation\"");
            dgvAuthor.DataSource = ExecuteSelectQuery("SELECT *from \"Author\"");
            dgvGenre.DataSource = ExecuteSelectQuery("SELECT *from \"Genre\"");
            dgvStudio.DataSource = ExecuteSelectQuery("SELECT *from \"Studio\"");

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void tbScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAnimID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDelete_A_Click(object sender, EventArgs e)
        {
            ExecuteSelectQueryAll("DELETE from \"Animation\" WHERE anim_id='" + dgvAnimation.SelectedRows[0].Cells[0].Value + "'");
        }

        private void tbStudID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInsert_A_Click(object sender, EventArgs e)
        {
            ExecuteSelectQueryAll("INSERT INTO \"Animation\" (animation_name, author_id, genre_id, studio_id, realese_date, episodes_number, score)" +
                " VALUES ('" + tbAnimName.Text + "'," + tbAuthorID.Text + ","+ tbGenreID.Text +", "+ tbStudID.Text +", '"+ tbReleaseDate.Text +"', "+ tbEpNum.Text +", "+ tbScore.Text +")");
        }
        //(animation_name, author_id, genre_id, studio_id, realese_date, episodes_number, score)

        private void btUpdate_A_Click(object sender, EventArgs e)
        {
            ExecuteSelectQueryAll("UPDATE \"Animation\" SET animation_name = '" + dgvAnimation.SelectedRows[0].Cells[1].Value + "', " +
                "author_id = " + dgvAnimation.SelectedRows[0].Cells[2].Value + ", genre_id = " + dgvAnimation.SelectedRows[0].Cells[3].Value + "," +
                "studio_id = "+ dgvAnimation.SelectedRows[0].Cells[4].Value + ", realese_date = '"+ dgvAnimation.SelectedRows[0].Cells[5].Value + "', " +
                "episodes_number = "+ dgvAnimation.SelectedRows[0].Cells[6].Value + ", score = "+ dgvAnimation.SelectedRows[0].Cells[7].Value + " " +
                "WHERE anim_id = "+ dgvAnimation.SelectedRows[0].Cells[0].Value + " " 
                );
        }

        private void tbReleaseDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGenreID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAuthorFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAuthorLN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInsert_Aut_Click(object sender, EventArgs e)
        {
            ExecuteSelectQueryAll("INSERT INTO \"Author\" (first_name,last_name) VALUES ('" + tbAuthorFN.Text + "','" + tbAuthorLN.Text + "')");
        }

        private void btDelet_Aut_Click(object sender, EventArgs e)
        {
            ExecuteSelectQueryAll("DELETE from \"Author\" WHERE author_id='" + dgvAuthor.SelectedRows[0].Cells[0].Value + "'");
        }

        private void btInsert_G_Click(object sender, EventArgs e)
        {
            ExecuteSelectQueryAll("INSERT INTO \"Genre\" (genre_name) VALUES ('" + tbGenreName.Text + "')");
        }

        private void btUpdate_G_Click(object sender, EventArgs e)
        {
            ExecuteSelectQueryAll("UPDATE \"Genre\" SET genre_name = '" + dgvGenre.SelectedRows[0].Cells[1].Value + "' " +
                "WHERE genre_id = " + dgvGenre.SelectedRows[0].Cells[0].Value + " "
                );
        }

        private void btDelete_G_Click(object sender, EventArgs e)
        {
            ExecuteSelectQueryAll("DELETE from \"Genre\" WHERE genre_id='" + dgvGenre.SelectedRows[0].Cells[0].Value + "'");

        }

        private void tbGenreName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInsert_S_Click(object sender, EventArgs e)
        {
            ExecuteSelectQueryAll("INSERT INTO \"Studio\" (studio_name) VALUES ('" + tbStudioName.Text + "')");
        }

        private void btUpdate_S_Click(object sender, EventArgs e)
        {
            ExecuteSelectQueryAll("UPDATE \"Studio\" SET studio_name = '" + dgvStudio.SelectedRows[0].Cells[1].Value + "' " +
                "WHERE studio_id = " + dgvStudio.SelectedRows[0].Cells[0].Value + " "
                );
        }

        private void btDelete_S_Click(object sender, EventArgs e)
        {
            ExecuteSelectQueryAll("DELETE from \"Studio\" WHERE studio_id='" + dgvStudio.SelectedRows[0].Cells[0].Value + "'");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbStudioName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvAnimation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btRead_A_Click(object sender, EventArgs e)
        {
            dgvAnimation.DataSource = ExecuteSelectQuery("SELECT *from \"Animation\"");
        }

        private void btRead_G_Click(object sender, EventArgs e)
        {
            dgvGenre.DataSource = ExecuteSelectQuery("SELECT *from \"Genre\"");
        }

        private void btRead_S_Click(object sender, EventArgs e)
        {
            dgvStudio.DataSource = ExecuteSelectQuery("SELECT *from \"Studio\"");
        }

        private void btRead_Aut_Click(object sender, EventArgs e)
        {
            dgvAuthor.DataSource = ExecuteSelectQuery("SELECT *from \"Author\"");
        }

        private void btUpdate_Aut_Click(object sender, EventArgs e)
        {
            ExecuteSelectQueryAll("UPDATE \"Author\" SET first_name = '" + dgvAuthor.SelectedRows[0].Cells[1].Value + "', " +
                "last_name = '" + dgvAuthor.SelectedRows[0].Cells[2].Value +"' " +
                "WHERE author_id = " + dgvAuthor.SelectedRows[0].Cells[0].Value + " "
                );
        }
    }
}
