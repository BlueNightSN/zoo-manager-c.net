namespace Zoo
{
    partial class Animal_list
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
            this.Animals = new System.Windows.Forms.ListBox();
            this.add_Lion_btn = new System.Windows.Forms.Button();
            this.remove_single = new System.Windows.Forms.Button();
            this.count_btn = new System.Windows.Forms.Button();
            this.num_age_Lion = new System.Windows.Forms.NumericUpDown();
            this.label_gender_Lion = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name_Lion = new System.Windows.Forms.TextBox();
            this.textBox_gender_Lion = new System.Windows.Forms.TextBox();
            this.roar_lvl = new System.Windows.Forms.NumericUpDown();
            this.label_Roar = new System.Windows.Forms.Label();
            this.numeric_Trunk_len = new System.Windows.Forms.NumericUpDown();
            this.Trunk_len = new System.Windows.Forms.Label();
            this.elephant_age = new System.Windows.Forms.NumericUpDown();
            this.textBox_name_Elpehant = new System.Windows.Forms.TextBox();
            this.textBox_gen_elephant = new System.Windows.Forms.TextBox();
            this.add_elephant = new System.Windows.Forms.Button();
            this.age_alligator = new System.Windows.Forms.NumericUpDown();
            this.textBox_name_alligator = new System.Windows.Forms.TextBox();
            this.textBox_gen_alligator = new System.Windows.Forms.TextBox();
            this.butt_alligator = new System.Windows.Forms.Button();
            this.pea_len = new System.Windows.Forms.NumericUpDown();
            this.label_peac_tail = new System.Windows.Forms.Label();
            this.age_pea = new System.Windows.Forms.NumericUpDown();
            this.textBox_name_pea = new System.Windows.Forms.TextBox();
            this.textBox_gen_pea = new System.Windows.Forms.TextBox();
            this.butt_pea = new System.Windows.Forms.Button();
            this.butt_save_list = new System.Windows.Forms.Button();
            this.butt_load_list = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_age_Lion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roar_lvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Trunk_len)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elephant_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_alligator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pea_len)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_pea)).BeginInit();
            this.SuspendLayout();
            // 
            // Animals
            // 
            this.Animals.FormattingEnabled = true;
            this.Animals.ItemHeight = 16;
            this.Animals.Location = new System.Drawing.Point(329, 13);
            this.Animals.MultiColumn = true;
            this.Animals.Name = "Animals";
            this.Animals.Size = new System.Drawing.Size(818, 500);
            this.Animals.TabIndex = 0;
            // 
            // add_Lion_btn
            // 
            this.add_Lion_btn.Location = new System.Drawing.Point(26, 12);
            this.add_Lion_btn.Name = "add_Lion_btn";
            this.add_Lion_btn.Size = new System.Drawing.Size(133, 26);
            this.add_Lion_btn.TabIndex = 1;
            this.add_Lion_btn.Text = "add Lion";
            this.add_Lion_btn.UseVisualStyleBackColor = true;
            this.add_Lion_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_single
            // 
            this.remove_single.Location = new System.Drawing.Point(12, 454);
            this.remove_single.Name = "remove_single";
            this.remove_single.Size = new System.Drawing.Size(311, 25);
            this.remove_single.TabIndex = 3;
            this.remove_single.Text = "remove from list";
            this.remove_single.UseVisualStyleBackColor = true;
            this.remove_single.Click += new System.EventHandler(this.remove_single_Click);
            // 
            // count_btn
            // 
            this.count_btn.Location = new System.Drawing.Point(12, 485);
            this.count_btn.Name = "count_btn";
            this.count_btn.Size = new System.Drawing.Size(311, 28);
            this.count_btn.TabIndex = 4;
            this.count_btn.Text = "count list";
            this.count_btn.UseVisualStyleBackColor = true;
            this.count_btn.Click += new System.EventHandler(this.count_btn_Click);
            // 
            // num_age_Lion
            // 
            this.num_age_Lion.DecimalPlaces = 1;
            this.num_age_Lion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_age_Lion.Location = new System.Drawing.Point(100, 66);
            this.num_age_Lion.Name = "num_age_Lion";
            this.num_age_Lion.Size = new System.Drawing.Size(52, 22);
            this.num_age_Lion.TabIndex = 21;
            // 
            // label_gender_Lion
            // 
            this.label_gender_Lion.AutoSize = true;
            this.label_gender_Lion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender_Lion.Location = new System.Drawing.Point(162, 42);
            this.label_gender_Lion.Name = "label_gender_Lion";
            this.label_gender_Lion.Size = new System.Drawing.Size(69, 20);
            this.label_gender_Lion.TabIndex = 20;
            this.label_gender_Lion.Text = "Gender:";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(99, 42);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(43, 20);
            this.label_age.TabIndex = 18;
            this.label_age.Text = "Age:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(21, 41);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(58, 20);
            this.label_name.TabIndex = 16;
            this.label_name.Text = "Name:";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_name_Lion
            // 
            this.textBox_name_Lion.Location = new System.Drawing.Point(22, 64);
            this.textBox_name_Lion.Name = "textBox_name_Lion";
            this.textBox_name_Lion.Size = new System.Drawing.Size(72, 22);
            this.textBox_name_Lion.TabIndex = 15;
            // 
            // textBox_gender_Lion
            // 
            this.textBox_gender_Lion.Location = new System.Drawing.Point(163, 66);
            this.textBox_gender_Lion.Name = "textBox_gender_Lion";
            this.textBox_gender_Lion.Size = new System.Drawing.Size(66, 22);
            this.textBox_gender_Lion.TabIndex = 12;
            // 
            // roar_lvl
            // 
            this.roar_lvl.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.roar_lvl.Location = new System.Drawing.Point(235, 67);
            this.roar_lvl.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.roar_lvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roar_lvl.Name = "roar_lvl";
            this.roar_lvl.Size = new System.Drawing.Size(52, 22);
            this.roar_lvl.TabIndex = 23;
            this.roar_lvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roar_lvl.ValueChanged += new System.EventHandler(this.roar_lvl_ValueChanged);
            // 
            // label_Roar
            // 
            this.label_Roar.AutoSize = true;
            this.label_Roar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Roar.Location = new System.Drawing.Point(234, 43);
            this.label_Roar.Name = "label_Roar";
            this.label_Roar.Size = new System.Drawing.Size(71, 20);
            this.label_Roar.TabIndex = 22;
            this.label_Roar.Text = "Roar lvl:";
            // 
            // numeric_Trunk_len
            // 
            this.numeric_Trunk_len.Location = new System.Drawing.Point(241, 126);
            this.numeric_Trunk_len.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Trunk_len.Name = "numeric_Trunk_len";
            this.numeric_Trunk_len.Size = new System.Drawing.Size(52, 22);
            this.numeric_Trunk_len.TabIndex = 32;
            this.numeric_Trunk_len.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Trunk_len
            // 
            this.Trunk_len.AutoSize = true;
            this.Trunk_len.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trunk_len.Location = new System.Drawing.Point(231, 102);
            this.Trunk_len.Name = "Trunk_len";
            this.Trunk_len.Size = new System.Drawing.Size(83, 20);
            this.Trunk_len.TabIndex = 31;
            this.Trunk_len.Text = "Trunk len:";
            // 
            // elephant_age
            // 
            this.elephant_age.DecimalPlaces = 1;
            this.elephant_age.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.elephant_age.Location = new System.Drawing.Point(103, 125);
            this.elephant_age.Name = "elephant_age";
            this.elephant_age.Size = new System.Drawing.Size(52, 22);
            this.elephant_age.TabIndex = 30;
            // 
            // textBox_name_Elpehant
            // 
            this.textBox_name_Elpehant.Location = new System.Drawing.Point(25, 123);
            this.textBox_name_Elpehant.Name = "textBox_name_Elpehant";
            this.textBox_name_Elpehant.Size = new System.Drawing.Size(72, 22);
            this.textBox_name_Elpehant.TabIndex = 26;
            // 
            // textBox_gen_elephant
            // 
            this.textBox_gen_elephant.Location = new System.Drawing.Point(166, 125);
            this.textBox_gen_elephant.Name = "textBox_gen_elephant";
            this.textBox_gen_elephant.Size = new System.Drawing.Size(66, 22);
            this.textBox_gen_elephant.TabIndex = 25;
            // 
            // add_elephant
            // 
            this.add_elephant.Location = new System.Drawing.Point(26, 94);
            this.add_elephant.Name = "add_elephant";
            this.add_elephant.Size = new System.Drawing.Size(133, 26);
            this.add_elephant.TabIndex = 24;
            this.add_elephant.Text = "add elephant";
            this.add_elephant.UseVisualStyleBackColor = true;
            this.add_elephant.Click += new System.EventHandler(this.add_elephant_Click);
            // 
            // age_alligator
            // 
            this.age_alligator.DecimalPlaces = 1;
            this.age_alligator.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.age_alligator.Location = new System.Drawing.Point(104, 189);
            this.age_alligator.Name = "age_alligator";
            this.age_alligator.Size = new System.Drawing.Size(52, 22);
            this.age_alligator.TabIndex = 39;
            // 
            // textBox_name_alligator
            // 
            this.textBox_name_alligator.Location = new System.Drawing.Point(26, 187);
            this.textBox_name_alligator.Name = "textBox_name_alligator";
            this.textBox_name_alligator.Size = new System.Drawing.Size(72, 22);
            this.textBox_name_alligator.TabIndex = 35;
            // 
            // textBox_gen_alligator
            // 
            this.textBox_gen_alligator.Location = new System.Drawing.Point(167, 189);
            this.textBox_gen_alligator.Name = "textBox_gen_alligator";
            this.textBox_gen_alligator.Size = new System.Drawing.Size(66, 22);
            this.textBox_gen_alligator.TabIndex = 34;
            // 
            // butt_alligator
            // 
            this.butt_alligator.Location = new System.Drawing.Point(26, 155);
            this.butt_alligator.Name = "butt_alligator";
            this.butt_alligator.Size = new System.Drawing.Size(133, 26);
            this.butt_alligator.TabIndex = 33;
            this.butt_alligator.Text = "add alligator";
            this.butt_alligator.UseVisualStyleBackColor = true;
            this.butt_alligator.Click += new System.EventHandler(this.butt_alligator_Click);
            // 
            // pea_len
            // 
            this.pea_len.Location = new System.Drawing.Point(238, 252);
            this.pea_len.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pea_len.Name = "pea_len";
            this.pea_len.Size = new System.Drawing.Size(52, 22);
            this.pea_len.TabIndex = 48;
            this.pea_len.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_peac_tail
            // 
            this.label_peac_tail.AutoSize = true;
            this.label_peac_tail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_peac_tail.Location = new System.Drawing.Point(237, 228);
            this.label_peac_tail.Name = "label_peac_tail";
            this.label_peac_tail.Size = new System.Drawing.Size(68, 20);
            this.label_peac_tail.TabIndex = 47;
            this.label_peac_tail.Text = "Tail len:";
            // 
            // age_pea
            // 
            this.age_pea.DecimalPlaces = 1;
            this.age_pea.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.age_pea.Location = new System.Drawing.Point(100, 251);
            this.age_pea.Name = "age_pea";
            this.age_pea.Size = new System.Drawing.Size(52, 22);
            this.age_pea.TabIndex = 46;
            // 
            // textBox_name_pea
            // 
            this.textBox_name_pea.Location = new System.Drawing.Point(22, 249);
            this.textBox_name_pea.Name = "textBox_name_pea";
            this.textBox_name_pea.Size = new System.Drawing.Size(72, 22);
            this.textBox_name_pea.TabIndex = 42;
            // 
            // textBox_gen_pea
            // 
            this.textBox_gen_pea.Location = new System.Drawing.Point(163, 251);
            this.textBox_gen_pea.Name = "textBox_gen_pea";
            this.textBox_gen_pea.Size = new System.Drawing.Size(66, 22);
            this.textBox_gen_pea.TabIndex = 41;
            // 
            // butt_pea
            // 
            this.butt_pea.Location = new System.Drawing.Point(26, 217);
            this.butt_pea.Name = "butt_pea";
            this.butt_pea.Size = new System.Drawing.Size(133, 26);
            this.butt_pea.TabIndex = 40;
            this.butt_pea.Text = "add peacock";
            this.butt_pea.UseVisualStyleBackColor = true;
            this.butt_pea.Click += new System.EventHandler(this.butt_pea_Click);
            // 
            // butt_save_list
            // 
            this.butt_save_list.Location = new System.Drawing.Point(12, 425);
            this.butt_save_list.Name = "butt_save_list";
            this.butt_save_list.Size = new System.Drawing.Size(311, 23);
            this.butt_save_list.TabIndex = 49;
            this.butt_save_list.Text = "Save list";
            this.butt_save_list.UseVisualStyleBackColor = true;
            this.butt_save_list.Click += new System.EventHandler(this.butt_save_list_Click);
            // 
            // butt_load_list
            // 
            this.butt_load_list.Location = new System.Drawing.Point(12, 396);
            this.butt_load_list.Name = "butt_load_list";
            this.butt_load_list.Size = new System.Drawing.Size(311, 23);
            this.butt_load_list.TabIndex = 50;
            this.butt_load_list.Text = "Load list";
            this.butt_load_list.UseVisualStyleBackColor = true;
            this.butt_load_list.Click += new System.EventHandler(this.butt_load_list_Click);
            // 
            // Animal_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1159, 521);
            this.Controls.Add(this.butt_load_list);
            this.Controls.Add(this.butt_save_list);
            this.Controls.Add(this.pea_len);
            this.Controls.Add(this.label_peac_tail);
            this.Controls.Add(this.age_pea);
            this.Controls.Add(this.textBox_name_pea);
            this.Controls.Add(this.textBox_gen_pea);
            this.Controls.Add(this.butt_pea);
            this.Controls.Add(this.age_alligator);
            this.Controls.Add(this.textBox_name_alligator);
            this.Controls.Add(this.textBox_gen_alligator);
            this.Controls.Add(this.butt_alligator);
            this.Controls.Add(this.numeric_Trunk_len);
            this.Controls.Add(this.Trunk_len);
            this.Controls.Add(this.elephant_age);
            this.Controls.Add(this.textBox_name_Elpehant);
            this.Controls.Add(this.textBox_gen_elephant);
            this.Controls.Add(this.add_elephant);
            this.Controls.Add(this.roar_lvl);
            this.Controls.Add(this.label_Roar);
            this.Controls.Add(this.num_age_Lion);
            this.Controls.Add(this.label_gender_Lion);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_name_Lion);
            this.Controls.Add(this.textBox_gender_Lion);
            this.Controls.Add(this.count_btn);
            this.Controls.Add(this.remove_single);
            this.Controls.Add(this.add_Lion_btn);
            this.Controls.Add(this.Animals);
            this.Name = "Animal_list";
            this.Text = "Animal_list";
            ((System.ComponentModel.ISupportInitialize)(this.num_age_Lion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roar_lvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Trunk_len)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elephant_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_alligator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pea_len)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_pea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Animals;
        private System.Windows.Forms.Button add_Lion_btn;
        private System.Windows.Forms.Button remove_single;
        private System.Windows.Forms.Button count_btn;
        private System.Windows.Forms.NumericUpDown num_age_Lion;
        private System.Windows.Forms.Label label_gender_Lion;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name_Lion;
        private System.Windows.Forms.TextBox textBox_gender_Lion;
        private System.Windows.Forms.NumericUpDown roar_lvl;
        private System.Windows.Forms.Label label_Roar;
        private System.Windows.Forms.NumericUpDown numeric_Trunk_len;
        private System.Windows.Forms.Label Trunk_len;
        private System.Windows.Forms.NumericUpDown elephant_age;
        private System.Windows.Forms.TextBox textBox_name_Elpehant;
        private System.Windows.Forms.TextBox textBox_gen_elephant;
        private System.Windows.Forms.Button add_elephant;
        private System.Windows.Forms.NumericUpDown age_alligator;
        private System.Windows.Forms.TextBox textBox_name_alligator;
        private System.Windows.Forms.TextBox textBox_gen_alligator;
        private System.Windows.Forms.Button butt_alligator;
        private System.Windows.Forms.NumericUpDown pea_len;
        private System.Windows.Forms.Label label_peac_tail;
        private System.Windows.Forms.NumericUpDown age_pea;
        private System.Windows.Forms.TextBox textBox_name_pea;
        private System.Windows.Forms.TextBox textBox_gen_pea;
        private System.Windows.Forms.Button butt_pea;
        private System.Windows.Forms.Button butt_save_list;
        private System.Windows.Forms.Button butt_load_list;
    }
}