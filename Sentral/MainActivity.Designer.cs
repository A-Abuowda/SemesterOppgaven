﻿namespace Sentral
{
    partial class MainActivity
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Access_Panel = new System.Windows.Forms.Panel();
            this.Alarm_window = new System.Windows.Forms.Panel();
            this.listview_alarm_log = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.AlarmType = new System.Windows.Forms.ColumnHeader();
            this.last_user = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.Access_window = new System.Windows.Forms.Panel();
            this.listview_access_log = new System.Windows.Forms.ListView();
            this.access_id = new System.Windows.Forms.ColumnHeader();
            this.Card_number = new System.Windows.Forms.ColumnHeader();
            this.bruker_etternavn = new System.Windows.Forms.ColumnHeader();
            this.Bruker_Fornavn = new System.Windows.Forms.ColumnHeader();
            this.Door = new System.Windows.Forms.ColumnHeader();
            this.access_time = new System.Windows.Forms.ColumnHeader();
            this.access_granted = new System.Windows.Forms.ColumnHeader();
            this.ButtonPanel.SuspendLayout();
            this.Alarm_window.SuspendLayout();
            this.Access_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.button6);
            this.ButtonPanel.Controls.Add(this.button5);
            this.ButtonPanel.Controls.Add(this.panel3);
            this.ButtonPanel.Controls.Add(this.button4);
            this.ButtonPanel.Controls.Add(this.button3);
            this.ButtonPanel.Controls.Add(this.panel2);
            this.ButtonPanel.Controls.Add(this.button2);
            this.ButtonPanel.Controls.Add(this.button1);
            this.ButtonPanel.Controls.Add(this.panel1);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(200, 686);
            this.ButtonPanel.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 598);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 44);
            this.button6.TabIndex = 9;
            this.button6.Text = "Open Folder";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 642);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 44);
            this.button5.TabIndex = 8;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 265);
            this.panel3.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 44);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 44);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Generate Alarmlog";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Access Log";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 201);
            this.panel1.TabIndex = 0;
            // 
            // Access_Panel
            // 
            this.Access_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Access_Panel.Location = new System.Drawing.Point(1049, 0);
            this.Access_Panel.Name = "Access_Panel";
            this.Access_Panel.Size = new System.Drawing.Size(122, 686);
            this.Access_Panel.TabIndex = 1;
            // 
            // Alarm_window
            // 
            this.Alarm_window.Controls.Add(this.listview_alarm_log);
            this.Alarm_window.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Alarm_window.Location = new System.Drawing.Point(200, 458);
            this.Alarm_window.Name = "Alarm_window";
            this.Alarm_window.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Alarm_window.Size = new System.Drawing.Size(849, 228);
            this.Alarm_window.TabIndex = 2;
            // 
            // listview_alarm_log
            // 
            this.listview_alarm_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.AlarmType,
            this.last_user,
            this.time});
            this.listview_alarm_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listview_alarm_log.FullRowSelect = true;
            this.listview_alarm_log.GridLines = true;
            this.listview_alarm_log.Location = new System.Drawing.Point(10, 0);
            this.listview_alarm_log.Name = "listview_alarm_log";
            this.listview_alarm_log.Size = new System.Drawing.Size(829, 218);
            this.listview_alarm_log.TabIndex = 0;
            this.listview_alarm_log.UseCompatibleStateImageBehavior = false;
            this.listview_alarm_log.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 40;
            // 
            // AlarmType
            // 
            this.AlarmType.Text = "Alarm type";
            this.AlarmType.Width = 120;
            // 
            // last_user
            // 
            this.last_user.Text = "Last user";
            this.last_user.Width = 300;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 100;
            // 
            // Access_window
            // 
            this.Access_window.Controls.Add(this.listview_access_log);
            this.Access_window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Access_window.Location = new System.Drawing.Point(200, 0);
            this.Access_window.Name = "Access_window";
            this.Access_window.Padding = new System.Windows.Forms.Padding(10);
            this.Access_window.Size = new System.Drawing.Size(849, 458);
            this.Access_window.TabIndex = 3;
            // 
            // listview_access_log
            // 
            this.listview_access_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.access_id,
            this.Card_number,
            this.bruker_etternavn,
            this.Bruker_Fornavn,
            this.Door,
            this.access_time,
            this.access_granted});
            this.listview_access_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listview_access_log.FullRowSelect = true;
            this.listview_access_log.GridLines = true;
            this.listview_access_log.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listview_access_log.Location = new System.Drawing.Point(10, 10);
            this.listview_access_log.Name = "listview_access_log";
            this.listview_access_log.Size = new System.Drawing.Size(829, 438);
            this.listview_access_log.TabIndex = 0;
            this.listview_access_log.UseCompatibleStateImageBehavior = false;
            this.listview_access_log.View = System.Windows.Forms.View.Details;
            // 
            // access_id
            // 
            this.access_id.Text = "ID";
            this.access_id.Width = 40;
            // 
            // Card_number
            // 
            this.Card_number.Text = "Card number";
            this.Card_number.Width = 100;
            // 
            // bruker_etternavn
            // 
            this.bruker_etternavn.Text = "Etternavn";
            this.bruker_etternavn.Width = 130;
            // 
            // Bruker_Fornavn
            // 
            this.Bruker_Fornavn.Text = "Fornavn";
            this.Bruker_Fornavn.Width = 130;
            // 
            // Door
            // 
            this.Door.Text = "Door";
            // 
            // access_time
            // 
            this.access_time.Text = "Access Time";
            this.access_time.Width = 150;
            // 
            // access_granted
            // 
            this.access_granted.Text = "Access Granted";
            this.access_granted.Width = 100;
            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 686);
            this.Controls.Add(this.Access_window);
            this.Controls.Add(this.Alarm_window);
            this.Controls.Add(this.Access_Panel);
            this.Controls.Add(this.ButtonPanel);
            this.Name = "MainActivity";
            this.Text = "Form1";
            this.ButtonPanel.ResumeLayout(false);
            this.Alarm_window.ResumeLayout(false);
            this.Access_window.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ButtonPanel;
        private Button button6;
        private Button button5;
        private Panel panel3;
        private Button button4;
        private Button button3;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Panel Access_Panel;
        private Panel Alarm_window;
        private Panel Access_window;
        private ListView listview_access_log;
        private ColumnHeader access_id;
        private ColumnHeader Bruker_Fornavn;
        private ColumnHeader Card_number;
        private ColumnHeader access_time;
        private ColumnHeader access_granted;
        private ListView listview_alarm_log;
        private ColumnHeader id;
        private ColumnHeader AlarmType;
        private ColumnHeader last_user;
        private ColumnHeader time;
        private ColumnHeader bruker_etternavn;
        private ColumnHeader Door;
    }
}