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
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = txtFirstName.Text;
            String lname = txtLastname.Text;

            String Gender = "";

            bool ischeck = radioButton1.Checked;
            if (ischeck)
            {
                Gender = radioButton1.Text;

            }
            else Gender = radioButton2.Text;

            String dob = dateTimePickerDOB.Text;
            String address = txtAddress.Text;
            String email = txtEmail.Text;
            String joinDate = dateTimePickerJoinDate.Text;
            String membership = comboBoxMembership.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String joinMonth = dateTimePickerJoin.Text;
            String Cnic = txtCnic.Text;



            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AKBAR-PC\\SQLEXPRESS; database = gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into NewMember (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Maddress,MembershipTime,MembershipEnds,CnicNumber) values ('" + fname + "','" + lname + "','" + Gender + "','" + dob + "'," + mobile + ",'" + email + "','" + joinDate + "','" + address + "','" + membership + "','" + joinMonth + "','" + Cnic + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data is Saved");
            txtFirstName.Clear();
            txtLastname.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtMobile.Clear();
            txtAddress.Clear();
            txtEmail.Clear();

            comboBoxMembership.ResetText();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
            dateTimePickerJoin.Value = DateTime.Now;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastname.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtMobile.Clear();
            txtAddress.Clear();
            txtEmail.Clear();

            comboBoxMembership.ResetText();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
            dateTimePickerJoin.Value = DateTime.Now;


        }

        private void dateTimePickerJoinDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
