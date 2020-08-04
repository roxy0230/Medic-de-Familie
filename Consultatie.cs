using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicDeFamilie
{
	class Consultatie
	{

		private Boala b;
		private Pacient p;
		private int zi;
		private int luna;
		private int an;

		public Boala getB()
		{
			return b;
		}


		public void setB(Boala b)
		{
			this.b = b;
		}
		public Pacient getP()
		{
			return p;
		}
		public void setP(Pacient p)
		{
			this.p = p;
		}
		public Consultatie(Boala b, Pacient p, int zi, int luna, int an)
		{
			this.b = b;
			this.p = p;
			this.zi = zi;
			this.luna = luna;
			this.an = an;
		}
		public Consultatie()
		{
			this.b = new Boala();
			this.p = new Pacient();
			this.zi = 1;
			this.luna = 1;
			this.an = 2000;
		}
		public int getZi()
		{
			return zi;
		}


		public void setZi(int zi)
		{
			this.zi = zi;
		}


		public int getLuna()
		{
			return luna;
		}


		public void setLuna(int luna)
		{
			this.luna = luna;
		}


		public int getAn()
		{
			return an;
		}


		public void setAn(int an)
		{
			this.an = an;
		}


	}
}
