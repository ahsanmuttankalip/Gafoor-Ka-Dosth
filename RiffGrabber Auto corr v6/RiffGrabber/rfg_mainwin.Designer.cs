namespace lbass_test
{
    partial class rfg_mainwin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rfg_mainwin));
            this.btn_file_open = new System.Windows.Forms.Button();
            this.ofd_input_file = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbx_found_tones = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_start_rec = new System.Windows.Forms.Button();
            this.btn_stop_rec = new System.Windows.Forms.Button();
            this.lbl_recstat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_raw_peaks = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_md5_raw_peaks = new System.Windows.Forms.Label();
            this.cbx_wav = new System.Windows.Forms.CheckBox();
            this.btn_noten_tbl = new System.Windows.Forms.Button();
            this.prgb_lvl = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TAB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Clear = new System.Windows.Forms.Button();
            this.TABLIST = new System.Windows.Forms.ListBox();
            this.E2 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.D3 = new System.Windows.Forms.Button();
            this.G3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.E4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbar = new System.Windows.Forms.ProgressBar();
            this.ON = new System.Windows.Forms.Button();
            this.OFF = new System.Windows.Forms.Button();
            this.Tbox = new System.Windows.Forms.ListBox();
            this.Rbar = new System.Windows.Forms.ProgressBar();
            this.TLABEL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_raw_peaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_file_open
            // 
            this.btn_file_open.Location = new System.Drawing.Point(12, 60);
            this.btn_file_open.Name = "btn_file_open";
            this.btn_file_open.Size = new System.Drawing.Size(99, 23);
            this.btn_file_open.TabIndex = 0;
            this.btn_file_open.Text = "Open File";
            this.btn_file_open.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_file_open.UseVisualStyleBackColor = true;
            this.btn_file_open.Click += new System.EventHandler(this.btn_file_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Results";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fname.Location = new System.Drawing.Point(67, 34);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(44, 13);
            this.lbl_fname.TabIndex = 6;
            this.lbl_fname.Text = "EMPTY";
            this.lbl_fname.Click += new System.EventHandler(this.lbl_fname_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filename:";
            // 
            // lbx_found_tones
            // 
            this.lbx_found_tones.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbx_found_tones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_found_tones.FormattingEnabled = true;
            this.lbx_found_tones.ItemHeight = 16;
            this.lbx_found_tones.Location = new System.Drawing.Point(278, 290);
            this.lbx_found_tones.Name = "lbx_found_tones";
            this.lbx_found_tones.Size = new System.Drawing.Size(276, 404);
            this.lbx_found_tones.TabIndex = 8;
            this.lbx_found_tones.SelectedIndexChanged += new System.EventHandler(this.lbx_found_tones_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Playback";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Record";
            // 
            // btn_start_rec
            // 
            this.btn_start_rec.Location = new System.Drawing.Point(128, 34);
            this.btn_start_rec.Name = "btn_start_rec";
            this.btn_start_rec.Size = new System.Drawing.Size(48, 23);
            this.btn_start_rec.TabIndex = 12;
            this.btn_start_rec.Text = "Start";
            this.btn_start_rec.UseVisualStyleBackColor = true;
            this.btn_start_rec.Click += new System.EventHandler(this.btn_start_rec_Click);
            // 
            // btn_stop_rec
            // 
            this.btn_stop_rec.Location = new System.Drawing.Point(215, 34);
            this.btn_stop_rec.Name = "btn_stop_rec";
            this.btn_stop_rec.Size = new System.Drawing.Size(48, 23);
            this.btn_stop_rec.TabIndex = 13;
            this.btn_stop_rec.Text = "Stop";
            this.btn_stop_rec.UseVisualStyleBackColor = true;
            this.btn_stop_rec.Click += new System.EventHandler(this.btn_stop_rec_Click);
            // 
            // lbl_recstat
            // 
            this.lbl_recstat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_recstat.ForeColor = System.Drawing.Color.Red;
            this.lbl_recstat.Location = new System.Drawing.Point(151, 104);
            this.lbl_recstat.Name = "lbl_recstat";
            this.lbl_recstat.Size = new System.Drawing.Size(69, 13);
            this.lbl_recstat.TabIndex = 14;
            this.lbl_recstat.Text = "IDLE";
            this.lbl_recstat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(119, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Status";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(279, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Found Notes";
            // 
            // dgv_raw_peaks
            // 
            this.dgv_raw_peaks.AllowUserToAddRows = false;
            this.dgv_raw_peaks.AllowUserToDeleteRows = false;
            this.dgv_raw_peaks.AllowUserToResizeColumns = false;
            this.dgv_raw_peaks.AllowUserToResizeRows = false;
            this.dgv_raw_peaks.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_raw_peaks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_raw_peaks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_raw_peaks.ColumnHeadersHeight = 20;
            this.dgv_raw_peaks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_raw_peaks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_raw_peaks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_raw_peaks.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_raw_peaks.Location = new System.Drawing.Point(12, 290);
            this.dgv_raw_peaks.Name = "dgv_raw_peaks";
            this.dgv_raw_peaks.ReadOnly = true;
            this.dgv_raw_peaks.RowHeadersVisible = false;
            this.dgv_raw_peaks.RowTemplate.Height = 20;
            this.dgv_raw_peaks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_raw_peaks.Size = new System.Drawing.Size(251, 404);
            this.dgv_raw_peaks.TabIndex = 43;
            this.dgv_raw_peaks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_raw_peaks_CellContentClick);
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time_in_Ms";
            dataGridViewCellStyle1.Format = "0 ms";
            dataGridViewCellStyle1.NullValue = null;
            this.Time.DefaultCellStyle = dataGridViewCellStyle1;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // lbl_md5_raw_peaks
            // 
            this.lbl_md5_raw_peaks.AutoSize = true;
            this.lbl_md5_raw_peaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_md5_raw_peaks.Location = new System.Drawing.Point(45, 760);
            this.lbl_md5_raw_peaks.Name = "lbl_md5_raw_peaks";
            this.lbl_md5_raw_peaks.Size = new System.Drawing.Size(0, 12);
            this.lbl_md5_raw_peaks.TabIndex = 45;
            // 
            // cbx_wav
            // 
            this.cbx_wav.AutoSize = true;
            this.cbx_wav.BackColor = System.Drawing.Color.Transparent;
            this.cbx_wav.Location = new System.Drawing.Point(15, 103);
            this.cbx_wav.Name = "cbx_wav";
            this.cbx_wav.Size = new System.Drawing.Size(98, 17);
            this.cbx_wav.TabIndex = 53;
            this.cbx_wav.Text = "create Wav file";
            this.cbx_wav.UseVisualStyleBackColor = false;
            this.cbx_wav.CheckedChanged += new System.EventHandler(this.cbx_wav_CheckedChanged);
            // 
            // btn_noten_tbl
            // 
            this.btn_noten_tbl.Location = new System.Drawing.Point(12, 144);
            this.btn_noten_tbl.Name = "btn_noten_tbl";
            this.btn_noten_tbl.Size = new System.Drawing.Size(233, 23);
            this.btn_noten_tbl.TabIndex = 54;
            this.btn_noten_tbl.Text = "Guitar-Synthesizer";
            this.btn_noten_tbl.UseVisualStyleBackColor = true;
            this.btn_noten_tbl.Click += new System.EventHandler(this.btn_noten_tbl_Click);
            // 
            // prgb_lvl
            // 
            this.prgb_lvl.Location = new System.Drawing.Point(15, 206);
            this.prgb_lvl.Name = "prgb_lvl";
            this.prgb_lvl.Size = new System.Drawing.Size(232, 20);
            this.prgb_lvl.TabIndex = 55;
            this.prgb_lvl.Click += new System.EventHandler(this.prgb_lvl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Input Level";
            // 
            // TAB
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.IsReversed = true;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 1D;
            chartArea1.AxisY2.IsReversed = true;
            chartArea1.Name = "ChartArea1";
            this.TAB.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TAB.Legends.Add(legend1);
            this.TAB.Location = new System.Drawing.Point(269, 34);
            this.TAB.Name = "TAB";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "TAB DIAGRAM";
            dataPoint1.IsValueShownAsLabel = true;
            series1.Points.Add(dataPoint1);
            series1.YValuesPerPoint = 2;
            this.TAB.Series.Add(series1);
            this.TAB.Size = new System.Drawing.Size(1069, 242);
            this.TAB.TabIndex = 57;
            this.TAB.Text = "TAB";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(154, 63);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 58;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // TABLIST
            // 
            this.TABLIST.FormattingEnabled = true;
            this.TABLIST.Location = new System.Drawing.Point(596, 290);
            this.TABLIST.Name = "TABLIST";
            this.TABLIST.Size = new System.Drawing.Size(270, 407);
            this.TABLIST.TabIndex = 59;
            this.TABLIST.SelectedIndexChanged += new System.EventHandler(this.TABLIST_SelectedIndexChanged);
            // 
            // E2
            // 
            this.E2.Location = new System.Drawing.Point(956, 370);
            this.E2.Name = "E2";
            this.E2.Size = new System.Drawing.Size(75, 23);
            this.E2.TabIndex = 60;
            this.E2.Text = "E2 ";
            this.E2.UseVisualStyleBackColor = true;
            this.E2.Click += new System.EventHandler(this.button1_Click);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(957, 396);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 23);
            this.A2.TabIndex = 61;
            this.A2.Text = "A2";
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button2_Click);
            // 
            // D3
            // 
            this.D3.Location = new System.Drawing.Point(957, 422);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(75, 23);
            this.D3.TabIndex = 62;
            this.D3.Text = "D3";
            this.D3.UseVisualStyleBackColor = true;
            this.D3.Click += new System.EventHandler(this.button3_Click);
            // 
            // G3
            // 
            this.G3.Location = new System.Drawing.Point(958, 448);
            this.G3.Name = "G3";
            this.G3.Size = new System.Drawing.Size(75, 23);
            this.G3.TabIndex = 63;
            this.G3.Text = "G3";
            this.G3.UseVisualStyleBackColor = true;
            this.G3.Click += new System.EventHandler(this.G3_Click);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(958, 474);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(75, 23);
            this.B4.TabIndex = 64;
            this.B4.Text = "B4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // E4
            // 
            this.E4.Location = new System.Drawing.Point(958, 503);
            this.E4.Name = "E4";
            this.E4.Size = new System.Drawing.Size(75, 20);
            this.E4.TabIndex = 65;
            this.E4.Text = "E4";
            this.E4.UseVisualStyleBackColor = true;
            this.E4.Click += new System.EventHandler(this.E4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1012, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 31);
            this.label7.TabIndex = 67;
            this.label7.Text = "Digital Guitar Tuner";
            // 
            // Lbar
            // 
            this.Lbar.Location = new System.Drawing.Point(1075, 463);
            this.Lbar.Name = "Lbar";
            this.Lbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbar.RightToLeftLayout = true;
            this.Lbar.Size = new System.Drawing.Size(108, 23);
            this.Lbar.Step = 2;
            this.Lbar.TabIndex = 68;
            this.Lbar.Click += new System.EventHandler(this.Lbar_Click);
            // 
            // ON
            // 
            this.ON.Location = new System.Drawing.Point(1072, 370);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(93, 87);
            this.ON.TabIndex = 70;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = true;
            this.ON.Click += new System.EventHandler(this.ON_Click);
            // 
            // OFF
            // 
            this.OFF.Location = new System.Drawing.Point(1203, 370);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(93, 87);
            this.OFF.TabIndex = 71;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = true;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // Tbox
            // 
            this.Tbox.FormattingEnabled = true;
            this.Tbox.Location = new System.Drawing.Point(1072, 496);
            this.Tbox.Name = "Tbox";
            this.Tbox.Size = new System.Drawing.Size(226, 30);
            this.Tbox.TabIndex = 72;
            this.Tbox.SelectedIndexChanged += new System.EventHandler(this.Tbox_SelectedIndexChanged);
            // 
            // Rbar
            // 
            this.Rbar.Location = new System.Drawing.Point(1183, 463);
            this.Rbar.Name = "Rbar";
            this.Rbar.Size = new System.Drawing.Size(109, 23);
            this.Rbar.TabIndex = 73;
            // 
            // TLABEL
            // 
            this.TLABEL.AutoSize = true;
            this.TLABEL.Location = new System.Drawing.Point(1163, 559);
            this.TLABEL.Name = "TLABEL";
            this.TLABEL.Size = new System.Drawing.Size(24, 13);
            this.TLABEL.TabIndex = 74;
            this.TLABEL.Text = "NIL";
            this.TLABEL.Click += new System.EventHandler(this.TLABEL_Click);
            // 
            // rfg_mainwin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 702);
            this.Controls.Add(this.TLABEL);
            this.Controls.Add(this.Rbar);
            this.Controls.Add(this.Tbox);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.ON);
            this.Controls.Add(this.Lbar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.E4);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.G3);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.E2);
            this.Controls.Add(this.TABLIST);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.TAB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prgb_lvl);
            this.Controls.Add(this.btn_noten_tbl);
            this.Controls.Add(this.cbx_wav);
            this.Controls.Add(this.lbl_md5_raw_peaks);
            this.Controls.Add(this.dgv_raw_peaks);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_recstat);
            this.Controls.Add(this.btn_stop_rec);
            this.Controls.Add(this.btn_start_rec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbx_found_tones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_file_open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rfg_mainwin";
            this.Text = "A-G-T-A-B";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rgr_test_fft_FormClosing);
            this.Load += new System.EventHandler(this.rfg_mainwin_Load);
            this.Shown += new System.EventHandler(this.rgr_test_fft_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_raw_peaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_file_open;
        private System.Windows.Forms.OpenFileDialog ofd_input_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbx_found_tones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_start_rec;
        private System.Windows.Forms.Button btn_stop_rec;
        private System.Windows.Forms.Label lbl_recstat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_raw_peaks;
       // private System.Windows.Forms.DataGridView file_spec_peaks;
        private System.Windows.Forms.Label lbl_md5_raw_peaks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.CheckBox cbx_wav;
        private System.Windows.Forms.Button btn_noten_tbl;
        private System.Windows.Forms.ProgressBar prgb_lvl;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart TAB;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ListBox TABLIST;
        private System.Windows.Forms.Button E2;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button D3;
        private System.Windows.Forms.Button G3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button E4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar Lbar;
        private System.Windows.Forms.Button ON;
        private System.Windows.Forms.Button OFF;
        private System.Windows.Forms.ListBox Tbox;
        private System.Windows.Forms.ProgressBar Rbar;
        private System.Windows.Forms.Label TLABEL;
    }
}