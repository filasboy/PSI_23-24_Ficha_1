# Ficha de Programação e Sistemas de Informação - Classes

Faz *fork* do repositório para teres a tua cópia.
Faz clone da tua cópia do repositório para o teu PC.
Preenche o README localmente e seguidamente faz push das atualizações.

Escreve as respostas dentro dos blocos correspondentes. Substitui as reticências pelo que é pedido em cada pergunta. Não desformates o documento.

## Informação do aluno

    Nome: filipe sousa

## E1 - Responde às seguintes questões (4v)

    1 - As classes são tipos de referência? 
        Em programação e na orientação a objetos, uma classe é um Tipo abstrato de Dado
    2   Instânciasdefinem o que algo pode fazer e guardar, enquanto uma
        classe é um objeto específico que contém o seu próprio estado 
        (Apaga a opção entre parênteses errada)
    3 - Indica três tipos de membros que podem pertencer a uma classe 
        Os membros de uma classe em C++ podem pertencer a uma de três categorias de acesso: público, protegido e privado
    4 - Se algo é static então é partilhado por todas as instâncias desse tipo específico? 
        Por outro lado, um campo estático pertence ao tipo propriamente dito e é partilhado entre todas as instâncias desse tipo
    5 - Como se chamam os métodos especiais que inicializam uma classe? 
        Construtores são basicamente funções de inicialização de uma classe, as quais são invocadas no momento em que objetos desta classe são criadas
    6 - De onde podes aceder a algo private? 
         private: O tipo ou membro pode ser acessado apenas por código no mesmo class ou struct
    7 - De onde podes aceder a algo public? 
         Quando utilizamos a palavra public, liberamos o acesso do atributo/método/classe para ser utilizado por qualquer um
    8 - De onde podes aceder a algo internal? 
        ...

## E2 - Explica por palavras tuas o significado dos seguintes termos (4v)

    1 - Classe
        Em síntese, a classe é um conjunto de objetos com características em comum. E é justamente a classe quem define o comportamento do objeto. 
    2 - Objeto / instância
        Em programação orientada a objetos, chama-se instância de uma classe, um objeto cujo comportamento e estado são definidos pela classe
    3 - Método
        Um método é uma sub-rotina que é executada por um objeto ao receber uma mensagem. Os métodos determinam o comportamento dos objetos de uma classe e são análogos a funções ou procedimentos da programação estruturada.
    4 - Construtor
        ...
    5 - Variável de instância
        Um programa pode criar muitos objetos da mesma classe. Os objetos também são denominados instâncias e podem ser armazenados numa variável com nome ou numa matriz ou coleção
    6 - Variável local
        uma variável local é uma variável temporária que só é conhecida (somente existe) na função onde foi criada.
    7 - Overloading
        ...
    8 - Encapsulação
        ...

## E3 - Cria o seguinte programa de consola (12v)

- Nome do projeto: **BolasColoridas**
  - Cria a classe **Cor** com:
    - Estado representado pelos valores **red, green, blue, alpha**
    - Construtor que aceita todos os parâmetros necessários para inicializar o estado de uma cor
    - Construtor que aceita **red, green, blue,** e coloca **alpha** a 255
    - Métodos *getter* e *setter* para os componentes **red, green, blue e alpha**
    - Método *getter* para obter o grau de cinzento da cor, igual à média dos valores **red, green e blue**
  - Cria a classe **Bola** com:
    - Estado representado pelos valores de **cor, raio e o nº de vezes que a bola foi atirada**
    - Construtores apropriados
    - Método **Pop()** que fura a bola (coloca o seu raio a zero)
    - Método **Atirar()** que incrementa o nº de vezes que a bola foi atirada (apenas se a bola não estiver furada)
    - Método que retorna o nº de vezes que a bola foi atirada
  - Na classe **Program**, método **Main**, escreve código para:
    - Criar algumas bolas
    - Atirar as bolas várias vezes
    - Rebentar algumas das bolas
    - Imprimir no ecrã o estado de cada uma (incluindo cor)
  - Faz vários *commits* ao longo do desenvolvimento e no fim faz *push* para o repositório remoto
