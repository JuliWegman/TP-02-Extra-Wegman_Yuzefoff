class Boxeador
{
    public string Nombre {get; set;}
    public string Pais {get; set;}
    public int Peso{get;set;}
    public int PotenciaGolpes{get; set;}
    public int VelocidadPiernas{get; set;}
    public Boxeador(string nombre, string pais, int peso, int velocidadPiernas, int potenciaGolpes)
    {
        Nombre=nombre;
        Pais=pais;
        Peso=peso;
        VelocidadPiernas=velocidadPiernas;
        PotenciaGolpes=potenciaGolpes;
    }

    public double ObtenerSkill()
    {
        int min = 1, max=10;
        Random random = new Random();
        double x=(random.Next(min, max + 1));

        double skill= x + VelocidadPiernas* 0.6 +PotenciaGolpes*0.8;
        return skill;
    }


}