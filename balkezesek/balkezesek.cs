using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    internal class balkezesek
    {
    public string Nev { get; private set; }
    public string Elso { get; private set; }
    public string Utolso { get; private set; }
    public int Suly { get; private set; }
    public int Magassag { get; private set; }
        public balkezesek(string sor)
        {
            string[] adat = sor.Split(';');
            Nev = adat[0];
            Elso = adat[1];
            Utolso = adat[2];
            Suly = Convert.ToInt32(adat[3]);
            Magassag = Convert.ToInt32(adat[4]);
        }
}
}
