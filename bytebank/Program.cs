using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas Vindas ao seu Banco, ByteBank");
Console.WriteLine("=============================================================================");

//conta1.titular = "Edmilson Gato Jr";
//conta1.conta = "10123-X";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agencia Central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Jimmy";
//conta2.conta = "18568-X";
//conta2.numero_agencia = 23;
//conta2.nome_agencia = "Agencia Central";
//conta2.saldo = 350;

//Console.WriteLine("Titula: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número da Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
//Console.WriteLine("Saldo: R$" + conta1.saldo);
//Console.WriteLine("-----------------------------------------------------------------------------");
//Console.WriteLine("Titula: " + conta2.titular);
//Console.WriteLine("Conta: " + conta2.conta);
//Console.WriteLine("Número da Agencia: " + conta2.numero_agencia);
//Console.WriteLine("Nome da Agencia: " + conta2.nome_agencia);
//Console.WriteLine("Saldo: R$" + conta2.saldo);
//Console.WriteLine("-----------------------------------------------------------------------------");
//Console.WriteLine("Saldo da Jimmy Pré-Trasnferencia: " + conta2.saldo);
//Console.WriteLine("Saldo da Edmilson Pré-Trasnferencia: " + conta1.saldo);
//conta1.Transferir(50, conta2);
//Console.WriteLine("-----------------------------------------------------------------------------");
//Console.WriteLine("Saldo da Jimmy Pós-Trasnferencia: " + conta2.saldo);
//Console.WriteLine("Saldo da Edmilson Pós-Trasnferencia: " + conta1.saldo);
//conta2.Transferir(25, conta1);
//Console.WriteLine("-----------------------------------------------------------------------------");
//Console.WriteLine("Saldo da Jimmy Pós-Trasnferencia: " + conta2.saldo);
//Console.WriteLine("Saldo da Edmilson Pós-Trasnferencia: " + conta1.saldo);

//ContaCorrente conta1 = new ContaCorrente();
//Cliente cliente = new Cliente();

//cliente.nome = "Edmilson Gato Jr";
//cliente.cpf = "15975345682";
//cliente.profissao = "Analista de Sistemas";

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = cliente;
//conta3.conta = "2516321-X";
//conta3.numero_agencia = 35;
//conta3.nome_agencia = "Agencia Central";

//Console.WriteLine(cliente.nome);
//Console.WriteLine(conta3.titular.nome
//
//Cliente cliente = new();
//cliente.Nome = "Jimmy";
//ContaCorrente conta4 = new (235,"123456-X");

//conta4.Saldo = 300;
//conta4.Saldo = 300;
//conta4.Titular = cliente;
//Console.WriteLine(conta4.Titular.Nome);
//Console.WriteLine(conta4.Saldo);
//Console.WriteLine(conta4.Numero_agencia);
//Console.WriteLine(conta4.Conta);

Cliente cliente = new ();
cliente.Nome = "Jimmy";
;
ContaCorrente conta6 = new(conta6.Titular.Nome, "Agencia de Registro",365, "1258436-X");
conta6.Titular = cliente;
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
Console.WriteLine(conta6.Titular.Nome);
Console.WriteLine(conta6.Nome_Agencia);
Console.WriteLine(conta6.Numero_agencia);
Console.WriteLine(conta6.Conta);

Console.ReadKey();