namespace SUDecontominators
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDownTempBak = new System.Windows.Forms.NumericUpDown();
            this.lRelay1 = new System.Windows.Forms.Label();
            this.bK1off = new System.Windows.Forms.Button();
            this.bK1on = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Relay1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lRelay2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lSec = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lST2 = new System.Windows.Forms.Label();
            this.lST1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lTE2 = new System.Windows.Forms.Label();
            this.lTE1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lUTEhi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bClear = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lUTElo = new System.Windows.Forms.Label();
            this.numericUpDownUTElo = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lUtmin = new System.Windows.Forms.Label();
            this.numericUpDownUtmin = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
            this.lCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lHLW = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempBak)).BeginInit();
            this.Relay1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUTElo)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUtmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Visible = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(368, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Visible = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(124, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Reset_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(131, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Установить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDownTempBak
            // 
            this.numericUpDownTempBak.Location = new System.Drawing.Point(32, 54);
            this.numericUpDownTempBak.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTempBak.Name = "numericUpDownTempBak";
            this.numericUpDownTempBak.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownTempBak.TabIndex = 8;
            // 
            // lRelay1
            // 
            this.lRelay1.AutoSize = true;
            this.lRelay1.BackColor = System.Drawing.SystemColors.Window;
            this.lRelay1.Location = new System.Drawing.Point(118, 47);
            this.lRelay1.Name = "lRelay1";
            this.lRelay1.Size = new System.Drawing.Size(27, 13);
            this.lRelay1.TabIndex = 10;
            this.lRelay1.Text = "OFF";
            // 
            // bK1off
            // 
            this.bK1off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bK1off.Location = new System.Drawing.Point(13, 59);
            this.bK1off.Name = "bK1off";
            this.bK1off.Size = new System.Drawing.Size(75, 23);
            this.bK1off.TabIndex = 3;
            this.bK1off.Text = "K1 выкл";
            this.bK1off.UseVisualStyleBackColor = true;
            this.bK1off.Click += new System.EventHandler(this.bK1off_Click);
            // 
            // bK1on
            // 
            this.bK1on.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bK1on.Location = new System.Drawing.Point(14, 21);
            this.bK1on.Name = "bK1on";
            this.bK1on.Size = new System.Drawing.Size(75, 23);
            this.bK1on.TabIndex = 2;
            this.bK1on.Text = "K1 вкл";
            this.bK1on.UseVisualStyleBackColor = true;
            this.bK1on.Click += new System.EventHandler(this.bK1on_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(12, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Аммиак";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Ammiac_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(12, 59);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Формалин";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Formalin_Click);
            // 
            // Relay1
            // 
            this.Relay1.Controls.Add(this.bK1on);
            this.Relay1.Controls.Add(this.bK1off);
            this.Relay1.Controls.Add(this.lRelay1);
            this.Relay1.Location = new System.Drawing.Point(18, 62);
            this.Relay1.Name = "Relay1";
            this.Relay1.Size = new System.Drawing.Size(200, 100);
            this.Relay1.TabIndex = 13;
            this.Relay1.TabStop = false;
            this.Relay1.Text = "Реле 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lRelay2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Location = new System.Drawing.Point(240, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Реле 2";
            // 
            // lRelay2
            // 
            this.lRelay2.AutoSize = true;
            this.lRelay2.Location = new System.Drawing.Point(126, 47);
            this.lRelay2.Name = "lRelay2";
            this.lRelay2.Size = new System.Drawing.Size(48, 13);
            this.lRelay2.TabIndex = 12;
            this.lRelay2.Text = "Аммиак";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(179, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Счетчик секунд:";
            // 
            // lSec
            // 
            this.lSec.AutoSize = true;
            this.lSec.BackColor = System.Drawing.SystemColors.Window;
            this.lSec.Location = new System.Drawing.Point(285, 7);
            this.lSec.Name = "lSec";
            this.lSec.Size = new System.Drawing.Size(13, 13);
            this.lSec.TabIndex = 15;
            this.lSec.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(224, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "АВАРИЯ";
            this.label2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lST2);
            this.groupBox2.Controls.Add(this.lST1);
            this.groupBox2.Location = new System.Drawing.Point(18, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Термостаты";
            // 
            // lST2
            // 
            this.lST2.AutoSize = true;
            this.lST2.BackColor = System.Drawing.SystemColors.Window;
            this.lST2.Enabled = false;
            this.lST2.ForeColor = System.Drawing.Color.Crimson;
            this.lST2.Location = new System.Drawing.Point(31, 61);
            this.lST2.Name = "lST2";
            this.lST2.Size = new System.Drawing.Size(55, 13);
            this.lST2.TabIndex = 12;
            this.lST2.Text = "ST2 Откл";
            // 
            // lST1
            // 
            this.lST1.AutoSize = true;
            this.lST1.BackColor = System.Drawing.SystemColors.Window;
            this.lST1.Enabled = false;
            this.lST1.ForeColor = System.Drawing.Color.Crimson;
            this.lST1.Location = new System.Drawing.Point(31, 27);
            this.lST1.Name = "lST1";
            this.lST1.Size = new System.Drawing.Size(55, 13);
            this.lST1.TabIndex = 11;
            this.lST1.Text = "ST1 Откл";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(18, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 130);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Состояние установки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(24, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Перегрев бака 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(24, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Перегрев бака 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(24, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Термостат ST2 сработал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Термостат ST1 сработал";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lTE2);
            this.groupBox4.Controls.Add(this.lTE1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(240, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 121);
            this.groupBox4.TabIndex = 18;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lUTEhi);
            this.groupBox5.Controls.Add(this.numericUpDownTempBak);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Location = new System.Drawing.Point(208, 313);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(232, 88);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Уставка температуры перегрева бака";
            // 
            // lUTEhi
            // 
            this.lUTEhi.AutoSize = true;
            this.lUTEhi.BackColor = System.Drawing.SystemColors.Window;
            this.lUTEhi.ForeColor = System.Drawing.Color.Maroon;
            this.lUTEhi.Location = new System.Drawing.Point(94, 27);
            this.lUTEhi.Name = "lUTEhi";
            this.lUTEhi.Size = new System.Drawing.Size(13, 13);
            this.lUTEhi.TabIndex = 15;
            this.lUTEhi.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(399, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(486, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(555, 484);
            this.listBox1.TabIndex = 21;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(486, 7);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 22;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuSettings});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 26);
            // 
            // toolStripMenuSettings
            // 
            this.toolStripMenuSettings.Name = "toolStripMenuSettings";
            this.toolStripMenuSettings.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.toolStripMenuSettings.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuSettings.Text = "Настройки";
            this.toolStripMenuSettings.Click += new System.EventHandler(this.toolStripMenuSettings_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lUTElo);
            this.groupBox6.Controls.Add(this.numericUpDownUTElo);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Location = new System.Drawing.Point(18, 419);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 88);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Уставка температуры нагрева бака";
            // 
            // lUTElo
            // 
            this.lUTElo.AutoSize = true;
            this.lUTElo.BackColor = System.Drawing.SystemColors.Window;
            this.lUTElo.ForeColor = System.Drawing.Color.Maroon;
            this.lUTElo.Location = new System.Drawing.Point(94, 27);
            this.lUTElo.Name = "lUTElo";
            this.lUTElo.Size = new System.Drawing.Size(13, 13);
            this.lUTElo.TabIndex = 15;
            this.lUTElo.Text = "0";
            // 
            // numericUpDownUTElo
            // 
            this.numericUpDownUTElo.Location = new System.Drawing.Point(14, 51);
            this.numericUpDownUTElo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownUTElo.Name = "numericUpDownUTElo";
            this.numericUpDownUTElo.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownUTElo.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(106, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Установить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lUtmin);
            this.groupBox7.Controls.Add(this.numericUpDownUtmin);
            this.groupBox7.Controls.Add(this.button7);
            this.groupBox7.Location = new System.Drawing.Point(240, 419);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(203, 88);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Уставка времени нагрева бака";
            // 
            // lUtmin
            // 
            this.lUtmin.AutoSize = true;
            this.lUtmin.BackColor = System.Drawing.SystemColors.Window;
            this.lUtmin.ForeColor = System.Drawing.Color.Maroon;
            this.lUtmin.Location = new System.Drawing.Point(94, 27);
            this.lUtmin.Name = "lUtmin";
            this.lUtmin.Size = new System.Drawing.Size(13, 13);
            this.lUtmin.TabIndex = 15;
            this.lUtmin.Text = "0";
            // 
            // numericUpDownUtmin
            // 
            this.numericUpDownUtmin.Location = new System.Drawing.Point(12, 54);
            this.numericUpDownUtmin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownUtmin.Name = "numericUpDownUtmin";
            this.numericUpDownUtmin.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownUtmin.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(99, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Установить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.BackColor = System.Drawing.SystemColors.Window;
            this.lCount.Location = new System.Drawing.Point(285, 22);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(13, 13);
            this.lCount.TabIndex = 25;
            this.lCount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(93, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Счетчик ожидания нагрева бака:";
            // 
            // lHLW
            // 
            this.lHLW.AutoSize = true;
            this.lHLW.BackColor = System.Drawing.SystemColors.Window;
            this.lHLW.Enabled = false;
            this.lHLW.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHLW.ForeColor = System.Drawing.Color.Green;
            this.lHLW.Location = new System.Drawing.Point(96, 43);
            this.lHLW.Name = "lHLW";
            this.lHLW.Size = new System.Drawing.Size(120, 18);
            this.lHLW.TabIndex = 26;
            this.lHLW.Text = "Работа Откл";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 549);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lHLW);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Relay1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Пульт деконтаминатора";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempBak)).EndInit();
            this.Relay1.ResumeLayout(false);
            this.Relay1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUTElo)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUtmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDownTempBak;
        private System.Windows.Forms.Label lRelay1;
        private System.Windows.Forms.Button bK1off;
        private System.Windows.Forms.Button bK1on;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox Relay1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lRelay2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lST2;
        private System.Windows.Forms.Label lST1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lUTEhi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSettings;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lUTElo;
        private System.Windows.Forms.NumericUpDown numericUpDownUTElo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lUtmin;
        private System.Windows.Forms.NumericUpDown numericUpDownUtmin;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lHLW;
        public System.Windows.Forms.Label lTE2;
        public System.Windows.Forms.Label lTE1;
    }
}

