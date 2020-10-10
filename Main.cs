using System;
using System.Diagnostics;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textToSpeech
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        void FileIsSaved()
        {
            string path = Process.GetCurrentProcess().MainModule.FileName;
            MessageBox.Show($@"Запись была сохранена в: {path.Remove(path.Length - (1 + 16), 17)}\sound.wav");
        }
        string GetOutputPath(bool check)
        {
            if (check)
                return "sound.wav";
            return "none";
        }
        private void Speak_Click(object sender, EventArgs e)
        {
            TextToSpeech(textBox.Text, GetOutputPath(checkBox.Checked));
        }
        async void TextToSpeech(string text, string path)
        {
            using (SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer())
            {
                if (path == "none")
                    speechSynthesizer.SetOutputToDefaultAudioDevice();
                else
                {
                    speechSynthesizer.SetOutputToWaveFile(path);
                    FileIsSaved();
                }

                await Task.Run(() =>
                {
                    speechSynthesizer.Speak(text);
                });
            }
        }
    }
}
