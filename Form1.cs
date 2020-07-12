using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrCodeUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnQrCodeGenerator_Click(object sender, EventArgs e)
        {
            var qrCodeContent = txtQrCodeContent.Text;
            if (string.IsNullOrWhiteSpace(qrCodeContent))
            {
                lblErrorMessage.Text = "O conteúdo não pode ser vazio";
                return;
            }

            lblErrorMessage.Text = string.Empty;
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(qrCodeContent, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeBitmap = qrCode.GetGraphic(5);
            qrCodePictureBox.Image = qrCodeBitmap;
        }
    }
}
