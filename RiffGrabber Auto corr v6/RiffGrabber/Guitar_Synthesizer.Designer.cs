namespace lbass_test
{
    partial class GuitarSynthesizer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuitarSynthesizer));
            this.dgv_noten_tab = new System.Windows.Forms.DataGridView();
            this.oktaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knownNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.tbx_notes = new System.Windows.Forms.TextBox();
            this.btn_play = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_noten_tab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knownNoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_noten_tab
            // 
            this.dgv_noten_tab.AllowUserToAddRows = false;
            this.dgv_noten_tab.AllowUserToDeleteRows = false;
            this.dgv_noten_tab.AllowUserToResizeColumns = false;
            this.dgv_noten_tab.AllowUserToResizeRows = false;
            this.dgv_noten_tab.AutoGenerateColumns = false;
            this.dgv_noten_tab.BackgroundColor = System.Drawing.Color.White;
            this.dgv_noten_tab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_noten_tab.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_noten_tab.ColumnHeadersHeight = 20;
            this.dgv_noten_tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_noten_tab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oktaveDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn});
            this.dgv_noten_tab.DataSource = this.knownNoteBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_noten_tab.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_noten_tab.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_noten_tab.Location = new System.Drawing.Point(3, 25);
            this.dgv_noten_tab.MultiSelect = false;
            this.dgv_noten_tab.Name = "dgv_noten_tab";
            this.dgv_noten_tab.ReadOnly = true;
            this.dgv_noten_tab.RowHeadersVisible = false;
            this.dgv_noten_tab.RowTemplate.Height = 20;
            this.dgv_noten_tab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_noten_tab.Size = new System.Drawing.Size(268, 463);
            this.dgv_noten_tab.TabIndex = 44;
            this.dgv_noten_tab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_noten_tab_CellClick);
            // 
            // oktaveDataGridViewTextBoxColumn
            // 
            this.oktaveDataGridViewTextBoxColumn.DataPropertyName = "Oktave";
            this.oktaveDataGridViewTextBoxColumn.Frozen = true;
            this.oktaveDataGridViewTextBoxColumn.HeaderText = "Octave";
            this.oktaveDataGridViewTextBoxColumn.Name = "oktaveDataGridViewTextBoxColumn";
            this.oktaveDataGridViewTextBoxColumn.ReadOnly = true;
            this.oktaveDataGridViewTextBoxColumn.Width = 50;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.Frozen = true;
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 37;
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "Frequency";
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "Frequency";
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            this.frequencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // knownNoteBindingSource
            // 
            this.knownNoteBindingSource.DataSource = typeof(NoteFreqHelper.KnownNote);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Pitch: 440Hz (A1)";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(466, 51);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(44, 23);
            this.btn_stop.TabIndex = 46;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // tbx_notes
            // 
            this.tbx_notes.Location = new System.Drawing.Point(277, 25);
            this.tbx_notes.Name = "tbx_notes";
            this.tbx_notes.Size = new System.Drawing.Size(183, 20);
            this.tbx_notes.TabIndex = 47;
            this.tbx_notes.TextChanged += new System.EventHandler(this.tbx_notes_TextChanged);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(466, 25);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(44, 23);
            this.btn_play.TabIndex = 48;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // GuitarSynthesizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 525);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.tbx_notes);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_noten_tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuitarSynthesizer";
            this.Text = "Guitar Synthesizer";
            this.Load += new System.EventHandler(this.NotenTabelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_noten_tab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knownNoteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_noten_tab;
        private System.Windows.Forms.BindingSource knownNoteBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oktaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox tbx_notes;
        private System.Windows.Forms.Button btn_play;
    }
}