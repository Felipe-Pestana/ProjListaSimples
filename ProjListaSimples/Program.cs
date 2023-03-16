using ProjListaSimples;

ListItem list = new ListItem();

Item item = new(21);

list.Insert(item);
list.Print();

item = new(25);
list.Insert(item);
list.Print();

item = new(40);
list.Insert(item);
list.Print();

item = new(10);
list.Insert(item);
list.Print();

item = new(22);
list.Insert(item);
list.Print();