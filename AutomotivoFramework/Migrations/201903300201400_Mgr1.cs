namespace AutomotivoFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mgr1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tapetes",
                c => new
                    {
                        TapeteId = c.Int(nullable: false, identity: true),
                        IndicaTapeteBorracha = c.Boolean(nullable: false),
                        Cor = c.String(),
                    })
                .PrimaryKey(t => t.TapeteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tapetes");
        }
    }
}
