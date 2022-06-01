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
using System.IO;
using System.Net.Sockets;
using System.Xml;
using Microsoft.Win32;

namespace cantbeworsethancppbuilder
{
    public partial class Form1 : Form
    {
        MySqlConnection mysqlConn = new MySqlConnection();
        MySqlCommand mysqlCmd = new MySqlCommand();
        DataTable mysqlDt = new DataTable();
        //String \tsqlQuerry;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        DataSet DS = new DataSet();
        MySqlDataReader mysqlRd;
        //cmrlje ze spajanje
        public static string username;
        public static string lightTheme;
        public Form1()
        {
            InitializeComponent();
        }
        public static DateTime log;
        private void getData()
        {
            mysqlConn.ConnectionString = "server=localhost;user id=user;password=0000;database=ntp";
            mysqlConn.Open();
            mysqlCmd.Connection = mysqlConn;
            mysqlCmd.CommandText = "SELECT * FROM ntp.users";
            mysqlRd = mysqlCmd.ExecuteReader();
            mysqlDt.Load(mysqlRd);
            mysqlRd.Close();
            mysqlConn.Close();
            //mysqlDt u toj varijabli su podaci
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            var aes = Encrypt.AesEncryptString(key, passT.Text);
            var sha1 = Encrypt.Sha1Encrypt(passT.Text);
            for (int i = 0; i < mysqlDt.Rows.Count; i++)
            {
                //MessageBox.Show(mysqlDt.Rows[i][1].ToString() + mysqlDt.Rows[i][2].ToString() + mysqlDt.Rows[i][3].ToString() + mysqlDt.Rows[i][4].ToString());
                if (mysqlDt.Rows[i][1].ToString() == userT.Text) {
                    username = userT.Text;
                    if (mysqlDt.Rows[i][3].ToString() == aes)
                    {
                        //MessageBox.Show("aes");
                        log = DateTime.Now;
                        var form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else if (mysqlDt.Rows[i][4].ToString() == sha1)
                    {
                        //MessageBox.Show("sha1");
                        log = DateTime.Now;
                        var form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("Wrong password, try again");  //password = "0000"
                    }
                }
            }
            
            


        }
        private void loginB_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void VerifySerial(string SerialKey) {
            string response;
            connection:
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 1302);
                string messageToSend = SerialKey;
                int byteCount = Encoding.ASCII.GetByteCount(messageToSend + 1);
                byte[] sendData = Encoding.ASCII.GetBytes(messageToSend);

                NetworkStream stream = client.GetStream();
                stream.Write(sendData, 0, sendData.Length);
                Console.WriteLine("sending data to server...");

                StreamReader sr = new StreamReader(stream);
                response = sr.ReadLine();
                

                stream.Close();
                client.Close();
                if (response == "valid serial")
                {
                    loginB.Visible = true;
                    return;// response;
                    //MessageBox.Show("valid");
                }
                else if(response == "invalid serial")
                {
                    MessageBox.Show("get valid serial key");
                    this.Close();
                    //MessageBox.Show("invalid");
                }
            }
            catch (Exception ef)
            {
                
                Console.WriteLine("failed to connect...");
                goto connection;
                
            }
            return;// response;
        }

        public class serials { 
            public string serial { get; set; }
        }
        static string ReadFromRegistry(string keyName, string subKey)
        {
            RegistryKey sk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subKey);

            if (sk == null) return null; else return sk.GetValue(keyName.ToUpper()).ToString();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string subKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            lightTheme = ReadFromRegistry("AppsUseLightTheme", subKey);
            if(lightTheme == "0")
            {
                BackColor = System.Drawing.Color.Gray;
            }
            loginB.Visible = false;
            string xml = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "serial.xml"));
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            string serial = doc.DocumentElement?.FirstChild?.InnerText;
            VerifySerial(serial);


        }

        private void passT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
