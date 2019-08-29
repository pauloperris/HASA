using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using SAA.Properties;
using SAA.Dominio;

namespace SAA
{
    public partial class TelaBandeja : MaterialForm
    {
        private readonly int _temp = Convert.ToInt32(ConfigurationManager.AppSettings["tempo"]), _slots = Convert.ToInt32(ConfigurationManager.AppSettings["slots"]);
        private readonly bool _startWindows = Convert.ToBoolean(ConfigurationManager.AppSettings["IniciacomWindows"]);
        private TelaPrincipal telaPrincipal;

        public TelaBandeja()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            
            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue900, Primary.Blue500,
                Primary.Blue900, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void TelaBandeja_Load(object sender, EventArgs e)
        {
            MouseHook.Start();
            MouseHook.MouseAction += new EventHandler(Event);
            this.textBoxTempo.Text = ConfigurationManager.AppSettings["tempo"];
            if(Convert.ToBoolean(ConfigurationManager.AppSettings["iniciowindows"]) == true)
            {
                this.materialCheckBoxStartWindows.Checked = true;
                SetStartup(true);
            }
            else
            {
                SetStartup(false);
            }
            this.WindowState = FormWindowState.Minimized;
            this.notifyIconBandeja.BalloonTipText = "O SAA ja está monitorando o seu mouse.";
            this.notifyIconBandeja.ShowBalloonTip(3000);

            this.textBoxTempo.TextChanged += new EventHandler(LiberaSave);
            this.materialCheckBoxStartWindows.CheckedChanged += new EventHandler(LiberaSave);

            this.labelAviso.Enabled = false;
            this.labelAviso.Visible = false;
        }

        private void Event(object sender, EventArgs e)
        {
            if (MouseHook.t.Seconds >= _temp)
            {
                if (telaPrincipal == null)
                {
                    telaPrincipal = new TelaPrincipal(this);
                    telaPrincipal.Show();
                }
                else
                {
                    telaPrincipal.Show();
                }
            }
        }

        private void LiberaSave(object sender, EventArgs e)
        {
            this.materialFlatButtonSalvar.Enabled = true;
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.notifyIconBandeja.Visible = true;
        }

        private void MaterialFlatButtonSalvar_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("tempo");
            config.AppSettings.Settings.Add("tempo", this.textBoxTempo.Text);

            config.AppSettings.Settings.Remove("iniciowindows");
            config.AppSettings.Settings.Add("iniciowindows", Convert.ToString(this.materialCheckBoxStartWindows.Checked));

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            this.materialFlatButtonSalvar.Enabled = false;
            this.labelAviso.Text = "Você precisa reiniciar o SAA para que as alterações tenham efeito.";
            this.labelAviso.Enabled = true;
            this.labelAviso.Visible = true;
        }

        private void NotifyIconBandeja_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIconBandeja.Visible = false;
        }

        private void ToolStripMenuItemMostrar_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIconBandeja.Visible = false;
        }

        private void ToolStripMenuItemFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void SetStartup(bool OnOff)
        {
            try
            {
                //Nome a ser exibido no registro ou quando Der MSCONFIG
                string appName = "Software Auxiliar Assistivo";

                //Diretorio da chave do Registro NAO ALTERAR
                string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

                //Abre o registro
                RegistryKey startupKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

                //Valida se vai incluir o iniciar com o Windows ou remover
                if (OnOff)//Iniciar
                {
                    if (startupKey.GetValue(appName) == null)
                    {
                        // Add startup reg key
                        startupKey.SetValue(appName, Application.ExecutablePath.ToString());
                        startupKey.Close();
                    }
                }
                else//Nao iniciar mais
                {
                    // remove startup
                    startupKey = Registry.LocalMachine.OpenSubKey(runKey, true);
                    startupKey.DeleteValue(appName, false);
                    startupKey.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //metodo de configura o iniciar do app junto com o windows
    }
}
