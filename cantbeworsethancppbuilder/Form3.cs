using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Document;
using System.Globalization;
using System.Threading;

namespace cantbeworsethancppbuilder
{
    public partial class Form3 : Form
    {
        public static class ChecksumUtil
        {
            public static string GetChecksum(HashingAlgoTypes hashingAlgoType, string filename)
            {
                using (var hasher = System.Security.Cryptography.HashAlgorithm.Create(hashingAlgoType.ToString()))
                {
                    using (var stream = System.IO.File.OpenRead(filename))
                    {
                        var hash = hasher.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "");
                    }
                }
            }

        }
        public enum HashingAlgoTypes
        {
            MD5,
            SHA1,
            SHA256,
            SHA384,
            SHA512
        }
        public class Url
        {
            public string url { get; set; }
        }

        public class Root
        {
            public List<Url> urls { get; set; }
        }
        Form2 f = new Form2();
        public Form3()
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
        WebClient client = new WebClient();

        private void atqT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(urlT.Text))
                return;
            ListViewItem item = new ListViewItem(urlT.Text);
            listView1.Items.Add(item);
            urlT.Clear();


        }

        private void rfqB_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0) {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                    }
        }
        string PathToFile;
        public void DownloadFile(string url) {
            try
            {
                PathToFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), url.Substring(7).Replace('\\', '-').Replace('/', '-'));
                client.DownloadFileAsync(new Uri(url), PathToFile);
            }
            catch (UriFormatException)
            {
            }
        }
        public string GetFileName(string link) {
            Uri uri = new Uri(link);
            string name = System.IO.Path.GetFileName(uri.LocalPath);
            return name;
        }
        public void reportF(string option)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

            DocumentModel document = new DocumentModel();

            Section section = new Section(document);
            document.Sections.Add(section);

            Paragraph paragraph = new Paragraph(document);
            section.Blocks.Add(paragraph);

            Run run = new Run(document, PathToFile + " " + Form1.username);
            paragraph.Inlines.Add(run);

            document.Save(PathToFile + "." + option);
            MessageBox.Show(PathToFile);
        }

        private void downloadB_Click(object sender, EventArgs e)
        {
            DownloadFile(urlT.Text);
            if(reportCB.Checked == true)
            {
                switch (reportOptions.Text)
                {
                    case "pdf":
                        reportF("pdf");
                        break;
                    case "rtf":
                        reportF("rtf");
                        break;
                }
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Form1.lightTheme == "0")
            {
                BackColor = System.Drawing.Color.Gray;
            }
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                spb.Minimum = 0;
                double recive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = recive / total * 100;
                spb.Value = int.Parse(Math.Truncate(percentage).ToString());
                percentageL.Text = Math.Round(percentage,2) + "%";
            }));
        }
        
        private void downloadqueueB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++) {
                client = new WebClient();
                client.DownloadFileAsync(new Uri(listView1.Items[i].Text), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), listView1.Items[i].Text.Substring(7).Replace('\\', '-').Replace('/', '-')));
                //DownloadFile(listView1.Items[i].Text);
                //MessageBox.Show(listView1.Items[i].Text);
            }
        }

        private void itqB_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "import.json"));
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);
            //listView1.Items.Add(myDeserializedClass.urls[0].url.ToString());
            for (var i=0; i < myDeserializedClass.urls.Count(); i++)
            {
                listView1.Items.Add(myDeserializedClass.urls[i].url.ToString());
            }
            //MessageBox.Show(myDeserializedClass.urls[0].url.ToString());
        }

        private void efqB_Click(object sender, EventArgs e)
        {
            string json = "{\"urls\":[";
            for (int i = 0; i < listView1.Items.Count; i++) {
                json = json + "\n{\"url\":\"" + listView1.Items[i].Text + "\"},";
            }
            json = json + "\n]\n}";
            MessageBox.Show(json);
            File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "export.json"), json);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkB_Click(object sender, EventArgs e)
        {
            var checksum = ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA256, PathToFile);
            MessageBox.Show(checksum);
            if (checksum == checksumT.Text)
            {
                checksumL.Text = "Valid";
            }
            else {
                checksumL.Text = "Failed";
            }
        }
    }
}

