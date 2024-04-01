# README - Projeto Web API
## Este é o README do projeto da Web API.

#### Sobre o Projeto
Este projeto é uma Web API construída utilizando as melhores práticas de desenvolvimento, incluindo os conceitos de CQRS, Clean Code, Clean Architecture e Unit of Work. Esses conceitos foram aplicados para garantir a manutenibilidade, escalabilidade e robustez da aplicação.

## Princípios Utilizados
### CQRS (Command Query Responsibility Segregation)
O CQRS é um padrão de arquitetura que separa as operações de leitura (queries) das operações de escrita (commands) em um sistema. Isso permite otimizar cada operação para suas respectivas necessidades, melhorando a escalabilidade e a performance da aplicação.

### Clean Code
Clean Code é uma abordagem de escrita de código que enfatiza a legibilidade, a simplicidade e a manutenibilidade. Ao seguir os princípios de Clean Code, garantimos que nosso código seja fácil de entender, modificar e dar manutenção, promovendo uma base sólida para o desenvolvimento contínuo do projeto.

### Clean Architecture
A Clean Architecture é uma arquitetura de software que define uma estrutura clara e modular para organizar o código-fonte de uma aplicação. Ao seguir os princípios da Clean Architecture, separamos claramente as responsabilidades das diferentes camadas da aplicação, como a camada de apresentação, a camada de negócios e a camada de dados, facilitando a evolução e a manutenção do sistema.

### Unit of Work
O Unit of Work é um padrão de projeto que define uma interface para agrupar várias operações de banco de dados em uma única transação. Isso garante a consistência dos dados e simplifica o gerenciamento de transações em sistemas complexos.

#### Como Executar o Projeto
Para executar o projeto, siga estas etapas:

1. Clone o repositório para sua máquina local.
2. Abra o projeto em sua IDE de preferência.
3. Compile e execute a aplicação.
4. Acesse a API por meio do endpoint fornecido.

## IMPORTANTE:
* O projeto possui o funcionalidade de autenticação. O mesmo serve para demonstrar o domínio sobre o pacote (não foram adicionados os annotations de [authorize] nas controller para não dificultar a utilização da documentação viva);
* O projeto possui CRUD total para as entidades: CORRETOR, IMÓVEL, INQUILINO E PROPRIETÁRIO;
	* O projeto possui apenas POST para CORRETOR INQUILINO CONTATO e CORRETOR PROPRIETARIO CONTATO.
	Ambas servem para armazenar iterações entre as 'personas' na situação fictícia do projeto (inquilino(cliente) chamando corretor em busca de imovel)
	Proprietário chamando corretor para situação XPTO.
* O projeto possui uma controller chamada InquilinoImovelLocacao. O Post dessa controller é responsável por informar ao backend que se 'iniciou' um processo de aluguel;
	 O Putch informa que o mesmo se finalizou. Ambos possuem a relação através chave estrangeira com corretor inquilino contato.
	 Ainda na mesma controller, existe um método get que é responsável por emitir o 'relatório'. Imoveis alugados, com dados de proprietário + inquilino + corretor.