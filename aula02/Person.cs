using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace aula02
{
    public class Person
    {
        public string _locacion = string.Empty;
        public string Name { get; set; } // corrigi a sintaxe da propriedade
        public int Age { get; set; }

        // método construtor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // não é necessário um construtor vazio, mas se quiser manter, aqui está a correção
        public Person()
        {
            Name = "------";
        }

        // método para realocar a pessoa
        public void Relocate(string locacion)
        {
            if (!string.IsNullOrEmpty(locacion)) // corrigi o método IsNullOrEmpty
            {
                _locacion = locacion;
            }
        }

        // método para obter a distância
        public float GetDistance(string locacion)
        {
            // aqui você precisará implementar a lógica para calcular a distância
            // por enquanto, estou retornando 0
            return 0;
        }
    }
}