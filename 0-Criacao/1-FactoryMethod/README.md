# Problema
- Eu não posso antecipar o tipo da classe de objeto que deve ser criada. Pois, tenho objetos de vários tipos
- Preciso delegar a responsabilidade para que as subclasses especifiquem os objetos que criam

# Objetivo
- Também conhecido como **Construtor Virtual**, o objetivo desse padrão é a responsabilidade de criar uma fabrica de objetos em tempo de execução e deixar que o objeto decida seu tipo

# Características
- O Factory Method dispões uma interface que cria um objeto, mais são as subclasses, que irão decidir qual classe concreta instanciar

