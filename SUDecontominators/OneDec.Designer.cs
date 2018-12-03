namespace SUDecontominators
{
    partial class OneDec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneDec));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarAmmiac = new System.Windows.Forms.ProgressBar();
            this.progressBarWating = new System.Windows.Forms.ProgressBar();
            this.progressBarFormalin = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.labelUTEhi = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePickerWait = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAmmiac = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFormalin = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.labelAvaria = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.lHLW = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lTE2 = new System.Windows.Forms.Label();
            this.lTE1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(193, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Испарение аммиака.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(193, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выдержка.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(193, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Испарение формалина.";
            // 
            // progressBarAmmiac
            // 
            this.progressBarAmmiac.Location = new System.Drawing.Point(12, 175);
            this.progressBarAmmiac.Name = "progressBarAmmiac";
            this.progressBarAmmiac.Size = new System.Drawing.Size(677, 23);
            this.progressBarAmmiac.TabIndex = 4;
            // 
            // progressBarWating
            // 
            this.progressBarWating.Location = new System.Drawing.Point(12, 118);
            this.progressBarWating.Name = "progressBarWating";
            this.progressBarWating.Size = new System.Drawing.Size(677, 23);
            this.progressBarWating.TabIndex = 3;
            // 
            // progressBarFormalin
            // 
            this.progressBarFormalin.Location = new System.Drawing.Point(12, 62);
            this.progressBarFormalin.Name = "progressBarFormalin";
            this.progressBarFormalin.Size = new System.Drawing.Size(677, 23);
            this.progressBarFormalin.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 301);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(701, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "система управления деконтаинаторами";
            this.notifyIcon1.BalloonTipTitle = "decontaminator";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Система управления деконтаминаторами";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 26);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.start_Click);
            // 
            // labelUTEhi
            // 
            this.labelUTEhi.AutoSize = true;
            this.labelUTEhi.Location = new System.Drawing.Point(12, 223);
            this.labelUTEhi.Name = "labelUTEhi";
            this.labelUTEhi.Size = new System.Drawing.Size(13, 13);
            this.labelUTEhi.TabIndex = 9;
            this.labelUTEhi.Text = "0";
            this.labelUTEhi.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Настройки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Settings_Click);
            // 
            // dateTimePickerWait
            // 
            this.dateTimePickerWait.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimePickerWait.CausesValidation = false;
            this.dateTimePickerWait.Enabled = false;
            this.dateTimePickerWait.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerWait.Location = new System.Drawing.Point(326, 96);
            this.dateTimePickerWait.Name = "dateTimePickerWait";
            this.dateTimePickerWait.Size = new System.Drawing.Size(70, 20);
            this.dateTimePickerWait.TabIndex = 14;
            this.dateTimePickerWait.Value = new System.DateTime(2018, 10, 18, 0, 0, 0, 0);
            // 
            // dateTimePickerAmmiac
            // 
            this.dateTimePickerAmmiac.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimePickerAmmiac.CausesValidation = false;
            this.dateTimePickerAmmiac.Enabled = false;
            this.dateTimePickerAmmiac.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerAmmiac.Location = new System.Drawing.Point(326, 153);
            this.dateTimePickerAmmiac.Name = "dateTimePickerAmmiac";
            this.dateTimePickerAmmiac.Size = new System.Drawing.Size(70, 20);
            this.dateTimePickerAmmiac.TabIndex = 15;
            this.dateTimePickerAmmiac.Value = new System.DateTime(2018, 10, 18, 0, 0, 0, 0);
            // 
            // dateTimePickerFormalin
            // 
            this.dateTimePickerFormalin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimePickerFormalin.CausesValidation = false;
            this.dateTimePickerFormalin.Enabled = false;
            this.dateTimePickerFormalin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFormalin.Location = new System.Drawing.Point(326, 40);
            this.dateTimePickerFormalin.Name = "dateTimePickerFormalin";
            this.dateTimePickerFormalin.Size = new System.Drawing.Size(70, 20);
            this.dateTimePickerFormalin.TabIndex = 16;
            this.dateTimePickerFormalin.Value = new System.DateTime(2018, 10, 18, 0, 0, 0, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Пульт деконтаминатора";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelAvaria
            // 
            this.labelAvaria.AutoSize = true;
            this.labelAvaria.BackColor = System.Drawing.SystemColors.Window;
            this.labelAvaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAvaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAvaria.Font = new System.Drawing.Font("Verdana", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvaria.ForeColor = System.Drawing.Color.Red;
            this.labelAvaria.Location = new System.Drawing.Point(176, 223);
            this.labelAvaria.Name = "labelAvaria";
            this.labelAvaria.Size = new System.Drawing.Size(144, 34);
            this.labelAvaria.TabIndex = 18;
            this.labelAvaria.Text = "АВАРИЯ";
            this.labelAvaria.Visible = false;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(359, 234);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(91, 23);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "Сброс аварий";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Visible = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // lHLW
            // 
            this.lHLW.AutoSize = true;
            this.lHLW.BackColor = System.Drawing.SystemColors.Window;
            this.lHLW.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHLW.ForeColor = System.Drawing.Color.Green;
            this.lHLW.Location = new System.Drawing.Point(298, 9);
            this.lHLW.Name = "lHLW";
            this.lHLW.Size = new System.Drawing.Size(120, 18);
            this.lHLW.TabIndex = 27;
            this.lHLW.Text = "Работа Откл";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lTE2);
            this.groupBox4.Controls.Add(this.lTE1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(15, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 83);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Температуры";
            // 
            // lTE2
            // 
            this.lTE2.AutoSize = true;
            this.lTE2.BackColor = System.Drawing.SystemColors.Window;
            this.lTE2.ForeColor = System.Drawing.Color.Maroon;
            this.lTE2.Location = new System.Drawing.Point(82, 60);
            this.lTE2.Name = "lTE2";
            this.lTE2.Size = new System.Drawing.Size(13, 13);
            this.lTE2.TabIndex = 15;
            this.lTE2.Text = "1";
            // 
            // lTE1
            // 
            this.lTE1.AutoSize = true;
            this.lTE1.BackColor = System.Drawing.SystemColors.Window;
            this.lTE1.ForeColor = System.Drawing.Color.Maroon;
            this.lTE1.Location = new System.Drawing.Point(82, 27);
            this.lTE1.Name = "lTE1";
            this.lTE1.Size = new System.Drawing.Size(13, 13);
            this.lTE1.TabIndex = 14;
            this.lTE1.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(18, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "TЕ2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(18, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "TЕ1";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // OneDec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 323);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lHLW);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelAvaria);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePickerFormalin);
            this.Controls.Add(this.dateTimePickerAmmiac);
            this.Controls.Add(this.dateTimePickerWait);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelUTEhi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarAmmiac);
            this.Controls.Add(this.progressBarWating);
            this.Controls.Add(this.progressBarFormalin);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OneDec";
            this.Text = "Автоматизация деконтаминатора";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarAmmiac;
        private System.Windows.Forms.ProgressBar progressBarWating;
        private System.Windows.Forms.ProgressBar progressBarFormalin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelUTEhi;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DateTimePicker dateTimePickerWait;
        public System.Windows.Forms.DateTimePicker dateTimePickerAmmiac;
        public System.Windows.Forms.DateTimePicker dateTimePickerFormalin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelAvaria;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label lHLW;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lTE2;
        private System.Windows.Forms.Label lTE1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer2;
    }
}