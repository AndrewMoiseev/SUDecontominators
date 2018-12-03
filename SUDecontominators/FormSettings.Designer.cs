namespace SUDecontominators
{
    partial class FormSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.texIP = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownPollingInterval = new System.Windows.Forms.NumericUpDown();
            this.timeFormaline = new System.Windows.Forms.DateTimePicker();
            this.timeAmmiac = new System.Windows.Forms.DateTimePicker();
            this.timeWait = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownDec = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownSys = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPollingInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSys)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP адрес:";
            // 
            // texIP
            // 
            this.texIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texIP.Location = new System.Drawing.Point(117, 24);
            this.texIP.Name = "texIP";
            this.texIP.Size = new System.Drawing.Size(92, 20);
            this.texIP.TabIndex = 1;
            // 
            // textPort
            // 
            this.textPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPort.Location = new System.Drawing.Point(267, 24);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(38, 20);
            this.textPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "порт:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "время испарения формалина:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "время выдержки (экспозиции):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "время испарения аммиака:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "частота опроса (сек):";
            // 
            // numericUpDownPollingInterval
            // 
            this.numericUpDownPollingInterval.Location = new System.Drawing.Point(236, 297);
            this.numericUpDownPollingInterval.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericUpDownPollingInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPollingInterval.Name = "numericUpDownPollingInterval";
            this.numericUpDownPollingInterval.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownPollingInterval.TabIndex = 10;
            this.numericUpDownPollingInterval.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // timeFormaline
            // 
            this.timeFormaline.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeFormaline.Location = new System.Drawing.Point(231, 143);
            this.timeFormaline.Name = "timeFormaline";
            this.timeFormaline.ShowUpDown = true;
            this.timeFormaline.Size = new System.Drawing.Size(70, 20);
            this.timeFormaline.TabIndex = 12;
            this.timeFormaline.Value = new System.DateTime(2018, 10, 18, 0, 0, 0, 0);
            // 
            // timeAmmiac
            // 
            this.timeAmmiac.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeAmmiac.Location = new System.Drawing.Point(229, 179);
            this.timeAmmiac.Name = "timeAmmiac";
            this.timeAmmiac.ShowUpDown = true;
            this.timeAmmiac.Size = new System.Drawing.Size(70, 20);
            this.timeAmmiac.TabIndex = 13;
            this.timeAmmiac.Value = new System.DateTime(2018, 10, 18, 0, 0, 0, 0);
            // 
            // timeWait
            // 
            this.timeWait.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeWait.Location = new System.Drawing.Point(229, 218);
            this.timeWait.Name = "timeWait";
            this.timeWait.ShowUpDown = true;
            this.timeWait.Size = new System.Drawing.Size(70, 20);
            this.timeWait.TabIndex = 14;
            this.timeWait.Value = new System.DateTime(2018, 10, 18, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(114, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Номер устройства:";
            // 
            // numericUpDownDec
            // 
            this.numericUpDownDec.Enabled = false;
            this.numericUpDownDec.Location = new System.Drawing.Point(256, 58);
            this.numericUpDownDec.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericUpDownDec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDec.Name = "numericUpDownDec";
            this.numericUpDownDec.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDec.TabIndex = 15;
            this.numericUpDownDec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(114, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Номер системы:";
            // 
            // numericUpDownSys
            // 
            this.numericUpDownSys.Enabled = false;
            this.numericUpDownSys.Location = new System.Drawing.Point(256, 88);
            this.numericUpDownSys.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericUpDownSys.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSys.Name = "numericUpDownSys";
            this.numericUpDownSys.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownSys.TabIndex = 17;
            this.numericUpDownSys.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Записать уставки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownSys);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownDec);
            this.Controls.Add(this.timeWait);
            this.Controls.Add(this.timeAmmiac);
            this.Controls.Add(this.timeFormaline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownPollingInterval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texIP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSettings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPollingInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texIP;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownPollingInterval;
        private System.Windows.Forms.DateTimePicker timeFormaline;
        private System.Windows.Forms.DateTimePicker timeAmmiac;
        private System.Windows.Forms.DateTimePicker timeWait;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownDec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownSys;
        private System.Windows.Forms.Button button1;
    }
}