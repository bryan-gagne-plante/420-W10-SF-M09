namespace Exercice09.Etudiant
{
	public struct Etudiant
	{
		private string _nom;
		private string _prenom;
		private int _numeroMatricule;
		
		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

		public string Prenom
		{
			get { return _prenom; }
			set { _prenom = value; }
		}

		public int NumeroMatricule
		{
			get { return _numeroMatricule; }
			set { _numeroMatricule = value; }
		}
	}
}