using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    [Migration(2)]
    public class _2_CreateEmployee : Migration
    {
        public override void Down()
        {
            Delete.ForeignKey("DepartmentId");    
            Delete.Table("Employee");
        }

        public override void Up()
        {
            Create.Table("Employee")
                .WithColumn("Id").AsInt32().PrimaryKey().NotNullable().Indexed().Identity()
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("LastName").AsAnsiString(50).NotNullable()
                .WithColumn("DepartmentId").AsInt32().ForeignKey("DepartmentId", "Department", "Id");
                
        }
    }
}
