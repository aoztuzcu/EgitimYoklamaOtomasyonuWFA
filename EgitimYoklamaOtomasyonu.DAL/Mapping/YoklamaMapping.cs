using EgitimYoklamaOtomasyonu.DAL.Mapping.Base;
using EgitimYoklamaOtomasyonu.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.DAL.Mapping
{
    public class YoklamaMapping : BaseMapping<Yoklama> , IEntityTypeConfiguration<Yoklama>
    {
    }
}
