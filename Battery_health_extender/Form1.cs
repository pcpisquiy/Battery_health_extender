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
       
        private List<string> Imagenes = new List<string>() { "batRed", "batYellow", "batGreen" };
        bool error = false;
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
            try
            {
                PowerStatus powerStatus = SystemInformation.PowerStatus;
                double batteryLifePercent = powerStatus.BatteryLifePercent;
                int batteryLifeRemaining = powerStatus.BatteryLifeRemaining;
                int batteryLifeRemainingtoCharge = powerStatus.BatteryFullLifetime;
                //progresBarCustom1.Value = Convert.ToInt32(Convert.ToDecimal(batteryLifePercent) * 100);
                //progresBarCustom1.SliderColor = ColorPorcentaje(Convert.ToInt32(Convert.ToDecimal(batteryLifePercent) * 100));
                PowerLineStatus powerLineStatus = powerStatus.PowerLineStatus;
                if (powerLineStatus == PowerLineStatus.Online)
                {
                    lblEstado.Text = "CARGANDO";
                    if (progresBarCustom1.Value == 100)
                    {
                        Battery_healt_extender.BalloonTipText = "Desconecte el cargador";
                        Battery_healt_extender.ShowBalloonTip(1000);
                    }
                    double tiempo_Horas = Convert.ToDouble(batteryLifeRemaining) / 3600.00;
                    double tiempo_Minutos = Math.Round(Convert.ToDouble(tiempo_Horas - Math.Truncate(tiempo_Horas)) * (60), 2);
                    lblTiempo.Text = "Tiempo de carga estimado:" + Convert.ToString(Math.Truncate(tiempo_Horas)) + " horas " + tiempo_Minutos + " minutos";
                    for (int i = 0; i < 3; i++)
                    {

                        pbAnimación.Image = Image.FromFile(Application.StartupPath + "//RESOURCES//" + Imagenes[i] + ".png");
                        pbAnimación.Visible = true;
                        pbAnimación.Enabled = true;
                        pbAnimación.Refresh();
                        System.Threading.Thread.Sleep(1000);
                    }

                }
                else
                {
                    lblEstado.Text = "NO CARGANDO";
                    double tiempo_Horas = Convert.ToDouble(batteryLifeRemaining) / 3600.00;
                    double tiempo_Minutos = Math.Round(Convert.ToDouble(tiempo_Horas - Math.Truncate(tiempo_Horas)) * (60),2);
                    lblTiempo.Text = "Tiempo de descarga estimado:" + Convert.ToString(Math.Truncate(tiempo_Horas))+" horas "+tiempo_Minutos+" minutos";
                    for (int i = 2; i >= 0; i--){
                        pbAnimación.Image = Image.FromFile(Application.StartupPath + "//RESOURCES//" + Imagenes[i] + ".png");
                        pbAnimación.Visible = true;
                        pbAnimación.Enabled = true;
                        pbAnimación.Refresh();
                        System.Threading.Thread.Sleep(1000);

                    }
                }

            }
            catch (Exception ex)
            {

                error = true;
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void TimerCargador_Tick(object sender, EventArgs e)
        {
            if (!error)
            {
                Bateria();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!error)
            {
                Bateria();
            }
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
                Battery_healt_extender.BalloonTipTitle = lblTiempo.Text;
                Battery_healt_extender.BalloonTipText = "Recuerde que para tener una batería en óptimas condiciones debe desconectarla al llegar al 100%";
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
                Battery_healt_extender.BalloonTipTitle = lblTiempo.Text;
                Battery_healt_extender.BalloonTipText = "Recuerde que para tener una batería en óptimas condiciones debe desconectarla al llegar al 100%";
                Battery_healt_extender.ShowBalloonTip(1000);
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            //FrmSettings frm = new FrmSettings();
            //frm.ShowDialog();
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
