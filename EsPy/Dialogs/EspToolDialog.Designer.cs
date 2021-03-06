﻿namespace EsPy.Dialogs
{
    partial class EspToolDialog
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
            this.tbPython = new System.Windows.Forms.TextBox();
            this.btnPython = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEsptool = new System.Windows.Forms.TextBox();
            this.btnEsptool = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirmware = new System.Windows.Forms.TextBox();
            this.btnFirmware = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMac = new System.Windows.Forms.Button();
            this.btnFlashID = new System.Windows.Forms.Button();
            this.btnChipID = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "python.exe";
            // 
            // txtPython
            // 
            this.tbPython.Location = new System.Drawing.Point(75, 46);
            this.tbPython.Name = "txtPython";
            this.tbPython.Size = new System.Drawing.Size(502, 20);
            this.tbPython.TabIndex = 1;
            // 
            // btnPython
            // 
            this.btnPython.Location = new System.Drawing.Point(583, 44);
            this.btnPython.Name = "btnPython";
            this.btnPython.Size = new System.Drawing.Size(23, 23);
            this.btnPython.TabIndex = 2;
            this.btnPython.Text = "...";
            this.btnPython.UseVisualStyleBackColor = true;
            this.btnPython.Click += new System.EventHandler(this.btnPython_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "esptool.py";
            // 
            // txtEsptool
            // 
            this.tbEsptool.Location = new System.Drawing.Point(75, 72);
            this.tbEsptool.Name = "txtEsptool";
            this.tbEsptool.Size = new System.Drawing.Size(502, 20);
            this.tbEsptool.TabIndex = 3;
            // 
            // btnEsptool
            // 
            this.btnEsptool.Location = new System.Drawing.Point(583, 70);
            this.btnEsptool.Name = "btnEsptool";
            this.btnEsptool.Size = new System.Drawing.Size(23, 23);
            this.btnEsptool.TabIndex = 4;
            this.btnEsptool.Text = "...";
            this.btnEsptool.UseVisualStyleBackColor = true;
            this.btnEsptool.Click += new System.EventHandler(this.btnEsptool_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "frimware.bin";
            // 
            // txtFirmware
            // 
            this.tbFirmware.Location = new System.Drawing.Point(75, 98);
            this.tbFirmware.Name = "txtFirmware";
            this.tbFirmware.Size = new System.Drawing.Size(502, 20);
            this.tbFirmware.TabIndex = 5;
            // 
            // btnFirmware
            // 
            this.btnFirmware.Location = new System.Drawing.Point(583, 96);
            this.btnFirmware.Name = "btnFirmware";
            this.btnFirmware.Size = new System.Drawing.Size(23, 23);
            this.btnFirmware.TabIndex = 6;
            this.btnFirmware.Text = "...";
            this.btnFirmware.UseVisualStyleBackColor = true;
            this.btnFirmware.Click += new System.EventHandler(this.btnFirmware_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(12, 182);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(606, 157);
            this.textBox4.TabIndex = 0;
            // 
            // btnErase
            // 
            this.btnErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnErase.Location = new System.Drawing.Point(306, 346);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(100, 23);
            this.btnErase.TabIndex = 4;
            this.btnErase.Text = "1. Erase...";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.Erase_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWrite.Location = new System.Drawing.Point(412, 346);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(100, 23);
            this.btnWrite.TabIndex = 5;
            this.btnWrite.Text = "2. Write + Verify...";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(468, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "OK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(549, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVerify.Location = new System.Drawing.Point(518, 345);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(100, 23);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = global::EsPy.Properties.Resources.eraseflash1;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(636, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "         esptool";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPort);
            this.groupBox1.Controls.Add(this.cbBaudrate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbPython);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbEsptool);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbFirmware);
            this.groupBox1.Controls.Add(this.btnPython);
            this.groupBox1.Controls.Add(this.btnEsptool);
            this.groupBox1.Controls.Add(this.btnFirmware);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cbBaudrate.Location = new System.Drawing.Point(249, 19);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(104, 21);
            this.cbBaudrate.TabIndex = 0;
            this.cbBaudrate.Validating += new System.ComponentModel.CancelEventHandler(this.cbBaudrate_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Baud Rate";
            // 
            // btnMac
            // 
            this.btnMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMac.Location = new System.Drawing.Point(12, 345);
            this.btnMac.Name = "btnMac";
            this.btnMac.Size = new System.Drawing.Size(74, 23);
            this.btnMac.TabIndex = 1;
            this.btnMac.Text = "MAC";
            this.btnMac.UseVisualStyleBackColor = true;
            this.btnMac.Click += new System.EventHandler(this.btnMac_Click);
            // 
            // btnFlashID
            // 
            this.btnFlashID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFlashID.Location = new System.Drawing.Point(92, 346);
            this.btnFlashID.Name = "btnFlashID";
            this.btnFlashID.Size = new System.Drawing.Size(74, 23);
            this.btnFlashID.TabIndex = 2;
            this.btnFlashID.Text = "Flash ID";
            this.btnFlashID.UseVisualStyleBackColor = true;
            this.btnFlashID.Click += new System.EventHandler(this.btnFlashID_Click);
            // 
            // btnChipID
            // 
            this.btnChipID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChipID.Location = new System.Drawing.Point(172, 346);
            this.btnChipID.Name = "btnChipID";
            this.btnChipID.Size = new System.Drawing.Size(74, 23);
            this.btnChipID.TabIndex = 3;
            this.btnChipID.Text = "Chip ID";
            this.btnChipID.UseVisualStyleBackColor = true;
            this.btnChipID.Click += new System.EventHandler(this.btnChipID_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(612, 1);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 381);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(180, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/espressif/esptool";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 400);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(212, 13);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "http://micropython.org/download#esp8266";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Serial Port";
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(75, 19);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(104, 21);
            this.cbPort.TabIndex = 0;
            this.cbPort.Validating += new System.ComponentModel.CancelEventHandler(this.cbBaudrate_Validating);
            // 
            // EspToolDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 422);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChipID);
            this.Controls.Add(this.btnFlashID);
            this.Controls.Add(this.btnMac);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.textBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EspToolDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "esptool";
            this.Load += new System.EventHandler(this.EspToolDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPython;
        private System.Windows.Forms.Button btnPython;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEsptool;
        private System.Windows.Forms.Button btnEsptool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirmware;
        private System.Windows.Forms.Button btnFirmware;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMac;
        private System.Windows.Forms.Button btnFlashID;
        private System.Windows.Forms.Button btnChipID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label7;
    }
}