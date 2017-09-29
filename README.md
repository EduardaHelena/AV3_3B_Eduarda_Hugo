# AV3 3003 B3

## Seletor de itens a partir de um banco de dados de poções

Existem:
- Cena de teste Main.unity;
- Classe Potion.cs !!NÃO MEXE!!;
- Banco de dados com a lista de potions no script PotionDB.cs no prefab Resources/PotionDB !!NÃO MEXE!!;
- Script TestBehaviour.cs que server como exemplo, para testar e pra vocês editarem;

Vocês farão um PropertyDrawer para o atributo PotionSelectorAttribute (dentro do script TestBehaviour.cs).
O atributo é usado em campos do tipo string.

A ideia é que, ao invés de escrever o nome da poção desejada, aparece um dropdown (EditorLayout.Popup()) para selecionar entre as poções existentes. Use PotionDB.Instance para acessar o banco de poções de qualquer lugar.

Quando for dado play na cena, o script TestBehaviour deve imprimir qual o fator de cura da poção escolhida no Start() (assim como indica o comenário no script).

## Extras

- Ao invés do PotionSelectorAttribute funcionar para strings (só o nome da poção), ele funciona para campos do tipo Potion e já puxa todos os valores do banco de dados, ao invés de apenas o nome;

## Logística

Grupos de 2 a 3

Email: mlr@cesar.org.br

Assunto: AV3 3003

Nome do grupo no email. Apenas um email por grupo.
