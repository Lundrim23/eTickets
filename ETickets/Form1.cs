using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ETickets
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            fillcombobox();
            Load();
            
        }

        public static string passingText;

        SqlConnection con = new SqlConnection("Data Source=Lundrim; Initial Catalog=shitja; User Id=lundi; Password=12345678");
        SqlCommand cmd;
        SqlDataReader read;
        string id;
        bool Mode = true;
        string sql;

        

        public new void Load()
        {
           
            try
            {
                sql = "select * from bileta";
                cmd = new SqlCommand(sql, con);
                con.Open();
                read = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1], read[2], read[3]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            

        }

        public void getID(String id)
        {
            sql = "select * from bileta where ID = '" + id + "'  ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                txtEmri.Text = read[1].ToString();
                comboBox2.Text = read[2].ToString();
                txtPaga.Text = read[3].ToString();
            }
            con.Close();
        }




        private void btnRuaj_Click(object sender, EventArgs e)
        {
            string emri = txtEmri.Text;
            string ulsja = comboBox2.Text;
            string pagesa = txtPaga.Text;

            if(Mode == true)
            {
                sql = "insert into bileta(Emri,Ulsja,Pagesa) values(@Emri,@Ulsja,@Pagesa)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Emri", emri);
                cmd.Parameters.AddWithValue("@Ulsja", ulsja);
                cmd.Parameters.AddWithValue("@Pagesa", pagesa);
                MessageBox.Show("Te dhenat jan shtuar");
                cmd.ExecuteNonQuery();

                txtEmri.Clear();
               // txtUlsja1.Clear();
                txtPaga.Clear();
                txtEmri.Focus();
            }
            else
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "update bileta set Emri = @Emri, Ulsja= @Ulsja,Pagesa = @Pagesa where ID = @ID";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Emri", emri);
                cmd.Parameters.AddWithValue("@Ulsja", ulsja);
                cmd.Parameters.AddWithValue("@Pagesa", pagesa);
                cmd.Parameters.AddWithValue("@ID", id);
                MessageBox.Show("Ndryshimet jan pranuar");
                cmd.ExecuteNonQuery();

                txtEmri.Clear();
               // txtUlsja1.Clear();
                txtPaga.Clear();
                txtEmri.Focus();
                btnRuaj.Text = "Ruaj";
                Mode = true;
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Ndrysho"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getID(id);
                btnRuaj.Text = "Ndrysho";

            }
            else if (e.ColumnIndex == dataGridView1.Columns["Fshi"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from bileta where ID  = @ID ";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID ", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Te dhenat jan fshi");
                con.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void btnPastro_Click(object sender, EventArgs e)
        {
            
                txtEmri.Clear();
               // txtUlsja1.Clear();
                txtPaga.Clear();
                txtEmri.Focus();
                btnRuaj.Text = "Ruaj";
                Mode = true;
            
        }

        private void btnUlset_Click(object sender, EventArgs e)
        {
            SeatChart sc = new SeatChart();
            sc.Show();
        }
         public void fillcombobox()
        {
            SqlConnection con = new SqlConnection("Data Source=Lundrim; Initial Catalog=Produktet; User Id=lundi; Password=12345678");
            string sql = "select * from UlsetCmimet";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreander;
            this.comboBox2.DataSource = null;
            this.comboBox2.Items.Clear();
            try
            {
                con.Open();
                myreander = cmd.ExecuteReader();
                while (myreander.Read())
                {
                    string ulset = myreander.GetString(1);
                    comboBox2.Items.Add(ulset);

                } 
                    
            }catch(Exception ex)
            {
                MessageBox.Show("Error ne ComboBox " , ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Lundrim; Initial Catalog=Produktet; User Id=lundi; Password=12345678");
            string sql = "select * from UlsetCmimet where Ulset = '"+comboBox2.Text+"';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreander;
           // this.comboBox2.DataSource = null;
           // this.comboBox2.Items.Clear();
            try
            {
                con.Open();
                myreander = cmd.ExecuteReader();
                while (myreander.Read())
                {
                    string produktet = myreander.GetInt32(0).ToString();
                    string ulset = myreander.GetString(1);
                    string cmimet = myreander.GetString(2);
                    comboBox2.Text = ulset;
                    txtPaga.Text = cmimet + "€";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ne selektimin", ex.Message);
            }
        }

        private void btnPaguaj_Click(object sender, EventArgs e)
        {



            passingText = txtPaga.Text;
            Pagesa pagesa = new Pagesa();
            pagesa.Show();
        }
    }
}
