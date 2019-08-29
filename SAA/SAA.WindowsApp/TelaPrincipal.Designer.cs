namespace SAA
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.notifyIconAvisos = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelTextoRodape = new System.Windows.Forms.Label();
            this.openFileDialogAddApp = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanelApps = new System.Windows.Forms.TableLayoutPanel();
            this.botao8 = new System.Windows.Forms.Button();
            this.botao7 = new System.Windows.Forms.Button();
            this.botao6 = new System.Windows.Forms.Button();
            this.botao5 = new System.Windows.Forms.Button();
            this.botao4 = new System.Windows.Forms.Button();
            this.botao3 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.botao1 = new System.Windows.Forms.Button();
            this.splitContainerVApps = new System.Windows.Forms.SplitContainer();
            this.botaoAddApp = new System.Windows.Forms.Button();
            this.splitContainerVMenu = new System.Windows.Forms.SplitContainer();
            this.botaoFechar = new System.Windows.Forms.Button();
            this.botaoMenu = new System.Windows.Forms.Button();
            this.splitContainerHMenuApp = new System.Windows.Forms.SplitContainer();
            this.splitContainerHFundo = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelApps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVApps)).BeginInit();
            this.splitContainerVApps.Panel1.SuspendLayout();
            this.splitContainerVApps.Panel2.SuspendLayout();
            this.splitContainerVApps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVMenu)).BeginInit();
            this.splitContainerVMenu.Panel1.SuspendLayout();
            this.splitContainerVMenu.Panel2.SuspendLayout();
            this.splitContainerVMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHMenuApp)).BeginInit();
            this.splitContainerHMenuApp.Panel1.SuspendLayout();
            this.splitContainerHMenuApp.Panel2.SuspendLayout();
            this.splitContainerHMenuApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHFundo)).BeginInit();
            this.splitContainerHFundo.Panel1.SuspendLayout();
            this.splitContainerHFundo.Panel2.SuspendLayout();
            this.splitContainerHFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconAvisos
            // 
            this.notifyIconAvisos.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconAvisos.Icon")));
            this.notifyIconAvisos.Text = "Alerta";
            // 
            // labelTextoRodape
            // 
            this.labelTextoRodape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTextoRodape.Location = new System.Drawing.Point(0, 0);
            this.labelTextoRodape.Name = "labelTextoRodape";
            this.labelTextoRodape.Size = new System.Drawing.Size(800, 33);
            this.labelTextoRodape.TabIndex = 0;
            this.labelTextoRodape.Text = "Software Auxiliar Assistivo - SAA ver. 3.0.";
            this.labelTextoRodape.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // openFileDialogAddApp
            // 
            this.openFileDialogAddApp.Filter = "Atalhos (*.lnk) | *lnk";
            this.openFileDialogAddApp.InitialDirectory = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs";
            this.openFileDialogAddApp.RestoreDirectory = true;
            // 
            // tableLayoutPanelApps
            // 
            this.tableLayoutPanelApps.AutoSize = true;
            this.tableLayoutPanelApps.ColumnCount = 8;
            this.tableLayoutPanelApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelApps.Controls.Add(this.botao8, 7, 0);
            this.tableLayoutPanelApps.Controls.Add(this.botao7, 6, 0);
            this.tableLayoutPanelApps.Controls.Add(this.botao6, 5, 0);
            this.tableLayoutPanelApps.Controls.Add(this.botao5, 4, 0);
            this.tableLayoutPanelApps.Controls.Add(this.botao4, 3, 0);
            this.tableLayoutPanelApps.Controls.Add(this.botao3, 2, 0);
            this.tableLayoutPanelApps.Controls.Add(this.botao2, 1, 0);
            this.tableLayoutPanelApps.Controls.Add(this.botao1, 0, 0);
            this.tableLayoutPanelApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelApps.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanelApps.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelApps.Name = "tableLayoutPanelApps";
            this.tableLayoutPanelApps.RowCount = 1;
            this.tableLayoutPanelApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelApps.Size = new System.Drawing.Size(618, 364);
            this.tableLayoutPanelApps.TabIndex = 0;
            // 
            // botao8
            // 
            this.botao8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao8.FlatAppearance.BorderSize = 0;
            this.botao8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao8.Image = global::SAA.Properties.Resources.baseline_cancel_presentation_black_48dp;
            this.botao8.Location = new System.Drawing.Point(542, 3);
            this.botao8.Name = "botao8";
            this.botao8.Size = new System.Drawing.Size(73, 358);
            this.botao8.TabIndex = 0;
            this.botao8.Text = "Slot Vazio";
            this.botao8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao8.UseVisualStyleBackColor = true;
            this.botao8.Click += new System.EventHandler(this.Botao8_Click);
            // 
            // botao7
            // 
            this.botao7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao7.FlatAppearance.BorderSize = 0;
            this.botao7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao7.Image = global::SAA.Properties.Resources.baseline_cancel_presentation_black_48dp;
            this.botao7.Location = new System.Drawing.Point(465, 3);
            this.botao7.Name = "botao7";
            this.botao7.Size = new System.Drawing.Size(71, 358);
            this.botao7.TabIndex = 1;
            this.botao7.Text = "Slot Vazio";
            this.botao7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao7.UseVisualStyleBackColor = true;
            this.botao7.Click += new System.EventHandler(this.Botao7_Click);
            // 
            // botao6
            // 
            this.botao6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao6.FlatAppearance.BorderSize = 0;
            this.botao6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao6.Image = global::SAA.Properties.Resources.baseline_cancel_presentation_black_48dp;
            this.botao6.Location = new System.Drawing.Point(388, 3);
            this.botao6.Name = "botao6";
            this.botao6.Size = new System.Drawing.Size(71, 358);
            this.botao6.TabIndex = 2;
            this.botao6.Text = "Slot Vazio";
            this.botao6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao6.UseVisualStyleBackColor = true;
            this.botao6.Click += new System.EventHandler(this.Botao6_Click);
            // 
            // botao5
            // 
            this.botao5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao5.FlatAppearance.BorderSize = 0;
            this.botao5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao5.Image = global::SAA.Properties.Resources.baseline_cancel_presentation_black_48dp;
            this.botao5.Location = new System.Drawing.Point(311, 3);
            this.botao5.Name = "botao5";
            this.botao5.Size = new System.Drawing.Size(71, 358);
            this.botao5.TabIndex = 3;
            this.botao5.Text = "Slot Vazio";
            this.botao5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao5.UseVisualStyleBackColor = true;
            this.botao5.Click += new System.EventHandler(this.Botao5_Click);
            // 
            // botao4
            // 
            this.botao4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao4.FlatAppearance.BorderSize = 0;
            this.botao4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao4.Image = global::SAA.Properties.Resources.baseline_cancel_presentation_black_48dp;
            this.botao4.Location = new System.Drawing.Point(234, 3);
            this.botao4.Name = "botao4";
            this.botao4.Size = new System.Drawing.Size(71, 358);
            this.botao4.TabIndex = 4;
            this.botao4.Text = "Slot Vazio";
            this.botao4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao4.UseVisualStyleBackColor = true;
            this.botao4.Click += new System.EventHandler(this.Botao4_Click);
            // 
            // botao3
            // 
            this.botao3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao3.FlatAppearance.BorderSize = 0;
            this.botao3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao3.Image = global::SAA.Properties.Resources.baseline_cancel_presentation_black_48dp;
            this.botao3.Location = new System.Drawing.Point(157, 3);
            this.botao3.Name = "botao3";
            this.botao3.Size = new System.Drawing.Size(71, 358);
            this.botao3.TabIndex = 5;
            this.botao3.Text = "Slot Vazio";
            this.botao3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao3.UseVisualStyleBackColor = true;
            this.botao3.Click += new System.EventHandler(this.Botao3_Click);
            // 
            // botao2
            // 
            this.botao2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao2.FlatAppearance.BorderSize = 0;
            this.botao2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao2.Image = global::SAA.Properties.Resources.baseline_cancel_presentation_black_48dp;
            this.botao2.Location = new System.Drawing.Point(80, 3);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(71, 358);
            this.botao2.TabIndex = 6;
            this.botao2.Text = "Slot Vazio";
            this.botao2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao2.UseVisualStyleBackColor = true;
            this.botao2.Click += new System.EventHandler(this.Botao2_Click);
            // 
            // botao1
            // 
            this.botao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botao1.FlatAppearance.BorderSize = 0;
            this.botao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao1.Image = global::SAA.Properties.Resources.baseline_cancel_presentation_black_48dp;
            this.botao1.Location = new System.Drawing.Point(3, 3);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(71, 358);
            this.botao1.TabIndex = 7;
            this.botao1.Text = "Slot Vazio";
            this.botao1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.Botao1_Click);
            // 
            // splitContainerVApps
            // 
            this.splitContainerVApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVApps.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerVApps.IsSplitterFixed = true;
            this.splitContainerVApps.Location = new System.Drawing.Point(0, 0);
            this.splitContainerVApps.Name = "splitContainerVApps";
            // 
            // splitContainerVApps.Panel1
            // 
            this.splitContainerVApps.Panel1.Controls.Add(this.botaoAddApp);
            // 
            // splitContainerVApps.Panel2
            // 
            this.splitContainerVApps.Panel2.Controls.Add(this.tableLayoutPanelApps);
            this.splitContainerVApps.Size = new System.Drawing.Size(800, 364);
            this.splitContainerVApps.SplitterDistance = 178;
            this.splitContainerVApps.TabIndex = 0;
            // 
            // botaoAddApp
            // 
            this.botaoAddApp.BackColor = System.Drawing.SystemColors.Control;
            this.botaoAddApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botaoAddApp.FlatAppearance.BorderSize = 0;
            this.botaoAddApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAddApp.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAddApp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoAddApp.Image = global::SAA.Properties.Resources.outline_add_box_black_48dp;
            this.botaoAddApp.Location = new System.Drawing.Point(0, 0);
            this.botaoAddApp.Name = "botaoAddApp";
            this.botaoAddApp.Size = new System.Drawing.Size(178, 364);
            this.botaoAddApp.TabIndex = 0;
            this.botaoAddApp.Text = "Add";
            this.botaoAddApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoAddApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botaoAddApp.UseVisualStyleBackColor = false;
            this.botaoAddApp.Click += new System.EventHandler(this.BotaoAddApp_Click);
            // 
            // splitContainerVMenu
            // 
            this.splitContainerVMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVMenu.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerVMenu.IsSplitterFixed = true;
            this.splitContainerVMenu.Location = new System.Drawing.Point(0, 0);
            this.splitContainerVMenu.Name = "splitContainerVMenu";
            // 
            // splitContainerVMenu.Panel1
            // 
            this.splitContainerVMenu.Panel1.Controls.Add(this.botaoFechar);
            // 
            // splitContainerVMenu.Panel2
            // 
            this.splitContainerVMenu.Panel2.Controls.Add(this.botaoMenu);
            this.splitContainerVMenu.Size = new System.Drawing.Size(800, 45);
            this.splitContainerVMenu.SplitterDistance = 651;
            this.splitContainerVMenu.TabIndex = 0;
            // 
            // botaoFechar
            // 
            this.botaoFechar.BackColor = System.Drawing.Color.Firebrick;
            this.botaoFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botaoFechar.FlatAppearance.BorderSize = 0;
            this.botaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFechar.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFechar.ForeColor = System.Drawing.Color.White;
            this.botaoFechar.Image = global::SAA.Properties.Resources.baseline_clear_white_24dp;
            this.botaoFechar.Location = new System.Drawing.Point(0, 0);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(651, 45);
            this.botaoFechar.TabIndex = 0;
            this.botaoFechar.UseVisualStyleBackColor = false;
            this.botaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // botaoMenu
            // 
            this.botaoMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.botaoMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botaoMenu.FlatAppearance.BorderSize = 0;
            this.botaoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMenu.Image = global::SAA.Properties.Resources.baseline_widgets_white_24dp1;
            this.botaoMenu.Location = new System.Drawing.Point(0, 0);
            this.botaoMenu.Name = "botaoMenu";
            this.botaoMenu.Size = new System.Drawing.Size(145, 45);
            this.botaoMenu.TabIndex = 0;
            this.botaoMenu.UseVisualStyleBackColor = false;
            this.botaoMenu.Click += new System.EventHandler(this.BotaoMenu_Click);
            // 
            // splitContainerHMenuApp
            // 
            this.splitContainerHMenuApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHMenuApp.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerHMenuApp.IsSplitterFixed = true;
            this.splitContainerHMenuApp.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHMenuApp.Name = "splitContainerHMenuApp";
            this.splitContainerHMenuApp.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHMenuApp.Panel1
            // 
            this.splitContainerHMenuApp.Panel1.Controls.Add(this.splitContainerVMenu);
            // 
            // splitContainerHMenuApp.Panel2
            // 
            this.splitContainerHMenuApp.Panel2.Controls.Add(this.splitContainerVApps);
            this.splitContainerHMenuApp.Size = new System.Drawing.Size(800, 413);
            this.splitContainerHMenuApp.SplitterDistance = 45;
            this.splitContainerHMenuApp.TabIndex = 0;
            // 
            // splitContainerHFundo
            // 
            this.splitContainerHFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHFundo.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerHFundo.IsSplitterFixed = true;
            this.splitContainerHFundo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHFundo.Name = "splitContainerHFundo";
            this.splitContainerHFundo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHFundo.Panel1
            // 
            this.splitContainerHFundo.Panel1.Controls.Add(this.splitContainerHMenuApp);
            // 
            // splitContainerHFundo.Panel2
            // 
            this.splitContainerHFundo.Panel2.Controls.Add(this.labelTextoRodape);
            this.splitContainerHFundo.Size = new System.Drawing.Size(800, 450);
            this.splitContainerHFundo.SplitterDistance = 413;
            this.splitContainerHFundo.TabIndex = 1;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerHFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Auxiliar Assistivo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.tableLayoutPanelApps.ResumeLayout(false);
            this.splitContainerVApps.Panel1.ResumeLayout(false);
            this.splitContainerVApps.Panel2.ResumeLayout(false);
            this.splitContainerVApps.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVApps)).EndInit();
            this.splitContainerVApps.ResumeLayout(false);
            this.splitContainerVMenu.Panel1.ResumeLayout(false);
            this.splitContainerVMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVMenu)).EndInit();
            this.splitContainerVMenu.ResumeLayout(false);
            this.splitContainerHMenuApp.Panel1.ResumeLayout(false);
            this.splitContainerHMenuApp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHMenuApp)).EndInit();
            this.splitContainerHMenuApp.ResumeLayout(false);
            this.splitContainerHFundo.Panel1.ResumeLayout(false);
            this.splitContainerHFundo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHFundo)).EndInit();
            this.splitContainerHFundo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconAvisos;
        private System.Windows.Forms.Label labelTextoRodape;
        private System.Windows.Forms.OpenFileDialog openFileDialogAddApp;
        private System.Windows.Forms.Button botao8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelApps;
        private System.Windows.Forms.Button botao7;
        private System.Windows.Forms.Button botao6;
        private System.Windows.Forms.Button botao5;
        private System.Windows.Forms.Button botao4;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.SplitContainer splitContainerVApps;
        private System.Windows.Forms.Button botaoAddApp;
        private System.Windows.Forms.Button botaoFechar;
        private System.Windows.Forms.SplitContainer splitContainerVMenu;
        private System.Windows.Forms.Button botaoMenu;
        private System.Windows.Forms.SplitContainer splitContainerHMenuApp;
        private System.Windows.Forms.SplitContainer splitContainerHFundo;
    }
}

