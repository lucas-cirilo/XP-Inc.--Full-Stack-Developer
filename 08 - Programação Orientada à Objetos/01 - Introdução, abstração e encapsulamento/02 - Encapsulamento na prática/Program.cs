using Encapsulamento.Models;

ContaCorrente c1 = new ContaCorrente(1234, 1000);

c1.ExibirSaldo();
c1.Sacar(100);
c1.ExibirSaldo();