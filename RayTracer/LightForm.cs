using System;
using System.Windows.Forms;

namespace RayTracer
{
    internal class LightForm : Form
    {
        private Label label3;
        private Label light_label_pos;
        private Label light_label_color;
        private TextBox color_txtbox_b;
        private TextBox color_txtbox_g;
        private TextBox color_txtbox_r;
        private TextBox txtbox_x;
        private TextBox txtbox_y;
        private TextBox txtbox_z;
        private Label sphere_label_comma1;
        private Label sphere_label_comma2;
        private Label label1;
        private Label label2;
        private Button button1;
        private RayTracer_Form parent;

        public LightForm(RayTracer_Form rayTracer_Form)
        {
            this.parent = rayTracer_Form;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.light_label_pos = new System.Windows.Forms.Label();
            this.light_label_color = new System.Windows.Forms.Label();
            this.color_txtbox_b = new System.Windows.Forms.TextBox();
            this.color_txtbox_g = new System.Windows.Forms.TextBox();
            this.color_txtbox_r = new System.Windows.Forms.TextBox();
            this.txtbox_x = new System.Windows.Forms.TextBox();
            this.txtbox_y = new System.Windows.Forms.TextBox();
            this.txtbox_z = new System.Windows.Forms.TextBox();
            this.sphere_label_comma1 = new System.Windows.Forms.Label();
            this.sphere_label_comma2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "B:";
            // 
            // light_label_pos
            // 
            this.light_label_pos.AutoSize = true;
            this.light_label_pos.Location = new System.Drawing.Point(12, 101);
            this.light_label_pos.Name = "light_label_pos";
            this.light_label_pos.Size = new System.Drawing.Size(44, 13);
            this.light_label_pos.TabIndex = 30;
            this.light_label_pos.Text = "Position";
            // 
            // light_label_color
            // 
            this.light_label_color.AutoSize = true;
            this.light_label_color.Location = new System.Drawing.Point(15, 150);
            this.light_label_color.Name = "light_label_color";
            this.light_label_color.Size = new System.Drawing.Size(31, 13);
            this.light_label_color.TabIndex = 29;
            this.light_label_color.Text = "Color";
            // 
            // color_txtbox_b
            // 
            this.color_txtbox_b.Location = new System.Drawing.Point(196, 147);
            this.color_txtbox_b.Name = "color_txtbox_b";
            this.color_txtbox_b.Size = new System.Drawing.Size(27, 20);
            this.color_txtbox_b.TabIndex = 28;
            this.color_txtbox_b.Text = "255";
            // 
            // color_txtbox_g
            // 
            this.color_txtbox_g.Location = new System.Drawing.Point(137, 147);
            this.color_txtbox_g.Name = "color_txtbox_g";
            this.color_txtbox_g.Size = new System.Drawing.Size(27, 20);
            this.color_txtbox_g.TabIndex = 27;
            this.color_txtbox_g.Text = "255";
            // 
            // color_txtbox_r
            // 
            this.color_txtbox_r.Location = new System.Drawing.Point(85, 147);
            this.color_txtbox_r.Name = "color_txtbox_r";
            this.color_txtbox_r.Size = new System.Drawing.Size(27, 20);
            this.color_txtbox_r.TabIndex = 26;
            this.color_txtbox_r.Text = "255";
            // 
            // txtbox_x
            // 
            this.txtbox_x.Location = new System.Drawing.Point(84, 98);
            this.txtbox_x.Name = "txtbox_x";
            this.txtbox_x.Size = new System.Drawing.Size(29, 20);
            this.txtbox_x.TabIndex = 23;
            this.txtbox_x.Text = "0";
            // 
            // txtbox_y
            // 
            this.txtbox_y.Location = new System.Drawing.Point(135, 98);
            this.txtbox_y.Name = "txtbox_y";
            this.txtbox_y.Size = new System.Drawing.Size(29, 20);
            this.txtbox_y.TabIndex = 22;
            this.txtbox_y.Text = "0";
            // 
            // txtbox_z
            // 
            this.txtbox_z.Location = new System.Drawing.Point(196, 98);
            this.txtbox_z.Name = "txtbox_z";
            this.txtbox_z.Size = new System.Drawing.Size(29, 20);
            this.txtbox_z.TabIndex = 21;
            this.txtbox_z.Text = "0";
            // 
            // sphere_label_comma1
            // 
            this.sphere_label_comma1.AutoSize = true;
            this.sphere_label_comma1.Location = new System.Drawing.Point(120, 105);
            this.sphere_label_comma1.Name = "sphere_label_comma1";
            this.sphere_label_comma1.Size = new System.Drawing.Size(10, 13);
            this.sphere_label_comma1.TabIndex = 24;
            this.sphere_label_comma1.Text = ",";
            // 
            // sphere_label_comma2
            // 
            this.sphere_label_comma2.AutoSize = true;
            this.sphere_label_comma2.Location = new System.Drawing.Point(173, 105);
            this.sphere_label_comma2.Name = "sphere_label_comma2";
            this.sphere_label_comma2.Size = new System.Drawing.Size(10, 13);
            this.sphere_label_comma2.TabIndex = 25;
            this.sphere_label_comma2.Text = ",";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "G:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LightForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.light_label_pos);
            this.Controls.Add(this.light_label_color);
            this.Controls.Add(this.color_txtbox_b);
            this.Controls.Add(this.color_txtbox_g);
            this.Controls.Add(this.color_txtbox_r);
            this.Controls.Add(this.txtbox_x);
            this.Controls.Add(this.txtbox_y);
            this.Controls.Add(this.txtbox_z);
            this.Controls.Add(this.sphere_label_comma1);
            this.Controls.Add(this.sphere_label_comma2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "LightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try {
                double r = Convert.ToDouble(color_txtbox_r.Text);
                double g = Convert.ToDouble(color_txtbox_g.Text);
                double b = Convert.ToDouble(color_txtbox_b.Text);
                Color c = new Color(r,g,b);
                double x = Convert.ToDouble(txtbox_x.Text);
                double y = Convert.ToDouble(txtbox_y.Text);
                double z = Convert.ToDouble(txtbox_z.Text);
                Position p = new Position(x, y, z);
                LightSource l = new LightSource(p, c);
                RayTracer_Form.lights.AddLast(l);
                parent.updateLights();
                Console.WriteLine("light created");
            }
            catch
            {
                Console.WriteLine("ERROR: Invalid Input for Light source values");
            }
            this.Hide();
        }
    }
}