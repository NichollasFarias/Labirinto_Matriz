namespace TP07_182348
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_player = new System.Windows.Forms.PictureBox();
            this.LblTempo = new System.Windows.Forms.Label();
            this.LblTexto = new System.Windows.Forms.Label();
            this.Tempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::TP07_182348.Properties.Resources.Labirinto;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(71, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(799, 538);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pb_player
            // 
            this.pb_player.BackColor = System.Drawing.Color.White;
            this.pb_player.Image = ((System.Drawing.Image)(resources.GetObject("pb_player.Image")));
            this.pb_player.Location = new System.Drawing.Point(798, 23);
            this.pb_player.Name = "pb_player";
            this.pb_player.Size = new System.Drawing.Size(37, 48);
            this.pb_player.TabIndex = 2;
            this.pb_player.TabStop = false;
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.Location = new System.Drawing.Point(987, 23);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(85, 32);
            this.LblTempo.TabIndex = 3;
            this.LblTempo.Text = "00:00";
            // 
            // LblTexto
            // 
            this.LblTexto.AutoSize = true;
            this.LblTexto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTexto.Location = new System.Drawing.Point(876, 23);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(116, 32);
            this.LblTexto.TabIndex = 3;
            this.LblTexto.Text = "Tempo:";
            // 
            // Tempo
            // 
            this.Tempo.Enabled = true;
            this.Tempo.Tick += new System.EventHandler(this.Tempo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1084, 562);
            this.Controls.Add(this.LblTexto);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.pb_player);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MineLab";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb_player;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Label LblTexto;
        private System.Windows.Forms.Timer Tempo;
    }
}

