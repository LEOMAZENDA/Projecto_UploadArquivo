Este projeto é uma evolução de um projeto monolítico para a arquitetura Clean Architecture, com foco no salvamento de arquivos em um banco de dados SQL Server. Inicialmente, o projeto do Rafael Almeida, disponível em seu GitHub (rafaelalmeida12), apresentava uma estrutura monolítica.

Inspirado pelo projeto e ideias apresentados por Rafael Almeida em seu canal no YouTube, assumi o desafio de transformar o projeto monolítico em uma arquitetura mais limpa. Baseado no trabalho de Rafael Almeida, criei uma versão nova e aprimorada do projeto em meu repositório no GitHub (LEOMAZENDA), demonstrando a evolução e implementação dos princípios da Clean Architecture.

O projeto monolítico possuía uma única base de código onde todas as funcionalidades estavam intimamente acopladas. No entanto, com a adoção da Clean Architecture, o projeto foi dividido em cinco projetos distintos, cada um com sua própria responsabilidade e propósito.

Esta evolução do projeto inclui os seguintes projetos:

1. Domain: Este projeto contém a classe "Ficheiro", que representa a entidade principal do sistema. Ele define os atributos e comportamentos relacionados aos arquivos.

2. Infra.Data: Neste projeto, é implementada a camada de infraestrutura de dados. Ele inclui classes de repositório, acesso a dados e a lógica de persistência dos arquivos no banco de dados SQL Server.

3. Application: O projeto Application implementa as regras de negócio e lógica de aplicação do sistema. Ele define os casos de uso relacionados aos arquivos, como validação dos arquivos antes de salvá-los.

4. Infra.IoC: O projeto Infra.IoC lida com inversão de controle e injeção de dependências no sistema. Ele organiza as dependências e configura a estrutura do projeto, facilitando o gerenciamento das classes e suas dependências.

4. Camada de Apresentação Web (UploadArquivoAula): Este projeto é responsável pela interface de apresentação do sistema. Ele implementa a funcionalidade de upload de arquivos usando a função "IFormFile" para salvar os arquivos no banco de dados SQL Server.
Eeste Projecto segue os princípios fundamentais da Clean Architecture. Essa versão aprimorada pode ser encontrada sempre no meu repositório no GitHub (LEOMAZENDA), demonstrando seu progresso e avanços no projeto.

Este poderá ser Evoluido futuramente.

Obrigado
