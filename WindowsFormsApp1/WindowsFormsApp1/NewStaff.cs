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

namespace WindowsFormsApp1
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            String fname = txtFirstName.Text;
            String lname = txtLastName.Text;
            String Gender = "";

            bool ischeck = radioButton3.Checked;
            if (ischeck)
            {
                Gender = radioButton3.Text;

            }
            else Gender = radioButton4.Text;

            String datejoin = dateTimePickerStaffJoin.Text;
            String email = txtEmail1.Text;
            String cnic = txtCnic1.Text;
            String contact = txtContact.Text;
            String address = txtAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AKBAR-PC\\SQLEXPRESS; database = gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into NewStaff (Fname,Lname,Gender,Mobile,Email,JoinDate,Maddress,CnicNumber) values ('" + fname + "','" + lname + "','" + Gender + "'," + contact + ",'" + email + "','" + datejoin + "','" + address + "','" + cnic + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data is Saved");
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail1.Clear();
            txtContact.Clear();
            txtCnic1.Clear();
            txtAddress.Clear();
            dateTimePickerStaffJoin.Value = DateTime.Now;

            radioButton3.Checked = false;
            radioButton4.Checked = false;

        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail1.Clear();
            txtContact.Clear();
            txtCnic1.Clear();
            txtAddress.Clear();
            dateTimePickerStaffJoin.Value = DateTime.Now;

            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
}
