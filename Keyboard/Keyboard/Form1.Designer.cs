
namespace Keyboard
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetSpeed = new System.Windows.Forms.Button();
            this.txtPot = new System.Windows.Forms.TextBox();
            this.pot = new System.Windows.Forms.Timer(this.components);
            this.connectionStatus = new System.Windows.Forms.Label();
            this.gbGPU = new System.Windows.Forms.GroupBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtFan2 = new System.Windows.Forms.TextBox();
            this.txtFan1 = new System.Windows.Forms.TextBox();
            this.lblFan2 = new System.Windows.Forms.Label();
            this.lblFan1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSound = new System.Windows.Forms.TextBox();
            this.btnSound = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbGPU.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 36);
            this.textBox1.TabIndex = 0;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(49, 55);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnWrite);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 89);
            this.panel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(267, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetSpeed);
            this.groupBox1.Controls.Add(this.txtPot);
            this.groupBox1.Location = new System.Drawing.Point(34, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Potansiyometre";
            // 
            // btnSetSpeed
            // 
            this.btnSetSpeed.Location = new System.Drawing.Point(51, 58);
            this.btnSetSpeed.Name = "btnSetSpeed";
            this.btnSetSpeed.Size = new System.Drawing.Size(75, 23);
            this.btnSetSpeed.TabIndex = 8;
            this.btnSetSpeed.Text = "Ayarla";
            this.btnSetSpeed.UseVisualStyleBackColor = true;
            this.btnSetSpeed.Click += new System.EventHandler(this.btnSetSpeed_Click);
            // 
            // txtPot
            // 
            this.txtPot.Location = new System.Drawing.Point(41, 32);
            this.txtPot.Name = "txtPot";
            this.txtPot.ReadOnly = true;
            this.txtPot.Size = new System.Drawing.Size(100, 20);
            this.txtPot.TabIndex = 0;
            this.txtPot.Text = "50";
            // 
            // pot
            // 
            this.pot.Interval = 1000;
            this.pot.Tick += new System.EventHandler(this.pot_Tick);
            // 
            // connectionStatus
            // 
            this.connectionStatus.AutoSize = true;
            this.connectionStatus.Location = new System.Drawing.Point(309, 12);
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(35, 13);
            this.connectionStatus.TabIndex = 6;
            this.connectionStatus.Text = "label1";
            // 
            // gbGPU
            // 
            this.gbGPU.Controls.Add(this.txtTemp);
            this.gbGPU.Controls.Add(this.lblTemp);
            this.gbGPU.Controls.Add(this.txtFan2);
            this.gbGPU.Controls.Add(this.txtFan1);
            this.gbGPU.Controls.Add(this.lblFan2);
            this.gbGPU.Controls.Add(this.lblFan1);
            this.gbGPU.Location = new System.Drawing.Point(267, 164);
            this.gbGPU.Name = "gbGPU";
            this.gbGPU.Size = new System.Drawing.Size(442, 232);
            this.gbGPU.TabIndex = 7;
            this.gbGPU.TabStop = false;
            this.gbGPU.Text = "groupBox2";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(88, 33);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 13;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(18, 36);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(47, 13);
            this.lblTemp.TabIndex = 12;
            this.lblTemp.Text = "Sıcaklık:";
            // 
            // txtFan2
            // 
            this.txtFan2.Location = new System.Drawing.Point(163, 169);
            this.txtFan2.Name = "txtFan2";
            this.txtFan2.ReadOnly = true;
            this.txtFan2.Size = new System.Drawing.Size(100, 20);
            this.txtFan2.TabIndex = 11;
            // 
            // txtFan1
            // 
            this.txtFan1.Location = new System.Drawing.Point(21, 169);
            this.txtFan1.Name = "txtFan1";
            this.txtFan1.ReadOnly = true;
            this.txtFan1.Size = new System.Drawing.Size(100, 20);
            this.txtFan1.TabIndex = 10;
            // 
            // lblFan2
            // 
            this.lblFan2.AutoSize = true;
            this.lblFan2.Location = new System.Drawing.Point(180, 142);
            this.lblFan2.Name = "lblFan2";
            this.lblFan2.Size = new System.Drawing.Size(37, 13);
            this.lblFan2.TabIndex = 9;
            this.lblFan2.Text = "2. Fan";
            // 
            // lblFan1
            // 
            this.lblFan1.AutoSize = true;
            this.lblFan1.Location = new System.Drawing.Point(42, 142);
            this.lblFan1.Name = "lblFan1";
            this.lblFan1.Size = new System.Drawing.Size(37, 13);
            this.lblFan1.TabIndex = 8;
            this.lblFan1.Text = "1. Fan";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ses Seviyesi:";
            // 
            // txtSound
            // 
            this.txtSound.Location = new System.Drawing.Point(571, 37);
            this.txtSound.Name = "txtSound";
            this.txtSound.ReadOnly = true;
            this.txtSound.Size = new System.Drawing.Size(100, 20);
            this.txtSound.TabIndex = 8;
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(583, 67);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(75, 23);
            this.btnSound.TabIndex = 9;
            this.btnSound.Text = "Ses Ayarla";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 532);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.txtSound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbGPU);
            this.Controls.Add(this.connectionStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGPU.ResumeLayout(false);
            this.gbGPU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPot;
        private System.Windows.Forms.Timer pot;
        private System.Windows.Forms.Label connectionStatus;
        private System.Windows.Forms.GroupBox gbGPU;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblFan2;
        private System.Windows.Forms.Label lblFan1;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtFan2;
        private System.Windows.Forms.TextBox txtFan1;
        private System.Windows.Forms.Button btnSetSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSound;
        private System.Windows.Forms.Button btnSound;
    }
}

