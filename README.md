# Sobre

A Ideia é receber listas de dados e transformar esses dados em relatorios com a utilização do stimulsoft. nesse caso sera
gerado um excel personalizado afins de teste.

# O'que estamos usando ?

 - Padrão Command
 
    Nesse projeto foi usado o padrão command com intuito de encapsular uma solicitação como um objeto e passar essa solicitação para outro objeto para executá-la   posteriormente sem bloquear a thread principal do programa. 
    Pensando em responsabilidade unica descoplando o objeto que solicita a ação do objeto que executa a ação, permitindo que você trate as solicitações como objetos independentes e executáveis posteriormente.
    
 # Principios do command
 
  - Separação de responsabilidades: O padrão Command separa a lógica de solicitação do objeto que realiza a ação associada à solicitação. Isso permite que a solicitação seja tratada de maneira independente e reutilizável em diferentes partes do sistema.

  - Encapsulamento da solicitação: O padrão Command encapsula a solicitação como um objeto, permitindo que a solicitação seja tratada como uma entidade independente com sua própria interface. Isso torna mais fácil modificar, estender e reutilizar solicitações sem afetar o restante do sistema.

  - Flexibilidade de execução: O padrão Command permite que as solicitações sejam executadas em momentos diferentes do tempo, ou em locais diferentes do sistema. Isso torna mais fácil lidar com solicitações de forma assíncrona ou em uma fila de tarefas.

  - Suporte para desfazer e refazer operações: O padrão Command fornece uma maneira natural de implementar operações de desfazer e refazer, permitindo que o sistema reverta as operações executadas anteriormente.

  - Abstração de dependências: O padrão Command permite que o objeto que executa a ação associada à solicitação seja tratado de forma independente, reduzindo as dependências entre os objetos no sistema.

  - Suporte para histórico de operações: O padrão Command torna mais fácil manter um registro de todas as solicitações executadas pelo sistema, permitindo que o sistema mantenha um histórico de operações para fins de auditoria ou para desfazer/refazer operações específicas.

# CQRS VS Command

 -O Command se concentra na separação de solicitações e ações, o CQRS se concentra na separação de leitura e gravação em uma arquitetura de software mais ampla.

# Stimulsoft
  - Estamos usando a biblioteca do stimulsoft para geração de relatorios afins de aprendizados.
    
# Swagger
  - http://localhost:5000/index.html
    
  
 
