namespace youtubedl_gui {
	partial class Updater {
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
			this.label_info = new System.Windows.Forms.Label();
			this.progressBar_progress = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// label_info
			// 
			this.label_info.AutoSize = true;
			this.label_info.Location = new System.Drawing.Point(8, 8);
			this.label_info.Name = "label_info";
			this.label_info.Size = new System.Drawing.Size(0, 13);
			this.label_info.TabIndex = 1;
			// 
			// progressBar_progress
			// 
			this.progressBar_progress.Location = new System.Drawing.Point(11, 41);
			this.progressBar_progress.Name = "progressBar_progress";
			this.progressBar_progress.RightToLeftLayout = true;
			this.progressBar_progress.Size = new System.Drawing.Size(249, 23);
			this.progressBar_progress.TabIndex = 2;
			// 
			// Updater
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 76);
			this.Controls.Add(this.progressBar_progress);
			this.Controls.Add(this.label_info);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Updater";
			this.Text = "Updater";
			this.Load += new System.EventHandler(this.Updater_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label_info;
		private System.Windows.Forms.ProgressBar progressBar_progress;
	}
}