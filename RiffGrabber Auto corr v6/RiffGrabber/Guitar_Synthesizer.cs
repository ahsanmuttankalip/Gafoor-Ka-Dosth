using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Un4seen.Bass;
using System.Runtime.InteropServices;
using Midi;
using System.Threading;
namespace lbass_test
{
    public partial class GuitarSynthesizer : Form
    {
        NoteFreqHelper nfh;
        public GuitarSynthesizer()
        {
           
            InitializeComponent();
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, this.Handle);
        }

        private void NotenTabelle_Load(object sender, EventArgs e)
        {
          nfh = new NoteFreqHelper();
          nfh.FillNoteTable();
          dgv_noten_tab.DataSource = nfh.AllNotes;
          //Midi - Init
          outputDevice = OutputDevice.InstalledDevices[0];
          outputDevice.Open();
          outputDevice.SendProgramChange(Channel.Channel1, Instrument.AcousticGuitarNylon);
        }


        OutputDevice outputDevice;
        private void dgv_noten_tab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            NoteFreqHelper.KnownNote KnownNoteClicked = ((NoteFreqHelper.KnownNote)dgv_noten_tab.SelectedRows[0].DataBoundItem);
            string note_rewritten = KnownNoteClicked.Note.ToString().Replace("is", "#") ;
            Note nt = new Note(note_rewritten);
          
            outputDevice.SendNoteOn(Channel.Channel1, nt.PitchInOctave(KnownNoteClicked.Oktave), 120);

            //Add Space before New Note if required
            string prefix = "";
            if (tbx_notes.Text.Length > 0) {prefix = " "; }
            tbx_notes.Text =  tbx_notes.Text+prefix+ KnownNoteClicked.Note +"-"+ KnownNoteClicked.Oktave ;

            //Add Space if required
          
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            outputDevice.SilenceAllNotes();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {

            string[] splitted_notes = tbx_notes.Text.Split(' ');

            Clock clock = new Clock(160);
            int i = 0;
            foreach (string note_string in splitted_notes)
            {
  
            
            string    note_string_fixed = note_string.Replace("is", "#");
            int octave = Convert.ToInt32(note_string_fixed.Split('-')[1]);
            string note = note_string_fixed.Split('-')[0];
            Note nt = new Note(note);
            clock.Schedule(new NoteOnMessage(outputDevice, Channel.Channel1, nt.PitchInOctave(octave), 120, i));
            i++;
            clock.Schedule(new NoteOffMessage(outputDevice, Channel.Channel1, nt.PitchInOctave(octave), 120, i));
            i++;
    
            }

            clock.Start();
           // System.Threading.Thread.Sleep(5000);
          //  clock.Stop();


        }

        private void tbx_notes_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
