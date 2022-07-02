﻿namespace POC.ImageConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources being used.
        /// </summary>
        /// <param name="disposing">true if it is necessary to dispose of managed resources; otherwise false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code generated by Windows Form Designer

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxConfigurations = new System.Windows.Forms.GroupBox();
            this.groupBoxThirdStep = new System.Windows.Forms.GroupBox();
            this.buttonConvertImage = new System.Windows.Forms.Button();
            this.groupBoxSecondStep = new System.Windows.Forms.GroupBox();
            this.radioButtonTIFF = new System.Windows.Forms.RadioButton();
            this.radioButtonEXIF = new System.Windows.Forms.RadioButton();
            this.radioButtonICON = new System.Windows.Forms.RadioButton();
            this.radioButtonGIF = new System.Windows.Forms.RadioButton();
            this.radioButtonPNG = new System.Windows.Forms.RadioButton();
            this.radioButtonBMP = new System.Windows.Forms.RadioButton();
            this.radioButtonJPG = new System.Windows.Forms.RadioButton();
            this.groupBoxFirstStep = new System.Windows.Forms.GroupBox();
            this.buttonChooseImage = new System.Windows.Forms.Button();
            this.groupBoxChosenImage = new System.Windows.Forms.GroupBox();
            this.pictureBoxChosenImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.radioButtonWMF = new System.Windows.Forms.RadioButton();
            this.radioButtonEMF = new System.Windows.Forms.RadioButton();
            this.groupBoxConfigurations.SuspendLayout();
            this.groupBoxThirdStep.SuspendLayout();
            this.groupBoxSecondStep.SuspendLayout();
            this.groupBoxFirstStep.SuspendLayout();
            this.groupBoxChosenImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChosenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConfigurations
            // 
            this.groupBoxConfigurations.Controls.Add(this.groupBoxThirdStep);
            this.groupBoxConfigurations.Controls.Add(this.groupBoxSecondStep);
            this.groupBoxConfigurations.Controls.Add(this.groupBoxFirstStep);
            this.groupBoxConfigurations.Location = new System.Drawing.Point(13, 13);
            this.groupBoxConfigurations.Name = "groupBoxConfigurations";
            this.groupBoxConfigurations.Size = new System.Drawing.Size(248, 529);
            this.groupBoxConfigurations.TabIndex = 0;
            this.groupBoxConfigurations.TabStop = false;
            this.groupBoxConfigurations.Text = "Configurations";
            // 
            // groupBoxThirdStep
            // 
            this.groupBoxThirdStep.Controls.Add(this.buttonConvertImage);
            this.groupBoxThirdStep.Location = new System.Drawing.Point(7, 402);
            this.groupBoxThirdStep.Name = "groupBoxThirdStep";
            this.groupBoxThirdStep.Size = new System.Drawing.Size(235, 100);
            this.groupBoxThirdStep.TabIndex = 2;
            this.groupBoxThirdStep.TabStop = false;
            this.groupBoxThirdStep.Text = "Third Step";
            // 
            // buttonConvertImage
            // 
            this.buttonConvertImage.Location = new System.Drawing.Point(23, 28);
            this.buttonConvertImage.Name = "buttonConvertImage";
            this.buttonConvertImage.Size = new System.Drawing.Size(193, 52);
            this.buttonConvertImage.TabIndex = 1;
            this.buttonConvertImage.Text = "Convert Image";
            this.buttonConvertImage.UseVisualStyleBackColor = true;
            this.buttonConvertImage.Click += new System.EventHandler(this.BtnConvertImage_Click);
            // 
            // groupBoxSecondStep
            // 
            this.groupBoxSecondStep.Controls.Add(this.radioButtonEMF);
            this.groupBoxSecondStep.Controls.Add(this.radioButtonWMF);
            this.groupBoxSecondStep.Controls.Add(this.radioButtonTIFF);
            this.groupBoxSecondStep.Controls.Add(this.radioButtonEXIF);
            this.groupBoxSecondStep.Controls.Add(this.radioButtonICON);
            this.groupBoxSecondStep.Controls.Add(this.radioButtonGIF);
            this.groupBoxSecondStep.Controls.Add(this.radioButtonPNG);
            this.groupBoxSecondStep.Controls.Add(this.radioButtonBMP);
            this.groupBoxSecondStep.Controls.Add(this.radioButtonJPG);
            this.groupBoxSecondStep.Location = new System.Drawing.Point(7, 145);
            this.groupBoxSecondStep.Name = "groupBoxSecondStep";
            this.groupBoxSecondStep.Size = new System.Drawing.Size(235, 251);
            this.groupBoxSecondStep.TabIndex = 1;
            this.groupBoxSecondStep.TabStop = false;
            this.groupBoxSecondStep.Text = "Second Step";
            // 
            // radioButtonTIFF
            // 
            this.radioButtonTIFF.AutoSize = true;
            this.radioButtonTIFF.Location = new System.Drawing.Point(23, 146);
            this.radioButtonTIFF.Name = "radioButtonTIFF";
            this.radioButtonTIFF.Size = new System.Drawing.Size(49, 17);
            this.radioButtonTIFF.TabIndex = 9;
            this.radioButtonTIFF.TabStop = true;
            this.radioButtonTIFF.Text = ".TiFF";
            this.radioButtonTIFF.UseVisualStyleBackColor = true;
            // 
            // radioButtonEXIF
            // 
            this.radioButtonEXIF.AutoSize = true;
            this.radioButtonEXIF.Location = new System.Drawing.Point(23, 215);
            this.radioButtonEXIF.Name = "radioButtonEXIF";
            this.radioButtonEXIF.Size = new System.Drawing.Size(51, 17);
            this.radioButtonEXIF.TabIndex = 3;
            this.radioButtonEXIF.TabStop = true;
            this.radioButtonEXIF.Text = ".EXIF";
            this.radioButtonEXIF.UseVisualStyleBackColor = true;
            // 
            // radioButtonICON
            // 
            this.radioButtonICON.AutoSize = true;
            this.radioButtonICON.Location = new System.Drawing.Point(23, 100);
            this.radioButtonICON.Name = "radioButtonICON";
            this.radioButtonICON.Size = new System.Drawing.Size(54, 17);
            this.radioButtonICON.TabIndex = 4;
            this.radioButtonICON.TabStop = true;
            this.radioButtonICON.Text = ".ICON";
            this.radioButtonICON.UseVisualStyleBackColor = true;
            // 
            // radioButtonGIF
            // 
            this.radioButtonGIF.AutoSize = true;
            this.radioButtonGIF.Location = new System.Drawing.Point(23, 123);
            this.radioButtonGIF.Name = "radioButtonGIF";
            this.radioButtonGIF.Size = new System.Drawing.Size(45, 17);
            this.radioButtonGIF.TabIndex = 5;
            this.radioButtonGIF.TabStop = true;
            this.radioButtonGIF.Text = ".GIF";
            this.radioButtonGIF.UseVisualStyleBackColor = true;
            // 
            // radioButtonPNG
            // 
            this.radioButtonPNG.AutoSize = true;
            this.radioButtonPNG.Location = new System.Drawing.Point(23, 54);
            this.radioButtonPNG.Name = "radioButtonPNG";
            this.radioButtonPNG.Size = new System.Drawing.Size(51, 17);
            this.radioButtonPNG.TabIndex = 6;
            this.radioButtonPNG.TabStop = true;
            this.radioButtonPNG.Text = ".PNG";
            this.radioButtonPNG.UseVisualStyleBackColor = true;
            // 
            // radioButtonBMP
            // 
            this.radioButtonBMP.AutoSize = true;
            this.radioButtonBMP.Location = new System.Drawing.Point(23, 77);
            this.radioButtonBMP.Name = "radioButtonBMP";
            this.radioButtonBMP.Size = new System.Drawing.Size(51, 17);
            this.radioButtonBMP.TabIndex = 7;
            this.radioButtonBMP.TabStop = true;
            this.radioButtonBMP.Text = ".BMP";
            this.radioButtonBMP.UseVisualStyleBackColor = true;
            // 
            // radioButtonJPG
            // 
            this.radioButtonJPG.AutoSize = true;
            this.radioButtonJPG.Location = new System.Drawing.Point(23, 31);
            this.radioButtonJPG.Name = "radioButtonJPG";
            this.radioButtonJPG.Size = new System.Drawing.Size(48, 17);
            this.radioButtonJPG.TabIndex = 8;
            this.radioButtonJPG.TabStop = true;
            this.radioButtonJPG.Text = ".JPG";
            this.radioButtonJPG.UseVisualStyleBackColor = true;
            // 
            // groupBoxFirstStep
            // 
            this.groupBoxFirstStep.Controls.Add(this.buttonChooseImage);
            this.groupBoxFirstStep.Location = new System.Drawing.Point(7, 39);
            this.groupBoxFirstStep.Name = "groupBoxFirstStep";
            this.groupBoxFirstStep.Size = new System.Drawing.Size(235, 100);
            this.groupBoxFirstStep.TabIndex = 0;
            this.groupBoxFirstStep.TabStop = false;
            this.groupBoxFirstStep.Text = "First Step";
            // 
            // buttonChooseImage
            // 
            this.buttonChooseImage.Location = new System.Drawing.Point(23, 28);
            this.buttonChooseImage.Name = "buttonChooseImage";
            this.buttonChooseImage.Size = new System.Drawing.Size(193, 52);
            this.buttonChooseImage.TabIndex = 0;
            this.buttonChooseImage.Text = "Choose Image";
            this.buttonChooseImage.UseVisualStyleBackColor = true;
            this.buttonChooseImage.Click += new System.EventHandler(this.BtnChooseImage_Click);
            // 
            // groupBoxChosenImage
            // 
            this.groupBoxChosenImage.Controls.Add(this.pictureBoxChosenImage);
            this.groupBoxChosenImage.Location = new System.Drawing.Point(280, 13);
            this.groupBoxChosenImage.Name = "groupBoxChosenImage";
            this.groupBoxChosenImage.Size = new System.Drawing.Size(508, 529);
            this.groupBoxChosenImage.TabIndex = 1;
            this.groupBoxChosenImage.TabStop = false;
            this.groupBoxChosenImage.Text = "Chosen Image";
            // 
            // pictureBoxChosenImage
            // 
            this.pictureBoxChosenImage.Location = new System.Drawing.Point(18, 30);
            this.pictureBoxChosenImage.Name = "pictureBoxChosenImage";
            this.pictureBoxChosenImage.Size = new System.Drawing.Size(470, 480);
            this.pictureBoxChosenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChosenImage.TabIndex = 0;
            this.pictureBoxChosenImage.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // radioButtonWMF
            // 
            this.radioButtonWMF.AutoSize = true;
            this.radioButtonWMF.Location = new System.Drawing.Point(23, 169);
            this.radioButtonWMF.Name = "radioButtonWMF";
            this.radioButtonWMF.Size = new System.Drawing.Size(54, 17);
            this.radioButtonWMF.TabIndex = 10;
            this.radioButtonWMF.TabStop = true;
            this.radioButtonWMF.Text = ".WMF";
            this.radioButtonWMF.UseVisualStyleBackColor = true;
            // 
            // radioButtonEMF
            // 
            this.radioButtonEMF.AutoSize = true;
            this.radioButtonEMF.Location = new System.Drawing.Point(23, 192);
            this.radioButtonEMF.Name = "radioButtonEMF";
            this.radioButtonEMF.Size = new System.Drawing.Size(50, 17);
            this.radioButtonEMF.TabIndex = 11;
            this.radioButtonEMF.TabStop = true;
            this.radioButtonEMF.Text = ".EMF";
            this.radioButtonEMF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.groupBoxChosenImage);
            this.Controls.Add(this.groupBoxConfigurations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxConfigurations.ResumeLayout(false);
            this.groupBoxThirdStep.ResumeLayout(false);
            this.groupBoxSecondStep.ResumeLayout(false);
            this.groupBoxSecondStep.PerformLayout();
            this.groupBoxFirstStep.ResumeLayout(false);
            this.groupBoxChosenImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChosenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConfigurations;
        private System.Windows.Forms.GroupBox groupBoxThirdStep;
        private System.Windows.Forms.GroupBox groupBoxSecondStep;
        private System.Windows.Forms.GroupBox groupBoxFirstStep;
        private System.Windows.Forms.Button buttonConvertImage;
        private System.Windows.Forms.Button buttonChooseImage;
        private System.Windows.Forms.RadioButton radioButtonEXIF;
        private System.Windows.Forms.RadioButton radioButtonICON;
        private System.Windows.Forms.RadioButton radioButtonGIF;
        private System.Windows.Forms.RadioButton radioButtonPNG;
        private System.Windows.Forms.RadioButton radioButtonBMP;
        private System.Windows.Forms.RadioButton radioButtonJPG;
        private System.Windows.Forms.GroupBox groupBoxChosenImage;
        private System.Windows.Forms.PictureBox pictureBoxChosenImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RadioButton radioButtonTIFF;
        private System.Windows.Forms.RadioButton radioButtonWMF;
        private System.Windows.Forms.RadioButton radioButtonEMF;
    }
}