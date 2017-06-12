 
Projeto SeniorNEt Events
Este projeto consiste em desenvolver um software de pesquisa de diferentes tipos de eventos a realizar em Portugal.
Este software vai ser instalado num computador que terá um dispositivo de saída - tipo ecra e que estará numa residência senior,
onde cada senior poderá consultar os eventos a realizar.

Explicação do Projeto
##Passo 1: O administrador do sistema terá que efetuar login do sistema para poder gerir eventos
##Passo 2: O administrador do sistema insere eventos

O projeto irá ser efetuada em três camadas: Camada de Dados, Camada da Logica e Camada de Interface Grafica.
  - A Camada de dados irá tratar da persistência dos dados sendo ela a responsavel pela comunicação com os dados e fará a parte do criar e     alterar;
  - A Camada da Logica será a responsavel pela comunicação entre a interface grafica e o banco de dados, será a interface (proxy) entre as    duas camada;
  - A Camada da Interface Gráfica fará o contacto direto com o usuario, ou seja, são os forma que servem de interação com o usuario.
  
 Alem destas três camadas iremos ter também os modelos que serão as classes que contem os atributos dos objetos. Temos duas classes: Utilizador.cs e Eventos.cs.
 
 A camada gráfica interga com a camada lógica mas não com a camada de dados. Desta forma existe um nível de abstração entre as camadas, o que torna possível alterar ou atualizar uma camada sem ter que interferir com a outra camada, a camada de interface (GUI). A camada de interface utilizada foi a Windows Forms.


