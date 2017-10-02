COMMIT -- >  SYNC -->  PUSH (<-- REPEAT)


Carlos Silva  - Fabricio Rocha - Gustavo Nunes

ControlX -> Control de Controle(Estoque, produtos,enfim , do estabelecimento) e X, como a incógnita, uma variável,
mostrando de que é possível utilizar esse Software em vários tipos de Estabelecimento.

- Sistema de controle de Estoque, Compra e Venda.

---------- PRODUTO/ESTOQUE --------------

- Cadastrar produto (ADMIN):
  - id(auto incremento)
  - nome
  - preço
  - qtd
  - fornecedor
  
  - Realizar venda (ADMIN,USER):
  - id produto ou cópdigo de barras????
  - qtd
  -...
  
- Realizar compra/atualizar qtd estoque(ADMIN,USER):
  - id produto
  - qtd
  - preço(preco * qtd)
  - fornecedor(Só para salvar o nome do fornecedor desse produto)
  
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


