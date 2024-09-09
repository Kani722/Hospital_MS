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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            displayPatient();
        }

        readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOME\Documents\HospitalMS.mdf;Integrated Security=True;Connect Timeout=30");
        private void displayPatient()
        {
            try
            {
                con.Open();
                string Query = "select * from Patient";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " ||  textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " " || comboBox1.Text == " " || comboBox2.Text == " " || textBox6.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string qurey = "insert into Patient Values(' " + textBox1.Text + "' ,' " + textBox2.Text + "' ,' " + textBox3.Text + "' ,' " + textBox4.Text + "' ,' " + textBox5.Text + "' , ' " + comboBox1.Text + "' ,' " + comboBox2.Text + "' ,' " + textBox6.Text + "')";
                    SqlCommand cmd = new SqlCommand(qurey, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Entered Successfully");
                    displayPatient();
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

        private void Patient_Load(object sender, EventArgs e)
        {
            displayPatient();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "UPDATE Patient SET Patient Name = @PatientName, Address = @Address, PhoneNo = @PhoneNo, Age = @Age, Gender = @Gender, BloodGroup = @BloodGroup, Diseases = @Diseases WHERE PatientId = @PatientId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PatientName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                    cmd.Parameters.AddWithValue("@PhoneNo", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Age", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Diseases", textBox6.Text);
                    cmd.Parameters.AddWithValue("@PatientId", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated Successfully");
                    displayPatient();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                comboBox1.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                comboBox2.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
                textBox6.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
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
                    MessageBox.Show("Enter the Patient ID");
                }
                else
                {
                    con.Open();
                    string query = "delete from Patient where PatientId='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    displayPatient();
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

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textBox6.Text = " ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
