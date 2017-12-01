COMMIT -- >  SYNC -->  PUSH (<-- REPEAT)

<-------------------------------------------------------------------------------->

 -> Crystal Report: http://www.crystalreports.com/crystal-reports-visual-studio/
      - Digitar o e-mail e selecionar o país, clicar em Free Download;
      - Clicar no botão LARANJA na parte superior da tela e o arquivo será baixado.

 -> Crystal Report Essentials Version: 13.0.20.2399

<-------------------------------------------------------------------------------->

Carlos Silva  - Fabricio Rocha - Gustavo Nunes

ControlX -> Control de Controle(Estoque, produtos, enfim, do estabelecimento) e X, como a incógnita, uma variável,
mostrando de que é possível utilizar esse Software em vários tipos de Estabelecimento.

- Sistema de controle de Estoque, Compra e Venda.

*------------------------------ PARA FAZER ------------------------------*

 -Criar uma base de dados correta para apresentação;
 -Aperfeiçoar a interface gráfica do software;

*------------------------------ F O R M S ------------------------------* 
------------------------------ EM TODOS OS FORMS ------------------------------

*FEITO*-Busca por nome não pode aceitar ' aspas simples para não bugar o SQL
-Quando trocar de tipo de busca(ID,NOME), apagar o textbox para não gerar conflitos com o banco

------------------------------  ESTOQUE ------------------------------

*FEITO*-Busca por Categoria não funcionando
*FEITO*-DGV com dados errados em UN e Categoria quando usa-se o filtro de BUSCA
-Arrumar as imagens dos produtos/ou remover
*FEITO*-Na hora de adicionar, o campo nome não aceita ' aspas simples(inverter com o campo busca)

------------------------------ FORNECEDORES ------------------------------

  -Adicionar filtro por ID
  -Configurar para o Filtro buscar no NOME e por CIDADE

------------------------------ COMPRAS ------------------------------

  -Habilitar modo TELA CHEIA e arrumar os 'Anchors'
  -Preencher o DGV com as ultimas compras realizadas OU Colocar algo mais útil no lugar
  -Botão Finalizar só pode estar habilitado caso tenha algo no DGV de Compras em Aguardo
  -Ao adicionar uma compra, os valores em R$ devem estar com sua devida máscara
  -Poder Visualizar os itens da compra ao clicar em uma compra não finalizada(DGV direito)
  -Notificar caso o Preço de Compra seja maior que o Preço de Venda
  -Não pode comprar '0' produtos

*-------------------------------------------------------------------------*

*------------------------------ C A R G O S ------------------------------*

------------------------------ ADMIN ------------------------------

  -Dono da porra toda, acesso total ao Software

------------------------------ SUPERVISOR ------------------------------

  -Acesso total aos relatórios
  -Acesso parcial aos usuarios
	(Pode adicionar usuarios do tipo Caixa e Almoxarifado)
	(Não pode remover ninguém)
	(Pode editar usuarios do tipo Caixa e Almoxarifado)
  -Acesso total ao resto da porra toda ?!?

------------------------------ CAIXA ------------------------------

  -Acesso total ao sistema de Vendas
  -Acesso total ao Histórico de Vendas
  -Acesso parcial ao estoque
	(Somente habilitada a função de 'Detalhes')
  -Acesso total a aba Ajuda e Sobre

------------------------------ ALMOXARIFADO ------------------------------

  -Acesso total ao sistema de Compras
  -Acesso parcial ao estoque
	(Somente habilitada a função de 'Detalhes')
  -Acesso parcial aos fornecedores
	(Somente habilitada a função de 'Detalhes')

*-------------------------------------------------------------------------*

      
*---------------------------- ATRIBUTOS ------------------------------*

---------- PRODUTO/ESTOQUE --------------

- Cadastrar produto (ADMIN):
  - id(auto incremento)
  - nome
  - preço
  - qtd
  - fornecedor

- Realizar venda/atualizar qtd estoque(ADMIN,USER):


"Criar uma tabela no venda para vendas de produtos."
  - Produto
    - Id
    - Nome
  - qtd
  - preço(preco * qtd)
  - fornecedor(Só para salvar o nome do fornecedor desse produto)
      - id
      - nome

"No form de vender fazer uma List<Produtos> para colocar dentro da lista os produtos
  a serem vendidos. E dois datagridview para listar todos os produtos e os produtos
  que serão adicionados a venda."
  
- Realizar pedido para novos estoques(ADMIN):
  - Produto
    - Id
    - Nome
    - Quantidade(qtd)
  - (qtd <= 1)
  - Fornecedor
    - Id
    - Nome
  - Nova qtd a ser pedida.
  - (Fornecedor)Telefone(os dois se necessario)
  - (Fornecedor)Endereço
  
  
"Mostrar um tipo de relatorio com tudo acima."
  
---------- FORNECEDOR --------------

- Inserir fornecedor(ADMIN)
  - id(auto incremento)
  - nome
  - cnpj
  - telefone1
  - telefone2(opcional)
  - endereço:
    - cep(com busca no WS dos Correios)
    - rua
    - numero
    - bairro
    - cidade
    - estado
    - complemento(opcional)
    
- Visualizar produtos por fornecedor
  
---------------------------------

---------- USUÁRIOS -------------- 

- Cadastrar funcionarios(ADMIN)
  - id(auto incremento)
  - cpf
  - nome
  - data de nascimento
  - telefone
  - endereço:
    - cep(com busca no WS dos Correios)
    - rua
    - numero
    - bairro
    - cidade
    - estado
    - complemento(opcional)
  - login(id do funcionário)
  - senha(cpf??)
  
- Remover Funcionario;

------- VENDA -------------------

- Realizar venda(ADMIN, USER)
  - Produtos a serem vendidos;
  - Retirar do estoque;
  - Nome do funcionario;
  - Valor total da venda;
  - Emissão de nota fiscal com todos os dados acima.
  
- Buscar produto:
  - Numero do produto ou nome para busca.
  
- Total vendido no dia;
----------------------------------


