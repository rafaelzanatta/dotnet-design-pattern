# Problema
- Um dos requisitos não-funcionais de grande importância é performance (sistemas rápidos e com pouco consume de memória)
- Um bom caminho é reduzir objetos criados, ja que o processo de instanciação pode ser relativamente custoso, pois, o processo de contrução também envolve gerenciamento de memória, ponteiros e contagens de referência

# Objetivo
- O objetivo desse padrão é melhorar o desempenho de um procedimento compartilhando objetos com características parecidas
- O padrão provê parâmetros para serem aplicados em objetos já existente, modificando suas propriedades conform solicitado, ao invés da necessidade de sempre intanciá-los

# Características
- Intrínsecas: propriedade imutáveis, ou seja, que caracterizam o objeto compartilhado
- Extrínsecas: propriedades variáveis que podem receber novos valores a cada acesso
