using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    [Migration(1)]
    public class _1_CreateDepartment : Migration
    {
        public override void Down()
        {
            Delete.Table("Department");
        }

        public override void Up()
        {
            Create.Table("Department")
                .WithColumn("Id").AsInt32().PrimaryKey().NotNullable().Indexed().Identity()
                .WithColumn("Name").AsString(250).NotNullable();

        }
    }
}
