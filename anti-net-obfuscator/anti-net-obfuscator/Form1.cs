using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anti_net_obfuscator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Kasım Mert ŞENTÜRK - 03.08.2020
         * https://mertsenturk.net
         * Bu program halka açık lisans olarak lisanslanmıştı ve kullanımı serbesttir.
         * Dilediğiniz gibi kaynak kodlarda oynama yapabilirsiniz fakat tek şart ile yine aynı şekilde kaynak kodlar görünecek biçimdedir.
         * İYİ KODLAMALAR
         */
        string dosyadi;
        private void button2_Click(object sender, EventArgs e)
        {
            var stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Write);
            stream.Seek(244, SeekOrigin.Begin);
            stream.WriteByte(11);
            stream.Flush();
            stream.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Executable|*.exe|DLL|*.dll";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 dosyadi = openFileDialog1.FileName;
            }
        }
    }
}
