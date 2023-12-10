

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int x in fila)
{
    Console.WriteLine(x);
}
fila.Dequeue();

Console.WriteLine("----------");

foreach(int x in fila)
{
    Console.WriteLine(x);
}