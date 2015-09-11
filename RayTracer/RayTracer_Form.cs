using System.Drawing;
using System.Windows.Forms;

namespace RayTracer
{
    internal class RayTracer_Form : Form
    {
        private PictureBox pictureBox1;
        private Button sync_btn;
        public RayTracer_Form()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.sync_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sync_btn
            // 
            this.sync_btn.Location = new System.Drawing.Point(397, 426);
            this.sync_btn.Name = "sync_btn";
            this.sync_btn.Size = new System.Drawing.Size(75, 23);
            this.sync_btn.TabIndex = 0;
            this.sync_btn.Text = "Sync";
            this.sync_btn.UseMnemonic = false;
            this.sync_btn.UseVisualStyleBackColor = true;
            this.sync_btn.Click += new System.EventHandler(this.sync_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Image = new Bitmap("raytracer.png");
            this.pictureBox1.Size = new System.Drawing.Size(460, 408);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RayTracer_Form
            // 
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sync_btn);
            this.Name = "RayTracer_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void sync_btn_Click(object sender, System.EventArgs e)
        {
            Bitmap bmp = new Bitmap("raytracer.png");
            pictureBox1.Image = bmp;
        }
    }
}