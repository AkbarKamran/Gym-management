﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void DeleteMember_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "data source = AKBAR-PC\\SQLEXPRESS; database = gym; integrated security = True";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con1;

            cmd1.CommandText = "Select * from NewMember";
            SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
            DataSet DS1 = new DataSet();
            DA1.Fill(DS1);
            dataGridView1.DataSource = DS1.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("This will Delete your data, Congirm?", "Delete DATA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = AKBAR-PC\\SQLEXPRESS; database = gym; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "delete  from NewMember where MID = " + txtID.Text + "";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    MessageBox.Show("Data Deleted");
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "data source = AKBAR-PC\\SQLEXPRESS; database = gym; integrated security = True";
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = con1;

                    cmd1.CommandText = "Select * from NewMember";
                    SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                    DataSet DS1 = new DataSet();
                    DA1.Fill(DS1);
                    dataGridView1.DataSource = DS1.Tables[0];
                }
                else
                {
                    this.Activate();
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "data source = AKBAR-PC\\SQLEXPRESS; database = gym; integrated security = True";
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = con1;

                    cmd1.CommandText = "Select * from NewMember";
                    SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                    DataSet DS1 = new DataSet();
                    DA1.Fill(DS1);
                    dataGridView1.DataSource = DS1.Tables[0];

                }
              
            }
            else
            {
                MessageBox.Show("Please Enter Some ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
