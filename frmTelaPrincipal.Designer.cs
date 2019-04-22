namespace VisulNet
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.rbStretch = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.Fechar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbStretch
            // 
            this.rbStretch.AutoSize = true;
            this.rbStretch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStretch.Location = new System.Drawing.Point(364, 15);
            this.rbStretch.Name = "rbStretch";
            this.rbStretch.Size = new System.Drawing.Size(93, 28);
            this.rbStretch.TabIndex = 4;
            this.rbStretch.TabStop = true;
            this.rbStretch.Text = "Stretch";
            this.rbStretch.UseVisualStyleBackColor = true;
            this.rbStretch.CheckedChanged += new System.EventHandler(this.rbStretch_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNormal.Location = new System.Drawing.Point(559, 15);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(95, 28);
            this.rbNormal.TabIndex = 5;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // Fechar
            // 
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.Image = global::VisulNet.Properties.Resources.iconfinder_icons_exit_1564505;
            this.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fechar.Location = new System.Drawing.Point(225, 5);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(103, 38);
            this.Fechar.TabIndex = 6;
            this.Fechar.Text = "Fechar";
            this.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Image = global::VisulNet.Properties.Resources.iconfinder_17_330399;
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(106, 5);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(113, 38);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Image = global::VisulNet.Properties.Resources.iconfinder_folder_open_1189421;
            this.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrir.Location = new System.Drawing.Point(8, 5);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(92, 38);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(55, 48);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(616, 418);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VisulNet.Properties.Resources.photobook_10x8in_creation_kit_bojansavke_graphicriver_horizontal_frames;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Fechar);
            this.panel1.Controls.Add(this.rbCenter);
            this.panel1.Controls.Add(this.btnApagar);
            this.panel1.Controls.Add(this.btnAbrir);
            this.panel1.Controls.Add(this.rbStretch);
            this.panel1.Controls.Add(this.rbNormal);
            this.panel1.Location = new System.Drawing.Point(29, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 52);
            this.panel1.TabIndex = 7;
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCenter.Location = new System.Drawing.Point(463, 15);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(90, 28);
            this.rbCenter.TabIndex = 6;
            this.rbCenter.TabStop = true;
            this.rbCenter.Text = "Center";
            this.rbCenter.UseVisualStyleBackColor = true;
            this.rbCenter.CheckedChanged += new System.EventHandler(this.rbCenter_CheckedChanged);
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.FileName = "openFileDialog1";
            this.ofdAbrir.Filter = "Image Files (*.BMP;*.JPG;*.GIF) |*.BMP;*.JPG;*.GIF| All files (*.*)|*.*,";
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 605);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualNet";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.RadioButton rbStretch;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
    }
}