using System;

namespace Aula04_OperadoresMatematicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_inteiro; // ex: 1
             
            float numero_ponto_flutuante; // 2.5 valores que "não precisam" de precisão

            decimal numero_decimal; //2.55151 usamos para valores monetários.

            // Operadores
            //   + de adição (observar o contexto)
            //   - de subtração
            //   * de multiplicação
            //   / de divisão
            //   % de módulo, pega o resto de uma divisão


            // IMC = Índice de Massa de Corporal
            // imc = peso / altura²  => simplificando => imc = peso / altura * altura

            double peso, altura, imc;

            Console.WriteLine("Bem-vindo ao Sistema de Cálculo de IMC!");
            
            Console.WriteLine("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc);

            //Se
            if (imc < 17)
            {
                Console.WriteLine("Muito abaixo do peso."); // peso = 30


                // SE imc maior igual a 17 E imc menor igual a 18.49
            }
            else if (imc >= 17 && imc <= 18.49)
            {
                Console.WriteLine("Abaixo do peso."); // peso = 55

            }
            else if (imc >= 18.5 && imc <= 24.99)
            {
                Console.WriteLine("Peso normal."); // peso = talvez 65

            }
            else if (imc >= 25 && imc <= 29.99)
            {
                Console.WriteLine("Acima do peso."); // peso = talvez 85

            }
            else if (imc >= 30 && imc <= 34.99)
            {
                Console.WriteLine("Obesidade I"); // peso = talvez 100

            }
            else if (imc >= 35 && imc <= 39.99)
            {
                Console.WriteLine("Obesidade II"); // peso = talvez 115

            }
            else if (imc >= 40)
            {
                Console.WriteLine("Obesidade III"); // peso = talvez 150
            }
        }
    }
}
