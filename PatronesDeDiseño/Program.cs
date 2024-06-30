using AbstractFactory;
using FactoryMethod;
using Singleton;
using Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Specialized;
using Mediator;
using Memento;
using Adapter;
using Decorator;
using Interpreter;
using Microsoft.VisualBasic.CompilerServices;
using Iterator;

namespace PatronesDeDiseño
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Selecciona Patron: \n 1.Singleton \n 2.AbstractFactory \n 3.FactoryMethod \n 4.Observer \n 5.Mediator \n 6.Memento \n 7.Adapter \n 8.Decorator \n 9.Interpreter \n 10.Iterator \n 0. Exit \n");
                string response = Console.ReadLine();

                if (string.IsNullOrEmpty(response))
                {
                    Console.WriteLine("haz ingresado un valor erroneo");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                if (int.TryParse(response, out int _) && int.Parse(response) == 0) break;

                if (int.Parse(response) == 1)
                {
                    UserSingleton instancia1 = UserSingleton.GetInstance();

                    UserSingleton instancia2 = UserSingleton.GetInstance();

                    Console.WriteLine($"Instancia 1: {instancia1.Id}");
                    Console.WriteLine($"Instancia 2: {instancia1.Id}");

                    if (instancia1 == instancia2)
                    {
                        Console.WriteLine("Misma instancia de la clase");
                    }
                }

                if (int.Parse(response) == 2)
                {
                    VictorianFurnitureFactory victorianFactory = new VictorianFurnitureFactory();
                    ModerFurnitureFactory moderFactory = new ModerFurnitureFactory();

                    Console.WriteLine($"Moder factory: {moderFactory.CreateChair().Model}");
                    Console.WriteLine($"Victorian factory: {victorianFactory.CreateChair().Model}");
                }

                if (int.Parse(response) == 3)
                {
                    Logistics seaLogistics = new SeaLogistics();
                    Logistics roadLogistics = new RoadLogistics();

                    seaLogistics.PlanDelivery();
                    roadLogistics.PlanDelivery();

                    seaLogistics.CreateTransport().Deliver();
                    roadLogistics.CreateTransport().Deliver();
                }

                if (int.Parse(response) == 4)
                {
                    IPublisher publisher = new ConcretePublisher();

                    IObserver observer1 = new ConcreteObserver(1);
                    IObserver observer2 = new ConcreteObserver(2);
                    IObserver observer3 = new ConcreteObserver(3);

                    publisher.AddObserver(observer1);
                    publisher.AddObserver(observer2);
                    publisher.AddObserver(observer3);

                    publisher.NotifyAll();

                    Console.WriteLine("\nRemuevo observador 1");
                    publisher.RemoveObserver(observer1);

                    publisher.NotifyAll();
                }

                if (int.Parse(response) == 5)
                {

                    Usuario usuario1 = new Usuario 
                    {
                        Nombre = "Tomas"
                    }; 


                    Usuario usuario2 = new Usuario 
                    {
                        Nombre = "Facundo"
                    };

                    IChat chat = new ChatRoom(usuario1, usuario2);

                    usuario1.SetMediator(chat);
                    usuario2.SetMediator(chat);

                    usuario1.Enviar("Hola facundo", usuario2);

                    usuario2.Enviar("Hola Tomas", usuario1);

                }

                if (int.Parse(response) == 6)
                {
                    Persona persona = new Persona
                    {
                        Nombre = "Tomas"
                    };


                    CareTaker taker = new CareTaker();

                    taker.AddMemento(persona.SaveToMemento());

                    persona.Nombre = "Tomito";

                    persona.Restore(taker.GetMemento(0));
                }

                if (int.Parse(response) == 7)
                {
                    IMotor motorDiesel = new MotorDiesel();

                    IMotor motorElectrico = new MotorElectricoAdapter();

                    motorDiesel.CargarCombustible();
                    motorElectrico.CargarCombustible();
                }

                if (int.Parse(response) == 8)
                {
                    BebidaComponent bebida = new Cafe();

                    bebida = new Azucar(bebida);
                    bebida = new Azucar(bebida);
                    bebida = new Leche(bebida);

                    Console.WriteLine(bebida.Descripcion);
                    Console.WriteLine(bebida.Costo);

                }

                if (int.Parse(response) == 9)
                {
                    string[] tree;
                    var context = new Context();
                    var expressions = new List<IExpression>();
                    Console.WriteLine("ingrese la operacion en letras: ");
                    string val = Console.ReadLine();
                    tree = val.Split(' ');
                    IExpression exp;
                    foreach (var t in tree)
                    {
                        if (context.getInteger(t) >= 0)
                        {
                            exp = new NumericExpression(t);
                        }
                        else
                        {
                            exp = new OperationExpression(t);
                        }

                        exp.Interpret(context);
                    }

                    Console.WriteLine("El resultado para '" + val + "' es " + context.getResult());
                    Console.ReadKey();
                }

                if (int.Parse(response) == 10)
                {
                    ConcreteCollection collection = new ConcreteCollection();

                    collection.Agregar(new Item { Descripcion = "ALgo" });
                    collection.Agregar(new Item { Descripcion = "Otra cosa" });
                    collection.Agregar(new Item { Descripcion = "Luken" });
                    collection.Agregar(new Item { Descripcion = "Tomito" });

                    IteratorEjemplo ConcreteIterator = collection.CreateIterator();


                    ConcreteIterator.First();

                    ConcreteIterator.Siguiente();

                    Console.WriteLine(ConcreteIterator.CurrentItem().Descripcion);
                    Console.WriteLine("Se termino => " + ConcreteIterator.IsDone());




                }



                Console.WriteLine("\nToque cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
