**Problema:**
O banco possui uma carteira de investimento que rende 7% a.a. Sua
implementação deve receber o valor investido e a quantidade de
meses a ser acumulado. Ao final deve retornar os juros acumulado no
período em reais.

**Análise Documentada:**

**Valor investido** ***recebe** entrada do investidor*; var(***Double***)

+ Pode receber valores decimais ou inteiros e serão armazenados.
+ Caso não seja o tipo desejado, irá retornar um erro e pedirá para adicionar novamente.

**Quantidade de meses** ***recebe** entrada do investidor*; var*(***Inteiro***)*

* Variável irá receber apenas valores inteiros do investidor e será armazenado.
* Caso não seja o tipo desejado, irá retornar um erro e pedirá para adicionar novamente.

**Implementação *recebe* ~~Valor investido~~ + 7% po mês;** var(***Double***)

* Variável irá receber o valor armazenado e será adicionado um acréscimo de 7% baseado na quantidade de meses indicada pelo investidor.

**Retirada *recebe* ~~Implementação~~ com o juros acumulativo da quantidade de meses que passaram;** var: R$+(***Double***) máximo de duas casas decimais

* Variável que irá dar a saída do valor da implementação com os acúmulos de juros.
