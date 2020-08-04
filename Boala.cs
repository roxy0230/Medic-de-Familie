using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicDeFamilie
{
	class Boala
	{
		private List<String> medicamente = new List<String>();
		private String numeBoala;


		public String getNumeBoala()
		{
			return numeBoala;
		}

		public void setNumeBoala(String numeBoala)
		{
			this.numeBoala = numeBoala;
		}

		public List<String> getMedicamente()
		{
			return medicamente;
		}

		public void setMedicamente(List<String> medicamente)
		{
			this.medicamente = medicamente;
		}

		public Boala(List<String> medicamente, String nume)
		{
			this.medicamente = medicamente;
			this.numeBoala = nume;
		}
		public Boala()
		{
			this.medicamente = new List<String>();
			this.numeBoala = "";
		}
		public void AddElm(String m)
		{
			this.medicamente.Add(m);
		}
	public String toString()
		{
			return "" + medicamente + ",";
		}
	}
}
