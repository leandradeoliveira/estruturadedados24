
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using aula02;

 Person person = new Person();
Console.WriteLine(person.Name); // null

Person person1 = new Person("Mauricio gonzatto", 40);
Console.WriteLine(person1.Name); // Mauricio gonzatto

Person person2 = new Person();
person2.Name = "doido";
person2.Age = 70;
Console.WriteLine(person2.Name); // doido

Person person3 = new Person ()
{ 
    Name = "leonel Brizola", 
    Age = 80 };
Console.WriteLine(person3.Name); // leonel Brizola


