namespace TextToSpeech
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
			this.p_Main = new System.Windows.Forms.Panel();
			this.gb_Main = new System.Windows.Forms.GroupBox();
			this.btn_Read = new System.Windows.Forms.Button();
			this.rtb_Text = new System.Windows.Forms.RichTextBox();
			this.cb_Voices = new System.Windows.Forms.ComboBox();
			this.p_Main.SuspendLayout();
			this.gb_Main.SuspendLayout();
			this.SuspendLayout();
			// 
			// p_Main
			// 
			this.p_Main.Controls.Add(this.gb_Main);
			this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Main.Location = new System.Drawing.Point(0, 0);
			this.p_Main.Name = "p_Main";
			this.p_Main.Size = new System.Drawing.Size(721, 247);
			this.p_Main.TabIndex = 0;
			// 
			// gb_Main
			// 
			this.gb_Main.Controls.Add(this.cb_Voices);
			this.gb_Main.Controls.Add(this.btn_Read);
			this.gb_Main.Controls.Add(this.rtb_Text);
			this.gb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_Main.Location = new System.Drawing.Point(0, 0);
			this.gb_Main.Name = "gb_Main";
			this.gb_Main.Size = new System.Drawing.Size(721, 247);
			this.gb_Main.TabIndex = 0;
			this.gb_Main.TabStop = false;
			// 
			// btn_Read
			// 
			this.btn_Read.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Read.Location = new System.Drawing.Point(634, 212);
			this.btn_Read.Name = "btn_Read";
			this.btn_Read.Size = new System.Drawing.Size(75, 23);
			this.btn_Read.TabIndex = 1;
			this.btn_Read.Text = "Read";
			this.btn_Read.UseVisualStyleBackColor = true;
			this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
			// 
			// rtb_Text
			// 
			this.rtb_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.rtb_Text.Location = new System.Drawing.Point(3, 16);
			this.rtb_Text.Name = "rtb_Text";
			this.rtb_Text.Size = new System.Drawing.Size(715, 189);
			this.rtb_Text.TabIndex = 0;
			this.rtb_Text.Text = "I love you!";
			// 
			// cb_Voices
			// 
			this.cb_Voices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Voices.FormattingEnabled = true;
			this.cb_Voices.Location = new System.Drawing.Point(3, 214);
			this.cb_Voices.Name = "cb_Voices";
			this.cb_Voices.Size = new System.Drawing.Size(133, 21);
			this.cb_Voices.TabIndex = 2;
			this.cb_Voices.SelectedIndexChanged += new System.EventHandler(this.cb_Voices_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btn_Read;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 247);
			this.Controls.Add(this.p_Main);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TextToSpeech";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.p_Main.ResumeLayout(false);
			this.gb_Main.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel p_Main;
		private System.Windows.Forms.GroupBox gb_Main;
		private System.Windows.Forms.Button btn_Read;
		private System.Windows.Forms.RichTextBox rtb_Text;
		private System.Windows.Forms.ComboBox cb_Voices;
	}
}

