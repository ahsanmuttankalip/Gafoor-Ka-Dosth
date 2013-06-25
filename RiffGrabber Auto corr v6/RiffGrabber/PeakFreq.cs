using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    [Serializable]
   public class PeakFreq {


        private float power_;
        private int freq_;
        public double time_in_ms_;
     
            public PeakFreq(float power,int freq)
            {
                this.power_ = power;
                this.freq_ = freq;
            }

       
        public PeakFreq() : this (0f,0)
        {

        }

        public float Power
        {

            get
            {
                return (power_);
            }
            set
            {
                power_ = value;
            }

   }

        public  double Time_in_Ms
        {

            get
            {
                return Math.Round(time_in_ms_,2);
            }
            set
            {
                time_in_ms_ = value;
            }

        }


        public int Freq
        {

            get
            {
                return (freq_);
            }
            set
            {
                freq_ = value;
            }
        }
    }

