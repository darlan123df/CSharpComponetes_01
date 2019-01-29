
namespace AulaCadastroContrato.Entities
{
    class Department
    {
        public string Name { get; set; }
       
        //construtor padrão da class.
        public Department()
        {

        }
        //construtor que recebe Name com argumento.
        public Department (string name)
        {
            Name = name;
        }
    }
}
