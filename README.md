# Grupo 32 

## 🎯 Objetivo do Projeto

Este projeto foi desenvolvido utilizando os conhecimentos adquiridos na Fase 1 do curso da PÓS-TECH. O objetivo inicial é gerenciar o CRUD de usuários e jogos de forma modular, preparando a base para que o projeto final se torne uma solução para a FIAP Cloud Games (FCG).

## ✅ Testes

### (/test/FIAP.FCG.Tests.Unit)
Foram implementados **testes unitários específicos para as regras de negócio do CRUD de usuários**, além de validações relacionadas à autenticação.

## 🧪 BDD com SpecFlow (Reqnroll)

### (/test/FIAP.FCG.Tests.BDD)
Foi adotado o **Behavior-Driven Development (BDD)** utilizando a ferramenta **Reqnroll (SpecFlow)**, com foco no módulo de **Usuário**:

Os testes foram descritos utilizando a linguagem **Gherkin**, possibilitando o entendimento de todas as áreas envolvidas no projeto.

---
## 🧑‍💻 Usabilidade

> [!IMPORTANT]
> A configuração do appsettings.json será enviada junto ao PDF entregue na plataforma


### 🔐 Autenticação (Login)

Para acessar os endpoints protegidos da API, é necessário realizar login utilizando o seguinte endpoint:
```
POST /Auth/Login

{
  "username": "Admin",
  "password": "4Dm1n@Fiap"
}
```
Esse usuário possuí nível de acesso 'Admin' para relializar o CRUD de usuários e jogos

---


## 👥 Integrante

- **Felipe da Silva Fonseca Trosi** – *Discord:* `FelipeT (felipet9311)`

## 📄 Documentação

- [Event Storming](https://miro.com/app/board/uXjVJaedclw=/?share_link_id=660958015842)

## 💻 Repositório

- [github.com/FelipeTrosi](https://github.com/FelipeTrosi/FIAP.FCG)


