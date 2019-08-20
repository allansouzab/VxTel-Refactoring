#language: pt-br

Funcionalidade: Cálculo plano VxTel
	Para quanto vou gastar em uma ligação
	Enquanto cliente
	Eu gostaria de calcular o preço com o plano e sem o plano

Cenário: Origem de DDD 11 e Destino de DDD 16
	Dado que estou consumindo o método ValorComPlano
	E preencho o campo 'origem' com o valor 11, o campo 'destino' com o valor 16, o tempo com o valor 10 e o plano com o valor 5
	Quando executo a aplicação
	Então vejo '10.45'