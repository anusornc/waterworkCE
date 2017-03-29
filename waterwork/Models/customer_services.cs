using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace waterwork.Models
{
    public class customer_services
    {
        [Key]
        public Guid Uid { get; set; }
        [Display(Name = "���ʼ����ҹ")]
        [Required]
        [ForeignKey("customer")]
        public Guid customer_id { get; set; }
        [Display(Name = "�Ţ�����")]
        public int meter_id { get; set; }
        [Display(Name = "�ѹ������ҹ")]
        public DateTime service_date { get; set; }
        [Display(Name = "��ҹ�Ţ���")]
        [Required]
        public string house_id { get; set; }
        [Display(Name = "�������")]
        [Required]
        public string village_id { get; set; }
        [Display(Name = "�Ӻ�")]
        [Required]
        public string place { get; set; }
        [Display(Name = "�����")]
        [Required]
        public string amphur { get; set; }
        [Display(Name = "�ѧ��Ѵ")]
        [Required]
        public string province { get; set; }
        public Status status { get; set; }
        public virtual customers customer { get; set; }
        public enum Status { Wait = 0, ready = 1 }
        public static IEnumerable Getcustomer_services()
        {
            AssetDbContext Context = new AssetDbContext();
            return Context.customer_services.ToList();
        }
        public static void Insertcustomer_services(customer_services item)
        {
            AssetDbContext Context = new AssetDbContext();
            if (item != null)
            {
                item.Uid = Guid.NewGuid();
                Context.customer_services.Add(item);
                Context.SaveChanges();
            }
        }
    }
}