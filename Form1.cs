using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testforpower
{
    public partial class Form : System.Windows.Forms.Form
    {
        string title = "Is your computer on?";
        string detecting = "Detecting";
        string StartButtonText = "Start detecting";
        string StartButtonText2 = "Detecting again";
        string ResultText = "Your computer is on";
        string ResultText2 = "Not detecting yet";
        string language = "English";
        string SuccessText = "Successed!";
        string SuccessTitle = "Message";
        public Form()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(() =>
            {
                Start.Enabled = false;
                comboBox1.Enabled = false;
                Start.Text = detecting + "...";
                result.ForeColor = Color.Blue;
                for (int i = 0; i < 50; i++)
                {
                    progressBar1.Value += 2;
                    System.Threading.Thread.Sleep(new Random().Next(0, 100));
                }
                System.Threading.Thread.Sleep(800);
                progressBar1.Value = 0;
                comboBox1.Enabled = true;
                Start.Text = StartButtonText2;
                result.Text = ResultText;
                result.ForeColor = Color.FromArgb(0, 192, 0);
                Start.Enabled = true;
                MessageBox.Show(SuccessText + "\n" + ResultText, SuccessTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }).Start();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            new System.Threading.Thread(() =>
            {
                while (true)
                {
                    if (!Start.Enabled)
                    {
                        result.Text = detecting;
                        for (int i = 0; i < 3 && !Start.Enabled; i++)
                        {
                            result.Text += ".";
                            System.Threading.Thread.Sleep(80);
                        }
                    }
                }
            }).Start();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                detecting = "detecting";
                StartButtonText = "Start detecting";
                StartButtonText2 = "Detecting again";
                ResultText = "Your computer is on!";
                title = "Is your computer turn on?";
                ResultText2 = "Not detecting yet";
                SuccessText = "Successed!";
                SuccessTitle = "Message";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                detecting = "检测中";
                StartButtonText = "开始检测";
                StartButtonText2 = "重新检测";
                ResultText = "电脑电源已开";
                title = "检测电脑电源是否打开";
                ResultText2 = "未检测";
                SuccessText = "成功！";
                SuccessTitle = "消息";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                detecting = "檢測中";
                StartButtonText = "開始檢測";
                StartButtonText2 = "重新檢測";
                ResultText = "電腦電源已開";
                title = "檢測電腦電源是否打開";
                SuccessText = "成功！";
                SuccessTitle = "消息";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                detecting = "検査中";
                StartButtonText = "始める検査";
                StartButtonText2 = "再び検査";
                ResultText = "コンピュータの電源が入っています";
                title = "パソコンの電源は入っていますか？";
                SuccessText = "成功！";
                SuccessTitle = "情報";
            }
            language = comboBox1.Text;
            Controls.Clear();
            InitializeComponent();
        }
    }
}
