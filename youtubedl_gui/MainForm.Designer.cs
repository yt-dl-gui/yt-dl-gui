namespace youtubedl_gui {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.tabControl_action = new System.Windows.Forms.TabControl();
            this.tabPage_singlevideo = new System.Windows.Forms.TabPage();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_playlist = new System.Windows.Forms.TabPage();
            this.checkBox_Downloadall = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_to = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_from = new System.Windows.Forms.NumericUpDown();
            this.textBox_url_playlist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_savelocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_choosefolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_keepvideo = new System.Windows.Forms.CheckBox();
            this.checkBox_downcc = new System.Windows.Forms.CheckBox();
            this.checkBox_downmp3 = new System.Windows.Forms.CheckBox();
            this.button_download = new System.Windows.Forms.Button();
            this.consoleControl1 = new ConsoleControl.ConsoleControl();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_dlspeed = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.tabControl_action.SuspendLayout();
            this.tabPage_singlevideo.SuspendLayout();
            this.tabPage_playlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_from)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_action
            // 
            this.tabControl_action.Controls.Add(this.tabPage_singlevideo);
            this.tabControl_action.Controls.Add(this.tabPage_playlist);
            this.tabControl_action.Location = new System.Drawing.Point(12, 12);
            this.tabControl_action.Name = "tabControl_action";
            this.tabControl_action.SelectedIndex = 0;
            this.tabControl_action.Size = new System.Drawing.Size(740, 92);
            this.tabControl_action.TabIndex = 2;
            this.tabControl_action.SelectedIndexChanged += new System.EventHandler(this.tabControl_action_SelectedIndexChanged);
            // 
            // tabPage_singlevideo
            // 
            this.tabPage_singlevideo.Controls.Add(this.textBox_url);
            this.tabPage_singlevideo.Controls.Add(this.label1);
            this.tabPage_singlevideo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_singlevideo.Name = "tabPage_singlevideo";
            this.tabPage_singlevideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_singlevideo.Size = new System.Drawing.Size(732, 66);
            this.tabPage_singlevideo.TabIndex = 0;
            this.tabPage_singlevideo.Text = "Single video";
            this.tabPage_singlevideo.UseVisualStyleBackColor = true;
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(56, 6);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(670, 20);
            this.textBox_url.TabIndex = 2;
            this.textBox_url.Text = "https://www.youtube.com/watch?v=0NSZMNA1268";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // tabPage_playlist
            // 
            this.tabPage_playlist.Controls.Add(this.checkBox_Downloadall);
            this.tabPage_playlist.Controls.Add(this.label6);
            this.tabPage_playlist.Controls.Add(this.label5);
            this.tabPage_playlist.Controls.Add(this.numericUpDown_to);
            this.tabPage_playlist.Controls.Add(this.numericUpDown_from);
            this.tabPage_playlist.Controls.Add(this.textBox_url_playlist);
            this.tabPage_playlist.Controls.Add(this.label4);
            this.tabPage_playlist.Location = new System.Drawing.Point(4, 22);
            this.tabPage_playlist.Name = "tabPage_playlist";
            this.tabPage_playlist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_playlist.Size = new System.Drawing.Size(732, 66);
            this.tabPage_playlist.TabIndex = 1;
            this.tabPage_playlist.Text = "Playlist";
            this.tabPage_playlist.UseVisualStyleBackColor = true;
            // 
            // checkBox_Downloadall
            // 
            this.checkBox_Downloadall.AutoSize = true;
            this.checkBox_Downloadall.Location = new System.Drawing.Point(197, 32);
            this.checkBox_Downloadall.Name = "checkBox_Downloadall";
            this.checkBox_Downloadall.Size = new System.Drawing.Size(87, 17);
            this.checkBox_Downloadall.TabIndex = 15;
            this.checkBox_Downloadall.Text = "Download all";
            this.checkBox_Downloadall.UseVisualStyleBackColor = true;
            this.checkBox_Downloadall.CheckedChanged += new System.EventHandler(this.checkBox_Downloadall_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "From";
            // 
            // numericUpDown_to
            // 
            this.numericUpDown_to.Location = new System.Drawing.Point(139, 31);
            this.numericUpDown_to.Name = "numericUpDown_to";
            this.numericUpDown_to.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown_to.TabIndex = 12;
            // 
            // numericUpDown_from
            // 
            this.numericUpDown_from.Location = new System.Drawing.Point(56, 31);
            this.numericUpDown_from.Name = "numericUpDown_from";
            this.numericUpDown_from.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown_from.TabIndex = 11;
            // 
            // textBox_url_playlist
            // 
            this.textBox_url_playlist.Location = new System.Drawing.Point(56, 6);
            this.textBox_url_playlist.Name = "textBox_url_playlist";
            this.textBox_url_playlist.Size = new System.Drawing.Size(670, 20);
            this.textBox_url_playlist.TabIndex = 7;
            this.textBox_url_playlist.Text = "https://www.youtube.com/watch?v=Z8t9307-kcc&list=PLXbGO_aV_NBPSLMqvD7L0BONCLxWgOr" +
    "o-&index=1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "URL";
            // 
            // textBox_savelocation
            // 
            this.textBox_savelocation.Location = new System.Drawing.Point(62, 119);
            this.textBox_savelocation.Name = "textBox_savelocation";
            this.textBox_savelocation.Size = new System.Drawing.Size(650, 20);
            this.textBox_savelocation.TabIndex = 5;
            this.textBox_savelocation.Text = "C:\\Users\\MINH-LAPTOP\\Documents\\Visual Studio 2017\\Workspace\\c#\\youtubedl_gui\\yout" +
    "ubedl_gui\\bin\\Debug";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save to";
            // 
            // button_choosefolder
            // 
            this.button_choosefolder.Location = new System.Drawing.Point(718, 117);
            this.button_choosefolder.Name = "button_choosefolder";
            this.button_choosefolder.Size = new System.Drawing.Size(30, 23);
            this.button_choosefolder.TabIndex = 3;
            this.button_choosefolder.Text = "...";
            this.button_choosefolder.UseVisualStyleBackColor = true;
            this.button_choosefolder.Click += new System.EventHandler(this.button_choosefolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_keepvideo);
            this.groupBox1.Controls.Add(this.checkBox_downcc);
            this.groupBox1.Controls.Add(this.checkBox_downmp3);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download Options";
            // 
            // checkBox_keepvideo
            // 
            this.checkBox_keepvideo.AutoSize = true;
            this.checkBox_keepvideo.Enabled = false;
            this.checkBox_keepvideo.Location = new System.Drawing.Point(125, 19);
            this.checkBox_keepvideo.Name = "checkBox_keepvideo";
            this.checkBox_keepvideo.Size = new System.Drawing.Size(79, 17);
            this.checkBox_keepvideo.TabIndex = 2;
            this.checkBox_keepvideo.Text = "keep video";
            this.checkBox_keepvideo.UseVisualStyleBackColor = true;
            // 
            // checkBox_downcc
            // 
            this.checkBox_downcc.AutoSize = true;
            this.checkBox_downcc.Location = new System.Drawing.Point(6, 42);
            this.checkBox_downcc.Name = "checkBox_downcc";
            this.checkBox_downcc.Size = new System.Drawing.Size(146, 17);
            this.checkBox_downcc.TabIndex = 1;
            this.checkBox_downcc.Text = "Download closed-caption";
            this.checkBox_downcc.UseVisualStyleBackColor = true;
            // 
            // checkBox_downmp3
            // 
            this.checkBox_downmp3.AutoSize = true;
            this.checkBox_downmp3.Location = new System.Drawing.Point(6, 19);
            this.checkBox_downmp3.Name = "checkBox_downmp3";
            this.checkBox_downmp3.Size = new System.Drawing.Size(113, 17);
            this.checkBox_downmp3.TabIndex = 0;
            this.checkBox_downmp3.Text = "Download as MP3";
            this.checkBox_downmp3.UseVisualStyleBackColor = true;
            this.checkBox_downmp3.CheckedChanged += new System.EventHandler(this.checkBox_downmp3_CheckedChanged);
            // 
            // button_download
            // 
            this.button_download.Location = new System.Drawing.Point(589, 151);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(163, 95);
            this.button_download.TabIndex = 7;
            this.button_download.Text = "Download";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // consoleControl1
            // 
            this.consoleControl1.AutoScroll = true;
            this.consoleControl1.IsInputEnabled = false;
            this.consoleControl1.Location = new System.Drawing.Point(12, 250);
            this.consoleControl1.Name = "consoleControl1";
            this.consoleControl1.SendKeyboardCommandsToProcess = false;
            this.consoleControl1.ShowDiagnostics = false;
            this.consoleControl1.Size = new System.Drawing.Size(740, 132);
            this.consoleControl1.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 60);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(340, 23);
            this.progressBar.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_dlspeed);
            this.groupBox2.Controls.Add(this.label_size);
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Location = new System.Drawing.Point(231, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 95);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download info";
            // 
            // label_dlspeed
            // 
            this.label_dlspeed.AutoSize = true;
            this.label_dlspeed.Location = new System.Drawing.Point(6, 40);
            this.label_dlspeed.Name = "label_dlspeed";
            this.label_dlspeed.Size = new System.Drawing.Size(0, 13);
            this.label_dlspeed.TabIndex = 10;
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(6, 18);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(0, 13);
            this.label_size.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 394);
            this.Controls.Add(this.textBox_savelocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_choosefolder);
            this.Controls.Add(this.button_download);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl_action);
            this.Controls.Add(this.consoleControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "youtubedl gui";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl_action.ResumeLayout(false);
            this.tabPage_singlevideo.ResumeLayout(false);
            this.tabPage_singlevideo.PerformLayout();
            this.tabPage_playlist.ResumeLayout(false);
            this.tabPage_playlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_from)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private ConsoleControl.ConsoleControl consoleControl1;
		private System.Windows.Forms.TabControl tabControl_action;
		private System.Windows.Forms.TabPage tabPage_singlevideo;
		private System.Windows.Forms.TabPage tabPage_playlist;
		private System.Windows.Forms.TextBox textBox_url;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_savelocation;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button_choosefolder;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox_keepvideo;
		private System.Windows.Forms.CheckBox checkBox_downcc;
		private System.Windows.Forms.CheckBox checkBox_downmp3;
		private System.Windows.Forms.Button button_download;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label_dlspeed;
		private System.Windows.Forms.Label label_size;
		private System.Windows.Forms.TextBox textBox_url_playlist;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDown_to;
		private System.Windows.Forms.NumericUpDown numericUpDown_from;
		private System.Windows.Forms.CheckBox checkBox_Downloadall;
	}
}

