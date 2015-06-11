using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using VisualStudioCode.WebAPI.Models;

namespace VisualStudioCode.WebAPI.Migrations
{
    [ContextType(typeof(SalesDbContext))]
    partial class initialMigration
    {
        public override string Id
        {
            get { return "20150604002938_initialMigration"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta4-12943"; }
        }
        
        public override IModel Target
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Sequence");
                
                builder.Entity("VisualStudioCode.WebAPI.Models.Code", b =>
                    {
                        b.Property<string>("Display")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1)
                            .Annotation("SqlServer:ValueGeneration", "Identity");
                        b.Property<string>("Value")
                            .Annotation("OriginalValueIndex", 2);
                        b.Key("Id");
                    });
                
                builder.Entity("VisualStudioCode.WebAPI.Models.Product", b =>
                    {
                        b.Property<string>("Category")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1)
                            .Annotation("SqlServer:ValueGeneration", "Identity");
                        b.Property<string>("Name")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<decimal>("Price")
                            .Annotation("OriginalValueIndex", 3);
                        b.Key("Id");
                    });
                
                return builder.Model;
            }
        }
    }
}
