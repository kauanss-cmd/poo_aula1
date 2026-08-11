using PooPedidos;
using PooPedidos.Entidades;

var cliente = new Cliente();

cliente.Id = 1;
cliente.Nome= "kauan";
cliente.Email="testeemail";
cliente.cpf = "2312321414";

var cliente2 = new Cliente();
cliente2.Id = 2;
cliente2.Nome= "kauan2";
cliente2.Email="testeemail";
cliente2.cpf = "2312321414";

var cliente3 = new Cliente();
cliente3.Id = 3;
cliente3.Nome= "kauan3";
cliente3.Email="testeemail";
cliente3.cpf = "2312321414";

var listcliente = new List<Cliente>();
listcliente.Add(cliente);
listcliente.Add(cliente2);
listcliente.Add(cliente3);

var stringcliente = cliente2.ToString();
Console.WriteLine(stringcliente);


// var aplicacao = new Aplicacao();
// aplicacao.Executar();
