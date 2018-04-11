using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtubedl_gui
{
    public partial class MainForm : Form
    {

        const string executablePath = "youtube-dl.exe";
        const string EXTRACT_AUDIO = "--extract-audio";
        const string AUDIO_FORMAT = "--audio-format";
        const string OUTPUT = "--output";
        const string OUTPUT_TEMPLATE = "%(title)s.%(ext)s";
        const string YES_PLAYLIST = "--yes-playlist";
        const string NO_PLAYLIST = "--no-playlist";
        const string PLAYLIST_START = "--playlist-start";
        const string PLAYLIST_END = "--playlist-end";
        const string WRITE_SUB = "--write-sub";
        const string WRITE_AUTO_SUB = "--write-auto-sub";
        const string SUB_FORMAT = "--sub-format";
        const string SUB_LANG = "--sub-lang";
        const string SKIP_VIDEO = "--skip-download";
        const string KEEP_VIDEO = "--keep-video";
        const string SIMULATE = "--simulate";
        const string LIST_ALL_FORMATS = "--list-formats";

        delegate void act();

        private act mainthreadact;

        bool isSingleVideo = true;
        private bool isMP3;

        public MainForm()
        {
            InitializeComponent();
            consoleControl1.InternalRichTextBox.TextChanged += InternalRichTextBox_TextChanged;
            consoleControl1.ProcessInterface.OnProcessExit += ProcessInterface_OnProcessExit;
            mainthreadact = mainthreadthingy;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_choosefolder_Click(object sender, EventArgs e)
        {

        }

        private void button_download_Click(object sender, EventArgs e)
        {
            Uri uri = isSingleVideo ? new Uri(textBox_url.Text) : new Uri(textBox_url_playlist.Text);

            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            var videoID = query.Get("v");
            var listID = query.Get("list");

            List<string> args = new List<string>();

            //args.Add(SIMULATE);
            //args.Add(LIST_ALL_FORMATS);

            if (isSingleVideo)
            {
                args.Add(NO_PLAYLIST);
            }
            else
            {
                args.Add(YES_PLAYLIST);
                args.Add(numericUpDown_from.Value == 0 ? "" : $"{PLAYLIST_START} {numericUpDown_from.Value}");
                args.Add(numericUpDown_to.Value == 0 ? "" : $" {PLAYLIST_END} {numericUpDown_to.Value}");
            }

            if (isMP3)
            {
                args.Add(EXTRACT_AUDIO);
                args.Add(AUDIO_FORMAT);
                args.Add("mp3");
            }

            args.Add(OUTPUT);
            args.Add($"\"{Path.Combine(textBox_savelocation.Text, OUTPUT_TEMPLATE)}\"");

            if (isSingleVideo)
            {
                args.Add($"\"{videoID}\"");
            }
            else
            {
                args.Add($"\"{listID}\"");
            }

            var arg = string.Join(" ", args);
            consoleControl1.StartProcess(executablePath, arg);
        }

        private void InternalRichTextBox_TextChanged(object sender, EventArgs e)
        {
            var richTextBox = (RichTextBox)sender;
            //autoscroll
            richTextBox.SelectionStart = richTextBox.Text.Length;
            richTextBox.ScrollToCaret();

            var lastline = richTextBox.Lines[richTextBox.Lines.GetLength(0) - 1];
            if (string.IsNullOrWhiteSpace(lastline))
            {
                return;
            }
            float percent = -1f;
            float.TryParse(lastline.Between("[download]", "% of"), out percent);
            var filesize = lastline.Between("of", "at").Trim();
            var downspeed = lastline.Between("at", "ETA");

            label_size.Text = filesize;
            label_dlspeed.Text = downspeed;
            progressBar.Value = (int)percent;
        }

        private void ProcessInterface_OnProcessExit(object sender, ConsoleControlAPI.ProcessEventArgs args)
        {
            Invoke(mainthreadact);
        }

        private void mainthreadthingy()
        {
            label_dlspeed.Text = "Done";
            label_dlspeed.BackColor = Color.Green;
        }

        private void checkBox_Downloadall_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_from.Enabled = !checkBox_Downloadall.Checked;
            numericUpDown_to.Enabled = !checkBox_Downloadall.Checked;
        }

        private void tabControl_action_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl_action.SelectedTab.Name)
            {
                case "tabPage_singlevideo":
                    isSingleVideo = true;
                    break;
                case "tabPage_playlist":
                    isSingleVideo = false;
                    break;
            }
            //MessageBox.Show(isSingleVideo.ToString());
        }

        private void checkBox_downmp3_CheckedChanged(object sender, EventArgs e)
        {
            isMP3 = checkBox_downmp3.Checked;
        }
    }
}
