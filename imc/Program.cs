// Faça um programa que leia o peso, altura e sexo de uma pessoa e calcule o seu IMC informando a situação da pessoa: sobrepeso, obesidade, normal, raquitismo

Console.Write("Informe seu peso em kg: ");
double weight = double.Parse(Console.ReadLine());

while (weight <= 0)
{
    Console.Write("Peso não pode ser zero ou negativo, tente novamente: ");
    weight = double.Parse(Console.ReadLine());
}


Console.Write("Informe sua altura em metros (ex: 1,70): ");
double height = double.Parse(Console.ReadLine());

while (height <= 0)
{
    Console.Write("Altura não pode ser zero ou negativa, tente novamente: ");
    height = double.Parse(Console.ReadLine());
}

double imc = weight / Math.Pow(height, 2);

string state;

if (imc < 18.5)
    state = "Abaixo do peso";
else if (imc < 25)
    state = "Peso normal";
else if (imc < 30)
    state = "Sobrepeso";
else if (imc < 35)
    state = "Obesidade grau I";
else if (imc < 40)
    state = "Obesidade grau II";
else
    state = "Obesidade grau III";

Console.WriteLine($"Seu IMC é de {imc.ToString("0.0")} e é classificado como: {state}");