﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produtos(Nome, Descricao, Preco,ImagemUrl, Estoque, DataCadastro, CategoriaId) Values('Coca-cola','Refrigerante de Cola 350 ml',5.45,'cocacola.jpg', 50, GETDATE(), 1)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
