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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOME\Documents\HospitalMS.mdf;Integrated Security=True;Connect Timeout=30");
        private void displayDiagnosis()
        {
            try
            {
                con.Open();
                string Query = "select * from Diagnosis";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandbuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                con.Close();
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

        void DisplayPatientId()
        {
            string sql = "select * from Patient";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Patient Id", typeof(int));
                rdr = cmd.ExecuteReader();
                dataTable.Load(rdr);
                comboBox1.ValueMember = "Patient Id";
                comboBox1.DataSource = dataTable;
                con.Close();
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || comboBox1.Text == " " || textBox4.Text == " " || textBox5.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string qurey = "insert into Diagnosis Values(' " + textBox1.Text + "' ,' " + comboBox1.Text + "' ,' " + textBox4.Text + "' , ' " + textBox5.Text + "')";
                    SqlCommand cmd = new SqlCommand(qurey, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Entered Successfully");
                    displayDiagnosis();
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
                if (textBox1.Text == " " || comboBox1.Text == " " || textBox4.Text == " " || textBox5.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "UPDATE Diagnosis SET PatientId = @PatientId, DiagnosTest = @DiagnosTest, Medicine = @Medicine WHERE DiagnosId = @DiagnosId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PatientId", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@DiagnosTest", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Medicine", textBox5.Text);
                    cmd.Parameters.AddWithValue("@DiagnosId", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated Successfully");
                    displayDiagnosis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " ")
                {
                    MessageBox.Show("Enter the Diagnosis ID");
                }
                else
                {
                    con.Open();
                    string query = "delete from Diagnosis where DiagnosId='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    displayDiagnosis();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            comboBox1.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                comboBox1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox4.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                textBox5.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                label9.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                label10.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                label12.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            DisplayPatientId();
        }

        string pname;
        

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void pictureBox6_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
