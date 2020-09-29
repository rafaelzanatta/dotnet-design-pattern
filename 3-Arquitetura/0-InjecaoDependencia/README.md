# O que é dependency injection
- Em linhas gerais este padrão é uma das formas de implementar um outro padrão - Inversão de Controle
- Devemos utilizar esse padrão quando temos a necessidade de desenvolver sistemas em que o nível de acoplamento entre seus diferentes módulos precisem ser extremos baixos

- A função principal deste Pattern é oferecer uma estrutura de baixo acomplamento, visando os seguintes benefícios:
- 1. Oferecer reusabilidade de componentes, uma vez que criamos componentes interdependetes, eles podem ser facilemente implementados em sistemas diversos
- 2. Facilitar a manutenção de sistemas, fazendo com que as manutenções em módulos não afetem o restante do sistema
- 3. Criar códigos altamente "testáveis". Uma vez que temos código implementados seguindo esse Patter, podemos testá-los mais facilemnte utilizando os "mock tests"
- 4. Criar códigos mais legíveis, o que torna mais fácil a compreensão do sistema como um todo

# Meios de implementação
- Construtor => modo em que implementamos a injeção de dependência na definição dos contrutores das classes
- Getter and Setter => modo em que implementamos a injeção de dependência na definição dos Get e Sets das classes
- Interface Implementation => modo em que se usa a definição de interfaces para realizar a ainjeção de dependências
- Service Locator => modo em que construímos classes que servem como "localizadoras" de objetos que iremos instanciar em nossas outras classes
