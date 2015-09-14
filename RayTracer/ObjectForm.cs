using System;
using System.Windows.Forms;

namespace RayTracer
{
    internal class ObjectForm : Form
    {
        private Button button1;
        private Label sphere_label_center;
        private TextBox txtbox_x;
        private TextBox txtbox_y;
        private TextBox txtbox_z;
        private Label sphere_label_comma1;
        private Label sphere_label_comma2;
        private TextBox color_txtbox_b;
        private TextBox color_txtbox_g;
        private TextBox color_txtbox_r;
        private Label sphere_label_color;
        private Label sphere_label_radius;
        private TextBox sphere_txtbox_radius;
        private ComboBox comboBox1;
        private Label plane_label_normal;
        private Label plane_label_distance;
        private Label label1;
        private Label label2;
        private Label label3;
        private RayTracer_Form parent;
        public ObjectForm(RayTracer_Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sphere_label_center = new System.Windows.Forms.Label();
            this.txtbox_x = new System.Windows.Forms.TextBox();
            this.txtbox_y = new System.Windows.Forms.TextBox();
            this.txtbox_z = new System.Windows.Forms.TextBox();
            this.sphere_label_comma1 = new System.Windows.Forms.Label();
            this.sphere_label_comma2 = new System.Windows.Forms.Label();
            this.color_txtbox_b = new System.Windows.Forms.TextBox();
            this.color_txtbox_g = new System.Windows.Forms.TextBox();
            this.color_txtbox_r = new System.Windows.Forms.TextBox();
            this.sphere_label_color = new System.Windows.Forms.Label();
            this.sphere_label_radius = new System.Windows.Forms.Label();
            this.sphere_txtbox_radius = new System.Windows.Forms.TextBox();
            this.plane_label_normal = new System.Windows.Forms.Label();
            this.plane_label_distance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Plane",
            "Sphere"});
            this.comboBox1.Location = new System.Drawing.Point(13, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sphere_label_center
            // 
            this.sphere_label_center.AutoSize = true;
            this.sphere_label_center.Location = new System.Drawing.Point(13, 57);
            this.sphere_label_center.Name = "sphere_label_center";
            this.sphere_label_center.Size = new System.Drawing.Size(38, 13);
            this.sphere_label_center.TabIndex = 2;
            this.sphere_label_center.Text = "Center";
            // 
            // txtbox_x
            // 
            this.txtbox_x.Location = new System.Drawing.Point(197, 54);
            this.txtbox_x.Name = "txtbox_x";
            this.txtbox_x.Size = new System.Drawing.Size(29, 20);
            this.txtbox_x.TabIndex = 3;
            this.txtbox_x.Text = "0";
            // 
            // txtbox_y
            // 
            this.txtbox_y.Location = new System.Drawing.Point(136, 54);
            this.txtbox_y.Name = "txtbox_y";
            this.txtbox_y.Size = new System.Drawing.Size(29, 20);
            this.txtbox_y.TabIndex = 4;
            this.txtbox_y.Text = "0";
            this.txtbox_y.TextChanged += new System.EventHandler(this.txtbox_y_TextChanged);
            // 
            // txtbox_z
            // 
            this.txtbox_z.Location = new System.Drawing.Point(84, 54);
            this.txtbox_z.Name = "txtbox_z";
            this.txtbox_z.Size = new System.Drawing.Size(29, 20);
            this.txtbox_z.TabIndex = 5;
            this.txtbox_z.Text = "0";
            // 
            // sphere_label_comma1
            // 
            this.sphere_label_comma1.AutoSize = true;
            this.sphere_label_comma1.Location = new System.Drawing.Point(121, 61);
            this.sphere_label_comma1.Name = "sphere_label_comma1";
            this.sphere_label_comma1.Size = new System.Drawing.Size(10, 13);
            this.sphere_label_comma1.TabIndex = 6;
            this.sphere_label_comma1.Text = ",";
            // 
            // sphere_label_comma2
            // 
            this.sphere_label_comma2.AutoSize = true;
            this.sphere_label_comma2.Location = new System.Drawing.Point(174, 61);
            this.sphere_label_comma2.Name = "sphere_label_comma2";
            this.sphere_label_comma2.Size = new System.Drawing.Size(10, 13);
            this.sphere_label_comma2.TabIndex = 7;
            this.sphere_label_comma2.Text = ",";
            // 
            // color_txtbox_b
            // 
            this.color_txtbox_b.Location = new System.Drawing.Point(197, 103);
            this.color_txtbox_b.Name = "color_txtbox_b";
            this.color_txtbox_b.Size = new System.Drawing.Size(27, 20);
            this.color_txtbox_b.TabIndex = 10;
            this.color_txtbox_b.Text = "255";
            // 
            // color_txtbox_g
            // 
            this.color_txtbox_g.Location = new System.Drawing.Point(138, 103);
            this.color_txtbox_g.Name = "color_txtbox_g";
            this.color_txtbox_g.Size = new System.Drawing.Size(27, 20);
            this.color_txtbox_g.TabIndex = 9;
            this.color_txtbox_g.Text = "255";
            // 
            // color_txtbox_r
            // 
            this.color_txtbox_r.Location = new System.Drawing.Point(86, 103);
            this.color_txtbox_r.Name = "color_txtbox_r";
            this.color_txtbox_r.Size = new System.Drawing.Size(27, 20);
            this.color_txtbox_r.TabIndex = 8;
            this.color_txtbox_r.Text = "255";
            // 
            // sphere_label_color
            // 
            this.sphere_label_color.AutoSize = true;
            this.sphere_label_color.Location = new System.Drawing.Point(16, 106);
            this.sphere_label_color.Name = "sphere_label_color";
            this.sphere_label_color.Size = new System.Drawing.Size(31, 13);
            this.sphere_label_color.TabIndex = 13;
            this.sphere_label_color.Text = "Color";
            // 
            // sphere_label_radius
            // 
            this.sphere_label_radius.AutoSize = true;
            this.sphere_label_radius.Location = new System.Drawing.Point(13, 153);
            this.sphere_label_radius.Name = "sphere_label_radius";
            this.sphere_label_radius.Size = new System.Drawing.Size(40, 13);
            this.sphere_label_radius.TabIndex = 14;
            this.sphere_label_radius.Text = "Radius";
            // 
            // sphere_txtbox_radius
            // 
            this.sphere_txtbox_radius.Location = new System.Drawing.Point(73, 151);
            this.sphere_txtbox_radius.Name = "sphere_txtbox_radius";
            this.sphere_txtbox_radius.Size = new System.Drawing.Size(40, 20);
            this.sphere_txtbox_radius.TabIndex = 15;
            this.sphere_txtbox_radius.Text = "1";
            // 
            // plane_label_normal
            // 
            this.plane_label_normal.AutoSize = true;
            this.plane_label_normal.Location = new System.Drawing.Point(13, 57);
            this.plane_label_normal.Name = "plane_label_normal";
            this.plane_label_normal.Size = new System.Drawing.Size(40, 13);
            this.plane_label_normal.TabIndex = 16;
            this.plane_label_normal.Text = "Normal";
            // 
            // plane_label_distance
            // 
            this.plane_label_distance.AutoSize = true;
            this.plane_label_distance.Location = new System.Drawing.Point(13, 153);
            this.plane_label_distance.Name = "plane_label_distance";
            this.plane_label_distance.Size = new System.Drawing.Size(49, 13);
            this.plane_label_distance.TabIndex = 17;
            this.plane_label_distance.Text = "Distance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "R:";
            // 
            // ObjectForm
            // 
            this.ClientSize = new System.Drawing.Size(234, 189);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plane_label_distance);
            this.Controls.Add(this.plane_label_normal);
            this.Controls.Add(this.sphere_txtbox_radius);
            this.Controls.Add(this.sphere_label_radius);
            this.Controls.Add(this.sphere_label_color);
            this.Controls.Add(this.color_txtbox_b);
            this.Controls.Add(this.color_txtbox_g);
            this.Controls.Add(this.color_txtbox_r);
            this.Controls.Add(this.txtbox_z);
            this.Controls.Add(this.txtbox_y);
            this.Controls.Add(this.txtbox_x);
            this.Controls.Add(this.sphere_label_center);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sphere_label_comma1);
            this.Controls.Add(this.sphere_label_comma2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ObjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
            string selection = (string)combobox.SelectedItem;
            switch(selection)
            {
                case "Plane":
                    sphere_label_center.Hide();
                    sphere_label_radius.Hide();

                    plane_label_distance.Show();
                    plane_label_normal.Show();
                    Console.WriteLine("Plane Selected");
                    break;
                case "Sphere":
                    plane_label_distance.Hide();
                    plane_label_normal.Hide();

                    sphere_label_center.Show();
                    sphere_label_radius.Show();
                    Console.WriteLine("Sphere Selected");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selection = (string)comboBox1.SelectedItem;
            Object o = new Object();
            switch (selection)
            {
                case "Plane":
                    try {
                        double plane_normal_x = Convert.ToDouble(txtbox_x.Text);
                        double plane_normal_y = Convert.ToDouble(txtbox_y.Text);
                        double plane_normal_z = Convert.ToDouble(txtbox_z.Text);

                        double plane_color_r = Convert.ToDouble(color_txtbox_r.Text);
                        double plane_color_g = Convert.ToDouble(color_txtbox_g.Text);
                        double plane_color_b = Convert.ToDouble(color_txtbox_b.Text);

                        Color color = new Color(plane_color_r, plane_color_g, plane_color_b);
                        Vector normal = new Vector(plane_normal_x, plane_normal_y, plane_normal_z);
                        double distance = Convert.ToDouble(sphere_txtbox_radius.Text);

                        o = new Plane(normal, distance, color);
                        RayTracer_Form.objects.AddLast(o);
                        parent.updateObjects();
                        Console.WriteLine("Plane Created");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;
                case "Sphere":
                    try
                    {
                        double sphere_x = Convert.ToDouble(txtbox_x.Text);
                        double sphere_y = Convert.ToDouble(txtbox_y.Text);
                        double sphere_z = Convert.ToDouble(txtbox_z.Text);

                        double sphere_r = Convert.ToDouble(color_txtbox_r.Text);
                        double sphere_g = Convert.ToDouble(color_txtbox_g.Text);
                        double sphere_b = Convert.ToDouble(color_txtbox_b.Text);

                        Position center = new Position(sphere_x, sphere_y, sphere_z);
                        double radius = Convert.ToDouble(sphere_txtbox_radius.Text);
                        Color c = new Color(sphere_r, sphere_g, sphere_b);
                        o = new Sphere(radius, center, c);
                        RayTracer_Form.objects.AddLast(o);
                        parent.updateObjects();
                        Console.WriteLine("Sphere Created");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;
                default:
                    return;
            }
            this.Hide();
        }

        private void txtbox_y_TextChanged(object sender, EventArgs e)
        {

        }
    }

}