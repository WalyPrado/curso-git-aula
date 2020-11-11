using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Primeiro
{
    class Employee
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Employee(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void EmployeeData() => Console.WriteLine(Id + " - " + Nome + " - " + Salario.ToString("F2", CultureInfo.InvariantCulture));
        
        public void AumentoSalarial(double valor)
        {
            double Valor = (valor / 100) + 1;
            Salario *= Valor;
        }


    }
}
