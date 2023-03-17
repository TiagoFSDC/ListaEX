using ListaEX;

internal class Program
{
    private static void Main(string[] args)
    {
        ListItem list = new ListItem();
        Item item = new(21);

        list.Insert(item);
        list.Print(item);

        item = new(25);
        list.Insert(item);
        list.Print(item);

        item = new(40);
        list.Insert(item);
        list.Print(item);

        item = new(10);
        list.Insert(item);
        list.Print(item);

        item = new(22);
        list.Insert(item);
        list.Print(item);

        item = new(23);
        list.Insert(item);
        list.Print(item);

        item = new(8);
        list.Insert(item);
        list.Print(item);
    }
}