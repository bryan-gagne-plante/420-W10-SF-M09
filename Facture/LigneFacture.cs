namespace Exercice09.Facture;

public struct LigneFacture
{
	private string _description;
	private int _quantite;
	private double _prixUnitaire;

	public string Description
	{
		get { return this._description; }
		set { this._description = value; }
	}

	public int Quantite
	{
		get { return this._quantite; }
		set { this._quantite = value; }
	}

	public double PrixUnitaire
	{
		get { return this._prixUnitaire; }
		set { this._prixUnitaire = value; }
	}
}