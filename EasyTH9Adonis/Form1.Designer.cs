﻿namespace EasyTH9Adonis
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
            this.checkBox_useUPNP = new System.Windows.Forms.CheckBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.numeric_Port = new System.Windows.Forms.NumericUpDown();
            this.textBox_upnpIP = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.page_Server = new System.Windows.Forms.TabPage();
            this.btn_StartServer = new System.Windows.Forms.Button();
            this.page_ClientWatch = new System.Windows.Forms.TabPage();
            this.btn_watch = new System.Windows.Forms.Button();
            this.btn_Client = new System.Windows.Forms.Button();
            this.textBox_ConnectIP = new System.Windows.Forms.TextBox();
            this.label_IP2 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.domain_Adonis = new System.Windows.Forms.DomainUpDown();
            this.label_GitHub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Port)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.page_Server.SuspendLayout();
            this.page_ClientWatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_useUPNP
            // 
            this.checkBox_useUPNP.AutoSize = true;
            this.checkBox_useUPNP.Location = new System.Drawing.Point(6, 8);
            this.checkBox_useUPNP.Name = "checkBox_useUPNP";
            this.checkBox_useUPNP.Size = new System.Drawing.Size(76, 17);
            this.checkBox_useUPNP.TabIndex = 0;
            this.checkBox_useUPNP.Text = "Use UPnP";
            this.toolTip1.SetToolTip(this.checkBox_useUPNP, "Enables Universal Plug and Play.\\n\r\nIf your router supports UPnP this should allo" +
        "w you for automatic port fowarding.\\n\r\nMay or may not actually work.");
            this.checkBox_useUPNP.UseVisualStyleBackColor = true;
            this.checkBox_useUPNP.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(16, 104);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(26, 13);
            this.label_Port.TabIndex = 1;
            this.label_Port.Text = "Port";
            // 
            // numeric_Port
            // 
            this.numeric_Port.Location = new System.Drawing.Point(47, 102);
            this.numeric_Port.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numeric_Port.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_Port.Name = "numeric_Port";
            this.numeric_Port.Size = new System.Drawing.Size(56, 20);
            this.numeric_Port.TabIndex = 2;
            this.toolTip1.SetToolTip(this.numeric_Port, "The Port Number used to connect.\\nMake sure this is the same!");
            this.numeric_Port.Value = new decimal(new int[] {
            17723,
            0,
            0,
            0});
            this.numeric_Port.ValueChanged += new System.EventHandler(this.numeric_Port_ValueChanged);
            // 
            // textBox_upnpIP
            // 
            this.textBox_upnpIP.Location = new System.Drawing.Point(88, 6);
            this.textBox_upnpIP.Name = "textBox_upnpIP";
            this.textBox_upnpIP.ReadOnly = true;
            this.textBox_upnpIP.Size = new System.Drawing.Size(130, 20);
            this.textBox_upnpIP.TabIndex = 4;
            this.textBox_upnpIP.Text = "UPnP Disabled";
            this.toolTip1.SetToolTip(this.textBox_upnpIP, "Displays the external IP if UPnP is successful.");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.page_Server);
            this.tabControl1.Controls.Add(this.page_ClientWatch);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(233, 86);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Deselected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Deselected);
            // 
            // page_Server
            // 
            this.page_Server.Controls.Add(this.btn_StartServer);
            this.page_Server.Controls.Add(this.checkBox_useUPNP);
            this.page_Server.Controls.Add(this.textBox_upnpIP);
            this.page_Server.Location = new System.Drawing.Point(4, 22);
            this.page_Server.Name = "page_Server";
            this.page_Server.Padding = new System.Windows.Forms.Padding(3);
            this.page_Server.Size = new System.Drawing.Size(225, 60);
            this.page_Server.TabIndex = 0;
            this.page_Server.Text = "Server";
            this.page_Server.UseVisualStyleBackColor = true;
            // 
            // btn_StartServer
            // 
            this.btn_StartServer.Location = new System.Drawing.Point(6, 32);
            this.btn_StartServer.Name = "btn_StartServer";
            this.btn_StartServer.Size = new System.Drawing.Size(212, 23);
            this.btn_StartServer.TabIndex = 5;
            this.btn_StartServer.Text = "Start Server";
            this.toolTip1.SetToolTip(this.btn_StartServer, "Launch adonis with these server settings.");
            this.btn_StartServer.UseVisualStyleBackColor = true;
            this.btn_StartServer.Click += new System.EventHandler(this.btn_StartServer_Click);
            // 
            // page_ClientWatch
            // 
            this.page_ClientWatch.Controls.Add(this.btn_watch);
            this.page_ClientWatch.Controls.Add(this.btn_Client);
            this.page_ClientWatch.Controls.Add(this.textBox_ConnectIP);
            this.page_ClientWatch.Controls.Add(this.label_IP2);
            this.page_ClientWatch.Location = new System.Drawing.Point(4, 22);
            this.page_ClientWatch.Name = "page_ClientWatch";
            this.page_ClientWatch.Padding = new System.Windows.Forms.Padding(3);
            this.page_ClientWatch.Size = new System.Drawing.Size(225, 60);
            this.page_ClientWatch.TabIndex = 1;
            this.page_ClientWatch.Text = "Client/Watch";
            this.page_ClientWatch.UseVisualStyleBackColor = true;
            // 
            // btn_watch
            // 
            this.btn_watch.Location = new System.Drawing.Point(115, 31);
            this.btn_watch.Name = "btn_watch";
            this.btn_watch.Size = new System.Drawing.Size(107, 23);
            this.btn_watch.TabIndex = 7;
            this.btn_watch.Text = "Watch!";
            this.toolTip1.SetToolTip(this.btn_watch, "Connects to the server as a spectator.\\nThe server host\'s adonis_config.ini shoul" +
        "d allow this!");
            this.btn_watch.UseVisualStyleBackColor = true;
            this.btn_watch.Click += new System.EventHandler(this.btn_watch_Click);
            // 
            // btn_Client
            // 
            this.btn_Client.Location = new System.Drawing.Point(3, 31);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(107, 23);
            this.btn_Client.TabIndex = 6;
            this.btn_Client.Text = "Play!";
            this.toolTip1.SetToolTip(this.btn_Client, "Connects to the server as a client player.\\nOnly one client can exist!");
            this.btn_Client.UseVisualStyleBackColor = true;
            this.btn_Client.Click += new System.EventHandler(this.btn_Client_Click);
            // 
            // textBox_ConnectIP
            // 
            this.textBox_ConnectIP.Location = new System.Drawing.Point(33, 5);
            this.textBox_ConnectIP.Name = "textBox_ConnectIP";
            this.textBox_ConnectIP.Size = new System.Drawing.Size(186, 20);
            this.textBox_ConnectIP.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBox_ConnectIP, "The external IP address of the server.\\n\r\nIf you\'re not on the same network make " +
        "sure it\'s not their LAN address!\\n\r\nLAN Address example: 192.168.0.100");
            // 
            // label_IP2
            // 
            this.label_IP2.AutoSize = true;
            this.label_IP2.Location = new System.Drawing.Point(6, 9);
            this.label_IP2.Name = "label_IP2";
            this.label_IP2.Size = new System.Drawing.Size(20, 13);
            this.label_IP2.TabIndex = 4;
            this.label_IP2.Text = "IP:";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(16, 128);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(38, 13);
            this.label_Status.TabIndex = 6;
            this.label_Status.Text = "Ready";
            // 
            // domain_Adonis
            // 
            this.domain_Adonis.Items.Add("adonis");
            this.domain_Adonis.Items.Add("adonise");
            this.domain_Adonis.Location = new System.Drawing.Point(110, 102);
            this.domain_Adonis.Name = "domain_Adonis";
            this.domain_Adonis.ReadOnly = true;
            this.domain_Adonis.Size = new System.Drawing.Size(120, 20);
            this.domain_Adonis.TabIndex = 7;
            this.domain_Adonis.Text = "adonis";
            this.toolTip1.SetToolTip(this.domain_Adonis, "The adonis version to use.\\nadnos.exe launches th09.exe, while adonise.exe launch" +
        "es th09e.exe\\nMake sure this is the same!");
            // 
            // label_GitHub
            // 
            this.label_GitHub.AutoSize = true;
            this.label_GitHub.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_GitHub.Location = new System.Drawing.Point(16, 149);
            this.label_GitHub.Name = "label_GitHub";
            this.label_GitHub.Size = new System.Drawing.Size(173, 13);
            this.label_GitHub.TabIndex = 8;
            this.label_GitHub.Text = "Click me to get to the GitHub page.";
            this.label_GitHub.Click += new System.EventHandler(this.label_GitHub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 172);
            this.Controls.Add(this.label_GitHub);
            this.Controls.Add(this.domain_Adonis);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.numeric_Port);
            this.Controls.Add(this.label_Port);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Touhou 9 Adonis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Port)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.page_Server.ResumeLayout(false);
            this.page_Server.PerformLayout();
            this.page_ClientWatch.ResumeLayout(false);
            this.page_ClientWatch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_useUPNP;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.NumericUpDown numeric_Port;
        private System.Windows.Forms.TextBox textBox_upnpIP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage page_Server;
        private System.Windows.Forms.TabPage page_ClientWatch;
        private System.Windows.Forms.Button btn_StartServer;
        private System.Windows.Forms.Button btn_watch;
        private System.Windows.Forms.Button btn_Client;
        private System.Windows.Forms.TextBox textBox_ConnectIP;
        private System.Windows.Forms.Label label_IP2;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DomainUpDown domain_Adonis;
        private System.Windows.Forms.Label label_GitHub;
    }
}
