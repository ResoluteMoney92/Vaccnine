using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Vaccine
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VDKG9I7U;Initial Catalog=Vaccine;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {   con.Open();
            
            SqlCommand cmd = new SqlCommand("insert into Register(Id, Surname, Name, Gender, Province)values (@Id, @Surname, @Name, @Gender, @Province)", con);
            cmd.Parameters.AddWithValue("@Id", txt1.Text);
            cmd.Parameters.AddWithValue("@Surname", txt2.Text);
            cmd.Parameters.AddWithValue("@Name", txt3.Text);
            cmd.Parameters.AddWithValue("@Gender", cbx1.Text);
            cmd.Parameters.AddWithValue("@Province", cbx2.Text);
            
            
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Register Added");
           
        }
        public static void main(string[] args)
            {

                Application.Run(new Form1());

            }
    }
    }

            
        
