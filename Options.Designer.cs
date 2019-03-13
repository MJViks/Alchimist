namespace Alchimist
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.cb_mus = new System.Windows.Forms.CheckBox();
            this.cb_eff = new System.Windows.Forms.CheckBox();
            this.cb_fon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_mus
            // 
            this.cb_mus.BackColor = System.Drawing.Color.Transparent;
            this.cb_mus.Checked = true;
            this.cb_mus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_mus.ForeColor = System.Drawing.Color.White;
            this.cb_mus.Location = new System.Drawing.Point(83, 76);
            this.cb_mus.Name = "cb_mus";
            this.cb_mus.Size = new System.Drawing.Size(119, 24);
            this.cb_mus.TabIndex = 0;
            this.cb_mus.Text = "Музыка";
            this.cb_mus.UseVisualStyleBackColor = false;
            // 
            // cb_eff
            // 
            this.cb_eff.AutoSize = true;
            this.cb_eff.BackColor = System.Drawing.Color.Transparent;
            this.cb_eff.Checked = true;
            this.cb_eff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_eff.ForeColor = System.Drawing.Color.White;
            this.cb_eff.Location = new System.Drawing.Point(83, 143);
            this.cb_eff.Name = "cb_eff";
            this.cb_eff.Size = new System.Drawing.Size(74, 17);
            this.cb_eff.TabIndex = 1;
            this.cb_eff.Text = "Эффекты";
            this.cb_eff.UseVisualStyleBackColor = false;
            // 
            // cb_fon
            // 
            this.cb_fon.FormattingEnabled = true;
            this.cb_fon.Items.AddRange(new object[] {
            "Кмень",
            "Дерево",
            "Ничего"});
            this.cb_fon.Location = new System.Drawing.Point(125, 207);
            this.cb_fon.Name = "cb_fon";
            this.cb_fon.Size = new System.Drawing.Size(115, 21);
            this.cb_fon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Задний фон";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alchimist.Properties.Resources.minecraft_textures_maynkraft_копия;
            this.ClientSize = new System.Drawing.Size(270, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_fon);
            this.Controls.Add(this.cb_eff);
            this.Controls.Add(this.cb_mus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox cb_mus;
        public System.Windows.Forms.CheckBox cb_eff;
        public System.Windows.Forms.ComboBox cb_fon;
        private System.Windows.Forms.Button button1;
    }
}