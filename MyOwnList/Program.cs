using MyOwnList;

MyOwnList<int> list = new MyOwnList<int>();

list.Add(3);
list.Add(12);
list.Add(1241);
list.Add(1);

list.Remove(1);
list.Remove(2);

list.Add(14312);
list.Add(1);
list.Add(4);
list.Add(2);

var items = list.FindAll(_item => _item < 5);

foreach (var element in items)
    Console.WriteLine(element);

Console.ReadLine();