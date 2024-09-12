using listaGenerica;

List<double> numbers = new List<double>();

do
{
    Console.WriteLine("infeome um numero: ");
    string? numberStr = Console.ReadLine();
    //validando a entrada do usuario
    if(!double.TryParse(numberStr, out double number))
        break;

    numbers.Add(number);
    Console.WriteLine ($"a media dos valores e {numbers.Average()}");
}
while (true);

// lista de pessoas 
List< Person> people= new List<Person>();

Person p1 = new Person();
p1.Nome = "Joao";   
p1.Age = 12;
p1.Contry = contryEnum.PY;
    people.Add( new Person (){ 
        Nome = "Shoron Stone",
        Age = 60,

    });

    Person p3 = new Person();{
        p3.Nome = "Arnold ",
        Age = 65,
        Country = contryEnum.JP        
    };
    people.Add(p3)

    // 
    foreach ( Perrson  p in people)
    {
        Console.WriteLine(p.Name);

    }

    {
        for( int i = 0; i < people.Count;  i++)
        Console.WriteLine( $"Nome{people[i].Name}");

    }

    {
        
    }


