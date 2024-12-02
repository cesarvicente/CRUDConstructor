# CRUDConstructor

O **CRUDConstructor** é uma ferramenta desenvolvida para gerar automaticamente uma estrutura de código baseada em consultas ao banco de dados MySQL, utilizando queries manuais. A aplicação é projetada para criar uma estrutura de pastas organizada e funcional para projetos C#.

---

## **Descrição do Funcionamento**

Ao se conectar ao banco de dados MySQL, o CRUDConstructor realiza as seguintes operações:

1. **Leitura da Estrutura do Banco**:
   - Analisa as tabelas, colunas e tipos de dados definidos no banco.

2. **Geração Automática de Código**:
   - Cria uma estrutura de pastas organizada com três camadas principais:
     - **Model**: Define classes que representam as tabelas do banco de dados. Cada classe reflete os campos e suas propriedades.
     - **DAO (Data Access Object)**: Contém as queries SQL personalizadas para operações de CRUD, como:
       - Inserção de dados (`INSERT`);
       - Atualização de registros (`UPDATE`);
       - Exclusão de dados (`DELETE`);
       - Consulta de informações (`SELECT`).
     - **Controller**: Disponibiliza métodos públicos para interação com os dados gerados na camada DAO, atuando como uma ponte para o restante do sistema.

3. **Personalização do Código**:
   - Permite ao desenvolvedor selecionar os campos que serão incluídos nas operações.
   - Possibilita definir quais operações CRUD serão geradas para cada tabela.

---

## **Características**

- **Baseado em Queries Manuais**:
  - Ideal para desenvolvedores que preferem controle detalhado sobre as consultas SQL ao invés de usar um ORM tradicional.
  
- **Estrutura Modular**:
  - Código gerado em camadas separadas para facilitar a manutenção e organização do projeto.

- **Configuração Direcionada**:
  - Adapta-se às necessidades específicas do projeto, permitindo maior flexibilidade na geração de código.

- **Foco no Banco de Dados MySQL**:
  - Gera código específico para interação eficiente com este banco de dados.

---

## **Objetivo do Projeto**

O CRUDConstructor foi criado para atender a projetos que exigem um nível maior de controle e personalização nas interações com o banco de dados. Ele automatiza tarefas repetitivas e ajuda a estruturar o código de maneira consistente, sem abrir mão da flexibilidade necessária em cenários complexos.
