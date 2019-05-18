CREATE DATABASE biblioteca;
USE biblioteca;
   CREATE TABLE CadastroAdm(
    id_adm INT PRIMARY KEY AUTO_INCREMENT,
    login_adm varchar(5),
    senha_adm varchar(4));
    INSERT INTO CadastroAdm values (0.1,'Nayla', '1234'),(0.2,'Tamar','4321'),(0.3,'Nathi','1111');
    
     CREATE  TABLE cadastroAluno(
    id_alunos INT PRIMARY KEY AUTO_INCREMENT,
    nome_aluno varchar(60),
    curso varchar(14),
    periodo varchar(100),
    semestre varchar(50),
    nomeLivro varchar(100),
	telefoneCel varchar(14),
    email varchar(70));
    alter table cadastroAluno modify
 curso varchar(60);
    CREATE TABLE  cadastrolivro(
    id_livro INT PRIMARY KEY AUTO_INCREMENT,
    nomeLivro varchar(100),
    nomeAutor varchar(120),
    editora varchar (120),
    generoLivro varchar(100),
    qntdLivros int
    );
    select * from cadastrolivro;
    select * from CadastroAdm;
    select*from cadastroAluno;