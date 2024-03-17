public class HaloGeneric
{
    public void SapaUser<U>(U user)
    {
        Console.WriteLine($"Halo {user}");
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<String>("Daffa");

    }
}