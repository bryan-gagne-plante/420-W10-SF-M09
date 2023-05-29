using System.Collections.Generic;

namespace Exercice09.Facture;

public struct Facture
{
	private List<LigneFacture> _lignesFacture;
	private double _sousTotal;
	private double _tps;
	private double _tvq;
	private double _total;

	public List<LigneFacture> LignesFacture
	{
		get { return _lignesFacture; }
		set { _lignesFacture = value; }
	}

	public double SousTotal
	{
		get { return _sousTotal; }
		set { _sousTotal = value; }
	}

	public double Tps
	{
		get { return _tps; }
		set { _tps = value; }
	}

	public double Tvq
	{
		get { return _tvq; }
		set { _tvq = value; }
	}

	public double Total
	{
		get { return _total; }
		set { _total = value; }
	}
}