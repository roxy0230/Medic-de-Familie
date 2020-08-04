using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MedicDeFamilie
{
	class Repository
	{

		public List<Consultatie> repo = new List<Consultatie>();
		public List<Pacient> pacienti = new List<Pacient>();

		public List<Pacient> getPacienti()
		{
			return pacienti;
		}
		public void setPacienti(List<Pacient> pacienti)
		{
			this.pacienti = pacienti;
		}
		public List<Consultatie> getRepo()
		{
			return repo;
		}
		public void setRepo(List<Consultatie> repo)
		{
			this.repo = repo;
		}

		public Repository(List<Consultatie> repo, List<Pacient> pacienti)
		{
			//	super();
			this.repo = repo;
			this.pacienti = pacienti;
		}
		public Repository()
		{
			this.repo = new List<Consultatie>();
			this.pacienti = new List<Pacient>();
		}
		//Metoda pt adaugarea unei consultatii
		public void AddElm(Consultatie c)
		{
			this.repo.Add(c);
		}
		//Metoda pt adaugarea unui pacient
		public void AddPacient(Pacient p)
		{
			this.pacienti.Add(p);
		}
		//Metoda pt stergerea unei consultatii
		public void DeleteElm(int poz)
		{
			this.repo.RemoveAt(poz);
		}
		//Metoda pt Verificarea daca un pacient a mai fost stocat in lista de pacienti sau daca e unul nou.Daca este deja in lista i se va adauga o noua boala in vectorul de boli
		public void Comparare(Pacient p)
		{
			int gasit = 0, i;
			for (i = 0; i < pacienti.Count && gasit == 0; i++)
				if (p.getNume().Equals(pacienti.ElementAt(i).getNume()) && p.getPrenume().Equals(pacienti.ElementAt(i).getPrenume()))
					gasit = 1;
			if (gasit == 0)
				AddPacient(p);
			else
				pacienti.ElementAt(i - 1).getBoli().Add(p.getBoli().ElementAt(0));
		}


		//Metoda pentru modificarea unei consultatii de pe o anumita pozitie
		public void UpdateElm(int poz, Consultatie c)
		{
			this.repo.ElementAt(poz).setB(c.getB());
			this.repo.ElementAt(poz).setP(c.getP());
			this.repo.ElementAt(poz).setZi(c.getZi());
			this.repo.ElementAt(poz).setLuna(c.getLuna());
			this.repo.ElementAt(poz).setAn(c.getAn());
		}

		//Metoda ppt sortarea consultatiilor in functie de numele pancientilor
		public void SortP()
		{
			Consultatie aux = new Consultatie();
			for (int i = 0; i < repo.Count - 1; i++)
				for (int j = i + 1; j < repo.Count; j++)
					if (String.Compare(repo.ElementAt(i).getP().getNume(),repo.ElementAt(j).getP().getNume(), StringComparison.InvariantCulture) > 0)
					{
						aux.setB(this.repo.ElementAt(j).getB());
						aux.setP(this.repo.ElementAt(j).getP());
						aux.setZi(this.repo.ElementAt(j).getZi());
						aux.setLuna(this.repo.ElementAt(j).getLuna());
						aux.setAn(this.repo.ElementAt(j).getAn());
						UpdateElm(j, this.repo.ElementAt(i));
						UpdateElm(i, aux);
					}
			//Aff();

		}
		//Metoda pentru citirea tuturor consultatiilor dintr-un  fisier Medic.txt
		public String ReadFromFile()
		{
			String msg="Fisier gol";
			//try
			//{

				StreamReader br = new StreamReader("D:\\Visual Studio\\repos\\MedicDeFamilie\\read.txt");

				String line = null;
				while ((line = br.ReadLine()) != null)
				{
					char[] separator = { ',' };
					String[] components = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

					String stringzi = components[0].Trim();
					String stringluna = components[1].Trim();
					String stringan = components[2].Trim();
					String nume = components[3].Trim();
					String prenume = components[4].Trim();
					String stringvarsta = components[5].Trim();
					String adresa = components[6].Trim();
					String numeBoala = components[7].Trim();
					String tratament = components[8].Trim();
					int zi = Int32.Parse(stringzi);
					int luna = Int32.Parse(stringluna);
					int an = Int32.Parse(stringan);
					int varsta = Int32.Parse(stringvarsta);
					Boala b = new Boala();
					b.AddElm(tratament);
					b.setNumeBoala(numeBoala);
					Pacient p = new Pacient();
					p.setVarsta(varsta);
					p.setAdresa(adresa);
					p.setNume(nume);
					p.setPrenume(prenume);
					p.AddElm(b);
					Consultatie c = new Consultatie(b, p, zi, luna, an);
					AddElm(c);
					Comparare(p);


				}
				if(repo.Count()!=0)
				msg = "Citire reusita";
						
				br.Close();

			//}
			//catch (IOException e)
		//	{
		//		msg = "Eroare";
			//}
			return msg;

			//for (int i = 0; i < repo.Count(); i++)
				//Console.WriteLine("|%-28.8s",repo.ElementAt(i).getZi(), repo.ElementAt(i).getLuna(), repo.ElementAt(i).getAn(), repo.ElementAt(i).getP().getNume(), repo.ElementAt(i).getP().getPrenume());
		}

	}
}
