using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicDeFamilie
{
	class Pacient
	{

		private String nume;
		private String prenume;
		private String adresa;
		private int varsta;
		private List<Boala> boli = new List<Boala>();

		public int getVarsta()
		{
			return varsta;
		}

		public void setVarsta(int varsta)
		{
			this.varsta = varsta;
		}

		public String getNume()
		{
			return nume;
		}

		public void setNume(String nume)
		{
			this.nume = nume;
		}

		public String getPrenume()
		{
			return prenume;
		}

		public void setPrenume(String prenume)
		{
			this.prenume = prenume;
		}

		public String getAdresa()
		{
			return adresa;
		}

		public void setAdresa(String adresa)
		{
			this.adresa = adresa;
		}

		public List<Boala> getBoli()
		{
			return boli;
		}

		public void setBoli(List<Boala> boli)
		{
			this.boli = boli;
		}

		public Pacient()
		{
			this.adresa = "";
			this.nume = "";
			this.prenume = "";
			this.varsta = 0;
			this.boli = new List<Boala>();
		}

		public Pacient(String nume, String prenume, int varsta, String adresa, List<Boala> boli)
		{
			this.nume = nume;
			this.prenume = prenume;
			this.adresa = adresa;
			this.boli = boli;
			this.varsta = varsta;
		}

		public void AddElm(Boala b)
		{
			this.boli.Add(b);
		}

	    public String toString()
		{
			return " " + boli + ",";
		}

	}
}
