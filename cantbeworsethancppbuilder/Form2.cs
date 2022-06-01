using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RestSharp;
using cantbeworsethancppbuilder.Models;
using Newtonsoft.Json;
using System.Globalization;
using System.Threading;

namespace cantbeworsethancppbuilder
{
    public partial class Form2 : Form
    {
        static void SaveLog()
        {
            FileStream fs = new FileStream("lastlog.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(Form1.log.Hour);
            bw.Write(Form1.log.Minute);
            bw.Write(Form1.log.Day);
            bw.Write(Form1.log.Month);
            bw.Write(Form1.log.Year);
            bw.Close();
            fs.Close();
            
        }
        static string ShowLog() {
            if (File.Exists("lastlog.bin"))
            {
                FileStream fs = new FileStream("lastlog.bin", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                string LastLog = br.ReadInt32() + ":" + br.ReadInt32() + " " + br.ReadInt32() + "/" + br.ReadInt32() + "/" + br.ReadInt32();
                br.Close();
                fs.Close();
                return LastLog;
            }
            else {
                return "First log";
            }
        }
        public Form2()
        {
            string country = WhereAmI();
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
            if (country == "Ukraine")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            }
            InitializeComponent();
            LastLoginDateTimeLabel.Text = ShowLog();
            SaveLog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.lightTheme == "0")
            {
                BackColor = System.Drawing.Color.Gray;
            }
            locationL.Text = WhereAmI();
            //ManageUsersB.Visible = false;
            if (Form1.username == "admin")
            {
                ManageUsersB.Visible = true;
            }
            else
            {
                ManageUsersB.Visible = false;
            }
        }

        public string WhereAmI()
        {
            var ip = GetIpData();
            //MessageBox.Show(ip.IP);
            var location = GetDataFromIpData(ip.IP);
            //MessageBox.Show(location.Country);
            return location.Country;

        }


        private GetIp GetIpData()
        {
            var ApiClient = new RestClient("https://api.ipify.org/?format=json");
            var ApiResult = ApiClient.Execute<GetIp>(new RestRequest());
            return JsonConvert.DeserializeObject<GetIp>(ApiResult.Content);
        }
        private GetDataFromIp GetDataFromIpData(string ip) {
            var ApiClient = new RestClient("http://ip-api.com/json/" + ip);
            var ApiResult = ApiClient.Execute<GetDataFromIp>(new RestRequest());
            return JsonConvert.DeserializeObject<GetDataFromIp>(ApiResult.Content);
        } 

        private void frm3_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
        }

        private void ManageUsersB_Click(object sender, EventArgs e)
        {
            var ManageUsers = new ManageUsers();
            ManageUsers.Show();
        }
    }
}
