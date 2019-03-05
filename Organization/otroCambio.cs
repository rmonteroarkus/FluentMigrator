using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    [Migration(4)]
    public class otroCambio : Migration
    {
        public override void Down()
        {
            Delete.Table("Department");
        }

        public override void Up()
        {
            Alter.Table("Department")
                .AddColumn("AnotherColumn2").AsString().NotNullable();


        }
    }
}
