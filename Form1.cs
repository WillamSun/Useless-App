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
                result.ForeColor = Color.Gold;
                for (int i = 0; i < 50; i++)
                {
                    progressBar1.Value += 2;
                    System.Threading.Thread.Sleep(new Random().Next(0, 100));
                }
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 0;
                comboBox1.Enabled = true;
                Start.Text = StartButtonText2;
                System.Threading.Thread.Sleep(81);
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
                StartButtonText = "Start detection";
                StartButtonText2 = "Detect again";
                ResultText = "Your computer is on!";
                title = "Is your computer turn on?";
                ResultText2 = "Not detected yet";
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
                ResultText2 = "未檢測";
                SuccessText = "成功！";
                SuccessTitle = "消息";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                detecting = "обнаружение";
                StartButtonText = "Начать обнаружение";
                StartButtonText2 = "Обнаружить снова";
                ResultText = "Ваш компьютер включен!";
                title = "Ваш компьютер включен?";
                ResultText2 = "Еще не обнаружить";
                SuccessText = "Успешно!";
                SuccessTitle = "Сообщение";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                detecting = "détection";
                StartButtonText = "Commencer à détecter";
                StartButtonText2 = "Détecter à nouveau";
                ResultText = "Votre ordinateur est allumé !";
                title = "Votre ordinateur est allumé ?";
                ResultText2 = "Pas encore détecté";
                SuccessText = "Réussie!";
                SuccessTitle = "Message";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                detecting = "erkennen";
                StartButtonText = "Starten Sie die Erkennung";
                StartButtonText2 = "Erneut erkennen";
                ResultText = "Ihr Computer ist eingeschaltet!";
                title = "Ist Ihr Computer eingeschaltet?";
                ResultText2 = "Noch nicht erkannt";
                SuccessText = "Erfolgreich!";
                SuccessTitle = "Nachricht";
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                detecting = "検査中";
                StartButtonText = "始める検査";
                StartButtonText2 = "再び検査";
                ResultText = "コンピュータの電源が入っています";
                title = "パソコンの電源は入っていますか？";
                ResultText2 = "まだ検査していません";
                SuccessText = "成功！";
                SuccessTitle = "情報";
            }
            language = comboBox1.Text;
            Controls.Clear();
            InitializeComponent();
        }
    }
}
