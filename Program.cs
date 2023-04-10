internal class Program
{
    private static void Main(string[] args)
    {
        int eleccion=IngresarInt("1- Cargar Datos Boxeador 1 \n2- Cargar Datos Boxeador 2 \n3- Pelear! \n4-Salir");
        Boxeador uno=null, dos=null;
        while(eleccion!=4){
            switch(eleccion){
                case 1:
                uno=IngresarBoxeador();
                break;
                case 2:
                dos=IngresarBoxeador();
                break;
                case 3:
                Pelear(uno,dos);
                break;
            }
            eleccion=IngresarInt("1- Cargar Datos Boxeador 1 \n2- Cargar Datos Boxeador 2 \n3- Pelear! \n4-Salir");
        }
    }
    static Boxeador IngresarBoxeador(){
        string nombre=IngresarString("ingresar nombre del boxeador");
        string pais=IngresarString("Ingresar país de origen del boxeador");
        int peso= IngresarInt("Ingresar peso del boxeador"),velocidadPiernas,potenciaGolpes;

        do{velocidadPiernas= IngresarInt("Ingresar la velocidad de las piernas"); }while(velocidadPiernas<1 || velocidadPiernas>100);
        do{potenciaGolpes= IngresarInt("Ingresar la Potencia de los golpes");}while(potenciaGolpes<1 || potenciaGolpes>100);
        Boxeador x=new Boxeador(nombre,pais,peso,velocidadPiernas,potenciaGolpes);
        return x;
    }
    static void Pelear(Boxeador uno, Boxeador dos){
        double skill1=uno.ObtenerSkill(), skill2=dos.ObtenerSkill();
        double mayor,menor;
        string ganador;
        if(skill1>skill2){
            ganador=uno.Nombre; 
            mayor=skill1; 
            menor=skill2;
            }else{ 
            ganador=dos.Nombre; 
            mayor=skill2; 
            menor=skill2;
            } 
        double resultado= mayor - menor;
        switch(resultado){
            case (>=30):
            Console.WriteLine("Ganó "+ganador+" por KO");
            break;
            case(>=10):
            Console.WriteLine("Ganó "+ganador+" por puntos en fallo unánime");
            break;
            default:
            Console.WriteLine("Ganó "+ganador+" por puntos en fallo dividido");
            break;
        }
    }
    static int IngresarInt(string mensaje){
        Console.WriteLine(mensaje);
        int.TryParse(Console.ReadLine(),out int num);
        return num;
    }
    static string IngresarString(string mensaje){
        Console.WriteLine(mensaje);
        string frase=Console.ReadLine();
        return frase;
    }
}