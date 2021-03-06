﻿using System;
using WingMan.Objects;

namespace WingMan
{
    partial class MainForm
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
            this.connectButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.oscLog = new System.Windows.Forms.TextBox();
            this.oscLogLabel = new System.Windows.Forms.Label();
            this.sourceTabPage = new System.Windows.Forms.TabPage();
            this.arduinoSettingsPanel = new System.Windows.Forms.Panel();
            this.arduinoHwInfoLabel = new System.Windows.Forms.Label();
            this.arduinoConfiguredBox = new System.Windows.Forms.CheckBox();
            this.arduinoHwInfoBox = new System.Windows.Forms.TextBox();
            this.arduinoFadersCountBox = new System.Windows.Forms.TextBox();
            this.arduinoIdBox = new System.Windows.Forms.TextBox();
            this.arduinoButtonsCountBox = new System.Windows.Forms.TextBox();
            this.arduinoConfigureButton = new System.Windows.Forms.Button();
            this.arduinoFadersCountLabel = new System.Windows.Forms.Label();
            this.arduinoFWverBox = new System.Windows.Forms.TextBox();
            this.arduinoConfiguredLabel = new System.Windows.Forms.Label();
            this.arduinoIdLabel = new System.Windows.Forms.Label();
            this.arduinoButtonsCountLabel = new System.Windows.Forms.Label();
            this.arduinoFWverLabel = new System.Windows.Forms.Label();
            this.arduinoSerialComboLabel = new System.Windows.Forms.Label();
            this.arduinoSettingsLabel = new System.Windows.Forms.Label();
            this.arduinoSerialPortCombo = new System.Windows.Forms.ComboBox();
            this.sourceModeComboLabel = new System.Windows.Forms.Label();
            this.sourceModeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.targetPortTextBox = new System.Windows.Forms.TextBox();
            this.sourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.sourceTabPage.SuspendLayout();
            this.arduinoSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.connectButton.Location = new System.Drawing.Point(15, 153);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(94, 32);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 212);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLog);
            this.tabControl1.Controls.Add(this.sourceTabPage);
            this.tabControl1.Location = new System.Drawing.Point(212, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 197);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.oscLog);
            this.tabPageLog.Controls.Add(this.oscLogLabel);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(352, 171);
            this.tabPageLog.TabIndex = 0;
            this.tabPageLog.Text = "OSC Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // oscLog
            // 
            this.oscLog.AcceptsReturn = true;
            this.oscLog.Location = new System.Drawing.Point(6, 20);
            this.oscLog.Multiline = true;
            this.oscLog.Name = "oscLog";
            this.oscLog.ReadOnly = true;
            this.oscLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.oscLog.Size = new System.Drawing.Size(340, 145);
            this.oscLog.TabIndex = 1;
            // 
            // oscLogLabel
            // 
            this.oscLogLabel.AutoSize = true;
            this.oscLogLabel.Location = new System.Drawing.Point(6, 4);
            this.oscLogLabel.Name = "oscLogLabel";
            this.oscLogLabel.Size = new System.Drawing.Size(146, 13);
            this.oscLogLabel.TabIndex = 3;
            this.oscLogLabel.Text = "Log: (recent OSC commands)";
            // 
            // sourceTabPage
            // 
            this.sourceTabPage.Controls.Add(this.arduinoSettingsPanel);
            this.sourceTabPage.Controls.Add(this.sourceModeComboLabel);
            this.sourceTabPage.Controls.Add(this.sourceModeCombo);
            this.sourceTabPage.Location = new System.Drawing.Point(4, 22);
            this.sourceTabPage.Name = "sourceTabPage";
            this.sourceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sourceTabPage.Size = new System.Drawing.Size(352, 171);
            this.sourceTabPage.TabIndex = 1;
            this.sourceTabPage.Text = "Source";
            this.sourceTabPage.UseVisualStyleBackColor = true;
            // 
            // arduinoSettingsPanel
            // 
            this.arduinoSettingsPanel.Controls.Add(this.arduinoHwInfoLabel);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoConfiguredBox);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoHwInfoBox);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoFadersCountBox);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoIdBox);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoButtonsCountBox);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoConfigureButton);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoFadersCountLabel);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoFWverBox);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoConfiguredLabel);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoIdLabel);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoButtonsCountLabel);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoFWverLabel);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoSerialComboLabel);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoSettingsLabel);
            this.arduinoSettingsPanel.Controls.Add(this.arduinoSerialPortCombo);
            this.arduinoSettingsPanel.Location = new System.Drawing.Point(0, 33);
            this.arduinoSettingsPanel.Name = "arduinoSettingsPanel";
            this.arduinoSettingsPanel.Size = new System.Drawing.Size(352, 138);
            this.arduinoSettingsPanel.TabIndex = 2;
            this.arduinoSettingsPanel.Visible = false;
            // 
            // arduinoHwInfoLabel
            // 
            this.arduinoHwInfoLabel.AutoSize = true;
            this.arduinoHwInfoLabel.Location = new System.Drawing.Point(196, 32);
            this.arduinoHwInfoLabel.Name = "arduinoHwInfoLabel";
            this.arduinoHwInfoLabel.Size = new System.Drawing.Size(49, 13);
            this.arduinoHwInfoLabel.TabIndex = 13;
            this.arduinoHwInfoLabel.Text = "HW info:";
            // 
            // arduinoConfiguredBox
            // 
            this.arduinoConfiguredBox.AutoCheck = false;
            this.arduinoConfiguredBox.AutoSize = true;
            this.arduinoConfiguredBox.Location = new System.Drawing.Point(331, 111);
            this.arduinoConfiguredBox.Name = "arduinoConfiguredBox";
            this.arduinoConfiguredBox.Size = new System.Drawing.Size(15, 14);
            this.arduinoConfiguredBox.TabIndex = 12;
            this.arduinoConfiguredBox.UseVisualStyleBackColor = true;
            // 
            // arduinoHwInfoBox
            // 
            this.arduinoHwInfoBox.Location = new System.Drawing.Point(251, 29);
            this.arduinoHwInfoBox.Name = "arduinoHwInfoBox";
            this.arduinoHwInfoBox.ReadOnly = true;
            this.arduinoHwInfoBox.Size = new System.Drawing.Size(95, 20);
            this.arduinoHwInfoBox.TabIndex = 11;
            // 
            // arduinoFadersCountBox
            // 
            this.arduinoFadersCountBox.Location = new System.Drawing.Point(193, 82);
            this.arduinoFadersCountBox.Name = "arduinoFadersCountBox";
            this.arduinoFadersCountBox.ReadOnly = true;
            this.arduinoFadersCountBox.Size = new System.Drawing.Size(27, 20);
            this.arduinoFadersCountBox.TabIndex = 11;
            // 
            // arduinoIdBox
            // 
            this.arduinoIdBox.Location = new System.Drawing.Point(70, 108);
            this.arduinoIdBox.Name = "arduinoIdBox";
            this.arduinoIdBox.ReadOnly = true;
            this.arduinoIdBox.Size = new System.Drawing.Size(150, 20);
            this.arduinoIdBox.TabIndex = 11;
            // 
            // arduinoButtonsCountBox
            // 
            this.arduinoButtonsCountBox.Location = new System.Drawing.Point(70, 82);
            this.arduinoButtonsCountBox.Name = "arduinoButtonsCountBox";
            this.arduinoButtonsCountBox.ReadOnly = true;
            this.arduinoButtonsCountBox.Size = new System.Drawing.Size(27, 20);
            this.arduinoButtonsCountBox.TabIndex = 11;
            // 
            // arduinoConfigureButton
            // 
            this.arduinoConfigureButton.Enabled = false;
            this.arduinoConfigureButton.Location = new System.Drawing.Point(271, 81);
            this.arduinoConfigureButton.Name = "arduinoConfigureButton";
            this.arduinoConfigureButton.Size = new System.Drawing.Size(75, 23);
            this.arduinoConfigureButton.TabIndex = 2;
            this.arduinoConfigureButton.Text = "Configure";
            this.arduinoConfigureButton.UseVisualStyleBackColor = true;
            this.arduinoConfigureButton.Click += new System.EventHandler(this.arduinoConfigureButton_Click);
            // 
            // arduinoFadersCountLabel
            // 
            this.arduinoFadersCountLabel.AutoSize = true;
            this.arduinoFadersCountLabel.Location = new System.Drawing.Point(130, 86);
            this.arduinoFadersCountLabel.Name = "arduinoFadersCountLabel";
            this.arduinoFadersCountLabel.Size = new System.Drawing.Size(42, 13);
            this.arduinoFadersCountLabel.TabIndex = 1;
            this.arduinoFadersCountLabel.Text = "Faders:";
            // 
            // arduinoFWverBox
            // 
            this.arduinoFWverBox.Location = new System.Drawing.Point(70, 56);
            this.arduinoFWverBox.Name = "arduinoFWverBox";
            this.arduinoFWverBox.ReadOnly = true;
            this.arduinoFWverBox.Size = new System.Drawing.Size(276, 20);
            this.arduinoFWverBox.TabIndex = 10;
            // 
            // arduinoConfiguredLabel
            // 
            this.arduinoConfiguredLabel.AutoSize = true;
            this.arduinoConfiguredLabel.Location = new System.Drawing.Point(264, 112);
            this.arduinoConfiguredLabel.Name = "arduinoConfiguredLabel";
            this.arduinoConfiguredLabel.Size = new System.Drawing.Size(61, 13);
            this.arduinoConfiguredLabel.TabIndex = 1;
            this.arduinoConfiguredLabel.Text = "Configured:";
            // 
            // arduinoIdLabel
            // 
            this.arduinoIdLabel.AutoSize = true;
            this.arduinoIdLabel.Location = new System.Drawing.Point(7, 111);
            this.arduinoIdLabel.Name = "arduinoIdLabel";
            this.arduinoIdLabel.Size = new System.Drawing.Size(58, 13);
            this.arduinoIdLabel.TabIndex = 1;
            this.arduinoIdLabel.Text = "Device ID:";
            // 
            // arduinoButtonsCountLabel
            // 
            this.arduinoButtonsCountLabel.AutoSize = true;
            this.arduinoButtonsCountLabel.Location = new System.Drawing.Point(7, 86);
            this.arduinoButtonsCountLabel.Name = "arduinoButtonsCountLabel";
            this.arduinoButtonsCountLabel.Size = new System.Drawing.Size(46, 13);
            this.arduinoButtonsCountLabel.TabIndex = 1;
            this.arduinoButtonsCountLabel.Text = "Buttons:";
            // 
            // arduinoFWverLabel
            // 
            this.arduinoFWverLabel.AutoSize = true;
            this.arduinoFWverLabel.Location = new System.Drawing.Point(6, 59);
            this.arduinoFWverLabel.Name = "arduinoFWverLabel";
            this.arduinoFWverLabel.Size = new System.Drawing.Size(47, 13);
            this.arduinoFWverLabel.TabIndex = 1;
            this.arduinoFWverLabel.Text = "FW info:";
            // 
            // arduinoSerialComboLabel
            // 
            this.arduinoSerialComboLabel.AutoSize = true;
            this.arduinoSerialComboLabel.Location = new System.Drawing.Point(6, 32);
            this.arduinoSerialComboLabel.Name = "arduinoSerialComboLabel";
            this.arduinoSerialComboLabel.Size = new System.Drawing.Size(58, 13);
            this.arduinoSerialComboLabel.TabIndex = 1;
            this.arduinoSerialComboLabel.Text = "Serial Port:";
            // 
            // arduinoSettingsLabel
            // 
            this.arduinoSettingsLabel.AutoSize = true;
            this.arduinoSettingsLabel.Location = new System.Drawing.Point(3, 0);
            this.arduinoSettingsLabel.Name = "arduinoSettingsLabel";
            this.arduinoSettingsLabel.Size = new System.Drawing.Size(217, 26);
            this.arduinoSettingsLabel.TabIndex = 0;
            this.arduinoSettingsLabel.Text = "Please ensure you have the correct firmware\r\ninstalled on your Arduino.";
            // 
            // arduinoSerialPortCombo
            // 
            this.arduinoSerialPortCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arduinoSerialPortCombo.FormattingEnabled = true;
            this.arduinoSerialPortCombo.Location = new System.Drawing.Point(70, 29);
            this.arduinoSerialPortCombo.Name = "arduinoSerialPortCombo";
            this.arduinoSerialPortCombo.Size = new System.Drawing.Size(120, 21);
            this.arduinoSerialPortCombo.TabIndex = 0;
            this.arduinoSerialPortCombo.SelectedIndexChanged += new System.EventHandler(this.arduinoSerialPortCombo_SelectedIndexChanged);
            // 
            // sourceModeComboLabel
            // 
            this.sourceModeComboLabel.AutoSize = true;
            this.sourceModeComboLabel.Location = new System.Drawing.Point(6, 9);
            this.sourceModeComboLabel.Name = "sourceModeComboLabel";
            this.sourceModeComboLabel.Size = new System.Drawing.Size(37, 13);
            this.sourceModeComboLabel.TabIndex = 1;
            this.sourceModeComboLabel.Text = "Mode:";
            // 
            // sourceModeCombo
            // 
            this.sourceModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceModeCombo.FormattingEnabled = true;
            this.sourceModeCombo.Location = new System.Drawing.Point(70, 6);
            this.sourceModeCombo.Name = "sourceModeCombo";
            this.sourceModeCombo.Size = new System.Drawing.Size(120, 21);
            this.sourceModeCombo.TabIndex = 0;
            this.sourceModeCombo.SelectedIndexChanged += new System.EventHandler(this.sourceModeCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Target:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.OrangeRed;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.statusLabel.Location = new System.Drawing.Point(12, 12);
            this.statusLabel.MinimumSize = new System.Drawing.Size(185, 40);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(185, 40);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Disconnected";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetTextBox
            // 
            this.targetTextBox.Location = new System.Drawing.Point(83, 59);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(114, 20);
            this.targetTextBox.TabIndex = 10;
            this.targetTextBox.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Target port:";
            // 
            // targetPortTextBox
            // 
            this.targetPortTextBox.Location = new System.Drawing.Point(83, 85);
            this.targetPortTextBox.Name = "targetPortTextBox";
            this.targetPortTextBox.Size = new System.Drawing.Size(47, 20);
            this.targetPortTextBox.TabIndex = 10;
            this.targetPortTextBox.Text = "3032";
            // 
            // sourceLinkLabel
            // 
            this.sourceLinkLabel.AutoSize = true;
            this.sourceLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sourceLinkLabel.Location = new System.Drawing.Point(12, 110);
            this.sourceLinkLabel.Name = "sourceLinkLabel";
            this.sourceLinkLabel.Size = new System.Drawing.Size(49, 15);
            this.sourceLinkLabel.TabIndex = 11;
            this.sourceLinkLabel.TabStop = true;
            this.sourceLinkLabel.Text = "Source:";
            this.sourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sourceLinkLabel_LinkClicked);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(83, 110);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ReadOnly = true;
            this.sourceTextBox.Size = new System.Drawing.Size(114, 20);
            this.sourceTextBox.TabIndex = 10;
            this.sourceTextBox.Text = "Not Configured!";
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(115, 153);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(82, 32);
            this.disconnectButton.TabIndex = 5;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(108, 17);
            this.toolStripStatusLabel1.Text = "Robert Phipps 2017";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.IsLink = true;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(136, 17);
            this.toolStripStatusLabel2.Text = "rphi.github.io/WingMan";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 234);
            this.Controls.Add(this.sourceLinkLabel);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.targetPortTextBox);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Name = "MainForm";
            this.Text = "WingMan for Eos";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.sourceTabPage.ResumeLayout(false);
            this.sourceTabPage.PerformLayout();
            this.arduinoSettingsPanel.ResumeLayout(false);
            this.arduinoSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox targetPortTextBox;
        private System.Windows.Forms.TabPage sourceTabPage;
        private System.Windows.Forms.Label sourceModeComboLabel;
        private System.Windows.Forms.ComboBox sourceModeCombo;
        private System.Windows.Forms.LinkLabel sourceLinkLabel;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Panel arduinoSettingsPanel;
        private System.Windows.Forms.Label arduinoSerialComboLabel;
        private System.Windows.Forms.Label arduinoSettingsLabel;
        private System.Windows.Forms.ComboBox arduinoSerialPortCombo;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button arduinoConfigureButton;
        private System.Windows.Forms.TextBox arduinoFWverBox;
        private System.Windows.Forms.Label arduinoFWverLabel;
        private System.Windows.Forms.TextBox arduinoFadersCountBox;
        private System.Windows.Forms.TextBox arduinoButtonsCountBox;
        private System.Windows.Forms.Label arduinoFadersCountLabel;
        private System.Windows.Forms.Label arduinoButtonsCountLabel;
        private System.Windows.Forms.TextBox arduinoIdBox;
        private System.Windows.Forms.Label arduinoIdLabel;
        private System.Windows.Forms.CheckBox arduinoConfiguredBox;
        private System.Windows.Forms.Label arduinoConfiguredLabel;
        private System.Windows.Forms.Label arduinoHwInfoLabel;
        private System.Windows.Forms.TextBox arduinoHwInfoBox;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TextBox oscLog;
        private System.Windows.Forms.Label oscLogLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

