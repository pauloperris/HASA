using System;
using System.Drawing;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SAA
{
    public partial class TelaPrincipal : Form
    {
        //private MAC.WindowsService.MACMonitorService service;
        private readonly int _tamanho = 35;
        private TelaConfiguracao tc;
        private DataSet dataSet;
        string caminhoArquivo = String.Empty, nomeApp = String.Empty, caminho;
        private DialogResult dr;
        private TelaBandeja telaBandeja;

        public TelaPrincipal()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, (Screen.PrimaryScreen.Bounds.Height * _tamanho) / 100);
        }

        public TelaPrincipal(TelaBandeja tb)
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, (Screen.PrimaryScreen.Bounds.Height * _tamanho) / 100);
            telaBandeja = tb;
        }

       
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            //service = new MACMonitorService(); //somente para testes, depois tirar a referencia
            
            CriaDiretorios();

            if (!System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\SAA\\configuracoes\\UserConfig.xml"))
            {
                NovoDataSet();
            }
            else
            {
                dataSet = new DataSet();
                dataSet.ReadXml(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\SAA\\configuracoes\\UserConfig.xml");
            }
            PreencherTabela();
        }

        private void NovoDataSet()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "App";

            DataColumn dc1 = new DataColumn("AppNumber", typeof(int));
            DataColumn dc2 = new DataColumn("AppName", typeof(string));
            DataColumn dc3 = new DataColumn("AppPath", typeof(string));

            dataTable.Columns.Add(dc1);
            dataTable.Columns.Add(dc2);
            dataTable.Columns.Add(dc3);


            for (int i = 1; i < 9; i++)
            {
                dataTable.Rows.Add(i, "", "");
            }

            dataSet = new DataSet();
            dataSet.DataSetName = "AtalhosApps";
            dataSet.Tables.Add(dataTable);

            dataSet.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\SAA\\configuracoes\\UserConfig.xml");
        }

        private void BotaoAddApp_Click(object sender, EventArgs e)
        {
            //TODO: condições para adicionar app [espaço livre, ter escolhido algo no dialogo, nao existir outro app igual nos slots]

            if (HaEspacoLivre(dataSet) == true) //primeira condição
            {
                dr = this.openFileDialogAddApp.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK) //segunda condição
                {
                    caminhoArquivo = this.openFileDialogAddApp.FileName;
                    nomeApp = this.openFileDialogAddApp.SafeFileName;
                    nomeApp = nomeApp.Remove(nomeApp.Length - 4);

                    if (JaExiste(nomeApp) != true) //terceira condição
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            if (string.IsNullOrEmpty(Convert.ToString(dataSet.Tables[0].Rows[i][2])) == true) //considera-se q todas as condições foram atendidas e há slot livre
                            {
                                //TODO: Arrumar isso aqui, os botoes estao pegando os atalhos tudo no 1 botao

                                dataSet.Tables[0].Rows[i][1] = nomeApp;
                                dataSet.Tables[0].Rows[i][2] = caminhoArquivo;

                                dataSet.Tables[0].AcceptChanges();

                                dataSet.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\SAA\\configuracoes\\UserConfig.xml");


                                PreencherTabela();
                                this.openFileDialogAddApp.Dispose();
                                //telaBandeja.LogEventos(2);
                                break;
                            }
                        }
                    }
                    else
                    {
                        MensagensSlostsAppsIguais();
                        this.openFileDialogAddApp.Dispose();
                    }

                }
            }
            else
            {
                MensagensSlotsIndisponiveis();
            }
        }

        private void Botao1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataSet.Tables[0].Rows[0][2])) != true)
            {
                System.Diagnostics.Process.Start(Convert.ToString(dataSet.Tables[0].Rows[0][2]));
                this.Hide();
            }
            else
            {
                MensagensNotificacao(1);
            }
        }

        private void Botao2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataSet.Tables[0].Rows[1][2])) != true)
            {
                System.Diagnostics.Process.Start(Convert.ToString(dataSet.Tables[0].Rows[1][2]));
                this.Hide();
            }
            else
            {
                MensagensNotificacao(2);
            }
        }

        private void Botao3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataSet.Tables[0].Rows[2][2])) != true)
            {
                System.Diagnostics.Process.Start(Convert.ToString(dataSet.Tables[0].Rows[2][2]));
                this.Hide();
            }
            else
            {
                MensagensNotificacao(3);
            }
        }

        private void Botao4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataSet.Tables[0].Rows[3][2])) != true)
            {
                System.Diagnostics.Process.Start(Convert.ToString(dataSet.Tables[0].Rows[3][2]));
                this.Hide();
            }
            else
            {
                MensagensNotificacao(4);
            }
        }

        private void Botao5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataSet.Tables[0].Rows[4][2])) != true)
            {
                System.Diagnostics.Process.Start(Convert.ToString(dataSet.Tables[0].Rows[4][2]));
                this.Hide();
            }
            else
            {
                MensagensNotificacao(5);
            }
        }

        private void Botao6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataSet.Tables[0].Rows[5][2])) != true)
            {
                System.Diagnostics.Process.Start(Convert.ToString(dataSet.Tables[0].Rows[5][2]));
                this.Hide();
            }
            else
            {
                MensagensNotificacao(6);
            }
        }

        private void Botao7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataSet.Tables[0].Rows[6][2])) != true)
            {
                System.Diagnostics.Process.Start(Convert.ToString(dataSet.Tables[0].Rows[6][2]));
                this.Hide();
            }
            else
            {
                MensagensNotificacao(7);
            }
        }

        private void Botao8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataSet.Tables[0].Rows[7][2])) != true)
            {
                System.Diagnostics.Process.Start(Convert.ToString(dataSet.Tables[0].Rows[7][2]));
                this.Hide();
            }
            else
            {
                MensagensNotificacao(8);
            }
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            //TODO: Arrumar aqui o uso do botao de fechar da janela principal
            this.Hide();
        }

        private void BotaoMenu_Click(object sender, EventArgs e)
        {
            //TODO: desenhar a tela de configurações
            tc = new TelaConfiguracao(this, telaBandeja, dataSet);
            tc.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            tc.Show();
            tc.WindowState = FormWindowState.Maximized;
        }

        public void PreencherTabela()
        {

            for (int i = 0; i < 8; i++)
            {
                if (string.IsNullOrEmpty(Convert.ToString(dataSet.Tables[0].Rows[i][2])) != true)
                {
                    ConfigurarBotao((i + 1));
                }
                else
                {
                    ConfigurarBotao((i + 1));
                }
            }
        }

        private void ConfigurarBotao(int botao)
        {
            foreach (DataRow row in dataSet.Tables[0].Select("AppNumber = " + botao))
            {
                switch (botao)
                {
                    case 1:
                        if (string.IsNullOrEmpty(Convert.ToString(row[1])) == true)
                        {
                            this.botao1.Text = "Slot Vazio";
                            this.botao1.Image = Properties.Resources.baseline_cancel_presentation_black_48dp;
                        }
                        else
                        {
                            WshShell shell = new WshShell();
                            WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(Convert.ToString(row[2]));
                            this.botao1.Text = Convert.ToString(row[1]);
                            this.botao1.Image = Bitmap.FromHicon(new Icon(IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                        }
                        break;
                    case 2:
                        if (string.IsNullOrEmpty(Convert.ToString(row[1])) == true)
                        {
                            this.botao2.Text = "Slot Vazio";
                            this.botao2.Image = Properties.Resources.baseline_cancel_presentation_black_48dp;
                        }
                        else
                        {
                            WshShell shell = new WshShell();
                            WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(Convert.ToString(row[2]));
                            this.botao2.Text = Convert.ToString(row[1]);
                            this.botao2.Image = Bitmap.FromHicon(new Icon(IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                        }
                        break;
                    case 3:
                        if (string.IsNullOrEmpty(Convert.ToString(row[1])) == true)
                        {
                            this.botao3.Text = "Slot Vazio";
                            this.botao3.Image = Properties.Resources.baseline_cancel_presentation_black_48dp;
                        }
                        else
                        {
                            WshShell shell = new WshShell();
                            WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(Convert.ToString(row[2]));
                            this.botao3.Text = Convert.ToString(row[1]);
                            this.botao3.Image = Bitmap.FromHicon(new Icon(IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                        }
                        break;
                    case 4:
                        if (string.IsNullOrEmpty(Convert.ToString(row[1])) == true)
                        {
                            this.botao4.Text = "Slot Vazio";
                            this.botao4.Image = Properties.Resources.baseline_cancel_presentation_black_48dp;
                        }
                        else
                        {
                            WshShell shell = new WshShell();
                            WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(Convert.ToString(row[2]));
                            this.botao4.Text = Convert.ToString(row[1]);
                            this.botao4.Image = Bitmap.FromHicon(new Icon(IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                        }
                        break;
                    case 5:
                        if (string.IsNullOrEmpty(Convert.ToString(row[1])) == true)
                        {
                            this.botao5.Text = "Slot Vazio";
                            this.botao5.Image = Properties.Resources.baseline_cancel_presentation_black_48dp;
                        }
                        else
                        {
                            WshShell shell = new WshShell();
                            WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(Convert.ToString(row[2]));
                            this.botao5.Text = Convert.ToString(row[1]);
                            this.botao5.Image = Bitmap.FromHicon(new Icon(IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                        }
                        break;
                    case 6:
                        if (string.IsNullOrEmpty(Convert.ToString(row[1])) == true)
                        {
                            this.botao6.Text = "Slot Vazio";
                            this.botao6.Image = Properties.Resources.baseline_cancel_presentation_black_48dp;
                        }
                        else
                        {
                            WshShell shell = new WshShell();
                            WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(Convert.ToString(row[2]));
                            this.botao6.Text = Convert.ToString(row[1]);
                            this.botao6.Image = Bitmap.FromHicon(new Icon(IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                        }
                        break;
                    case 7:
                        if (string.IsNullOrEmpty(Convert.ToString(row[1])) == true)
                        {
                            this.botao7.Text = "Slot Vazio";
                            this.botao7.Image = Properties.Resources.baseline_cancel_presentation_black_48dp;
                        }
                        else
                        {
                            WshShell shell = new WshShell();
                            WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(Convert.ToString(row[2]));
                            this.botao7.Text = Convert.ToString(row[1]);
                            this.botao7.Image = Bitmap.FromHicon(new Icon(IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                        }
                        break;
                    case 8:
                        if (string.IsNullOrEmpty(Convert.ToString(row[1])) == true)
                        {
                            this.botao8.Text = "Slot Vazio";
                            this.botao8.Image = Properties.Resources.baseline_cancel_presentation_black_48dp;
                        }
                        else
                        {
                            WshShell shell = new WshShell();
                            WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(Convert.ToString(row[2]));
                            this.botao8.Text = Convert.ToString(row[1]);
                            this.botao8.Image = Bitmap.FromHicon(new Icon(IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        //desativado porque adicionar controle em tempo de execução é um porre.

        /*private Button CriarBotao(string text, int valor, Bitmap img)
        {
            Button b = new Button();
            b.Name = "botao" + valor;
            b.Text = text;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new Font("Arial", 10, FontStyle.Regular);
            b.Dock = System.Windows.Forms.DockStyle.Fill;

            
            return b;
        }*/

        public static Icon IconFromFilePath(string filePath)
        {
            var result = (Icon)null;

            try
            {
                result = Icon.ExtractAssociatedIcon(filePath);
            }
            catch (System.Exception)
            {
                return SystemIcons.Exclamation;
            }

            return result;
        }

        public static Boolean HaEspacoLivre(DataSet ds)
        {
            for (int i = 0; i < 8; i++)
            {
                if (string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i][2])) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public void CriaDiretorios()
        {
            caminho = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            if (!Directory.Exists(@caminho + "\\SAA"))
            {
                Directory.CreateDirectory(@caminho + "\\SAA");
                Directory.CreateDirectory(@caminho + "\\SAA\\configuracoes");
                Directory.CreateDirectory(@caminho + "\\SAA\\icons");
                Directory.CreateDirectory(@caminho + "\\SAA\\logs");
            }
        }

        private bool JaExiste(string app)
        {
            //funcao validada e conferida
            for (int i = 0; i < 8; i++)
            {
                if (Convert.ToString(dataSet.Tables[0].Rows[i][1]) == app)
                {
                    return true;
                }
            }
            return false;
        }

        //metodo para deixar o botao redondo, mas esse delirio de paulo foi ignorado pelo desenvolvedor :)

        /*protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, this.botaoAddApp.Width, this.botaoAddApp.Height);
            this.botaoAddApp.Region = new Region(forma);
        }*/

        private void MensagensNotificacao(int slot)
        {
            //TODO: ver com paulo um Icone definitivo para o sistema.

            //this.notifyIconAvisos.Icon = SystemIcons.Exclamation;
            this.notifyIconAvisos.Visible = true;
            this.notifyIconAvisos.BalloonTipIcon = ToolTipIcon.Info;
            this.notifyIconAvisos.BalloonTipTitle = "Opa?!";
            this.notifyIconAvisos.BalloonTipText = "o Slot " + slot + " não contem um atalho válido.";
            this.notifyIconAvisos.ShowBalloonTip(3000);
        }

        private void MensagensSlotsIndisponiveis()
        {
            //this.notifyIconAvisos.Icon = SystemIcons.Exclamation;
            this.notifyIconAvisos.Visible = true;
            this.notifyIconAvisos.BalloonTipIcon = ToolTipIcon.Info;
            this.notifyIconAvisos.BalloonTipTitle = "Opa?!";
            this.notifyIconAvisos.BalloonTipText = "Não há Slots disponíveis para adicionar novos atalhos, considere remover atalhos nao utilizados.";
            this.notifyIconAvisos.ShowBalloonTip(3000);
        }

        private void MensagensSlostsAppsIguais()
        {
            //this.notifyIconAvisos.Icon = SystemIcons.Exclamation;
            this.notifyIconAvisos.Visible = true;
            this.notifyIconAvisos.BalloonTipIcon = ToolTipIcon.Info;
            this.notifyIconAvisos.BalloonTipTitle = "De novo?";
            this.notifyIconAvisos.BalloonTipText = "Desculpe mas esse App ja está adicionado aos atalhos.";
            this.notifyIconAvisos.ShowBalloonTip(3000);
        }
    }
}

//TODO: nao esquecer de adicionar o comando 'Settings.Default.Save()' na janela de configurações para q as alterações sejam salvas