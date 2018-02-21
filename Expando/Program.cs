using System;
using System.ComponentModel;
using System.Dynamic;

namespace Expando
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration
            dynamic expando = new ExpandoObject();

            //property
            expando.property = "Property";

            //function
            expando.function = (Action)(() => Console.WriteLine("Method"));
            expando.function();

            //event
            expando.eventt = null;
            expando.eventt += new EventHandler(MyEventHandler);
            expando.eventt(expando, new EventArgs());

            //Notify property changed
            ((INotifyPropertyChanged)expando).PropertyChanged += new PropertyChangedEventHandler(MyPropertyChangedEventHandler);
            expando.property = "New value";

            Console.WriteLine(expando.nonexistant);
        }

        private static void MyPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine(string.Format($"Property {e.PropertyName} chagned"));
        }

        private static void MyEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Hello, event");
        }
    }
}
