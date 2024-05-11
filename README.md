# Cadastro de Produtos
Este é um projeto de Cadastro de Produtos desenvolvido utilizando .NET 8, Razor e Entity Framework com a arquitetura MVC. O principal objetivo deste projeto é permitir aos usuários cadastrar, visualizar, editar e excluir produtos, além de oferecer a funcionalidade de filtro de pesquisa para encontrar produtos específicos de forma rápida e eficiente.

# Funcionalidades Principais
- Cadastro de Produtos: Os usuários podem adicionar novos produtos, incluindo informações como nome, descrição, preço, categoria, etc.
- Visualização de Produtos: Exibe todos os produtos cadastrados em uma interface amigável e responsiva.
- Edição de Produtos: Permite aos usuários editar as informações dos produtos existentes.
- Exclusão de Produtos: Possibilidade de remover produtos da base de dados.
- Filtro de Pesquisa: Implementação de um filtro de pesquisa para encontrar produtos com base em critérios específicos, como nome, categoria, preço, etc.

# Pré-requisitos
Certifique-se de ter os seguintes requisitos instalados em sua máquina:

- .NET 8 SDK
- Visual Studio Code ou Visual Studio 2019 (ou superior)
- SQL Server (ou outro banco de dados compatível com o Entity Framework)

# Instalação e Execução
1. Clone este repositório em sua máquina local:
git clone https://github.com/seu-usuario/cadastro-de-produtos.git

2. Navegue até o diretório do projeto:
- cd cadastro-de-produtos

3. Abra o projeto em sua IDE preferida (Visual Studio Code ou Visual Studio).
4. Abra o arquivo appsettings.json e ajuste a string de conexão com o seu banco de dados SQL Server.
5. Abra um terminal na raiz do projeto e execute os seguintes comandos para criar o banco de dados e aplicar as migrações:
- dotnet ef database update
6. Execute o projeto pressionando F5 ou através do comando:
- dotnet run
7. Abra um navegador web e acesse a URL https://localhost:7282/ para visualizar a aplicação em execução.
