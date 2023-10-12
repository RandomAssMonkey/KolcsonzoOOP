using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
	internal class Dvd : IKolcsonozheto
	{
		private string cim;
		private int hossz; // percben.

		public string Cim { get => cim; set => cim = value; }
		public int Hossz { get => hossz; set => hossz = value; }

		public Dvd(string cim, int hossz)
		{
			this.cim = cim;
			this.hossz = hossz;
		}

		public int MeddigKolcsonozheto()
		{
			return Convert.ToInt32(7);
		}

		public string MegjelenitendoNev()
		{
			return $"{this.cim} ({this.hossz}) perc.";
		}
	}
}
