namespace Process_Scheduler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ADD_Button = new System.Windows.Forms.Button();
            this.Run_Button = new System.Windows.Forms.Button();
            this.Select_Label = new System.Windows.Forms.Label();
            this.FCFS_Button = new System.Windows.Forms.RadioButton();
            this.SJFP_Button = new System.Windows.Forms.RadioButton();
            this.SJFNP_Button = new System.Windows.Forms.RadioButton();
            this.PriorityP_Button = new System.Windows.Forms.RadioButton();
            this.PriorityNP_Button = new System.Windows.Forms.RadioButton();
            this.RR_Button = new System.Windows.Forms.RadioButton();
            this.process_id = new System.Windows.Forms.TextBox();
            this.arrival_time = new System.Windows.Forms.TextBox();
            this.burst_time = new System.Windows.Forms.TextBox();
            this.priority = new System.Windows.Forms.TextBox();
            this.quantum = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.arrival_label = new System.Windows.Forms.Label();
            this.burst_label = new System.Windows.Forms.Label();
            this.priority_label = new System.Windows.Forms.Label();
            this.quantum_label = new System.Windows.Forms.Label();
            this.enter_label = new System.Windows.Forms.Label();
            this.processes_table = new System.Windows.Forms.DataGridView();
            this.processes_no_Label = new System.Windows.Forms.Label();
            this.processes_no = new System.Windows.Forms.TextBox();
            this.waitingtime = new System.Windows.Forms.Label();
            this.waitingtime_label = new System.Windows.Forms.Label();
            this.Restart_Button = new System.Windows.Forms.Button();
            this.ganttchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.processes_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganttchart)).BeginInit();
            this.SuspendLayout();
            // 
            // ADD_Button
            // 
            this.ADD_Button.BackColor = System.Drawing.SystemColors.Info;
            this.ADD_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADD_Button.Enabled = false;
            this.ADD_Button.Location = new System.Drawing.Point(468, 211);
            this.ADD_Button.Name = "ADD_Button";
            this.ADD_Button.Size = new System.Drawing.Size(172, 48);
            this.ADD_Button.TabIndex = 0;
            this.ADD_Button.Text = "ADD";
            this.ADD_Button.UseVisualStyleBackColor = false;
            this.ADD_Button.Click += new System.EventHandler(this.ADD_Button_Click);
            // 
            // Run_Button
            // 
            this.Run_Button.BackColor = System.Drawing.Color.White;
            this.Run_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Run_Button.Enabled = false;
            this.Run_Button.Location = new System.Drawing.Point(25, 477);
            this.Run_Button.Name = "Run_Button";
            this.Run_Button.Size = new System.Drawing.Size(172, 48);
            this.Run_Button.TabIndex = 1;
            this.Run_Button.Text = "Run";
            this.Run_Button.UseVisualStyleBackColor = false;
            this.Run_Button.Click += new System.EventHandler(this.Run_Button_Click);
            // 
            // Select_Label
            // 
            this.Select_Label.AutoSize = true;
            this.Select_Label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Label.Location = new System.Drawing.Point(36, 39);
            this.Select_Label.Name = "Select_Label";
            this.Select_Label.Size = new System.Drawing.Size(166, 16);
            this.Select_Label.TabIndex = 2;
            this.Select_Label.Text = "Select type of shceduler";
            // 
            // FCFS_Button
            // 
            this.FCFS_Button.AutoSize = true;
            this.FCFS_Button.Location = new System.Drawing.Point(43, 71);
            this.FCFS_Button.Name = "FCFS_Button";
            this.FCFS_Button.Size = new System.Drawing.Size(51, 17);
            this.FCFS_Button.TabIndex = 3;
            this.FCFS_Button.TabStop = true;
            this.FCFS_Button.Text = "FCFS";
            this.FCFS_Button.UseVisualStyleBackColor = true;
            this.FCFS_Button.CheckedChanged += new System.EventHandler(this.FCFS_Button_CheckedChanged);
            // 
            // SJFP_Button
            // 
            this.SJFP_Button.AutoSize = true;
            this.SJFP_Button.Location = new System.Drawing.Point(43, 95);
            this.SJFP_Button.Name = "SJFP_Button";
            this.SJFP_Button.Size = new System.Drawing.Size(105, 17);
            this.SJFP_Button.TabIndex = 4;
            this.SJFP_Button.TabStop = true;
            this.SJFP_Button.Text = "SJF (Preemptive)";
            this.SJFP_Button.UseVisualStyleBackColor = true;
            this.SJFP_Button.CheckedChanged += new System.EventHandler(this.JSFP_Button_CheckedChanged);
            // 
            // SJFNP_Button
            // 
            this.SJFNP_Button.AutoSize = true;
            this.SJFNP_Button.Location = new System.Drawing.Point(43, 119);
            this.SJFNP_Button.Name = "SJFNP_Button";
            this.SJFNP_Button.Size = new System.Drawing.Size(128, 17);
            this.SJFNP_Button.TabIndex = 5;
            this.SJFNP_Button.TabStop = true;
            this.SJFNP_Button.Text = "SJF (Non Preemptive)";
            this.SJFNP_Button.UseVisualStyleBackColor = true;
            this.SJFNP_Button.CheckedChanged += new System.EventHandler(this.JSFNP_Button_CheckedChanged);
            // 
            // PriorityP_Button
            // 
            this.PriorityP_Button.AutoSize = true;
            this.PriorityP_Button.Location = new System.Drawing.Point(43, 143);
            this.PriorityP_Button.Name = "PriorityP_Button";
            this.PriorityP_Button.Size = new System.Drawing.Size(118, 17);
            this.PriorityP_Button.TabIndex = 6;
            this.PriorityP_Button.TabStop = true;
            this.PriorityP_Button.Text = "Priority (Preemptive)";
            this.PriorityP_Button.UseVisualStyleBackColor = true;
            this.PriorityP_Button.CheckedChanged += new System.EventHandler(this.PriorityP_Button_CheckedChanged);
            // 
            // PriorityNP_Button
            // 
            this.PriorityNP_Button.AutoSize = true;
            this.PriorityNP_Button.Location = new System.Drawing.Point(43, 166);
            this.PriorityNP_Button.Name = "PriorityNP_Button";
            this.PriorityNP_Button.Size = new System.Drawing.Size(141, 17);
            this.PriorityNP_Button.TabIndex = 7;
            this.PriorityNP_Button.TabStop = true;
            this.PriorityNP_Button.Text = "Priority (Non Preemptive)";
            this.PriorityNP_Button.UseVisualStyleBackColor = true;
            this.PriorityNP_Button.CheckedChanged += new System.EventHandler(this.PriorityNP_Button_CheckedChanged);
            // 
            // RR_Button
            // 
            this.RR_Button.AutoSize = true;
            this.RR_Button.Location = new System.Drawing.Point(43, 191);
            this.RR_Button.Name = "RR_Button";
            this.RR_Button.Size = new System.Drawing.Size(88, 17);
            this.RR_Button.TabIndex = 8;
            this.RR_Button.TabStop = true;
            this.RR_Button.Text = "Round Robin";
            this.RR_Button.UseVisualStyleBackColor = true;
            this.RR_Button.CheckedChanged += new System.EventHandler(this.RR_Button_CheckedChanged);
            // 
            // process_id
            // 
            this.process_id.Enabled = false;
            this.process_id.Location = new System.Drawing.Point(540, 66);
            this.process_id.Name = "process_id";
            this.process_id.Size = new System.Drawing.Size(100, 20);
            this.process_id.TabIndex = 9;
            // 
            // arrival_time
            // 
            this.arrival_time.Enabled = false;
            this.arrival_time.Location = new System.Drawing.Point(540, 92);
            this.arrival_time.Name = "arrival_time";
            this.arrival_time.Size = new System.Drawing.Size(100, 20);
            this.arrival_time.TabIndex = 10;
            // 
            // burst_time
            // 
            this.burst_time.Enabled = false;
            this.burst_time.Location = new System.Drawing.Point(540, 118);
            this.burst_time.Name = "burst_time";
            this.burst_time.Size = new System.Drawing.Size(100, 20);
            this.burst_time.TabIndex = 11;
            // 
            // priority
            // 
            this.priority.Enabled = false;
            this.priority.Location = new System.Drawing.Point(540, 144);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(100, 20);
            this.priority.TabIndex = 12;
            // 
            // quantum
            // 
            this.quantum.Enabled = false;
            this.quantum.Location = new System.Drawing.Point(540, 170);
            this.quantum.Name = "quantum";
            this.quantum.Size = new System.Drawing.Size(100, 20);
            this.quantum.TabIndex = 13;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(465, 66);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(59, 13);
            this.id_label.TabIndex = 14;
            this.id_label.Text = "Process ID";
            // 
            // arrival_label
            // 
            this.arrival_label.AutoSize = true;
            this.arrival_label.Location = new System.Drawing.Point(465, 92);
            this.arrival_label.Name = "arrival_label";
            this.arrival_label.Size = new System.Drawing.Size(62, 13);
            this.arrival_label.TabIndex = 15;
            this.arrival_label.Text = "Arrival Time";
            // 
            // burst_label
            // 
            this.burst_label.AutoSize = true;
            this.burst_label.Location = new System.Drawing.Point(465, 118);
            this.burst_label.Name = "burst_label";
            this.burst_label.Size = new System.Drawing.Size(57, 13);
            this.burst_label.TabIndex = 16;
            this.burst_label.Text = "Burst Time";
            // 
            // priority_label
            // 
            this.priority_label.AutoSize = true;
            this.priority_label.Location = new System.Drawing.Point(465, 144);
            this.priority_label.Name = "priority_label";
            this.priority_label.Size = new System.Drawing.Size(38, 13);
            this.priority_label.TabIndex = 17;
            this.priority_label.Text = "Priority";
            // 
            // quantum_label
            // 
            this.quantum_label.AutoSize = true;
            this.quantum_label.Location = new System.Drawing.Point(465, 170);
            this.quantum_label.Name = "quantum_label";
            this.quantum_label.Size = new System.Drawing.Size(50, 13);
            this.quantum_label.TabIndex = 18;
            this.quantum_label.Text = "Quantum";
            // 
            // enter_label
            // 
            this.enter_label.AutoSize = true;
            this.enter_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_label.Location = new System.Drawing.Point(487, 32);
            this.enter_label.Name = "enter_label";
            this.enter_label.Size = new System.Drawing.Size(113, 16);
            this.enter_label.TabIndex = 19;
            this.enter_label.Text = "Enter Processes";
            // 
            // processes_table
            // 
            this.processes_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processes_table.Location = new System.Drawing.Point(804, 32);
            this.processes_table.Name = "processes_table";
            this.processes_table.RowHeadersVisible = false;
            this.processes_table.Size = new System.Drawing.Size(402, 244);
            this.processes_table.TabIndex = 20;
            // 
            // processes_no_Label
            // 
            this.processes_no_Label.AutoSize = true;
            this.processes_no_Label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processes_no_Label.Location = new System.Drawing.Point(36, 218);
            this.processes_no_Label.Name = "processes_no_Label";
            this.processes_no_Label.Size = new System.Drawing.Size(144, 16);
            this.processes_no_Label.TabIndex = 21;
            this.processes_no_Label.Text = "Number of processes";
            // 
            // processes_no
            // 
            this.processes_no.Location = new System.Drawing.Point(39, 246);
            this.processes_no.Name = "processes_no";
            this.processes_no.Size = new System.Drawing.Size(100, 20);
            this.processes_no.TabIndex = 22;
            // 
            // waitingtime
            // 
            this.waitingtime.AutoSize = true;
            this.waitingtime.Location = new System.Drawing.Point(197, 422);
            this.waitingtime.Name = "waitingtime";
            this.waitingtime.Size = new System.Drawing.Size(0, 13);
            this.waitingtime.TabIndex = 23;
            this.waitingtime.Visible = false;
            // 
            // waitingtime_label
            // 
            this.waitingtime_label.AutoSize = true;
            this.waitingtime_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingtime_label.Location = new System.Drawing.Point(25, 419);
            this.waitingtime_label.Name = "waitingtime_label";
            this.waitingtime_label.Size = new System.Drawing.Size(159, 16);
            this.waitingtime_label.TabIndex = 24;
            this.waitingtime_label.Text = "Average Waiting Time :";
            // 
            // Restart_Button
            // 
            this.Restart_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Restart_Button.Enabled = false;
            this.Restart_Button.Location = new System.Drawing.Point(25, 562);
            this.Restart_Button.Name = "Restart_Button";
            this.Restart_Button.Size = new System.Drawing.Size(172, 48);
            this.Restart_Button.TabIndex = 26;
            this.Restart_Button.Text = "Restart";
            this.Restart_Button.UseVisualStyleBackColor = false;
            this.Restart_Button.Click += new System.EventHandler(this.Restart_Button_Click);
            // 
            // ganttchart
            // 
            this.ganttchart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IsMarksNextToAxis = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.LineColor = System.Drawing.SystemColors.GradientActiveCaption;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.CursorX.LineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.ganttchart.ChartAreas.Add(chartArea1);
            this.ganttchart.Cursor = System.Windows.Forms.Cursors.Default;
            this.ganttchart.Enabled = false;
            legend1.Name = "Legend1";
            this.ganttchart.Legends.Add(legend1);
            this.ganttchart.Location = new System.Drawing.Point(372, 369);
            this.ganttchart.Name = "ganttchart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series1.Legend = "Legend1";
            series1.Name = "CPU Schedule";
            series1.YValuesPerPoint = 4;
            this.ganttchart.Series.Add(series1);
            this.ganttchart.Size = new System.Drawing.Size(918, 281);
            this.ganttchart.TabIndex = 25;
            this.ganttchart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1329, 653);
            this.Controls.Add(this.Restart_Button);
            this.Controls.Add(this.ganttchart);
            this.Controls.Add(this.waitingtime_label);
            this.Controls.Add(this.waitingtime);
            this.Controls.Add(this.processes_no);
            this.Controls.Add(this.processes_no_Label);
            this.Controls.Add(this.processes_table);
            this.Controls.Add(this.enter_label);
            this.Controls.Add(this.quantum_label);
            this.Controls.Add(this.priority_label);
            this.Controls.Add(this.burst_label);
            this.Controls.Add(this.arrival_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.quantum);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.burst_time);
            this.Controls.Add(this.arrival_time);
            this.Controls.Add(this.process_id);
            this.Controls.Add(this.RR_Button);
            this.Controls.Add(this.PriorityNP_Button);
            this.Controls.Add(this.PriorityP_Button);
            this.Controls.Add(this.SJFNP_Button);
            this.Controls.Add(this.SJFP_Button);
            this.Controls.Add(this.FCFS_Button);
            this.Controls.Add(this.Select_Label);
            this.Controls.Add(this.Run_Button);
            this.Controls.Add(this.ADD_Button);
            this.Name = "Form1";
            this.Text = "Process Scheduler ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processes_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganttchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD_Button;
        private System.Windows.Forms.Button Run_Button;
        private System.Windows.Forms.Label Select_Label;
        private System.Windows.Forms.RadioButton FCFS_Button;
        private System.Windows.Forms.RadioButton SJFP_Button;
        private System.Windows.Forms.RadioButton SJFNP_Button;
        private System.Windows.Forms.RadioButton PriorityP_Button;
        private System.Windows.Forms.RadioButton PriorityNP_Button;
        private System.Windows.Forms.RadioButton RR_Button;
        private System.Windows.Forms.TextBox process_id;
        private System.Windows.Forms.TextBox arrival_time;
        private System.Windows.Forms.TextBox burst_time;
        private System.Windows.Forms.TextBox priority;
        private System.Windows.Forms.TextBox quantum;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label arrival_label;
        private System.Windows.Forms.Label burst_label;
        private System.Windows.Forms.Label priority_label;
        private System.Windows.Forms.Label quantum_label;
        private System.Windows.Forms.Label enter_label;
        private System.Windows.Forms.DataGridView processes_table;
        private System.Windows.Forms.Label processes_no_Label;
        private System.Windows.Forms.TextBox processes_no;
        private System.Windows.Forms.Label waitingtime;
        private System.Windows.Forms.Label waitingtime_label;
        private System.Windows.Forms.Button Restart_Button;
        private System.Windows.Forms.DataVisualization.Charting.Chart ganttchart;
    }
}

