using EgitimYoklamaOtomasyonu.DAL.Repository;
using EgitimYoklamaOtomasyonu.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.BLL.Interface
{
    public interface IOgrenciServis 
    {
        public int OgrenciSayisiGetir();
        public int OgrenciSayisiGetir(int subeId);
    }
}
