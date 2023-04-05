string nome;

int idade;

double salario;

string estadoCivil;

Console.WriteLine($" Informe seu Nome: ");
nome = (Console.ReadLine()!);

while (string.IsNullOrEmpty(nome))

{
    Console.WriteLine($"Nome inválido !");
    nome = (Console.ReadLine()!);

}



Console.Write("Digite sua idade: ");
while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0 || idade > 100)

{
    Console.WriteLine($"idade Invalida !");

}


Console.Write("Digite seu salário: ");
while (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0)
{
    Console.Write("Salário inválido. Digite novamente: ");
}


Console.Write("Digite seu estado civil (solteiro,   casado,  - viúvo,  - divorciado): ");
            estadoCivil =  (Console.ReadLine()!);

            while (estadoCivil != "solteiro" && estadoCivil != "casado" && estadoCivil != "viuvo" && estadoCivil != "divorciado")
            {
                Console.Write("Estado civil inválido. Digite novamente: ");
                estadoCivil = (Console.ReadLine()!);
            }

            Console.WriteLine("Informações validadas!");
     

   
     

        

