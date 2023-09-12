using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.Data.Entities.Base
{
    public abstract class BaseEntitiy
    {
    }
    public class BaseEntity<TKey> : BaseEntitiy
    {
        public TKey Id { get; set; }
    }
    public class FullAudit<TKey> : BaseEntity<int>
    {
        public bool SilindiMi { get; set; } = false;
        public TKey SilenId { get; set; }
        public DateTime YaratilmaZamani { get; set; }
        public TKey YaraticiId { get; set; }
    }
}
