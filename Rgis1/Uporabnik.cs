using System;

public class Uporabnik {
	private int id;
	private string ime;
	private string priimek;

	private OsebnaKniznica osebnaKniznica;

    public Uporabnik(int id, string ime, string priimek)
    {
        this.id = id;
		this.ime = ime;
		this.priimek = priimek;
		this.osebnaKniznica = new OsebnaKniznica();
    }



    public int GetID()
	{
		return this.id; 
	}

	public string GetIme() 
	{
		return this.ime;
	}

	public void ChangeIme(string ime)
	{
		this.ime = ime; 
	}
}
