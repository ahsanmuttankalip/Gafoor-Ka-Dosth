namespace lbass_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Esc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Esc
            // 
            this.Esc.BackColor = System.Drawing.Color.Transparent;
            this.Esc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Esc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Esc.FlatAppearance.BorderSize = 0;
            this.Esc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Esc.Font = new System.Drawing.Font("Old English Text MT", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Esc.ForeColor = System.Drawing.Color.Red;
            this.Esc.Location = new System.Drawing.Point(340, 446);
            this.Esc.Name = "Esc";
            this.Esc.Size = new System.Drawing.Size(152, 35);
            this.Esc.TabIndex = 1;
            this.Esc.Text = "Loading.....";
            this.Esc.UseVisualStyleBackColor = true;
            this.Esc.Click += new System.EventHandler(this.Esc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.Esc;
            this.ClientSize = new System.Drawing.Size(504, 493);
            this.Controls.Add(this.Esc);
            this.Font = new System.Drawing.Font("Narkisim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Esc;

    }
}