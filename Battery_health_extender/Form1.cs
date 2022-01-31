using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Win32;

namespace Battery_health_extender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbAnimación.Visible = false;
            pbAnimación.Enabled = false;
        }
        Color ColorPorcentaje(int Porcentaje) {
            if (Porcentaje <= 100 && Porcentaje >= 75)
            {
                return Color.Green;
            }
            else if (Porcentaje <= 74 && Porcentaje >= 50)
            {
                return Color.Blue;
            }
            else if (Porcentaje <= 49 && Porcentaje >= 25)
            {
                return Color.Brown;
            }
            else {
                return Color.Red;
            }
        }
        public void Bateria() {
            var estado = typeof(PowerStatus);
            PropertyInfo[] propiedades = estado.GetProperties();
            PropertyInfo carga = propiedades[3];
            object valor = carga.GetValue(SystemInformation.PowerStatus, null);
            progresBarCustom1.Value = Convert.ToInt32(Convert.ToDecimal(valor)*100);
            progresBarCustom1.SliderColor = ColorPorcentaje(Convert.ToInt32(Convert.ToDecimal(valor) * 100));
            PropertyInfo Conectado = propiedades[0];
            object conexion = Conectado.GetValue(SystemInformation.PowerStatus, null);
            if (Convert.ToBoolean(conexion) == true)
            {
                if (progresBarCustom1.Value == 100) {
                    Battery_healt_extender.BalloonTipText = "Desconecte el cargador";
                    Battery_healt_extender.ShowBalloonTip(1000);
                }
                lblEstado.Text = "CARGANDO";
                pbAnimación.Image = Image.FromFile(Application.StartupPath + "//Cargando.gif");
                pbAnimación.Visible = true;
                pbAnimación.Enabled = true;

            }
            else {
                lblEstado.Text = "No Cargando";
                pbAnimación.Image = Image.FromFile(Application.StartupPath + "//Descargando.gif");

                pbAnimación.Visible = true;
                pbAnimación.Enabled = true;
            }

        }

        private void TimerCargador_Tick(object sender, EventArgs e)
        {
            Bateria();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bateria();
        }
        int m, mx, my;

        private void pnBorder_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                Battery_healt_extender.BalloonTipText = "La applicación sera ejecutada en segundo plano";
                Battery_healt_extender.ShowBalloonTip(1000);
            }
            
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                Battery_healt_extender.BalloonTipText = "La applicación sera ejecutada en segundo plano";
                Battery_healt_extender.ShowBalloonTip(1000);
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }
        private void pnBorder_MouseUp(object sender, MouseEventArgs e)
        {
            m =0;
        }

    }
}
