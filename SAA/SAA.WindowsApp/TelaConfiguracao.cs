using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAA
{
    public partial class TelaConfiguracao : Form
    {
        private DataSet dataSet;
        string caminhoArquivo = string.Empty, nomeApp = string.Empty;
        private int[] contadorLivre;
        TelaPrincipal telaPrincipal;
        TelaBandeja telaBandeja;

        public TelaConfiguracao()
        {
            InitializeComponent();
        }

        public TelaConfiguracao(TelaPrincipal tp, TelaBandeja tb, DataSet ds)
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            telaBandeja = tb;
            telaPrincipal = tp;
            dataSet = ds;
            contadorLivre = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        private void TelaConfiguracao_Load(object sender, EventArgs e)
        {
            PreencherTabelaAtalhos();
            StatusBar();
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            dataSet.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MAC\\configuracoes\\UserConfig.xml");
            telaPrincipal.PreencherTabela();
            telaPrincipal.Show();
            this.Dispose();
        }

        private void ButtonApp1_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataSet.Tables[0].Select("AppNumber = 1"))
            {
                row[1] = "";
                row[2] = "";
            }
            //telaBandeja.LogEventos(3);
            dataSet.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MAC\\configuracoes\\UserConfig.xml");
            PreencherTabelaAtalhos();
            StatusBar();
        }

        private void ButtonApp2_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataSet.Tables[0].Select("AppNumber = 2"))
            {
                row[1] = "";
                row[2] = "";
            }
            //telaBandeja.LogEventos(3);
            dataSet.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MAC\\configuracoes\\UserConfig.xml");
            PreencherTabelaAtalhos();
            StatusBar();
        }

        private void ButtonApp3_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataSet.Tables[0].Select("AppNumber = 3"))
            {
                row[1] = "";
                row[2] = "";
            }
            //telaBandeja.LogEventos(3);
            dataSet.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MAC\\configuracoes\\UserConfig.xml");
            PreencherTabelaAtalhos();
            StatusBar();
        }

        private void ButtonApp4_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataSet.Tables[0].Select("AppNumber = 4"))
            {
                row[1] = "";
                row[2] = "";
            }
            //telaBandeja.LogEventos(3);
            dataSet.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MAC\\configuracoes\\UserConfig.xml");
            PreencherTabelaAtalhos();
            StatusBar();
        }

        private void ButtonApp5_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataSet.Tables[0].Select("AppNumber = 5"))
            {
                row[1] = "";
                row[2] = "";
            }
            //telaBandeja.LogEventos(3);
            dataSet.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MAC\\configuracoes\\UserConfig.xml");
            PreencherTabelaAtalhos();
            StatusBar();
        }

        private void ButtonApp6_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataSet.Tables[0].Select("AppNumber = 6"))
            {
                row[1] = "";
                row[2] = "";
            }
            //telaBandeja.LogEventos(3);
            dataSet.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MAC\\configuracoes\\UserConfig.xml");
            PreencherTabelaAtalhos();
            StatusBar();
        }

        private void ButtonApp7_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataSet.Tables[0].Select("AppNumber = 7"))
            {
                row[1] = "";
                row[2] = "";
            }
            //telaBandeja.LogEventos(3);
            dataSet.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MAC\\configuracoes\\UserConfig.xml");
            PreencherTabelaAtalhos();
            StatusBar();
        }

        private void ButtonApp8_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataSet.Tables[0].Select("AppNumber = 8"))
            {
                row[1] = "";
                row[2] = "";
            }
            //telaBandeja.LogEventos(3);
            dataSet.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MAC\\configuracoes\\UserConfig.xml");
            PreencherTabelaAtalhos();
            StatusBar();
        }


        private void StatusBar()
        {
            int calculo = 0;
            for (int i = 0; i < this.contadorLivre.Length; i++)
            {
                calculo += contadorLivre[i];
            }
            this.toolStripStatusLabelInfo.Text = "Você está utilizando " + calculo + " slots de um total de " + ConfigurationManager.AppSettings["slots"] + " slots disponiveis.";
            //barra de progresso ver aqui depois
            
            this.toolStripProgressBar1.Value = calculo;
        }

        private void TelaConfiguracao_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaPrincipal.Show();
        }

        private void PreencherTabelaAtalhos()
        {
            WshShell shell = new WshShell();
            for (int i = 0; i < 8; i++)
            {
                if (string.IsNullOrEmpty(Convert.ToString(dataSet.Tables[0].Rows[i][1])) != true)
                {
                    WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(Convert.ToString(dataSet.Tables[0].Rows[i][2]));
                    switch (i)
                    {
                        case 0:
                            this.pictureBoxApp1.Image = Bitmap.FromHicon(new Icon(TelaPrincipal.IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                            this.labelApp1.Text = "Nome do Aplicativo: " + Convert.ToString(dataSet.Tables[0].Rows[i][1]) + "\nCaminho: " + Convert.ToString(dataSet.Tables[0].Rows[i][2]);
                            this.labelSlotSitu1.Text = "OCUPADO";
                            this.buttonApp1.Visible = true;
                            this.buttonApp1.Enabled = true;
                            contadorLivre[0] = 1;
                            break;
                        case 1:
                            this.pictureBoxApp2.Image = Bitmap.FromHicon(new Icon(TelaPrincipal.IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                            this.labelApp2.Text = "Nome do Aplicativo: " + Convert.ToString(dataSet.Tables[0].Rows[i][1]) + "\nCaminho: " + Convert.ToString(dataSet.Tables[0].Rows[i][2]);
                            this.labelSlotSitu2.Text = "OCUPADO";
                            this.buttonApp2.Visible = true;
                            this.buttonApp2.Enabled = true;
                            contadorLivre[1] = 1;
                            break;
                        case 2:
                            this.pictureBoxApp3.Image = Bitmap.FromHicon(new Icon(TelaPrincipal.IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                            this.labelApp3.Text = "Nome do Aplicativo: " + Convert.ToString(dataSet.Tables[0].Rows[i][1]) + "\nCaminho: " + Convert.ToString(dataSet.Tables[0].Rows[i][2]);
                            this.labelSlotSitu3.Text = "OCUPADO";
                            this.buttonApp3.Visible = true;
                            this.buttonApp3.Enabled = true;
                            contadorLivre[2] = 1;
                            break;
                        case 3:
                            this.pictureBoxApp4.Image = Bitmap.FromHicon(new Icon(TelaPrincipal.IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                            this.labelApp4.Text = "Nome do Aplicativo: " + Convert.ToString(dataSet.Tables[0].Rows[i][1]) + "\nCaminho: " + Convert.ToString(dataSet.Tables[0].Rows[i][2]);
                            this.labelSlotSitu4.Text = "OCUPADO";
                            this.buttonApp4.Visible = true;
                            this.buttonApp4.Enabled = true;
                            contadorLivre[3] = 1;
                            break;
                        case 4:
                            this.pictureBoxApp5.Image = Bitmap.FromHicon(new Icon(TelaPrincipal.IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                            this.labelApp5.Text = "Nome do Aplicativo: " + Convert.ToString(dataSet.Tables[0].Rows[i][1]) + "\nCaminho: " + Convert.ToString(dataSet.Tables[0].Rows[i][2]);
                            this.labelSlotSitu5.Text = "OCUPADO";
                            this.buttonApp5.Visible = true;
                            this.buttonApp5.Enabled = true;
                            contadorLivre[4] = 1;
                            break;
                        case 5:
                            this.pictureBoxApp6.Image = Bitmap.FromHicon(new Icon(TelaPrincipal.IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                            this.labelApp6.Text = "Nome do Aplicativo: " + Convert.ToString(dataSet.Tables[0].Rows[i][1]) + "\nCaminho: " + Convert.ToString(dataSet.Tables[0].Rows[i][2]);
                            this.labelSlotSitu6.Text = "OCUPADO";
                            this.buttonApp6.Visible = true;
                            this.buttonApp6.Enabled = true;
                            contadorLivre[5] = 1;
                            break;
                        case 6:
                            this.pictureBoxApp7.Image = Bitmap.FromHicon(new Icon(TelaPrincipal.IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                            this.labelApp7.Text = "Nome do Aplicativo: " + Convert.ToString(dataSet.Tables[0].Rows[i][1]) + "\nCaminho: " + Convert.ToString(dataSet.Tables[0].Rows[i][2]);
                            this.labelSlotSitu7.Text = "OCUPADO";
                            this.buttonApp7.Visible = true;
                            this.buttonApp7.Enabled = true;
                            contadorLivre[6] = 1;
                            break;
                        case 7:
                            this.pictureBoxApp8.Image = Bitmap.FromHicon(new Icon(TelaPrincipal.IconFromFilePath(shortcut.TargetPath), new Size(48, 48)).Handle);
                            this.labelApp8.Text = "Nome do Aplicativo: " + Convert.ToString(dataSet.Tables[0].Rows[i][1]) + "\nCaminho: " + Convert.ToString(dataSet.Tables[0].Rows[i][2]);
                            this.labelSlotSitu8.Text = "OCUPADO";
                            this.buttonApp8.Visible = true;
                            this.buttonApp8.Enabled = true;
                            contadorLivre[7] = 1;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            this.pictureBoxApp1.Image = Properties.Resources.baseline_panorama_fish_eye_black_48dp;
                            this.pictureBoxApp1.SizeMode = PictureBoxSizeMode.Zoom;
                            this.labelApp1.Text = "Nenhum App está adicionado neste slot.";
                            this.labelSlotSitu1.Text = "LIVRE";
                            this.buttonApp1.Visible = false;
                            this.buttonApp1.Enabled = false;
                            this.contadorLivre[0] = 0;
                            break;
                        case 1:
                            this.pictureBoxApp2.Image = Properties.Resources.baseline_panorama_fish_eye_black_48dp;
                            this.pictureBoxApp2.SizeMode = PictureBoxSizeMode.Zoom;
                            this.labelApp2.Text = "Nenhum App está adicionado neste slot.";
                            this.labelSlotSitu2.Text = "LIVRE";
                            this.buttonApp2.Visible = false;
                            this.buttonApp2.Enabled = false;
                            this.contadorLivre[1] = 0;
                            break;
                        case 2:
                            this.pictureBoxApp3.Image = Properties.Resources.baseline_panorama_fish_eye_black_48dp;
                            this.pictureBoxApp3.SizeMode = PictureBoxSizeMode.Zoom;
                            this.labelApp3.Text = "Nenhum App está adicionado neste slot.";
                            this.labelSlotSitu3.Text = "LIVRE";
                            this.buttonApp3.Visible = false;
                            this.buttonApp3.Enabled = false;
                            this.contadorLivre[2] = 0;
                            break;
                        case 3:
                            this.pictureBoxApp4.Image = Properties.Resources.baseline_panorama_fish_eye_black_48dp;
                            this.pictureBoxApp4.SizeMode = PictureBoxSizeMode.Zoom;
                            this.labelApp4.Text = "Nenhum App está adicionado neste slot.";
                            this.labelSlotSitu4.Text = "LIVRE";
                            this.buttonApp4.Visible = false;
                            this.buttonApp4.Enabled = false;
                            this.contadorLivre[3] = 0;
                            break;
                        case 4:
                            this.pictureBoxApp5.Image = Properties.Resources.baseline_panorama_fish_eye_black_48dp;
                            this.pictureBoxApp5.SizeMode = PictureBoxSizeMode.Zoom;
                            this.labelApp5.Text = "Nenhum App está adicionado neste slot.";
                            this.labelSlotSitu5.Text = "LIVRE";
                            this.buttonApp5.Visible = false;
                            this.buttonApp5.Enabled = false;
                            this.contadorLivre[4] = 0;
                            break;
                        case 5:
                            this.pictureBoxApp6.Image = Properties.Resources.baseline_panorama_fish_eye_black_48dp;
                            this.pictureBoxApp6.SizeMode = PictureBoxSizeMode.Zoom;
                            this.labelApp6.Text = "Nenhum App está adicionado neste slot.";
                            this.labelSlotSitu6.Text = "LIVRE";
                            this.buttonApp6.Visible = false;
                            this.buttonApp6.Enabled = false;
                            this.contadorLivre[5] = 0;
                            break;
                        case 6:
                            this.pictureBoxApp7.Image = Properties.Resources.baseline_panorama_fish_eye_black_48dp;
                            this.pictureBoxApp7.SizeMode = PictureBoxSizeMode.Zoom;
                            this.labelApp7.Text = "Nenhum App está adicionado neste slot.";
                            this.labelSlotSitu7.Text = "LIVRE";
                            this.buttonApp7.Visible = false;
                            this.buttonApp7.Visible = false;
                            this.contadorLivre[6] = 0;
                            break;
                        case 7:
                            this.pictureBoxApp8.Image = Properties.Resources.baseline_panorama_fish_eye_black_48dp;
                            this.pictureBoxApp8.SizeMode = PictureBoxSizeMode.Zoom;
                            this.labelApp8.Text = "Nenhum App está adicionado neste slot.";
                            this.labelSlotSitu8.Text = "LIVRE";
                            this.buttonApp8.Visible = false;
                            this.buttonApp8.Enabled = false;
                            this.contadorLivre[7] = 0;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

    }
}
