#language: pt-br

Funcionalidade: Cálculo do plano VxTel
Para quanto gastarei com plano ou sem plano
Enquanto cliente
Eu gostaria de calcular o valor da ligação com plano e sem o plano

Cenário: Origem de DDD 11, Destino de DDD 16 e Tempo de 20 minutos
Dado que estou consumindo o método ValorComPlano
E preencho o campo 'Origem' com o valor 11, o campo 'Destino' com o valor 16 e o campo 'Tempo' com valor 20
Quando executo a aplicação
Então vejo '38'