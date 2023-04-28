using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qrcode_scan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] code = { "b2555", "B1666", "c6559" };
        private void generateButton1_Click(object sender, EventArgs e)
        {
            foreach (string Num in code)
            {
                resultPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                Zen.Barcode.CodeQrBarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                resultPictureBox.Image = barcode.Draw(Num, 200);
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                resultPictureBox.Image.Save(
                    path + "\\" + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg",
                    ImageFormat.Jpeg);
            }
        }
    }
}
