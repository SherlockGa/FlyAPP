using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyApp
{
    public class Mechanism
    {
        public double lab;
        public double lbc;
        public double lcd;
        public double lde;
        public double lhm;
        public double lan;
        public double lef;
        public double ldg;
        public double lek;
        public double lag;
        public double lnk;
        public double lah;
        public double lnm;
        public double beta1 = Math.PI / 2;
        public double beta2 = Math.PI / 2;
        public double beta3 = 0;

        public Mechanism(double lab = 130, double lbc = 50, double lcd = 27.5, double lde = 135, double lhm = 135, double lan = 135, double lef = 172.5, double ldg = 147.022, double lek = 147.022, double lag = 60, double lnk = 60, double lah = 45, double lnm = 45)
        {
            this.lab = lab;
            this.lbc = lbc;
            this.lcd = lcd;
            this.lde = lde;
            this.lhm = lhm;
            this.lan = lan;
            this.lef = lef;
            this.ldg = ldg;
            this.lek = lek;
            this.lag = lag;
            this.lnk = lnk;
            this.lah = lah;
            this.lnm = lnm;
        }
    }
}
