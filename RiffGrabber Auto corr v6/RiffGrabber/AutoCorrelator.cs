using System;
using System.Diagnostics;



public class AutoCorrelator
{

    private int minOffset;
    private int maxOffset;
    private int sampleRate;

    public AutoCorrelator(int sampleRate)
    {
        this.sampleRate = sampleRate;
        int minFreq = 80;
        int maxFreq = 1050;

        this.maxOffset = sampleRate / minFreq;
        this.minOffset = sampleRate / maxFreq;
    }

    public PeakFreq DetectPitch(float[] buffer, int frames, int level)
    {

        float maxCorr = 0;
        int maxLag = 0;

        // starting with low frequencies, working to higher
        for (int lag = maxOffset; lag >= minOffset; lag--)
        {
            float corr = 0; // this is calculated as the sum of squares
            for (int i = 0; i < frames; i++)
            {
                int oldIndex = i - lag;
                float oldSample = 0;
                if (oldIndex > 0)
                {
                    oldSample = buffer[oldIndex];
                }
                float newSample = buffer[i];
                corr += (oldSample * newSample);
            }
            if (corr > maxCorr)
            {
                maxCorr = corr;
                maxLag = lag;
            }

        }

        float noiseThreshold = frames / 1000f;
        if (maxCorr < noiseThreshold || maxLag == 0) return new PeakFreq(0, 0);

        return new PeakFreq(/*maxCorr*/level, (int)Math.Round((double)(this.sampleRate / maxLag), 0));
    }
}
