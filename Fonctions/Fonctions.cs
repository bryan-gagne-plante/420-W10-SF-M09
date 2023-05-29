using System.Collections.Generic;

namespace Exercice09.Fonctions
{
	public class Functions
	{
		public static List<int> SaisirValeursEntieres()
		{
			List<int> listeValeurs = new List<int>();
			int valeur;
			do
			{
				System.Console.Write("Saisir une valeur entière : ");
				valeur = int.Parse(System.Console.ReadLine());
				if (valeur >= 0)
				{
					listeValeurs.Add(valeur);
				}
			} while (valeur >= 0);
			
			return listeValeurs;
		}
		
		public static int RechercherMinimum(List<int> listeValeurs)
		{
			int minimum = listeValeurs[0];
			foreach (int valeur in listeValeurs)
			{
				if (valeur < minimum)
				{
					minimum = valeur;
				}
			}
			
			return minimum;
		}
		
		public static int RechercherMaximum(List<int> listeValeurs)
		{
			int maximum = listeValeurs[0];
			foreach (int valeur in listeValeurs)
			{
				if (valeur > maximum)
				{
					maximum = valeur;
				}
			}
			
			return maximum;
		}
		
		public static int CalculerMoyenne(List<int> listeValeurs)
		{
			int somme = 0;
			foreach (int valeur in listeValeurs)
			{
				somme += valeur;
			}
			
			return somme / listeValeurs.Count;
		}
	}
}