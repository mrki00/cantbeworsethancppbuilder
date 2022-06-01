using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Threading;

namespace cantbeworsethancppbuilder
{
    public partial class ManageUsers : Form
    {
        MySqlConnection mysqlConn = new MySqlConnection();
        MySqlCommand mysqlCmd = new MySqlCommand();
        DataTable mysqlDt = new DataTable();
        //String sqlQuerry;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        DataSet DS = new DataSet();
        MySqlDataReader mysqlRd;
        Form2 f = new Form2();
        public ManageUsers()
        {
            string country = f.WhereAmI();
            if (country == "Croatia")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("hr-HR");
            }
            if (country == "Germany")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            }
            if (country == "Japan")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JA");
            }
            if (country == "Russia")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            }

            InitializeComponent();
        }
        public void GetUserData(string cmd) {
            mysqlConn.ConnectionString = "server=localhost;user id=user;password=0000;database=ntp";
            mysqlConn.Open();
            mysqlCmd.Connection = mysqlConn;
            if (cmd == null)
            {
                mysqlCmd.CommandText = "SELECT * FROM ntp.users";
            }
            else if (cmd != null) {
                mysqlCmd.CommandText = cmd;
            }
            mysqlRd = mysqlCmd.ExecuteReader();
            mysqlDt.Load(mysqlRd);
            mysqlRd.Close();
            mysqlConn.Close();
            dataGridView1.DataSource = mysqlDt;
        }
        private void CreateUserB_Click(object sender, EventArgs e)
        {
            mysqlConn.ConnectionString = "server=localhost;user id=user;password=0000;database=ntp";
            mysqlConn.Open();
            mysqlCmd.Connection = mysqlConn;
            //mysqlDt
            string EncryptType = "sha1Password";
            var pass = Encrypt.Sha1Encrypt(passT.Text);
            if (aesRB.Checked == true) {
                EncryptType = "aesPassword";
                var key = "b14ca5898a4e4133bbce2ea2315a1916";
                pass = Encrypt.AesEncryptString(key, passT.Text);
            }

            if (passT.Text == repassT.Text) {
                foreach (DataRow dr in mysqlDt.Rows)
                {
                    if(dr["appUser"].ToString() == usernameT.Text)
                    {
                        //MessageBox.Show("Username already taken");
                        //break;
                        DialogResult dialogResult = MessageBox.Show("Do you want to change password", "Username already taken", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            mysqlCmd.CommandText = $"UPDATE users SET  {EncryptType} = \"{pass}\" WHERE appUser = \"{usernameT.Text}\"";
                            goto LoopEnd;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            goto LoopEnd;
                        }
                    }
                } 
                mysqlCmd.CommandText = $"INSERT INTO users (appUser, {EncryptType}) VALUES (\"{usernameT.Text}\", \"{pass}\")";
                LoopEnd:
                    mysqlCmd.ExecuteNonQuery();
                    mysqlRd.Close();
                    mysqlConn.Close();
            } 
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            if (Form1.lightTheme == "0")
            {
                BackColor = System.Drawing.Color.Gray;
            }
            GetUserData(null);
            string[] arraj = { "id", "appuser", "aespassword", "sha1password"};
            string[] arraj2 = { "id", "appuser", "aespassword", "sha1password" };
            comboBox1.DataSource = arraj;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteUserB_Click(object sender, EventArgs e)
        {
            mysqlConn.ConnectionString = "server=localhost;user id=user;password=0000;database=ntp";
            mysqlConn.Open();
            mysqlCmd.Connection = mysqlConn;
            mysqlCmd.CommandText = $"DELETE FROM users WHERE {comboBox1.Text} = \"{conT.Text}\";";
            mysqlCmd.ExecuteNonQuery();
            mysqlRd.Close();
            mysqlConn.Close();
        }

        private void RefreshB_Click(object sender, EventArgs e)
        {
            GetUserData(null);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SortB_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
