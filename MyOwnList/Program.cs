using MyOwnList;

MyOwnList<int> list = new MyOwnList<int>();

list.Add(3);
list.Add(12);
list.Add(1241);
list.Add(1);

list.Remove(1);
list.Remove(2);

list.Add(14312);

Console.WriteLine(list[0]);

Console.ReadLine();