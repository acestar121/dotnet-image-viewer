using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisulNet
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //O componente OpenFileDialog abre uma janela de localização de arquivo

            if(ofdAbrir.ShowDialog()==DialogResult.OK)
            {
                pbImage.Load(ofdAbrir.FileName);
                btnAbrir.Enabled = false;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja apagar a foto?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                pbImage.Image = null;
            }
            btnAbrir.Enabled = true;
            
        }

        private void rbStretch_CheckedChanged(object sender, EventArgs e)
        {
            if(rbStretch.Checked==true)
            {
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void rbCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCenter.Checked == true)
            {
                pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked == true)
            {
                pbImage.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja fechar o programa?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
