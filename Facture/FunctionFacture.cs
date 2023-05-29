using System;
using System.Collections.Generic;

namespace Exercice09.Facture;

public class FunctionFacture
{
	public static Facture CreerFacture()
	{
		Facture facture = new Facture();
		facture.LignesFacture = new List<LigneFacture>();
		facture.Tps = 0;
		facture.Tvq = 0;
		facture.SousTotal = 0;
		facture.Total = 0;
		return facture;
	}

	public static LigneFacture SaisirLigneFacture()
	{
		LigneFacture ligneFacture = new LigneFacture();

		Console.Write("Description: ");
		ligneFacture.Description = Console.ReadLine();
		Console.Write("Prix: ");
		ligneFacture.PrixUnitaire = Convert.ToDouble(Console.ReadLine());
		Console.Write("Quantité: ");
		ligneFacture.Quantite = Convert.ToInt32(Console.ReadLine());

		return ligneFacture;
	}

	public static void AjouterLigneFacture(Facture facture, LigneFacture ligneFacture)
	{
		facture.LignesFacture.Add(ligneFacture);
	}

	public static double CalculerTps(Facture facture)
	{
		facture.Tps = CalculerSousTotal(facture) * 0.05;
		return facture.Tps;
	}

	public static double CalculerTvq(Facture facture)
	{
		facture.Tvq = CalculerSousTotal(facture) * 0.09975;
		return facture.Tvq;
	}

	public static double CalculerSousTotal(Facture facture)
	{
		facture.SousTotal = 0;
		foreach (LigneFacture ligneFacture in facture.LignesFacture)
		{
			facture.SousTotal += ligneFacture.PrixUnitaire * ligneFacture.Quantite;
		}

		return facture.SousTotal;
	}

	public static double CalculerTotal(Facture facture)
	{
		double sousTotal = CalculerSousTotal(facture);
		double tps = CalculerTps(facture);
		double tvq = CalculerTvq(facture);
		
		facture.Total = sousTotal + tps + tvq;
		
		return facture.Total;
	}

	//facture to string

	public static string FactureToString(Facture facture)
	{
		double sousTotal = CalculerSousTotal(facture);
		double tps = CalculerTps(facture);
		double tvq = CalculerTvq(facture);
		double total = CalculerTotal(facture);

		string factureString = "Facture" + Environment.NewLine;
		factureString += "Sous-total: " + sousTotal + Environment.NewLine;
		factureString += "TPS: " + tps + Environment.NewLine;
		factureString += "TVQ: " + tvq + Environment.NewLine;
		factureString += "Total: " + total + Environment.NewLine;
		factureString += "Lignes de facture: " + Environment.NewLine;
		
		foreach (LigneFacture ligneFacture in facture.LignesFacture)
		{
			factureString += LigneFactureToString(ligneFacture);
		}

		return factureString;
	}

	private static string LigneFactureToString(LigneFacture ligneFacture)
	{
		string ligneFactureString = "Description: " + ligneFacture.Description + Environment.NewLine;
		ligneFactureString += "Prix: " + ligneFacture.PrixUnitaire + Environment.NewLine;
		ligneFactureString += "Quantité: " + ligneFacture.Quantite + Environment.NewLine;
		return ligneFactureString;
	}
}