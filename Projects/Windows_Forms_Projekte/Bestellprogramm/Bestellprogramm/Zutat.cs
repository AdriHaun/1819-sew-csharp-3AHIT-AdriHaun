class Zutat
{
    private bool vegetarisch;
    private bool vegan;
    string beschreibung;

    public bool Vegetarisch
    {
        get { return vegetarisch; }
        set { vegetarisch = value; }
    }

    public bool Vegan
    {
        get { return vegan; }
        set { vegan = value; }
    }

    public string Beschreibung
    {
        get { return beschreibung; }
        set { beschreibung = value; }
    }
}