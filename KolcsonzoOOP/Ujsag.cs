using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
	internal class Ujsag : IKolcsonozheto
	{
		private string cim;
		private int kiadasEv;
		private int kiadasHet;

		public string Cim { get => cim; set => cim = value; }
		public int KiadasEv { get => kiadasEv; set => kiadasEv = value; }
		public int KiadasHet { get => kiadasHet; set => kiadasHet = value; }

		public Ujsag(string cim, int kiadasEv, int kiadasHet)
		{
			this.cim = cim;
			this.kiadasEv = kiadasEv;
			this.kiadasHet = kiadasHet;
		}

		public int MeddigKolcsonozheto()
		{
			return Convert.ToInt32(0);
		}

		public string MegjelenitendoNev()
		{
			return $"{this.cim} ~ {this.kiadasEv}/{this.kiadasHet}";
		}
	}
}
