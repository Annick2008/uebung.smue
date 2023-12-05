using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung.smue;

public class Auto
{
	private string _marke;

	public string Marke
	{
		get { return _marke; }
		set { _marke = value; }
	}

	private string _modell;

	public string Modell
	{
		get { return _modell; }
		set { _modell = value; }
	}

	public double Hoehe { get; set; }

	public double Laenge { get; set; }

	public bool AutoOffenZu {  get; private set; }

	public void AutoOffen()
	{
		AutoOffenZu = true;
	}

	public void AutoZu()
	{
		AutoOffenZu = false;
	}
}
