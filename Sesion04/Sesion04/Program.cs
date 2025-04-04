using Sesion04.PatronSingleton;

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



Console.ReadLine();