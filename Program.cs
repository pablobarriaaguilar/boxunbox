using System.Reflection.PortableExecutable;

object BoxedData = "hola";

if(BoxedData is int){
    Console.WriteLine("es int");
}
if(BoxedData is string){
    Console.WriteLine("es string");
}

List<object> lista = new List<object>();

lista.Add(7);
lista.Add(28);
lista.Add(-1);
lista.Add(true);
lista.Add("chair");

int suma = 0;
foreach( var elemento in lista){
    Console.WriteLine(elemento);

    if(elemento is int){
        suma = suma + (int)elemento;
    }
}

Console.WriteLine(suma);

