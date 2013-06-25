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
    public partial class rfg_mainwin : Form
    {
        AutoCorrelator ac;
        int _recHandle;
        private static int sampleRate = 44100;
        private RECORDPROC _myRecProc;
        List<PeakFreq> list_pkfrq = new List<PeakFreq>();
        public NoteFreqHelper nfh;
        string audio_file_name;
        double min_amp_to_capture = 0.02;
        Visuals _vis = new Visuals();
        EncoderWAV enc_wav;
        double prevfreq = 0;
        double prevtime = 0;
        double prevpower = 0;
        double curfreq = 0;
        int lvl = 0;
        double tunefreq = 1.0;
        Boolean tuneron = false;
        Tab prevnote = new Tab(0,0);
        public rfg_mainwin()
        {
            InitializeComponent();
        }

      

        private int voicePrintIdx = 0;
        void SetSilenceLabel()
        {
            if (lbx_found_tones.Items.Count > 0)
            {
                if ((String)lbx_found_tones.Items[lbx_found_tones.Items.Count - 1] != "Silent")
                {
                    lbx_found_tones.Items.Add("Silent");
                    lbx_found_tones.SelectedIndex = lbx_found_tones.Items.Count - 1;
                }
            }
        }

        List<NoteFreqHelper.KnownNote> list_known_notes;
        private void DoDetailAnalyseLoop(int _playBackHandle, long len_stream, bool isrec)
        {
          


            long bytesLeft = len_stream;
            if (!isrec) bytesLeft = len_stream;

            while (bytesLeft > 0)
            {


                // How Many Bytes to fill in the Window
                int length = (int)Bass.BASS_ChannelSeconds2Bytes(_playBackHandle, 0.1);
                //1Float = 4 Bytes
                float[] data = new float[length / 4];

                // get the data
                int ret = Bass.BASS_ChannelGetData(_playBackHandle, data, length);

                // Silence? > Print "Silence" on Label
                //Level Range: 0-32767

               // if (isrec)
              //  {
                    lvl = Utils.HighWord(Utils.GetLevel(data, 1, -1, -1));
                    prgb_lvl.Value = (int)((float)((float)lvl / 32767) * 100);
                    if (lvl < 1000) { SetSilenceLabel(); return; }
               // }


               /* //Offline (Decoding) 3D Spektrum
                if (!isrec && cbx_show_3dspec.Checked)
                {

                    long old_pos = Bass.BASS_ChannelGetPosition(_playBackHandle, BASSMode.BASS_POS_BYTES);

                    long steps = (Bass.BASS_ChannelGetLength(_playBackHandle) / pbx_spektrum_3d.Width);
                    Bitmap bmp = new Bitmap(pbx_spektrum_3d.Width, pbx_spektrum_3d.Height);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        for (int voicePrintIdx = 0; voicePrintIdx < this.pbx_spektrum_3d.Width - 1; voicePrintIdx++)
                        {
                            _vis.CreateSpectrum3DVoicePrint(_playBackHandle, g, pbx_spektrum_3d.Bounds, Color.Black, Color.White, voicePrintIdx, true, true);
                            Bass.BASS_ChannelSetPosition(_playBackHandle, Bass.BASS_ChannelBytes2Seconds(_playBackHandle, voicePrintIdx * steps));
                        }
                        pbx_spektrum_3d.Image = bmp;
                        g.Dispose();
                    }

                    Bass.BASS_ChannelSetPosition(_playBackHandle, Bass.BASS_ChannelBytes2Seconds(_playBackHandle, old_pos));
                }

                //Live Spectrum
                else if (isrec && cbx_show_3dspec.Checked)
                {
                 // Draw directly directly on the Picture Box
                  Graphics g = Graphics.FromHwnd(this.pbx_spektrum_3d.Handle);
                 g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                 //Set FFT Size
                 _vis.MaxFFT = BASSData.BASS_DATA_FFT2048;

                    _vis.CreateSpectrum3DVoicePrint(_playBackHandle, g, new Rectangle(0, 0, this.pbx_spektrum_3d.Width, this.pbx_spektrum_3d.Height), Color.Black, Color.White, voicePrintIdx, false, false);
                    g.Dispose();
                    // Next call will be at the next pos
                    voicePrintIdx++;
                    if (voicePrintIdx > this.pbx_spektrum_3d.Width - 1)
                    {
                        voicePrintIdx = 0;
                        pbx_spektrum_3d.Image = null;
                    }
                }
              */
                Application.DoEvents();
                //Get AutoCorrelator Results
                PeakFreq pfq_res = ac.DetectPitch(data, data.Length, lvl);
               /////////////////double TimeSpec = Un4seen.Bass.Bass.BASS_ChannelBytes2Seconds(_playBackHandle, Bass.BASS_ChannelGetPosition(_playBackHandle, BASSMode.BASS_POS_DECODE) * 1000);
               /////////////AddToFileSpectrum(data, TimeSpec);
                //Channel get info

                if (ret == -1) { MessageBox.Show("Error"); }
                bytesLeft = bytesLeft - ret;

                //Get AutoCorrelator Results
                //Minimum Power Level has to be reached



                if (pfq_res.Power >= 30000)
                {
                    curfreq = pfq_res.Freq;
                    AddToIncomingPeaks(pfq_res, _playBackHandle, false);
                    if (tuneron)
                        tuner();
                    if (isrec) { SetRecText("RECORDING"); }


                    pfq_res.Time_in_Ms = Un4seen.Bass.Bass.BASS_ChannelBytes2Seconds(_playBackHandle, Bass.BASS_ChannelGetPosition(_playBackHandle, BASSMode.BASS_POS_DECODE) * 1000);

                    List<NoteFreqHelper.KnownNote> Output_list = list_known_notes.FindAll(x => (Math.Abs(x.Frequency - pfq_res.Freq) <= 3));


                    //Show results if available!
                    if (Output_list.Count > 0)
                    {
                        
                        foreach (var item in Output_list)
                        {
                            //lbx_found_tones.Items.Add("Found: " + item.Note + item.Oktave + " - Input " + pfq_res.Freq + " Hz " + pfq_res.Time_in_Ms + "ms " + pfq_res.Power);
                            if (pfq_res.Freq == prevfreq || pfq_res.Freq == prevfreq + 1 || pfq_res.Freq == prevfreq - 1)
                            {
                                
                                //Show results
                 /*kalip sthalam*/if (!tuneron && pfq_res.Power >= prevpower && Math.Abs(pfq_res.Time_in_Ms - prevtime) > 300)
                                {
                                   
                                    if (Math.Abs(pfq_res.Time_in_Ms - prevtime) > 300)
                                    {
                                        lbx_found_tones.Items.Add("Found: " + item.Note + item.Oktave + " - Input " + pfq_res.Freq + " Hz " + pfq_res.Time_in_Ms + "ms " + pfq_res.Power);
                                        prevpower = pfq_res.Power;
                                        prevfreq = pfq_res.Freq;
                                        prevtime = pfq_res.Time_in_Ms;
                                        string resnote = item.Note.ToString() + item.Oktave.ToString();
                                        ToTab(resnote,pfq_res.Time_in_Ms);
                                    }
                                    else
                                    {
                                        prevpower = pfq_res.Power;
                                        prevfreq = pfq_res.Freq;
                                        //prevtime = pfq_res.Time_in_Ms;

                                    }
                                }
                                else
                                {
                                    prevpower = pfq_res.Power;
                                    //prevtime = pfq_res.Time_in_Ms;
                                }
                            }
                           else
                            {
                                if (!tuneron)
                                {
                                    lbx_found_tones.Items.Add("Found: " + item.Note + item.Oktave + " - Input " + pfq_res.Freq + " Hz " + pfq_res.Time_in_Ms + "ms " + pfq_res.Power);
                                    prevpower = pfq_res.Power;
                                    prevfreq = pfq_res.Freq;
                                    prevtime = pfq_res.Time_in_Ms;
                                    string resnote = item.Note.ToString() + item.Oktave.ToString();
                                    ToTab(resnote, pfq_res.Time_in_Ms);
                                }
                            }
                        }
                    }
                    else
                    {
                       //lbx_found_tones.Items.Add("Nothing found looking for - " + pfq_res.Freq + "(" + pfq_res.Power + ")");
                    }


                    lbx_found_tones.SelectedIndex = lbx_found_tones.Items.Count - 1;

                }
                else
                {
                    if (isrec) { SetRecText("Silent"); }
                }
            }

        }



        private void btn_start_rec_Click(object sender, EventArgs e)
        {
            tuneron = false;
            Bass.BASS_Free();
            Bass.BASS_RecordFree();
            ac = new AutoCorrelator(sampleRate);

            //Start Recording
            /////////////////////////////////chart_incoming_peaks.Series[0].Points.Clear();

            list_pkfrq.Clear();
            ((CurrencyManager)BindingContext[dgv_raw_peaks.DataSource, dgv_raw_peaks.DataMember]).Refresh();
            lbx_found_tones.Items.Clear();
            TAB.Series[0].Points.Clear();


            btn_start_rec.Enabled = false;
            btn_stop_rec.Enabled = !btn_start_rec.Enabled;

            //Record Device setzen
            Bass.BASS_RecordSetDevice(0);

        


                // Default Device
                Bass.BASS_RecordInit(-1);

                // start recording paused
                _myRecProc = new RECORDPROC(MyRecording);
                _recHandle = Bass.BASS_RecordStart(sampleRate, 1, BASSFlag.BASS_RECORD_PAUSE | BASSFlag.BASS_SAMPLE_FLOAT, _myRecProc, IntPtr.Zero);

                //save the file
                if (cbx_wav.Checked)
                {

                    // setup the encoder
                    enc_wav = new EncoderWAV(_recHandle);
                    enc_wav.InputFile = null;
                    enc_wav.OutputFile = "C:\\testrec.wav";
                    enc_wav.Start(null, IntPtr.Zero, true); // start encoder paused

                    // now really start recording and encoding
                    enc_wav.Pause(false);
                }
                Bass.BASS_ChannelPlay(_recHandle, false);

            
        }


        private bool MyRecording(int handle, IntPtr buffer, int length, IntPtr user)
        {
            //Record
            BeginInvoke((MethodInvoker)delegate()
              {
                  DoDetailAnalyseLoop(handle, length, true);
              });

            return true;
        }

        private void AddToFileSpectrum(float[] data, double TimeSpec)
        {

            //for (int i = 1; i < data.Length; i++)
            //{
                ///////////////////chart1.Series[0].Points.AddXY(TimeSpec, data[1]);
                //  chart_raw_peaks.Series[0].Points.AddXY(chart_raw_peaks.Series[0].Points.Count, pkfrq_new.Power);
                //((CurrencyManager)BindingContext[file_spec_peaks.DataSource, file_spec_peaks.DataMember]).Refresh();
           // }
            return;


        }
        private void AddToIncomingPeaks(PeakFreq pkfrq_new, int streamHandle, bool DrawOnly)
        {
            if (!DrawOnly)
            {
                list_pkfrq.Add(pkfrq_new);
               ///////////////////////////chart_incoming_peaks.Series[0].Points.AddXY(chart_incoming_peaks.Series[0].Points.Count, pkfrq_new.Freq);
             //  chart_raw_peaks.Series[0].Points.AddXY(chart_raw_peaks.Series[0].Points.Count, pkfrq_new.Power);
                ((CurrencyManager)BindingContext[dgv_raw_peaks.DataSource, dgv_raw_peaks.DataMember]).Refresh();
                return;
            }
           ///////////////////////// chart_incoming_peaks.Series[0].Points.AddXY(chart_incoming_peaks.Series[0].Points.Count, pkfrq_new.Freq);
            ((CurrencyManager)BindingContext[dgv_raw_peaks.DataSource, dgv_raw_peaks.DataMember]).Refresh();
            if (this.dgv_raw_peaks.Rows.Count > 0) { this.dgv_raw_peaks.CurrentCell = this.dgv_raw_peaks[0, this.dgv_raw_peaks.Rows.Count - 1]; }
            dgv_raw_peaks.CurrentCell = null;
        }

        public void SetRecText(string text)
        {
            if (lbl_recstat.Text != text) { lbl_recstat.Text = text; }
        }

        private void btn_stop_rec_Click(object sender, EventArgs e)
        {
            btn_stop_rec.Enabled = false;
            btn_start_rec.Enabled = !btn_stop_rec.Enabled;

            Bass.BASS_ChannelPause(_recHandle);
            if (enc_wav != null) { enc_wav.Stop(); }
            SetRecText("STOPPED");
        }

     
        private void rgr_test_fft_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Free BASS
            Bass.BASS_Free();
        }
      
        private void btn_file_open_Click(object sender, EventArgs e)
        {

            /////////////////////////////////////////////chart1.Series[0].Points.Clear();
            ///////////////////////////////////////////////chart_incoming_peaks.Series[0].Points.Clear();
            lbx_found_tones.Items.Clear();

            DialogResult dialog_result = ofd_input_file.ShowDialog();
            if (dialog_result != System.Windows.Forms.DialogResult.OK) { return; }
            list_pkfrq.Clear();

            string fname = ofd_input_file.FileName;
            lbl_fname.Text = System.IO.Path.GetFileNameWithoutExtension(fname);
            audio_file_name = lbl_fname.Text;

       

           //Create a stream channel from a file
                int fileplay_handle = Bass.BASS_StreamCreateFile(fname, 0, 0, BASSFlag.BASS_STREAM_DECODE| BASSFlag.BASS_SAMPLE_FLOAT);

                BASS_CHANNELINFO ci = new BASS_CHANNELINFO();
                Bass.BASS_ChannelGetInfo(fileplay_handle, ci);
                sampleRate = ci.freq;
                ac = new AutoCorrelator(sampleRate);
                long len = Bass.BASS_ChannelGetLength(fileplay_handle);
             
                DoDetailAnalyseLoop(fileplay_handle, len, false);
     
        }

       

      
        /*private void tb_empfindsensitivity_Scroll(object sender, EventArgs e)
        {
            min_amp_to_capture = (float)(tb_empfindsensitivity.Value * 0.01);

            UpdateEmpfDisplay();
        }

        private void UpdateEmpfDisplay()
        {
            lbl_min_empf_now.Text = tb_empfindsensitivity.Value.ToString() + "% - " + min_amp_to_capture.ToString();
        }

        private void btn_empf_reset_Click(object sender, EventArgs e)
        {

            tb_empfindsensitivity.Value = 2;
            UpdateEmpfDisplay();
        }*/

       

        private void rgr_test_fft_Shown(object sender, EventArgs e)
        {
            dgv_raw_peaks.DataSource = list_pkfrq;
            //Prevents the start of the first Line automatically "blue" (highlighted)

            //tb_empfindsensitivity.Value = ((int)((decimal)min_amp_to_capture * 100));

            BassNet.Registration("wschneiderbauer@gmx.at", "2X32283722152218");

            //Init & Fill Stuff
            Bass.BASS_Init(-1, sampleRate, BASSInit.BASS_DEVICE_DEFAULT, this.Handle);
            nfh = new NoteFreqHelper();
            nfh.FillNoteTable();
            list_known_notes = nfh.AllNotes;


            //UpdateEmpfDisplay();
        }

        private void btn_noten_tbl_Click(object sender, EventArgs e)
        {
            GuitarSynthesizer gs = new GuitarSynthesizer();
            gs.Show();
        }

        private void rfg_mainwin_Load(object sender, EventArgs e)
        {

        }

        private void chart_incoming_peaks_Click(object sender, EventArgs e)
        {

        }

        private void lbl_fname_Click(object sender, EventArgs e)
        {

        }

        private void cbx_wav_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbx_found_tones_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tp_settings_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_raw_peaks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        public void ToTab(String presnote,double time)
        {
            Tab p=new Tab(0,0);
            Tab res = new Tab(0, 0);
            Tab r = new Tab(0, 0);
            switch (presnote)
            {
                case "E2":
                    p.strng = 6; p.fret = 0;
                    res = p;
                    break;
                case "F2":
                    p.strng = 6; p.fret = 1;
                    res = p; break;
                case "Fs2":
                    p.strng = 6; p.fret = 2;
                    res = p; break;
                case "G2":
                    p.strng = 6; p.fret = 3;
                    res = p; break;
                case "Gs2":
                    p.strng = 6; p.fret = 4;
                    res = p; break;
                case "A2":
                    p.strng = 6; p.fret = 5;
                    r.strng = 5; r.fret = 0;
                    res = ham(p,r); break;
                case "As2":
                    p.strng = 6; p.fret = 6;
                    r.strng = 5; r.fret = 1;
                    res = ham(p,r); break;
                case "B2":
                    p.strng = 6; p.fret = 7;
                    r.strng = 5; r.fret = 2;
                    res = ham(p,r); break;
                case "C3":
                    p.strng = 6; p.fret = 8;
                    r.strng = 5; r.fret = 3;
                    res = ham(p,r); break;
                case "Cs3":
                    p.strng = 6; p.fret = 9;
                    r.strng = 5; r.fret = 4;
                    res = ham(p,r); break;
                case "D3":
                    p.strng = 5; p.fret = 5;
                    r.strng = 4; r.fret = 0;
                    res = ham(p,r); break;
                case "Ds3":
                    p.strng = 5; p.fret = 6;
                    r.strng = 4; r.fret = 1;
                    res = ham(p,r); break;
                case "E3":
                    p.strng = 5; p.fret = 7;
                    r.strng = 4; r.fret = 2;
                    res = ham(p,r); break;
                case "F3":

                    r.strng = 4; r.fret = 3;
                    res = r; break;
                case "Fs3":

                    r.strng = 4; r.fret = 4;
                    res = r; break;
                case "G3":
                    r.strng = 4; r.fret = 5;
                    p.strng = 3; p.fret = 0;
                    res = ham(p,r); break;
                case "Gs3":
                    r.strng = 4; r.fret = 6;
                    p.strng = 3; p.fret = 1;
                    res = ham(p,r); break;
                case "A3":
                    r.strng = 4; r.fret = 7;
                    p.strng = 3; p.fret = 2;
                    res = ham(p,r); break;
                case "As3":
                    p.strng = 3; p.fret = 3;
                    res = p; break;
                case "B3":
                    p.strng = 3; p.fret = 4;
                    r.strng = 2; r.fret = 0;
                    res = ham(p,r); break;
                case "C4":
                    r.strng = 3; r.fret = 5;
                    p.strng = 2; p.fret = 1;
                    res = ham(p,r); break;
                case "Cs4":
                    r.strng = 3; r.fret = 6;
                    p.strng = 2; p.fret = 2;
                    res = ham(p,r); break;
                case "D4":
                    r.strng = 3; r.fret = 7;
                    p.strng = 2; p.fret = 3;
                    res = ham(p,r); break;
                case "Ds4":
                    p.strng = 2; r.fret = 4;
                    res = p; break;
                case "E4":
                    r.strng = 2; r.fret = 5;
                    p.strng = 1; p.fret = 0;
                    res = ham(p,r); break;
                case "F4":
                    r.strng = 2; r.fret = 6;
                    p.strng = 1; p.fret = 1;
                    res = ham(p,r); break;
                case "Fs4":
                    r.strng = 2; r.fret = 7;
                    p.strng = 1; p.fret = 2;
                    res = ham(p,r); break;
                case "G4":
                    r.strng = 2; r.fret = 8;
                    p.strng = 1; p.fret = 3;
                    res = ham(p,r); break;
                case "Gs4":
                    r.strng = 2; r.fret = 9;
                    p.strng = 1; p.fret = 4;
                    res = ham(p,r);
                    break;
                case "A4":
                    p.strng = 1; p.fret = 5;
                    res = p;break;
                case "As4":
                    p.strng = 1; p.fret = 6;
                    res = p;break;
                case "B4":
                    p.strng = 1; p.fret = 7;
                    res = p;break;
                default:
                    break;
            }
            prevnote = res;
            addtotab(res,time);
        }
        public Tab ham(Tab p, Tab q)
        {
            Tab res = new Tab(0, 0);
            int dist1 = Math.Abs(prevnote.fret - p.fret),sdist1 = Math.Abs(prevnote.strng - p.strng);
            int dist2 = Math.Abs(prevnote.fret - q.fret),sdist2 = Math.Abs(prevnote.strng - q.strng);
            if (dist1 > dist2)
                res = q;
            if (dist1 < dist2)
                res = p;
            if (dist1 == dist2)
            {
                if (sdist1 > sdist2)
                    res = q;
                else
                    res = p;
            }
            return res;       
        }
        public void addtotab(Tab res,double time)
        {
            TAB.Series[0].SmartLabelStyle.Enabled = true;
            TAB.Series[0].Points.AddXY(time, res.strng); 
            //TAB.Series[0].Label=res.fret.ToString();
            TABLIST.Items.Add("String No:"+res.strng+" Fret No: "+res.fret);
            TABLIST.Items.Add("");
        }
        public void Clear_Click(object sender, EventArgs e)
        {

            TAB.Series[0].Points.Clear();
            list_pkfrq.Clear();
            ((CurrencyManager)BindingContext[dgv_raw_peaks.DataSource, dgv_raw_peaks.DataMember]).Refresh();
            lbx_found_tones.Items.Clear();
            TABLIST.Items.Clear();
        }

        private void TABLIST_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tunefreq = 82.40;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tunefreq = 110.0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tunefreq = 146.83;
        }

        private void ON_Click(object sender, EventArgs e)
        {
            tuneron = true;
            Bass.BASS_Free();
            Bass.BASS_RecordFree();
            ac = new AutoCorrelator(sampleRate);

            //Start Recording
            /////////////////////////////////chart_incoming_peaks.Series[0].Points.Clear();

            
            
            Bass.BASS_RecordSetDevice(0);




            // Default Device
            Bass.BASS_RecordInit(-1);

            // start recording paused
            _myRecProc = new RECORDPROC(MyRecording);
            _recHandle = Bass.BASS_RecordStart(sampleRate, 1, BASSFlag.BASS_RECORD_PAUSE | BASSFlag.BASS_SAMPLE_FLOAT, _myRecProc, IntPtr.Zero);

            //save the file
            if (cbx_wav.Checked)
            {

                // setup the encoder
                enc_wav = new EncoderWAV(_recHandle);
                enc_wav.InputFile = null;
                enc_wav.OutputFile = "C:\\testrec.wav";
                enc_wav.Start(null, IntPtr.Zero, true); // start encoder paused

                // now really start recording and encoding
                enc_wav.Pause(false);
            }
            Bass.BASS_ChannelPlay(_recHandle, false);
            tuner();
        }

        private void G3_Click(object sender, EventArgs e)
        {
            tunefreq = 196.0;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            tunefreq = 246.94;
        }

        private void E4_Click(object sender, EventArgs e)
        {
            tunefreq = 329.63;
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            tuneron = false;
            tunefreq = 0;
        }
        public void tuner()
        {
            Tbox.Items.Clear();
            Tbox.Items.Add(curfreq);
            double diff = curfreq - tunefreq;
            if (diff > 1)
            {
                if ((int)((diff / tunefreq) * 100) > 100)
                {
                    Rbar.Value = 95;
                    TLABEL.Text = "DECREASE";

                }
                else
                {
                    Rbar.Value = (int)((diff / tunefreq) * 100);
                    Lbar.Value = 0;
                    TLABEL.Text = "DECREASE";

                }
            }
            else if (diff < -1)
            {
                diff = Math.Abs(diff);
                if ((int)((diff / tunefreq) * 100) > 100)
                {
                    Lbar.Value = 95;
                    TLABEL.Text = "INCREASE";
                }
                else
                {
                    Lbar.Value = (int)((diff / tunefreq) * 100);
                    Rbar.Value = 0;
                    TLABEL.Text = "INCREASE";

                }
            }
            else
            {
                Rbar.Value = 0; Lbar.Value = 0;
               
                    TLABEL.Text = "GOOD";
            }
        }

        private void Tbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prgb_lvl_Click(object sender, EventArgs e)
        {

        }

        private void Lbar_Click(object sender, EventArgs e)
        {

        }

        private void TLABEL_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
       

      
    }

}
