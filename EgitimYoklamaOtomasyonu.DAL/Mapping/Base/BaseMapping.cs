using EgitimYoklamaOtomasyonu.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.DAL.Mapping.Base
{
    public abstract class BaseMapping<TEntity> where TEntity : class 
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasQueryFilter(e => EF.Property<bool>(e, "SilindiMi") == false);
        }
    }
}
