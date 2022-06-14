using bytebank;

Console.WriteLine("Boas Vindas ao seu Banco, ByteBank");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Edmilson Gato Jr";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 100;
    
Console.WriteLine("Titula: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número da Agencia: " + conta1.numero_agencia);
Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
Console.WriteLine("Saldo: R$" + conta1.saldo);

Console.ReadKey();