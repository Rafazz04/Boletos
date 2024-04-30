# BOLETOS

<p align="center">
<img src="http://img.shields.io/static/v1?label=STATUS&message=CONCLUIDO&color=GREEN&style=for-the-badge"/>
</p>

## 📁 Acesso ao projeto

Fazer o clone do projeto com o comando: git clone https://github.com/Rafazz04/Boletos.git

## 🛠️ Pré requisitos (Para usar as funcionalidades da API)
**-Ter o Visual Studio Baixado ou VsCode**<br>
**-Ter o Postgres baixado**<br>

## 🛠️ Abrir e rodar o projeto
**-Abra a pasta BoletosCrud**<br>
**-Abra a solução do projeto BoletosCrud.sln (Isso pelo Visual Studio)**<br>
**-Se estiver pelo VsCode abra o CMD, vá até o caminho em que fez o clone, entre na pasta Locadora crud e digite code**<br>
**-Vá até a aba PowerShell do desenvolvedor e rode o comando dotnet ef migrations add CricaoDatabase // Depois desse comando rode dotnet ef database update CricaoDatabase**<br>
**-Abra o arquivo appsettings.json. e verifique a DefaultConnection, esses são seus dados para acessar o postgres**<br>
**-Com o projeto aberto abra o powershell, vá até a pasta com o arquivo BoletosCrud.csproj e execute o comando dotnet watch run**<br>

## 🔨 Funcionalidades do projeto
-``Crição de Boletos e bancos:`` Post<br>
-``Listar todos os bancos:`` Get<br>
-``Lista um únic banco ou boleto especificados:`` GetById()<br>


## ✔️ Técnicas e Tecnologias utilizadas

- ``.Net 6.0``
- ``Enity Framework``
- ``Postgres``
- ``Injeção de dependência``
- ``Repository Pattern``
- ``IoC``
- ``Integração do Back end, e DataBase``
