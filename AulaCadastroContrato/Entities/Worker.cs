using System.Collections.Generic;
using AulaCadastroContrato.Entities.Enums;

namespace AulaCadastroContrato.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        //Associação do objeto Department com o Worke
        public Department Department { get; set; }

        //Associação do objeto HourContract com o Worke e já iniciei a lista para não começar vazia.
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }
        // Foi criado o construtor com todas a propriedade menos da associação de (1 -> muitos)
        public Worker(string name, WorerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
    }
}
