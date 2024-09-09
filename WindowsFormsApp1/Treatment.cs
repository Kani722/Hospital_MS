using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Treatment : Form
    {
        public Treatment()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HOME\Documents\HospitalMS.mdf;Integrated Security=True;Connect Timeout=30");
        private void displayTreatment()
        {
            try
            {
                con.Open();
                string Query = "select * from Treatment";
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
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string qurey = "insert into Treatment Values(' " + textBox1.Text + "' ,' " + textBox2.Text + "' ,' " + textBox3.Text + "' ,' " + textBox4.Text + "')";
                    SqlCommand cmd = new SqlCommand(qurey, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Entered Successfully");
                    displayTreatment();
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " ")
                {
                    MessageBox.Show("Enter the Treatment ID");
                }
                else
                {
                    con.Open();
                    string query = "delete from Treatment where TreatId='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    displayTreatment();
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
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "UPDATE Treatment SET TreatName = @TreatName, Diseases = @Diseases, Payments = @Payments WHERE TreatId = @TreatId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@TreatName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Diseases", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Payments", textBox4.Text);
                    cmd.Parameters.AddWithValue("@TreatId", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated Successfully");
                    displayTreatment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            
        }

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
