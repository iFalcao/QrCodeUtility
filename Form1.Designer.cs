namespace QrCodeUtility
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtQrCodeContent = new System.Windows.Forms.TextBox();
            this.BtnQrCodeGenerator = new System.Windows.Forms.Button();
            this.qrCodePictureBox = new System.Windows.Forms.PictureBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conteúdo do QR Code";
            // 
            // txtQrCodeContent
            // 
            this.txtQrCodeContent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQrCodeContent.Location = new System.Drawing.Point(56, 57);
            this.txtQrCodeContent.Name = "txtQrCodeContent";
            this.txtQrCodeContent.Size = new System.Drawing.Size(672, 27);
            this.txtQrCodeContent.TabIndex = 1;
            // 
            // BtnQrCodeGenerator
            // 
            this.BtnQrCodeGenerator.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnQrCodeGenerator.Location = new System.Drawing.Point(56, 97);
            this.BtnQrCodeGenerator.Name = "BtnQrCodeGenerator";
            this.BtnQrCodeGenerator.Size = new System.Drawing.Size(135, 34);
            this.BtnQrCodeGenerator.TabIndex = 2;
            this.BtnQrCodeGenerator.Text = "Gerar QR Code";
            this.BtnQrCodeGenerator.UseVisualStyleBackColor = true;
            this.BtnQrCodeGenerator.Click += new System.EventHandler(this.BtnQrCodeGenerator_Click);
            // 
            // qrCodePictureBox
            // 
            this.qrCodePictureBox.Location = new System.Drawing.Point(56, 191);
            this.qrCodePictureBox.Name = "qrCodePictureBox";
            this.qrCodePictureBox.Size = new System.Drawing.Size(672, 574);
            this.qrCodePictureBox.TabIndex = 3;
            this.qrCodePictureBox.TabStop = false;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(56, 153);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 15);
            this.lblErrorMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 789);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.qrCodePictureBox);
            this.Controls.Add(this.BtnQrCodeGenerator);
            this.Controls.Add(this.txtQrCodeContent);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "QR Code Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrCodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQrCodeContent;
        private System.Windows.Forms.Button BtnQrCodeGenerator;
        private System.Windows.Forms.PictureBox qrCodePictureBox;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}

