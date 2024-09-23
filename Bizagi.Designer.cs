namespace Trabalhando_com_tela
{
    partial class Bizagi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bizagi));
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            informaçõesToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            txtServidorBizagi = new TextBox();
            txtProjetoBizagi = new TextBox();
            btn_consultar = new Button();
            btn_sair = new Button();
            ckb_TabelasNativas = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { informaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // informaçõesToolStripMenuItem
            // 
            informaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem, sairToolStripMenuItem });
            informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            informaçõesToolStripMenuItem.Size = new Size(105, 24);
            informaçõesToolStripMenuItem.Text = "Informações";
            informaçõesToolStripMenuItem.Click += informaçõesToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(131, 26);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(131, 26);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 68);
            label1.Name = "label1";
            label1.Size = new Size(74, 18);
            label1.TabIndex = 2;
            label1.Text = "Servidor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 103);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 3;
            label2.Text = "Projeto:";
            // 
            // txtServidorBizagi
            // 
            txtServidorBizagi.Location = new Point(106, 59);
            txtServidorBizagi.Name = "txtServidorBizagi";
            txtServidorBizagi.Size = new Size(125, 27);
            txtServidorBizagi.TabIndex = 4;
            // 
            // txtProjetoBizagi
            // 
            txtProjetoBizagi.Location = new Point(106, 95);
            txtProjetoBizagi.Name = "txtProjetoBizagi";
            txtProjetoBizagi.Size = new Size(125, 27);
            txtProjetoBizagi.TabIndex = 5;
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = SystemColors.ControlDark;
            btn_consultar.Location = new Point(694, 394);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(94, 29);
            btn_consultar.TabIndex = 6;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = false;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = SystemColors.ControlDark;
            btn_sair.ForeColor = SystemColors.ActiveCaptionText;
            btn_sair.Location = new Point(594, 394);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(94, 29);
            btn_sair.TabIndex = 7;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // ckb_TabelasNativas
            // 
            ckb_TabelasNativas.AutoSize = true;
            ckb_TabelasNativas.Checked = true;
            ckb_TabelasNativas.CheckState = CheckState.Checked;
            ckb_TabelasNativas.Location = new Point(257, 98);
            ckb_TabelasNativas.Name = "ckb_TabelasNativas";
            ckb_TabelasNativas.Size = new Size(202, 24);
            ckb_TabelasNativas.TabIndex = 8;
            ckb_TabelasNativas.Text = "Consultar tabelas nativas?";
            ckb_TabelasNativas.UseVisualStyleBackColor = true;
            // 
            // Bizagi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ckb_TabelasNativas);
            Controls.Add(btn_sair);
            Controls.Add(btn_consultar);
            Controls.Add(txtProjetoBizagi);
            Controls.Add(txtServidorBizagi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "Bizagi";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bizagi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem informaçõesToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox txtServidorBizagi;
        private TextBox txtProjetoBizagi;
        private Button btn_consultar;
        private Button btn_sair;
        private CheckBox ckb_TabelasNativas;
    }
}