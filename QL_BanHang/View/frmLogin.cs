using QL_BanHang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_BanHang.View
{
    public partial class frmLogin : Form
    {
        Model.ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select  count(*) from tb_LOGIN where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();

                    frmMain main = new frmMain();
                    main.Show();
                   
                }
                else
                {
                    MessageBox.Show("Sai username hoac password");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
        }
    }
}
