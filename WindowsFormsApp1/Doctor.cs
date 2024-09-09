using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            displayDoctor();
        }

        readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOME\Documents\HospitalMS.mdf;Integrated Security=True;Connect Timeout=30");
        private void displayDoctor()
        {
            try
            {
                con.Open();
                string Query = "select * from Doctor";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandbuilder = new SqlCommandBuilder(sda);
                var ds= new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();    
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || comboBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string qurey = "insert into Doctor Values(' " + textBox1.Text + "' ,' " + comboBox1.Text + "' ,' " + textBox2.Text + "' ,' " + textBox3.Text + "' ,' " + textBox4.Text + "')";
                    SqlCommand cmd = new SqlCommand(qurey, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Entered Successfully");
                    displayDoctor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close() ;
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            displayDoctor() ;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            comboBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text== " ")
                {
                    MessageBox.Show("Enter the Doctor ID");
                }
                else
                {
                    con.Open();
                    string query = "delete from Doctor where DocId='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    displayDoctor();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || comboBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update Doctor Set Doc Title = @DocTitle, DocName = @DocName, Special = @Special, LicenseNo = @LicenseNo where DocId = @DocId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@DocTitle", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@DocName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Special", textBox3.Text);
                    cmd.Parameters.AddWithValue("@LicenseNo", textBox4.Text);
                    cmd.Parameters.AddWithValue("@DocId", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated Successfully");
                    displayDoctor();
                }
            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally { con.Close(); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
