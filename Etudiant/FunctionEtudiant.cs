using System;

namespace Exercice09.Etudiant;

public class FunctionEtudiant
{
	public static Etudiant SaisirEtudiant()
	{
		Etudiant e = new Etudiant();

		Console.Write("Saisir le nom de l'etudiant : ");
		e.Nom = Console.ReadLine();
		Console.Write("Saisir le prenom de l'etudiant : ");
		e.Prenom = Console.ReadLine();
		Console.Write("Saisir le numero de l'etudiant : ");
		e.NumeroMatricule = Convert.ToInt32(Console.ReadLine());

		return e;
	}
	
	public static void AfficherEtudiant(Etudiant e)
	{
		Console.WriteLine("Nom : " + e.Nom);
		Console.WriteLine("Prenom : " + e.Prenom);
		Console.WriteLine("Numero : " + e.NumeroMatricule);
	}
}