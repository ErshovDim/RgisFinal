using System;

public class Knjiga {
	public int Id { get; set; }
    public string naziv { get; set; }
    public string Avotr { get; set; }
    public string? pregled { get; set; }

    public string? opis { get; set; }
    public string kategorija { get; set; }



    public Knjiga()
    {
        
    }

    public Knjiga(string naziv, string avotr, string opis, string kategorija)
    {
        this.naziv = naziv;
		this.Avotr = avotr;
		this.opis = opis;
		
		this. kategorija = kategorija;
    }

    public void ChangePregled(string pregled) 
    {
        this.pregled = pregled;
    }

    public string GetKategorija()
    { 
        return this.kategorija; 
    }

    public void DeletePregled()
    {
        this.pregled = "";
    }

}
