//declarando variavel
using aula1;

int number;
//atribuindo valor 
number = 10;

//declarando constante 
const int DAYS_IN_WEEK = 7;

// IMPRIMINDO STRING CONCATENADA
Console.WriteLine($" a semana tem {DAYS_IN_WEEK}");

// new tipo enumerodor envoca o metado construtor do objeto
// toda clase tem o seu costrutuor padrão implicito sem argumentos/paramedes
// e possivel sobescrever esse metodo com especificando argumentos toda via se o fizermos perdermos o original implicido e
// precisaremos defeni-lo esplecitamente

TipoEnum tipoEnum= new TipoEnum(); //()isso no final e um metodo,construindo uma nova istancia dele
TipoEnum.Language enumEngles = tipoEnum.GetLanguageEnum ("English");

Console.WriteLine( $" O enun de ingles è {tipoEnum.GetLanguageEnum("ingles")}");