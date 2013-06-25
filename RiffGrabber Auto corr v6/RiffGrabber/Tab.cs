using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[Serializable]
public class Tab
{
    public int strng;
    public int fret;
    
    public Tab(int str, int frt)
    {
        this.strng= str;
        this.fret= frt;
    }
    public Tab()
        : this(0, 0)
    {

    }
}

