Console.WriteLine("----------- Atividade 1 ---------------");
try
{

    Console.Write("Digite o valor em centavos: ");
    int valor = int.Parse(Console.ReadLine());

    //1 prato economiza 6 cents

    if (valor <= 0 || valor >= 1000000)
    {
        Console.WriteLine("Valor inválido, o valor deve estar entre 1 e 1000000");
    }
    else
    {
        int pratosEconomizados = valor / 6;
        Console.WriteLine($"A quantidade de pratos economizados é {pratosEconomizados}");
    }
}catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}

Console.WriteLine("---------------------------------------");

Console.WriteLine("----------- Atividade 2 ---------------");

try
{
    Console.Write("Digite sua data de nascimento(dia/mes/ano): ");

    DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());

    int idade = DateTime.Now.Year - dataNascimento.Year;

    if (!VerificaAniversario(dataNascimento))
    {
        idade--;
    }

    if (VerificaSeNasceu(dataNascimento))
    {
        Console.WriteLine(idade);
    }
    else
    {
        Console.WriteLine("Você não nasceu ainda");
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

bool VerificaAniversario(DateTime dataNascimento)
{
    if (dataNascimento.Month > DateTime.Now.Month)
        return false;

    if (dataNascimento.Month == DateTime.Now.Month && dataNascimento.Day > DateTime.Now.Day)
        return false;

    return true;
}

bool VerificaSeNasceu(DateTime dataNascimento)
{
    return dataNascimento <= DateTime.Now;
}

Console.WriteLine("---------------------------------------");

Console.WriteLine("----------- Atividade 3 ---------------");

try
{

    Console.Write("Digite o salario bruto: ");
    double bruto = int.Parse(Console.ReadLine());

    double liquido = bruto - bruto * 0.22;

    Console.WriteLine("O salario liquido é: " + liquido);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.WriteLine("---------------------------------------");

Console.WriteLine("----------- Atividade 4 ---------------");

try
{

    Console.WriteLine("Que tipo de cliente você é?");

    Console.WriteLine("1-Normal");
    Console.WriteLine("2-Especial");
    int cliente = int.Parse(Console.ReadLine());

    Console.Write("Digite o seu saldo atual: ");
    double saldo = double.Parse(Console.ReadLine());

    Console.Write("Digite o valor desejado para saque: ");
    double saque = double.Parse(Console.ReadLine());

    if (cliente == 1)
    {
        if (saque <= 1000)
        {
            if (saque <= saldo)
            {

                Console.WriteLine("Saque realizado com sucesso");
        
            } else
            {

                Console.WriteLine("Saque não permitido");
        
            }
        } else
        {

            Console.WriteLine("Saque não permitido");
    
        }
    } else if (cliente == 2)
    {
        if (saque <= saldo)
        {

            Console.WriteLine("Saque realizado com sucesso");

        }

        else
        {

            Console.WriteLine("Saque não permitido");

        }
    } else
    {
        Console.WriteLine("Esse tipo de cliente é invalido, tente novamente!");
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
