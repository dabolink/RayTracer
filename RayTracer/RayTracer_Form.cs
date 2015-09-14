using System.Drawing;
using System.Windows.Forms;
using RayTracer;
using System.Collections.Generic;
using System;
using System.Threading;

namespace RayTracer
{
    internal class RayTracer_Form : Form
    {
        public static LinkedList<LightSource> lights;
        public static LinkedList<Object> objects;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button4;
        private ListBox listBox2;
        private Label label3;
        private Label label4;
        private TextBox txtbox_camera_x;
        private TextBox txtbox_camera_y;
        private TextBox txtbox_camera_z;
        private Label sphere_label_comma1;
        private Label sphere_label_comma2;
        private TextBox txtbox_lookat_x;
        private TextBox txtbox_lookat_y;
        private TextBox txtbox_lookat_z;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button sync_btn;
        private Camera camera;
        private Position cam_pos;
        private Position lookat;

        public RayTracer_Form()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.sync_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_camera_x = new System.Windows.Forms.TextBox();
            this.txtbox_camera_y = new System.Windows.Forms.TextBox();
            this.txtbox_camera_z = new System.Windows.Forms.TextBox();
            this.sphere_label_comma1 = new System.Windows.Forms.Label();
            this.sphere_label_comma2 = new System.Windows.Forms.Label();
            this.txtbox_lookat_x = new System.Windows.Forms.TextBox();
            this.txtbox_lookat_y = new System.Windows.Forms.TextBox();
            this.txtbox_lookat_z = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sync_btn
            // 
            this.sync_btn.Location = new System.Drawing.Point(471, 426);
            this.sync_btn.Name = "sync_btn";
            this.sync_btn.Size = new System.Drawing.Size(75, 23);
            this.sync_btn.TabIndex = 0;
            this.sync_btn.Text = "ReDraw";
            this.sync_btn.UseMnemonic = false;
            this.sync_btn.UseVisualStyleBackColor = true;
            this.sync_btn.Click += new System.EventHandler(this.sync_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 370);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(426, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Objects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lights";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(504, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(426, 191);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Camera";
            // 
            // txtbox_camera_x
            // 
            this.txtbox_camera_x.Location = new System.Drawing.Point(590, 49);
            this.txtbox_camera_x.Name = "txtbox_camera_x";
            this.txtbox_camera_x.Size = new System.Drawing.Size(29, 20);
            this.txtbox_camera_x.TabIndex = 14;
            this.txtbox_camera_x.Text = "0";
            this.txtbox_camera_x.TextChanged += new System.EventHandler(this.updateCameraPos);
            // 
            // txtbox_camera_y
            // 
            this.txtbox_camera_y.Location = new System.Drawing.Point(642, 49);
            this.txtbox_camera_y.Name = "txtbox_camera_y";
            this.txtbox_camera_y.Size = new System.Drawing.Size(29, 20);
            this.txtbox_camera_y.TabIndex = 13;
            this.txtbox_camera_y.Text = "1";
            this.txtbox_camera_y.TextChanged += new System.EventHandler(this.updateCameraPos);
            // 
            // txtbox_camera_z
            // 
            this.txtbox_camera_z.Location = new System.Drawing.Point(703, 49);
            this.txtbox_camera_z.Name = "txtbox_camera_z";
            this.txtbox_camera_z.Size = new System.Drawing.Size(29, 20);
            this.txtbox_camera_z.TabIndex = 12;
            this.txtbox_camera_z.Text = "-5";
            this.txtbox_camera_z.TextChanged += new System.EventHandler(this.updateCameraPos);
            // 
            // sphere_label_comma1
            // 
            this.sphere_label_comma1.AutoSize = true;
            this.sphere_label_comma1.Location = new System.Drawing.Point(627, 56);
            this.sphere_label_comma1.Name = "sphere_label_comma1";
            this.sphere_label_comma1.Size = new System.Drawing.Size(10, 13);
            this.sphere_label_comma1.TabIndex = 15;
            this.sphere_label_comma1.Text = ",";
            // 
            // sphere_label_comma2
            // 
            this.sphere_label_comma2.AutoSize = true;
            this.sphere_label_comma2.Location = new System.Drawing.Point(680, 56);
            this.sphere_label_comma2.Name = "sphere_label_comma2";
            this.sphere_label_comma2.Size = new System.Drawing.Size(10, 13);
            this.sphere_label_comma2.TabIndex = 16;
            this.sphere_label_comma2.Text = ",";
            // 
            // txtbox_lookat_x
            // 
            this.txtbox_lookat_x.Location = new System.Drawing.Point(590, 108);
            this.txtbox_lookat_x.Name = "txtbox_lookat_x";
            this.txtbox_lookat_x.Size = new System.Drawing.Size(29, 20);
            this.txtbox_lookat_x.TabIndex = 20;
            this.txtbox_lookat_x.Text = "0";
            this.txtbox_lookat_x.TextChanged += new System.EventHandler(this.updateCameraLookAt);
            // 
            // txtbox_lookat_y
            // 
            this.txtbox_lookat_y.Location = new System.Drawing.Point(642, 108);
            this.txtbox_lookat_y.Name = "txtbox_lookat_y";
            this.txtbox_lookat_y.Size = new System.Drawing.Size(29, 20);
            this.txtbox_lookat_y.TabIndex = 19;
            this.txtbox_lookat_y.Text = "0";
            this.txtbox_lookat_y.TextChanged += new System.EventHandler(this.updateCameraLookAt);
            // 
            // txtbox_lookat_z
            // 
            this.txtbox_lookat_z.Location = new System.Drawing.Point(703, 108);
            this.txtbox_lookat_z.Name = "txtbox_lookat_z";
            this.txtbox_lookat_z.Size = new System.Drawing.Size(29, 20);
            this.txtbox_lookat_z.TabIndex = 18;
            this.txtbox_lookat_z.Text = "0";
            this.txtbox_lookat_z.TextChanged += new System.EventHandler(this.updateCameraLookAt);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = ",";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = ",";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "LookAt";
            // 
            // RayTracer_Form
            // 
            this.ClientSize = new System.Drawing.Size(776, 461);
            this.Controls.Add(this.txtbox_lookat_x);
            this.Controls.Add(this.txtbox_lookat_y);
            this.Controls.Add(this.txtbox_lookat_z);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_camera_x);
            this.Controls.Add(this.txtbox_camera_y);
            this.Controls.Add(this.txtbox_camera_z);
            this.Controls.Add(this.sphere_label_comma1);
            this.Controls.Add(this.sphere_label_comma2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sync_btn);
            this.Name = "RayTracer_Form";
            this.Load += new System.EventHandler(this.RayTracer_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void sync_btn_Click(object sender, System.EventArgs e)
        {
            sync_btn.Text = "Loading...";
            sync_btn.Enabled = false;
            pictureBox1.Image = Program.run_raytracer(objects, lights, camera);
            sync_btn.Enabled = true;
            sync_btn.Text = "ReDraw";
        }

        private void RayTracer_Form_Load(object sender, System.EventArgs e)
        {
            objects = new LinkedList<Object>();
            lights = new LinkedList<LightSource>();

            cam_pos = new Position(0,-1,5);
            lookat = new Position(0,0,0);

            Color WHITE = new Color(255, 255, 255);
            LightSource l1 = new LightSource(new Position(20, 5, 10), WHITE);
            lights.AddLast(l1);
            this.camera = new Camera(cam_pos, lookat);
            pictureBox1.Image = Program.run_raytracer(objects, lights, camera);
            pictureBox1.Refresh();
        }
        //create object
        private void button1_Click(object sender, System.EventArgs e)
        {
            ObjectForm obj_form = new ObjectForm(this);
            obj_form.Show();
        }

        public void updateObjects()
        {
            listBox1.Items.Clear();
            foreach(Object o in objects)
            {
                listBox1.Items.Add(o);       
            }
        }
        //remove object
        private void button2_Click(object sender, EventArgs e)
        {
            if (objects.Remove((Object)listBox1.SelectedItem))
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                Console.WriteLine("object removed");
            }
        }

        private void updateCameraPos(object sender, EventArgs e)
        {
            try
            {
                cam_pos.x = Convert.ToDouble(txtbox_camera_x.Text);
                cam_pos.y = Convert.ToDouble(txtbox_camera_y.Text);
                cam_pos.z = Convert.ToDouble(txtbox_camera_z.Text);
            }
            catch
            {

            }
            
        }
        
        private void updateCameraLookAt(object sender, EventArgs e)
        {
            try
            {
                lookat.x = Convert.ToDouble(txtbox_lookat_x.Text);
                lookat.y = Convert.ToDouble(txtbox_lookat_y.Text);
                lookat.z = Convert.ToDouble(txtbox_lookat_z.Text);
            }
            catch
            {

            }
        }
    }
}