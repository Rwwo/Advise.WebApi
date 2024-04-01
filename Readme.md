# README - Projeto Web API
## Este � o README do projeto da Web API.

#### Sobre o Projeto
Este projeto � uma Web API constru�da utilizando as melhores pr�ticas de desenvolvimento, incluindo os conceitos de CQRS, Clean Code, Clean Architecture e Unit of Work. Esses conceitos foram aplicados para garantir a manutenibilidade, escalabilidade e robustez da aplica��o.

## Princ�pios Utilizados
### CQRS (Command Query Responsibility Segregation)
O CQRS � um padr�o de arquitetura que separa as opera��es de leitura (queries) das opera��es de escrita (commands) em um sistema. Isso permite otimizar cada opera��o para suas respectivas necessidades, melhorando a escalabilidade e a performance da aplica��o.

### Clean Code
Clean Code � uma abordagem de escrita de c�digo que enfatiza a legibilidade, a simplicidade e a manutenibilidade. Ao seguir os princ�pios de Clean Code, garantimos que nosso c�digo seja f�cil de entender, modificar e dar manuten��o, promovendo uma base s�lida para o desenvolvimento cont�nuo do projeto.

### Clean Architecture
A Clean Architecture � uma arquitetura de software que define uma estrutura clara e modular para organizar o c�digo-fonte de uma aplica��o. Ao seguir os princ�pios da Clean Architecture, separamos claramente as responsabilidades das diferentes camadas da aplica��o, como a camada de apresenta��o, a camada de neg�cios e a camada de dados, facilitando a evolu��o e a manuten��o do sistema.

### Unit of Work
O Unit of Work � um padr�o de projeto que define uma interface para agrupar v�rias opera��es de banco de dados em uma �nica transa��o. Isso garante a consist�ncia dos dados e simplifica o gerenciamento de transa��es em sistemas complexos.

#### Como Executar o Projeto
Para executar o projeto, siga estas etapas:

1. Clone o reposit�rio para sua m�quina local.
2. Abra o projeto em sua IDE de prefer�ncia.
3. Compile e execute a aplica��o.
4. Acesse a API por meio do endpoint fornecido.

## IMPORTANTE:
* O projeto possui o funcionalidade de autentica��o. O mesmo serve para demonstrar o dom�nio sobre o pacote (n�o foram adicionados os annotations de [authorize] nas controller para n�o dificultar a utiliza��o da documenta��o viva);
* O projeto possui CRUD total para as entidades: CORRETOR, IM�VEL, INQUILINO E PROPRIET�RIO;
	* O projeto possui apenas POST para CORRETOR INQUILINO CONTATO e CORRETOR PROPRIETARIO CONTATO.
	Ambas servem para armazenar itera��es entre as 'personas' na situa��o fict�cia do projeto (inquilino(cliente) chamando corretor em busca de imovel)
	Propriet�rio chamando corretor para situa��o XPTO.
* O projeto possui uma controller chamada InquilinoImovelLocacao. O Post dessa controller � respons�vel por informar ao backend que se 'iniciou' um processo de aluguel;
	 O Putch informa que o mesmo se finalizou. Ambos possuem a rela��o atrav�s chave estrangeira com corretor inquilino contato.
	 Ainda na mesma controller, existe um m�todo get que � respons�vel por emitir o 'relat�rio'. Imoveis alugados, com dados de propriet�rio + inquilino + corretor.