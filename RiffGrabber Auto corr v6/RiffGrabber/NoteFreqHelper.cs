using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public    class NoteFreqHelper
    {
        //Formular: 440 x 2^(x/12)
        //12 Semitones in 1 Octave

        public void FillNoteTable()
        {
            AllNotes = new List<KnownNote>();
            //Set Pitch Standard A-440Hz & Max Octave (Accoustic Guitar)
            int pitch_standard = 440;
            int max_octave = 6;
          
            // 440 * 2^(X/12)
            int count_norm = 0;
            
            int octave_ctr = 8;
            for (int octave = 50; octave >= -57; octave--)
            {
                    double freq = pitch_standard * Math.Pow(2, ((double)octave / 12));
                    KnownNote tmp = new KnownNote();
                    tmp.Frequency = freq;
                    tmp.Note = (KnownNote.Noten)(11-count_norm);
                    tmp.Oktave = octave_ctr;

                    if (tmp.Oktave <= max_octave) { AllNotes.Add(tmp); }
                    count_norm++;

                    if (count_norm > 11) { count_norm = 0; octave_ctr--; }
                  
            }
        }

        public class KnownNote
        {
            public double Frequency { get; set; }
            public enum Noten  {C=0,Cs=1,D=2,Ds=3,E=4,F=5,Fs=6,G=7,Gs=8,A=9,As=10,B=11};
            public Noten Note { get; set; }
            public int Oktave { get; set; }
        }
        public List<KnownNote> AllNotes { get; set; }
    }
    

