namespace tugas_week_3
{
    partial class mainf
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
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_fav = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.MaskedTextBox();
            this.tb_fav = new System.Windows.Forms.MaskedTextBox();
            this.cbox_a = new System.Windows.Forms.CheckBox();
            this.but_submite = new System.Windows.Forms.Button();
            this.but_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.Location = new System.Drawing.Point(98, 101);
            this.lab_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(99, 32);
            this.lab_name.TabIndex = 0;
            this.lab_name.Text = "NAME";
            // 
            // lab_fav
            // 
            this.lab_fav.AutoSize = true;
            this.lab_fav.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_fav.Location = new System.Drawing.Point(98, 183);
            this.lab_fav.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab_fav.Name = "lab_fav";
            this.lab_fav.Size = new System.Drawing.Size(327, 32);
            this.lab_fav.TabIndex = 0;
            this.lab_fav.Text = "MY FAVORITE ARTIST";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(554, 95);
            this.tb_name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(316, 38);
            this.tb_name.TabIndex = 1;
            // 
            // tb_fav
            // 
            this.tb_fav.Location = new System.Drawing.Point(554, 180);
            this.tb_fav.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_fav.Name = "tb_fav";
            this.tb_fav.Size = new System.Drawing.Size(316, 38);
            this.tb_fav.TabIndex = 1;
            this.tb_fav.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_fav_MaskInputRejected);
            // 
            // cbox_a
            // 
            this.cbox_a.AutoSize = true;
            this.cbox_a.Location = new System.Drawing.Point(104, 302);
            this.cbox_a.Name = "cbox_a";
            this.cbox_a.Size = new System.Drawing.Size(674, 36);
            this.cbox_a.TabIndex = 2;
            this.cbox_a.Text = "ALL OF THE CONTENT I PUT ABOVE IS TRUE";
            this.cbox_a.UseVisualStyleBackColor = true;
            this.cbox_a.CheckedChanged += new System.EventHandler(this.cbox_a_CheckedChanged);
            // 
            // but_submite
            // 
            this.but_submite.Enabled = false;
            this.but_submite.Location = new System.Drawing.Point(125, 413);
            this.but_submite.Name = "but_submite";
            this.but_submite.Size = new System.Drawing.Size(175, 70);
            this.but_submite.TabIndex = 3;
            this.but_submite.Text = "SUBMIT";
            this.but_submite.UseVisualStyleBackColor = true;
            this.but_submite.Click += new System.EventHandler(this.but_submite_Click);
            // 
            // but_open
            // 
            this.but_open.Location = new System.Drawing.Point(653, 413);
            this.but_open.Name = "but_open";
            this.but_open.Size = new System.Drawing.Size(294, 70);
            this.but_open.TabIndex = 3;
            this.but_open.Text = "OPEN NEXT FORM";
            this.but_open.UseVisualStyleBackColor = true;
            this.but_open.Click += new System.EventHandler(this.but_open_Click);
            // 
            // mainf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.but_open);
            this.Controls.Add(this.but_submite);
            this.Controls.Add(this.cbox_a);
            this.Controls.Add(this.tb_fav);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lab_fav);
            this.Controls.Add(this.lab_name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "mainf";
            this.Tag = "back1";
            this.Text = "Main Window Form";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_fav;
        private System.Windows.Forms.MaskedTextBox tb_name;
        private System.Windows.Forms.MaskedTextBox tb_fav;
        private System.Windows.Forms.CheckBox cbox_a;
        private System.Windows.Forms.Button but_submite;
        private System.Windows.Forms.Button but_open;
    }
}

