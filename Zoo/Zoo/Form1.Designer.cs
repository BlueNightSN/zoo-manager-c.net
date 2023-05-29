namespace Zoo
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
            this.Map = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.Button();
            this.Animals = new System.Windows.Forms.Button();
            this.map_pic = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.Adult_text = new System.Windows.Forms.TextBox();
            this.Price_lock = new System.Windows.Forms.Button();
            this.child_text = new System.Windows.Forms.TextBox();
            this.Adult_price = new System.Windows.Forms.NumericUpDown();
            this.Price_child = new System.Windows.Forms.NumericUpDown();
            this.fun_fuc_display = new System.Windows.Forms.RichTextBox();
            this.comboBox_test = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.map_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adult_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_child)).BeginInit();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.Location = new System.Drawing.Point(28, 72);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(99, 23);
            this.Map.TabIndex = 1;
            this.Map.Text = "Map";
            this.Map.UseVisualStyleBackColor = true;
            this.Map.Click += new System.EventHandler(this.Map_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(28, 115);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(99, 23);
            this.Price.TabIndex = 2;
            this.Price.Text = "Price";
            this.Price.UseVisualStyleBackColor = true;
            this.Price.Click += new System.EventHandler(this.Price_Click);
            // 
            // Animals
            // 
            this.Animals.Location = new System.Drawing.Point(28, 161);
            this.Animals.Name = "Animals";
            this.Animals.Size = new System.Drawing.Size(99, 23);
            this.Animals.TabIndex = 3;
            this.Animals.Text = "Animal Info";
            this.Animals.UseVisualStyleBackColor = true;
            this.Animals.Click += new System.EventHandler(this.Animals_Click);
            // 
            // map_pic
            // 
            this.map_pic.Image = global::Zoo.Properties.Resources.Zoo_map;
            this.map_pic.Location = new System.Drawing.Point(161, 12);
            this.map_pic.Name = "map_pic";
            this.map_pic.Size = new System.Drawing.Size(1055, 462);
            this.map_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map_pic.TabIndex = 5;
            this.map_pic.TabStop = false;
            this.map_pic.Visible = false;
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(28, 27);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(99, 23);
            this.Menu.TabIndex = 6;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(722, 284);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(96, 68);
            this.save.TabIndex = 7;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(447, 284);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(99, 68);
            this.load.TabIndex = 8;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Visible = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Adult_text
            // 
            this.Adult_text.BackColor = System.Drawing.SystemColors.Menu;
            this.Adult_text.Enabled = false;
            this.Adult_text.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Adult_text.Location = new System.Drawing.Point(348, 116);
            this.Adult_text.Name = "Adult_text";
            this.Adult_text.Size = new System.Drawing.Size(100, 22);
            this.Adult_text.TabIndex = 9;
            this.Adult_text.Text = "Adult Price:";
            this.Adult_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Adult_text.Visible = false;
            // 
            // Price_lock
            // 
            this.Price_lock.Location = new System.Drawing.Point(587, 284);
            this.Price_lock.Name = "Price_lock";
            this.Price_lock.Size = new System.Drawing.Size(96, 68);
            this.Price_lock.TabIndex = 10;
            this.Price_lock.Text = "Change";
            this.Price_lock.UseVisualStyleBackColor = true;
            this.Price_lock.Visible = false;
            this.Price_lock.Click += new System.EventHandler(this.Price_lock_Click);
            // 
            // child_text
            // 
            this.child_text.Enabled = false;
            this.child_text.Location = new System.Drawing.Point(827, 116);
            this.child_text.Name = "child_text";
            this.child_text.Size = new System.Drawing.Size(100, 22);
            this.child_text.TabIndex = 11;
            this.child_text.Text = "Child Price:";
            this.child_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.child_text.Visible = false;
            // 
            // Adult_price
            // 
            this.Adult_price.DecimalPlaces = 2;
            this.Adult_price.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Adult_price.Location = new System.Drawing.Point(348, 163);
            this.Adult_price.Name = "Adult_price";
            this.Adult_price.ReadOnly = true;
            this.Adult_price.Size = new System.Drawing.Size(120, 22);
            this.Adult_price.TabIndex = 14;
            this.Adult_price.ThousandsSeparator = true;
            this.Adult_price.Visible = false;
            this.Adult_price.ValueChanged += new System.EventHandler(this.Adult_price_ValueChanged);
            // 
            // Price_child
            // 
            this.Price_child.DecimalPlaces = 2;
            this.Price_child.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Price_child.Location = new System.Drawing.Point(827, 162);
            this.Price_child.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Price_child.Name = "Price_child";
            this.Price_child.ReadOnly = true;
            this.Price_child.Size = new System.Drawing.Size(120, 22);
            this.Price_child.TabIndex = 15;
            this.Price_child.Visible = false;
            this.Price_child.ValueChanged += new System.EventHandler(this.Price_child_ValueChanged);
            // 
            // fun_fuc_display
            // 
            this.fun_fuc_display.Location = new System.Drawing.Point(3, 234);
            this.fun_fuc_display.Name = "fun_fuc_display";
            this.fun_fuc_display.Size = new System.Drawing.Size(154, 96);
            this.fun_fuc_display.TabIndex = 17;
            this.fun_fuc_display.Text = "";
            this.fun_fuc_display.TextChanged += new System.EventHandler(this.fun_fuc_display_TextChanged);
            // 
            // comboBox_test
            // 
            this.comboBox_test.FormattingEnabled = true;
            this.comboBox_test.Items.AddRange(new object[] {
            "Alligator",
            "Lion",
            "Elephant",
            "Peacock"});
            this.comboBox_test.Location = new System.Drawing.Point(3, 204);
            this.comboBox_test.Name = "comboBox_test";
            this.comboBox_test.Size = new System.Drawing.Size(154, 24);
            this.comboBox_test.TabIndex = 18;
            this.comboBox_test.SelectedIndexChanged += new System.EventHandler(this.comboBox_test_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 501);
            this.Controls.Add(this.comboBox_test);
            this.Controls.Add(this.fun_fuc_display);
            this.Controls.Add(this.Price_child);
            this.Controls.Add(this.Adult_price);
            this.Controls.Add(this.child_text);
            this.Controls.Add(this.Price_lock);
            this.Controls.Add(this.Adult_text);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.map_pic);
            this.Controls.Add(this.Animals);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.map_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adult_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_child)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Map;
        private System.Windows.Forms.Button Price;
        private System.Windows.Forms.Button Animals;
        private System.Windows.Forms.PictureBox map_pic;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TextBox Adult_text;
        private System.Windows.Forms.Button Price_lock;
        private System.Windows.Forms.TextBox child_text;
        private System.Windows.Forms.NumericUpDown Adult_price;
        private System.Windows.Forms.NumericUpDown Price_child;
        private System.Windows.Forms.RichTextBox fun_fuc_display;
        private System.Windows.Forms.ComboBox comboBox_test;
    }
}

