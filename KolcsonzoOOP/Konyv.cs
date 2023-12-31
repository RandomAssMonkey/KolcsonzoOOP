﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
	internal class Konyv : IKolcsonozheto
	{
		private string cim;
		private string szerzo;
		private string isbn;

		public string Cim { get => cim; set => cim = value; }
		public string Szerzo { get => szerzo; set => szerzo = value; }
		public string Isbn { get => isbn; set => isbn = value; }

		public Konyv(string cim, string szerzo, string isbn)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.isbn = isbn;
		}

		public int MeddigKolcsonozheto()
		{
			return Convert.ToInt32(14);
		}

		public string MegjelenitendoNev()
		{
			return $"{this.szerzo} ~ {this.cim}";
		}

		
	}
}
