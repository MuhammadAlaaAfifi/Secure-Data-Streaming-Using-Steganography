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

namespace Secure_Data_Streaming_Using_Steganography
{
    public partial class Reciever : Form
    {
        private bool playingIsOn;
        public Reciever()
        {
            InitializeComponent();
            //this.saveFileDialog.DefaultExt = "txt";
            //this.saveFileDialog.FileName = "file.txt";
            //this.saveFileDialog.Filter = "Text files|*.txt|All files|*.*";
            //this.saveFileDialog.Title = "Save text file";
            //this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
        }
        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Stream fileStream = saveFileDialog.OpenFile();
            //path = saveFileDialog.FileName;
        }


        private void Reciever_Load(object sender, EventArgs e)
        {
            playingIsOn = false;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (channelComboBox.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Please select a specific channel");
                return;
            }
            playingIsOn = true;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            if (channelComboBox.SelectedItem.ToString().Equals("Arabic"))
            {
                player.SoundLocation = "abc.wav";
                player.Play();
            }
            else
            {
                player.SoundLocation = "abd.wav";
                player.Play();
            }

        }

        private void channelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(playingIsOn)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                if (channelComboBox.SelectedItem.ToString().Equals("Arabic"))
                {
                    player.SoundLocation = "abc.wav";
                    player.Play();
                }
                else
                {
                    player.SoundLocation = "abd.wav";
                    player.Play();
                }
            }
        }
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            //saveFileDialog.ShowDialog(this);
        }

        private void terminateBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
