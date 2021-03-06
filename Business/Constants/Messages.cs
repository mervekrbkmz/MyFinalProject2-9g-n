using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
  public static class Messages //sürekli newlememek için messages static verdik sabitledik yani.
    {
        public static string ProductAdded = "ÜRÜN EKLENDİ";
        public static string ProductNameInValid = "Ürün İsmi Geçersiz";
        internal static List<Product> MaintenanceTime;
        internal static string ProductsListed;
    }
}
