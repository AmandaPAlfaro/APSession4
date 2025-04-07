using Sesion04.PatronSingleton;
using Sesion04.PatronBuilder;
using Sesion04.PatronPrototype;

#region Patron Singleton
Console.WriteLine("Patrones Creacionales");

Console.WriteLine("Patron Singleton");
Console.WriteLine(new string('-', 100));

Console.WriteLine("Singleton Ingenuo");

var clase = SingletonIngenuo.GetInstance();

clase.ImprimeMensaje();

Console.WriteLine("Singleton seguro para hilos");
var claseSegura = ThreadSafeSingleton.GetInstance();
claseSegura.ImprimeMensaje();

Console.WriteLine("Singleton con carga temprana");
var singletonTemprano = EagerSingleton.Instance;
singletonTemprano.ImprimeMensaje();



Console.WriteLine("Singleton con carga diferida(Lazy)");
var singletonLazy = SingletonLazy.Instance;
singletonLazy.ImprimeMensaje();

#endregion

Thread.Sleep(1000);
//*****---------*****
#region Patron Builder

ServiceConnection conexion = new ServiceConnectionBuilder("https://api.example.com/v1/data")
    .Build();

conexion.Connect();
Console.WriteLine();

var conexionSegura = new ServiceConnectionBuilder("https://api.example.com/v1/data")
    .WithTimeout(TimeSpan.FromMinutes(2))
    .WithRetries(2)
    .WithBasicAuthentication("admin", "admin")
    .WithProxy("proxy.company.com", 8080)
    .UseSsl()
    .Build();

conexionSegura.Connect();
Console.WriteLine();
#endregion

#region Patron Prototype

AppNegocio.Ejecutar();

#endregion
