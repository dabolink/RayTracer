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
        private Button sync_btn;
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
            this.listBox1.Location = new System.Drawing.Point(413, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RayTracer_Form
            // 
            this.ClientSize = new System.Drawing.Size(558, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sync_btn);
            this.Name = "RayTracer_Form";
            this.Load += new System.EventHandler(this.RayTracer_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void sync_btn_Click(object sender, System.EventArgs e)
        {
            sync_btn.Text = "Loading...";
            sync_btn.Enabled = false;
            pictureBox1.Image = Program.run_raytracer(objects, lights);
            sync_btn.Enabled = true;
            sync_btn.Text = "ReDraw";
            pictureBox1.Refresh();
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void RayTracer_Form_Load(object sender, System.EventArgs e)
        {
            objects = new LinkedList<Object>();
            lights = new LinkedList<LightSource>();
            pictureBox1.Image = Program.run_raytracer(objects, lights);
            pictureBox1.Refresh();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (objects.Remove((Object)listBox1.SelectedItem))
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                Console.WriteLine("object removed");
            }
        }
    }
}