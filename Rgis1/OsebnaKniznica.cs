using System;

public class OsebnaKniznica {
	public List<Knjiga> kniznica;


    public OsebnaKniznica()
    {
        this.kniznica = new List<Knjiga> ();
    }


    public int GetCount()
	{
		return this.kniznica.Count; 
	}

	public void DeleteBook(Knjiga book)
	{ 
		this.kniznica.Remove(book);
	}

	public void AddBook(Knjiga book)
	{ 
		this.kniznica.Add(book);
	}


}
