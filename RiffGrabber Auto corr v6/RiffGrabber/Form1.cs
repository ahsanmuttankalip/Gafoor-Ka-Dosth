using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Un4seen.Bass;
using System.Security.Cryptography;
using Un4seen.Bass.AddOn.Mix;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.IO;
using Un4seen.Bass.AddOn.Fx;
using System.Collections.ObjectModel;
using Un4seen.Bass.Misc;
using Midi;

namespace lbass_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

                InitializeComponent();
                BassNet.Registration("wschneiderbauer@gmx.at", "2X32283722152218");
                if (Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
                {
                // create a stream channel from a file
                    int stream = Bass.BASS_StreamCreateFile("Intro.wav", 0L, 0L, BASSFlag.BASS_DEFAULT);
                    if (stream != 0)
                    {
                    // play the stream channel
                    Bass.BASS_ChannelPlay(stream, false);
                    }
                    BASSActive Status;
                    
                    
                
                    if ((Status = Bass.BASS_ChannelIsActive(stream)) == BASSActive.BASS_ACTIVE_STOPPED)


                    // wait for a key
                    {
                        
                        // free the stream
                        Bass.BASS_StreamFree(stream);
                        // free BASS
                        Bass.BASS_Free();
                        Dispose();
                    }
                
                

            }


            
        }
        public void Esc_Click(object sender, EventArgs e)
        {
            
            Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
          

            BassNet.Registration("wschneiderbauer@gmx.at", "2X32283722152218");
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, this.Handle);

           
        }
       
       
    }
}
