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
    public partial class frmTelaSplash : Form
    {
        public frmTelaSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Códigos do timer da telaSplash

            //Se o timer for menor ou igual a 40
            if(pbCarrega.Value<=40)
            {
                //O timer irá contar o valor dele mais quatro
                pbCarrega.Value = pbCarrega.Value + 4;
                //E exiirá a mensagem abaixo
                label2.Text = "Iniciando..." + pbCarrega.Value + "%";
            }
            //Se o timer for menor ou igual a 60
            else
                if (pbCarrega.Value<=60)
            {
                //O timer irá contar o valor dele mais quatro
                pbCarrega.Value = pbCarrega.Value + 4;
                //E exiirá a mensagem abaixo
                label2.Text = "Processando..." + pbCarrega.Value + "%";
            }

            //Se o timer for menor ou igual a 90
            else
                if (pbCarrega.Value<=90)
            {
                //O timer irá contar o valor dele mais quatro
                pbCarrega.Value = pbCarrega.Value + 4;
                //E exiirá a mensagem abaixo
                label2.Text = "Abrindo..." + pbCarrega.Value + "%";
            }

            //Se o timer for maior que 90
            if(pbCarrega.Value>90)
            {
                //O timer ficará desabilitado
                timer1.Enabled = false;

                //E a tela Splash não ficará visível
                this.Visible = false;

                //Em seguida o outro formulário será exibido
                frmTelaPrincipal principal = new frmTelaPrincipal();
                principal.ShowDialog();
            }
        }
    }
}
