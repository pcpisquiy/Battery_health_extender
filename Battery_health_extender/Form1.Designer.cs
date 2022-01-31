
namespace Battery_health_extender
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbAnimación = new System.Windows.Forms.PictureBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.TimerCargador = new System.Windows.Forms.Timer(this.components);
            this.pnBorder = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Battery_healt_extender = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progresBarCustom1 = new Battery_health_extender.ProgressCustomBar.ProgresBarCustom();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimación)).BeginInit();
            this.pnBorder.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAnimación
            // 
            this.pbAnimación.Location = new System.Drawing.Point(55, 218);
            this.pbAnimación.Name = "pbAnimación";
            this.pbAnimación.Size = new System.Drawing.Size(706, 360);
            this.pbAnimación.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimación.TabIndex = 2;
            this.pbAnimación.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Black;
            this.lblEstado.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(0, 103);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(784, 100);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "lblEstado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerCargador
            // 
            this.TimerCargador.Enabled = true;
            this.TimerCargador.Interval = 2000;
            this.TimerCargador.Tick += new System.EventHandler(this.TimerCargador_Tick);
            // 
            // pnBorder
            // 
            this.pnBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBorder.Controls.Add(this.Minimize);
            this.pnBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBorder.Location = new System.Drawing.Point(0, 0);
            this.pnBorder.Name = "pnBorder";
            this.pnBorder.Size = new System.Drawing.Size(796, 100);
            this.pnBorder.TabIndex = 5;
            this.pnBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBorder_MouseDown);
            this.pnBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBorder_MouseMove);
            this.pnBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnBorder_MouseUp);
            // 
            // Minimize
            // 
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = global::Battery_health_extender.Properties.Resources.Minimize;
            this.Minimize.Location = new System.Drawing.Point(685, -2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(109, 110);
            this.Minimize.TabIndex = 0;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Battery_healt_extender
            // 
            this.Battery_healt_extender.ContextMenuStrip = this.contextMenuStrip1;
            this.Battery_healt_extender.Icon = ((System.Drawing.Icon)(resources.GetObject("Battery_healt_extender.Icon")));
            this.Battery_healt_extender.Text = "Battery_healt_extender";
            this.Battery_healt_extender.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarToolStripMenuItem,
            this.minimizarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 76);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // progresBarCustom1
            // 
            this.progresBarCustom1.ChannelColor = System.Drawing.Color.Black;
            this.progresBarCustom1.ChannelHeight = 50;
            this.progresBarCustom1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progresBarCustom1.ForeBackColor = System.Drawing.Color.Black;
            this.progresBarCustom1.ForeColor = System.Drawing.Color.White;
            this.progresBarCustom1.Location = new System.Drawing.Point(31, 610);
            this.progresBarCustom1.Name = "progresBarCustom1";
            this.progresBarCustom1.ShowMaximun = true;
            this.progresBarCustom1.ShowValue = Battery_health_extender.ProgressCustomBar.TextPosition.Sliding;
            this.progresBarCustom1.Size = new System.Drawing.Size(753, 67);
            this.progresBarCustom1.SliderColor = System.Drawing.Color.Red;
            this.progresBarCustom1.SliderHeight = 40;
            this.progresBarCustom1.SymbolAfter = "%";
            this.progresBarCustom1.SymbolBefore = "";
            this.progresBarCustom1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(796, 700);
            this.Controls.Add(this.progresBarCustom1);
            this.Controls.Add(this.pnBorder);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.pbAnimación);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battery Healt Extender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimación)).EndInit();
            this.pnBorder.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbAnimación;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Timer TimerCargador;
        private System.Windows.Forms.Panel pnBorder;
        private ProgressCustomBar.ProgresBarCustom progresBarCustom1;
        private System.Windows.Forms.NotifyIcon Battery_healt_extender;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}

