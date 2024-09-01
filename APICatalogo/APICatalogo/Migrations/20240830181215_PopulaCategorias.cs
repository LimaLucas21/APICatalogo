using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categoria(Nome, ImagemUrl) Values('Bebidas','Bebidas.jpg')");
            mb.Sql("Insert into Categoria(Nome, ImagemUrl) Values('Lanches','Lanches.jpg')");
            mb.Sql("Insert into Categoria(Nome, ImagemUrl) Values('Sobremesas','Sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categoria");
        }
    }
}
