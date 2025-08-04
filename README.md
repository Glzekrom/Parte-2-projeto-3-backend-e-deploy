# Parte-2-projeto-3-backend-e-deploy

aqui temos o backend e o deploy com docker
Bruno, o meu computador não foi capaz de subir a api no docker todas as vezes aparece erros deste tipo:
target frontend: failed to receive status: rpc error: code = Unavailable desc = error reading from server: EOF
 => ERROR [frontend build 2/6] WORKDIR /app                                                                           0.0s 
 => ERROR [backend build 2/6] WORKDIR /src                                                                            0.0s 
------
 > [frontend build 2/6] WORKDIR /app:
------
------
 > [backend build 2/6] WORKDIR /src:
------
target frontend: failed to solve: Unavailable: error reading from server: EOF
assim por diante.
então como prova de que o codigo é funcional eu simulei prints de como ele se comporta,
e durante o projeto o vs code nao acusou erro na conclusao
