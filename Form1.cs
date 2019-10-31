using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gerador_de_Chaves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ocultar();
            this.Size = new Size(290,504);
        }

        private void Ocultar()
        {
            Grup_dias.Visible = false;
            Grup_mes.Visible = false;
            Data.Visible = false;
        }
        private void Atalhos(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(rd_dias.Checked == true)
            {
                Dias();
            }
            if(rd_mes.Checked == true)
            {
                Mês();
            }
            if(rd_data.Checked == true)
            {
                Date();
            }

        }
        private void Dias()
        {
            string Prazo = "0";
            string ID = Licença.Base64Encode(txt_id.Text);
            string Tipo = Licença.Base64Encode("Dias");

            int Radio = GetCheckedRadioButton(Grup_dias);
            if (Radio == 11)
                Prazo = Licença.Base64Encode("10 Dias");
            if (Radio == 10)
                Prazo = Licença.Base64Encode("20 Dias");
            if (Radio == 9)
                Prazo = Licença.Base64Encode("30 Dias");
            if (Radio == 8)
                Prazo = Licença.Base64Encode("40 Dias");
            if (Radio == 7)
                Prazo = Licença.Base64Encode("50 Dias");
            if (Radio == 6)
                Prazo = Licença.Base64Encode("60 Dias");
            if (Radio == 5)
                Prazo = Licença.Base64Encode("70 Dias");
            if (Radio == 4)
                Prazo = Licença.Base64Encode("80 Dias");
            if (Radio == 3)
                Prazo = Licença.Base64Encode("90 Dias");
            if (Radio == 2)
                Prazo = Licença.Base64Encode("100 Dias");
            if (Radio == 1)
                Prazo = Licença.Base64Encode("110 Dias");
            if (Radio == 0)
                Prazo = Licença.Base64Encode("120 Dias");

            string Chave = ID +"#"+ Tipo + "#" + Prazo;
            txt_chave.Text = Chave;

        }
        private void Mês()
        {
            string Prazo = "0";
            string ID = Licença.Base64Encode(txt_id.Text);
            string Tipo = Licença.Base64Encode("Mês");

            int Radio = GetCheckedRadioButton(Grup_mes);
            if (Radio == 3)
                Prazo = Licença.Base64Encode("1 Mês");
            if (Radio == 2)
                Prazo = Licença.Base64Encode("3 Meses");
            if (Radio == 1)
                Prazo = Licença.Base64Encode("2 Meses");
            if (Radio == 0)
                Prazo = Licença.Base64Encode("4 Meses");

            string Chave = ID + "#" + Tipo + "#" + Prazo;
            txt_chave.Text = Chave;
        }
        private void Date()
        {
            string Prazo = "0";
            string ID = Licença.Base64Encode(txt_id.Text);
            string Tipo = Licença.Base64Encode("Data");

            string dataInicial = DateTime.Now.ToString("dd/MM/yyyy");
            string dataFinal = Data.Value.ToString();
            TimeSpan date = Convert.ToDateTime(dataFinal) - Convert.ToDateTime(dataInicial);
            int totalDias = date.Days;

            Prazo = Licença.Base64Encode(totalDias.ToString());

            string Chave = ID + "#" + Tipo + "#" + Prazo;
            txt_chave.Text = Chave;
        }
        private int GetCheckedRadioButton(GroupBox controls)
        {
            int ret = -1;
            for (int i = 0; i < controls.Controls.Count && ret == -1; i++)
            {
                if (controls.Controls[i] is RadioButton)
                {
                    if (((RadioButton)controls.Controls[i]).Checked)
                    {
                        ret = i; // seria o índice que precisa.                        
                    }
                }
            }
            return ret;
        }
        private void rd_dias_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar();
            if (rd_dias.Checked == true)
            {
                Grup_dias.Visible = true;
                Grup_dias.Location = new Point(13, 157);
            }           
        }
        private void rd_mes_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar();
            if (rd_mes.Checked == true)
            {
                Grup_mes.Visible = true;
                Grup_mes.Location = new Point(13, 157);
            }
        }
        private void rd_data_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar();
            if (rd_data.Checked == true)
            {
                Data.Visible = true;
                Data.Location = new Point(13, 157);
            }
        }
    }
}
