using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        class Empregados
        {
            //1 QUESTAO:
            public string nome;
            public string sobrenome;
            public int salario;

            public void AtribuirNome(string trocarNome)
            {
                nome = trocarNome;

            }
            public void AtribuirSobrenome(string trocarSobrenome)
            {
                sobrenome = trocarSobrenome;
            }
            public void AtribuirSalario(int trocarSalario)
            {
                salario = trocarSalario;
            }
            //2 QUESTAO
            public string RetornarNome()
            {
                return nome;
            }
            public string RetornarSobrenome()
            {
                return sobrenome;
            }
            public int RetornarSalario()
            {
                return salario;
            }
            public int Retornar10Porcento()
            {
                int Salariox10 = salario * 10;
                int dezPorcento = Salariox10 / 100;
                return dezPorcento;
            }

        }
    }
}