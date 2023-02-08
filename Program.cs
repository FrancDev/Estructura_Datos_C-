/*Crea una estructura de datos para un cliente con estos campos:
Nombre completo
Teléfono
Dirección
Email
Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...) */


Cliente Datos = new Cliente("Franc Lopez", 31125885, "calle 12 7b-73", "franc@gmail.com", "Si");
Console.WriteLine("\n----Datos Del Cliente----\n");
Console.WriteLine(" Nombre Completo: {0} \n Telefono: {1} \n Direccion: {2} \n Email: {3} \n Nuevo Cliente?: {4}"
                    , Datos.Nom, Datos.Tel, Datos.Dir, Datos.Email, Datos.Est);

public struct Cliente
{
    public Cliente(String nom, float tel, String dir, String email, String est)
    {
        Nom = nom;
        Tel = tel;
        Dir = dir;
        Email = email;
        Est = est;

    }

    public String Nom { get; }
    public float Tel { get; }
    public String Dir { get; }
    public String Email { get; }
    public String Est { get; }

    public override string ToString() => $"({Tel})";
}