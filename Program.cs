using System;
using System.Collections.Generic;
using Exercice09.Facture;
using static Exercice09.Fonctions.Functions;
using static Exercice09.Etudiant.FunctionEtudiant;
using static Exercice09.Facture.FunctionFacture;

namespace Exercice09
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Facture();

			void SaisirValeurEntieresEtAfficherStatistiques()
			{
				List<int> valeursEntieres = SaisirValeursEntieres();
				int minimum = RechercherMinimum(valeursEntieres);
				int maximum = RechercherMaximum(valeursEntieres);
				int moyenne = CalculerMoyenne(valeursEntieres);

				Console.WriteLine(string.Join(", ", valeursEntieres));
				Console.WriteLine($"Minimum: {minimum}");
				Console.WriteLine($"Maximum: {maximum}");
				Console.WriteLine($"Moyenne: {moyenne}");
			}

			void SaisirEtAfficherUnEtudiant()
			{
				Etudiant.Etudiant etudiant = SaisirEtudiant();
				AfficherEtudiant(etudiant);
			}

			void Facture()
			{
				bool sortir = false;
				bool factureValide = false;
				Facture.Facture facture = default;

				do
				{
					Console.WriteLine("1. Creer une facture");
					Console.WriteLine("2. Ajouter un produit");
					Console.WriteLine("3. Calculer le total de la facture");
					Console.WriteLine("4. Afficher la facture");
					Console.WriteLine("5. Quitter");
					Console.Write("Votre choix: ");
					string choix = Console.ReadLine();

					switch (choix)
					{
						case "1":
							facture = CreerFacture();
							factureValide = true;
							break;
						case "2":
							if (factureValide)
							{
								LigneFacture ligneFacture = SaisirLigneFacture();
								AjouterLigneFacture(facture, ligneFacture);
							}
							else
							{
								Console.WriteLine("Vous devez d'abord creer une facture");
							}

							break;
						case "3":
							if (factureValide)
							{
								double total = CalculerTotal(facture);
								Console.WriteLine($"Total: {total}");
							}
							else
							{
								Console.WriteLine("Vous devez d'abord creer une facture");
							}

							break;
						case "4":
							if (factureValide)
							{
								Console.WriteLine(FactureToString(facture));
							}
							else
							{
								Console.WriteLine("Vous devez d'abord creer une facture");
							}

							break;
						case "5":
							sortir = true;
							break;
						default:
							Console.WriteLine("Choix invalide");
							break;
					}

					Console.ReadKey();
					Console.Clear();
				} while (!sortir);
			}
		}
	}
}