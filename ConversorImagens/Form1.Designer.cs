﻿namespace ConversorImagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxConf = new System.Windows.Forms.GroupBox();
            this.groupBox3E = new System.Windows.Forms.GroupBox();
            this.btnConverterImagem = new System.Windows.Forms.Button();
            this.groupBox2E = new System.Windows.Forms.GroupBox();
            this.radioEXIF = new System.Windows.Forms.RadioButton();
            this.radioICON = new System.Windows.Forms.RadioButton();
            this.radioGIF = new System.Windows.Forms.RadioButton();
            this.radioPNG = new System.Windows.Forms.RadioButton();
            this.radioBMP = new System.Windows.Forms.RadioButton();
            this.radioJPG = new System.Windows.Forms.RadioButton();
            this.groupBox1E = new System.Windows.Forms.GroupBox();
            this.btnEscolherImagem = new System.Windows.Forms.Button();
            this.groupBoxImagem = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxConf.SuspendLayout();
            this.groupBox3E.SuspendLayout();
            this.groupBox2E.SuspendLayout();
            this.groupBox1E.SuspendLayout();
            this.groupBoxImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConf
            // 
            this.groupBoxConf.Controls.Add(this.groupBox3E);
            this.groupBoxConf.Controls.Add(this.groupBox2E);
            this.groupBoxConf.Controls.Add(this.groupBox1E);
            this.groupBoxConf.Location = new System.Drawing.Point(13, 13);
            this.groupBoxConf.Name = "groupBoxConf";
            this.groupBoxConf.Size = new System.Drawing.Size(248, 529);
            this.groupBoxConf.TabIndex = 0;
            this.groupBoxConf.TabStop = false;
            this.groupBoxConf.Text = "Configurações";
            // 
            // groupBox3E
            // 
            this.groupBox3E.Controls.Add(this.btnConverterImagem);
            this.groupBox3E.Location = new System.Drawing.Point(7, 402);
            this.groupBox3E.Name = "groupBox3E";
            this.groupBox3E.Size = new System.Drawing.Size(235, 100);
            this.groupBox3E.TabIndex = 2;
            this.groupBox3E.TabStop = false;
            this.groupBox3E.Text = "Terceira Etapa";
            // 
            // btnConverterImagem
            // 
            this.btnConverterImagem.Location = new System.Drawing.Point(23, 28);
            this.btnConverterImagem.Name = "btnConverterImagem";
            this.btnConverterImagem.Size = new System.Drawing.Size(193, 52);
            this.btnConverterImagem.TabIndex = 1;
            this.btnConverterImagem.Text = "Converter Imagem";
            this.btnConverterImagem.UseVisualStyleBackColor = true;
            this.btnConverterImagem.Click += new System.EventHandler(this.btnConverterImagem_Click);
            // 
            // groupBox2E
            // 
            this.groupBox2E.Controls.Add(this.radioEXIF);
            this.groupBox2E.Controls.Add(this.radioICON);
            this.groupBox2E.Controls.Add(this.radioGIF);
            this.groupBox2E.Controls.Add(this.radioPNG);
            this.groupBox2E.Controls.Add(this.radioBMP);
            this.groupBox2E.Controls.Add(this.radioJPG);
            this.groupBox2E.Location = new System.Drawing.Point(7, 175);
            this.groupBox2E.Name = "groupBox2E";
            this.groupBox2E.Size = new System.Drawing.Size(235, 176);
            this.groupBox2E.TabIndex = 1;
            this.groupBox2E.TabStop = false;
            this.groupBox2E.Text = "Segunda Etapa";
            // 
            // radioEXIF
            // 
            this.radioEXIF.AutoSize = true;
            this.radioEXIF.Location = new System.Drawing.Point(23, 146);
            this.radioEXIF.Name = "radioEXIF";
            this.radioEXIF.Size = new System.Drawing.Size(85, 17);
            this.radioEXIF.TabIndex = 3;
            this.radioEXIF.TabStop = true;
            this.radioEXIF.Text = "Imgem .EXIF";
            this.radioEXIF.UseVisualStyleBackColor = true;
            // 
            // radioICON
            // 
            this.radioICON.AutoSize = true;
            this.radioICON.Location = new System.Drawing.Point(23, 100);
            this.radioICON.Name = "radioICON";
            this.radioICON.Size = new System.Drawing.Size(88, 17);
            this.radioICON.TabIndex = 4;
            this.radioICON.TabStop = true;
            this.radioICON.Text = "Imgem .ICON";
            this.radioICON.UseVisualStyleBackColor = true;
            // 
            // radioGIF
            // 
            this.radioGIF.AutoSize = true;
            this.radioGIF.Location = new System.Drawing.Point(23, 123);
            this.radioGIF.Name = "radioGIF";
            this.radioGIF.Size = new System.Drawing.Size(79, 17);
            this.radioGIF.TabIndex = 5;
            this.radioGIF.TabStop = true;
            this.radioGIF.Text = "Imgem .GIF";
            this.radioGIF.UseVisualStyleBackColor = true;
            // 
            // radioPNG
            // 
            this.radioPNG.AutoSize = true;
            this.radioPNG.Location = new System.Drawing.Point(23, 54);
            this.radioPNG.Name = "radioPNG";
            this.radioPNG.Size = new System.Drawing.Size(85, 17);
            this.radioPNG.TabIndex = 6;
            this.radioPNG.TabStop = true;
            this.radioPNG.Text = "Imgem .PNG";
            this.radioPNG.UseVisualStyleBackColor = true;
            // 
            // radioBMP
            // 
            this.radioBMP.AutoSize = true;
            this.radioBMP.Location = new System.Drawing.Point(23, 77);
            this.radioBMP.Name = "radioBMP";
            this.radioBMP.Size = new System.Drawing.Size(85, 17);
            this.radioBMP.TabIndex = 7;
            this.radioBMP.TabStop = true;
            this.radioBMP.Text = "Imgem .BMP";
            this.radioBMP.UseVisualStyleBackColor = true;
            // 
            // radioJPG
            // 
            this.radioJPG.AutoSize = true;
            this.radioJPG.Location = new System.Drawing.Point(23, 31);
            this.radioJPG.Name = "radioJPG";
            this.radioJPG.Size = new System.Drawing.Size(82, 17);
            this.radioJPG.TabIndex = 8;
            this.radioJPG.TabStop = true;
            this.radioJPG.Text = "Imgem .JPG";
            this.radioJPG.UseVisualStyleBackColor = true;
            // 
            // groupBox1E
            // 
            this.groupBox1E.Controls.Add(this.btnEscolherImagem);
            this.groupBox1E.Location = new System.Drawing.Point(7, 39);
            this.groupBox1E.Name = "groupBox1E";
            this.groupBox1E.Size = new System.Drawing.Size(235, 100);
            this.groupBox1E.TabIndex = 0;
            this.groupBox1E.TabStop = false;
            this.groupBox1E.Text = "Primeira Etapa";
            // 
            // btnEscolherImagem
            // 
            this.btnEscolherImagem.Location = new System.Drawing.Point(23, 28);
            this.btnEscolherImagem.Name = "btnEscolherImagem";
            this.btnEscolherImagem.Size = new System.Drawing.Size(193, 52);
            this.btnEscolherImagem.TabIndex = 0;
            this.btnEscolherImagem.Text = "Escolher Imagem";
            this.btnEscolherImagem.UseVisualStyleBackColor = true;
            this.btnEscolherImagem.Click += new System.EventHandler(this.btnEscolherImagem_Click);
            // 
            // groupBoxImagem
            // 
            this.groupBoxImagem.Controls.Add(this.pictureBox);
            this.groupBoxImagem.Location = new System.Drawing.Point(280, 13);
            this.groupBoxImagem.Name = "groupBoxImagem";
            this.groupBoxImagem.Size = new System.Drawing.Size(508, 529);
            this.groupBoxImagem.TabIndex = 1;
            this.groupBoxImagem.TabStop = false;
            this.groupBoxImagem.Text = "Imgem Escolhida";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(18, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(470, 480);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.groupBoxImagem);
            this.Controls.Add(this.groupBoxConf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxConf.ResumeLayout(false);
            this.groupBox3E.ResumeLayout(false);
            this.groupBox2E.ResumeLayout(false);
            this.groupBox2E.PerformLayout();
            this.groupBox1E.ResumeLayout(false);
            this.groupBoxImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConf;
        private System.Windows.Forms.GroupBox groupBox3E;
        private System.Windows.Forms.GroupBox groupBox2E;
        private System.Windows.Forms.GroupBox groupBox1E;
        private System.Windows.Forms.Button btnConverterImagem;
        private System.Windows.Forms.Button btnEscolherImagem;
        private System.Windows.Forms.RadioButton radioEXIF;
        private System.Windows.Forms.RadioButton radioICON;
        private System.Windows.Forms.RadioButton radioGIF;
        private System.Windows.Forms.RadioButton radioPNG;
        private System.Windows.Forms.RadioButton radioBMP;
        private System.Windows.Forms.RadioButton radioJPG;
        private System.Windows.Forms.GroupBox groupBoxImagem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}