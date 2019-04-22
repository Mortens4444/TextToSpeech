using System;
using System.Collections.ObjectModel;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TextToSpeech
{
	public partial class MainForm : Form
	{
		readonly SpeechSynthesizer reader;

		public MainForm()
		{
			InitializeComponent();
			reader = new SpeechSynthesizer();

			ReadOnlyCollection<InstalledVoice> voices = reader.GetInstalledVoices();
			for (int i = 0; i < voices.Count; i++)
			{
				cb_Voices.Items.Add(voices[i].VoiceInfo.Name);
			}
			cb_Voices.SelectedIndex = 0;
		}

		private void btn_Read_Click(object sender, EventArgs e)
		{
			reader.SpeakAsync(rtb_Text.Text);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			reader.Dispose();
		}

		private void cb_Voices_SelectedIndexChanged(object sender, EventArgs e)
		{
			reader.SelectVoice(cb_Voices.Text);
		}
	}
}
