using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace RijndaelEncryption
{
    public partial class MainForm : Form
    {
        string Decryption_successful, Encryption_successful, Filter;
        string settingfile = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RijndaelEncryption.dat");
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Loadlanguage();
                if (File.Exists(settingfile))
                {
                    FileStream fs = new FileStream(settingfile, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    this.Top = br.ReadInt32();
                    this.Left = br.ReadInt32();
                    br.Close();
                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream(settingfile, FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(this.Top);
                    bw.Write(this.Left);
                    bw.Close();
                    fs.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }
        private void Loadlanguage()
        {
            
            if (Thread.CurrentThread.CurrentCulture.Name == "zh-CN")
            {
                Decryption_successful = Resources_zh_Hans.Decryption_successful;
                Encryption_successful = Resources_zh_Hans.Encryption_successful;
                Filter = Resources_zh_Hans.Filter;
                this.Text = Resources_zh_Hans.Title;
                lbl_path.Text = Resources_zh_Hans.Path;
                lbl_key.Text = Resources_zh_Hans.Key;
                btn_brofiles.Text = Resources_zh_Hans.Browse_files;
                btn_ect.Text = Resources_zh_Hans.Encrypt;
                btn_dct.Text = Resources_zh_Hans.Decrypt;
            }
            else
            {
                Decryption_successful = Properties.Resources.Decryption_successful;
                Encryption_successful = Properties.Resources.Encryption_successful;
                Filter = Properties.Resources.Filter;
            }
        }
        private void Btn_brofiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Filter;
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbx_path.Text = ofd.FileName;
            }
        }

        private void Btn_ect_Click(object sender, EventArgs e)
        {
            try
            {
                Checkpath();
                string filename = tbx_path.Text;
                string key = tbx_key.Text;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = Filter;
                sfd.FileName = Path.GetFileName(filename);
                DialogResult result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string resultfilename = sfd.FileName;
                    Aes aes = new Aes();
                    bool issucceed = aes.Encrypt(filename, key, resultfilename);
                    if(issucceed)
                        MessageBox.Show(Encryption_successful, this.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try{
                FileStream fs = new FileStream(settingfile, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(this.Top);
                bw.Write(this.Left);
                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void Btn_dct_Click(object sender, EventArgs e)
        {
            try
            {
                Checkpath();
                string filename = tbx_path.Text;
                string key = tbx_key.Text;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = Filter;
                sfd.FileName = Path.GetFileName(filename);
                DialogResult result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string resultfilename = sfd.FileName;
                    Aes aes = new Aes();
                    bool issucceed = aes.Decrypt(filename, key, resultfilename);
                    if (issucceed)
                        MessageBox.Show(Decryption_successful, this.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }
        private void Checkpath()
        {
            string filename = tbx_path.Text;
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
        }
    }
}
