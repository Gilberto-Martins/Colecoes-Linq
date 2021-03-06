# Colecoes-Linq
Fundamentos de Coleções e Linq com .NET

## 

# Arrays e suas Manipulações

<p>
    Array é uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo. <br>
    Pode ser declarado um Array de 3 formas: <br> <br>
    <strong>1. int[] array = new int [4];</strong> <br>
    <strong>2. int[] array = new int []{42,75,74,61};</strong><br>
    <strong>3. string[] nomes = {"Jan","Fev"};</strong> <br>
</p>
<h3>Disposição do Array</h3>

<p>
    Índice: é a posição de um determinado valor de um array, sempre começando com zero. <br>
    int[] array = new int []{42,75,74,61} <br>
    var elemento = array[0] <br>
    array[0] = 42 <br>
</p>

<h3>Ordenando Arrays</h3>
<ul>
    <li>Bubble Sort</li>
    <li>Classe Array atraves do metodo sort</li>
    <li>Copiando Array pela class Array usando o metodo copy</li>
    <li>Verificando elemento existente usando o metodo Exists</li>
    <li>Verificando elementos usando TrueForAll</li>
    <li>Procurando elemento usando o metodo Find</li>
    <li>Encontrando o índece de um valor usando o IndexOf</li>
    <li>Redimensionando Array em tempo de execução usando o Resize</li>
    <li>Convertendo um Array de tipos diferentes usando o ConvertAll</li>
</ul>

## 

# Coleções genéricas
<p>
    No C#, existem classes de coleções que agrupam valores, e essas classes <br>
    são padronizadas para as operações mais comuns, como: <br><br>
</p>

<ul>
    <li>Ordenação</li>
    <li>Obter valor por índice</li>
    <li>Obter valor com expressões</li>
    <li>Trabalhar com tamanhos dinãmicos</li>
</ul>

<p>
    Para tratar de Coleções genéricas vamos usar as List. <br>
    Para declarar uma list: List< string> estados = new List< string>(); <br><br>
    As Lists tem metodos proprios como os Arrays. <br><br>
    Para adicionar um elemento na list: estados.Add("PE"); <br>
    E para saber seu tamanho: estados.Conut <br><br>
    Para Remover elementos de uma List: estados.Remove("PE"); <br> <br>
    O quando uma elemento é removido, o elemento que esta atras do removido <br>
    ira assumir a possição do índece do que foi removido. <br><br>
    Adicionando elementos de outra Coleção(List) a como Array <br>
    exemplo: string[] array = new string[2] {"SP","PE"}; <br>
    estados.AddRange(array); <br><br>
    Para Adicionar elementos por índice: estados.Insert(1, "RJ"); <br><br>
    O 1 é o índice de onde apos ele ira inserir o elemento e todos os elementos irão se reposicionar.
</p>

##

# Coleções específicas

<p>
    As coleçoes específicas implementa regras para sua ordem de acesso e manipulação de seus elementos, são elas: <br><br>
    <ul>
        <il>Qeue (Fila): Obedece a ordem FIFO (Frist In Frist Out)</il>
        <il>Stack (Pilha): Obedece a orde LIFO (Last In First Out)</il>
    </ul>
</p>

##

# Dicionários
<p>
    <ul>
        <li>Um dicionário é uma coleção de chave e valor, permitindo que você recupere rapidamente <br>seus itens baseado em sua chave.</li>
        <li>O dicionário armazena a sua chave em hash.</li>
    </ul>
</p>
<h3>Criando um dicionário:</h3>
<p>
    Dictionary< string, string> estados = new Dictionary< string, string>()
</p>

##

# Operações LINQ
<p>
    O Language-Integrated Query (LINQ) é uma maneira de você utilizar uma sintaxe de consulta <br>padronizada par coleções de objetos.
    <br>
    Exemplo: int[] numbers = { 5, 10, 8, 3 ,6, 12 }; <br><br>
    IEnumerable< int> numQuery1 = <br>
    From num in numbers <br>
    where num % 2 == 0 <br>
    orderby num <br>
    select num; <br><br>

    IEnumerable< int> numQuery2 = numbers.Where(num = > num % 2 == 0).OrderBy(n => n);
</p>
