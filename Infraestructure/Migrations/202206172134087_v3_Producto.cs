namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class v3_Producto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productoes",
                c => new
                {
                    productoID = c.Int(nullable: false, identity: true),
                    nombre = c.String(),
                    descripcion = c.String(),
                    fechaCreacion = c.DateTime(nullable: false),
                    fechaVencimiento = c.DateTime(nullable: false),
                    IsEnable = c.Boolean(nullable: false),
                    precioVenta = c.Int(nullable: false),
                    igv = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.productoID);

        }

        public override void Down()
        {
            DropTable("dbo.Productoes");
        }
    }
}
