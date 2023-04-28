using CoreShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreShop.DataAccess.Concrete.EFCore
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            var context = new Context();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategory);
                }
                context.SaveChanges();
            }
        }

        private static Category[] Categories =
        {
            new Category(){Name="OTURMA ODASI"},
            new Category(){Name="KOLTUK TAKIMLARI"},
            new Category(){Name="KÖŞE TAKIMLARI"},
            new Category(){Name="KANEPE/KOLTUK"},
            new Category(){Name="BERJER"},
            new Category(){Name="TV KOLTUKLARI"},
            new Category(){Name="TV ÜNİTESİ"},
            new Category(){Name="YEMEK ODASI"},
            new Category(){Name="YEMEK ODASI TAKIMLARI"},
            new Category(){Name="MUTFAK MASA TAKIMLARI"},
            new Category(){Name="KONSOL"},
            new Category(){Name="KONSOL AYNASI"},
            new Category(){Name="VİTRİN"},
            new Category(){Name="GÜMÜŞLÜK"},
            new Category(){Name="YEMEK MASASI"},
            new Category(){Name="SANDALYE"},
            new Category(){Name="YATAK ODASI"},
            new Category(){Name="YATAK ODASI TAKIMLARI"},
            new Category(){Name="DOLAP"},
            new Category(){Name="ŞİFONYER"},
            new Category(){Name="KOMODİN"},
            new Category(){Name="KOMODİN"},
            new Category(){Name="MAKYAJ MASASI"},
            new Category(){Name="MAKYAJ AYNASI"},
            new Category(){Name="KARYOLA"},
            new Category(){Name="KARYOLA BAŞLIKLARI"},
            new Category(){Name="YATAK VE BAZA"},
            new Category(){Name="YATAK"},
            new Category(){Name="BAZA"},
            new Category(){Name="BAŞLIK"},
            new Category(){Name="ÇOCUK VE GENÇ ODASI"},
            new Category(){Name="GENÇ ODASI TAKIMLARI"},
            new Category(){Name="BEBEK ODASI TAKIMLARI"},
            new Category(){Name="GENÇ ODASI DOLAP"},
            new Category(){Name="GENÇ ODASI ŞİFONYER"},
            new Category(){Name="KİTAPLIK"},
            new Category(){Name="GENÇ ODASI KOMODİN"},
            new Category(){Name="GENÇ ODASI BAŞLIK"},
            new Category(){Name="GENÇ ODASI KARYOLA"},
            new Category(){Name="RANZA"},
            new Category(){Name="ÇALIŞMA MASASI"},
            new Category(){Name="GENÇ ODASI SANDALYESİ"},
            new Category(){Name="BEŞİK"},
            new Category(){Name="BAHÇE MOBİLYASI"},
            new Category(){Name="MİNİ TAKIMLAR"},
            new Category(){Name="BAHÇE MASA TAKIMLARI"},
            new Category(){Name="BAHÇE KÖŞE TAKIMLARI"},
            new Category(){Name="SALINCAKLAR"},
            new Category(){Name="BAHÇE MASALARI"},
            new Category(){Name="BAHÇE SEHPALARI"},
            new Category(){Name="BAHÇE KOLTUKLARI"},
            new Category(){Name="DEKORATİF ÜRÜNLER"},
            new Category(){Name="PORTMANTO"},
            new Category(){Name="DRESUAR"},
            new Category(){Name="ORTA SEHPA"},
            new Category(){Name="ZİGON SEHPA"},
            new Category(){Name="YAN SEHPA"},
            new Category(){Name="TV SEHPASI"},

        };

        private static Product[] Products =
        {
             new Product(){Name="Ürün1",Description="Koltuk Takımları",Price=10000,Images={ new Image() {ImageUrl="a1.png"},new Image() {ImageUrl="a2.png"},new Image() { ImageUrl="a3.png"}, new Image() { ImageUrl = "a4.png" }, new Image() { ImageUrl = "a5.png" }, new Image() { ImageUrl = "a6.png" }, new Image() { ImageUrl = "a7.png" }, new Image() { ImageUrl = "a8.png" }} },
             new Product(){Name="Ürün2",Description="Koltuk Takımları",Price=10000,Images={ new Image() {ImageUrl="b1.png"},new Image() {ImageUrl="b2.png"},new Image() { ImageUrl="b3.png"}, new Image() { ImageUrl = "b4.png" }, new Image() { ImageUrl = "b5.png" }, new Image() { ImageUrl = "b6.png" }, new Image() { ImageUrl = "b7.png" }, new Image() { ImageUrl = "b8.png" }} },
             new Product(){Name="Ürün3",Description="Koltuk Takımları",Price=10000,Images={ new Image() {ImageUrl="c1.png"},new Image() {ImageUrl="c2.png"},new Image() { ImageUrl="c3.png"}, new Image() { ImageUrl = "c4.png" }, new Image() { ImageUrl = "c5.png" }, new Image() { ImageUrl = "c6.png" }, new Image() { ImageUrl = "c7.png" }, new Image() { ImageUrl = "c8.png" }} },
             new Product(){Name="Ürün4",Description="Koltuk Takımları",Price=10000,Images={ new Image() {ImageUrl="d1.png"},new Image() {ImageUrl="d2.png"},new Image() { ImageUrl="d3.png"}, new Image() { ImageUrl = "d4.png" }, new Image() { ImageUrl = "d5.png" }, new Image() { ImageUrl = "d6.png" }, new Image() { ImageUrl = "d7.png" }, new Image() { ImageUrl = "d8.png" }} },
             new Product(){Name="Ürün5",Description="Koltuk Takımları",Price=10000,Images={ new Image() {ImageUrl="e1.png"},new Image() {ImageUrl="e2.png"},new Image() { ImageUrl="e3.png"}, new Image() { ImageUrl = "e4.png" }, new Image() { ImageUrl = "e5.png" }, new Image() { ImageUrl = "e6.png" }, new Image() { ImageUrl = "e7.png" }, new Image() { ImageUrl = "e8.png" }} },
             new Product(){Name="Ürün6",Description="Koltuk Takımları",Price=10000,Images={ new Image() {ImageUrl="f1.png"},new Image() {ImageUrl="f2.png"},new Image() { ImageUrl="f3.png"}, new Image() { ImageUrl = "f4.png" }, new Image() { ImageUrl = "f5.png" }, new Image() { ImageUrl = "f6.png" }, new Image() { ImageUrl = "f7.png" }, new Image() { ImageUrl = "f8.png" }} },


        };

        private static ProductCategory[] ProductCategory =
        {
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[0],Category=Categories[1]},
            new ProductCategory(){Product=Products[1],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[2]},
            new ProductCategory(){Product=Products[2],Category=Categories[0]},
            new ProductCategory(){Product=Products[2],Category=Categories[3]},
            new ProductCategory(){Product=Products[3],Category=Categories[0]},
            new ProductCategory(){Product=Products[3],Category=Categories[4]},
            new ProductCategory(){Product=Products[4],Category=Categories[0]},
            new ProductCategory(){Product=Products[4],Category=Categories[5]},
            new ProductCategory(){Product=Products[5],Category=Categories[0]},
            new ProductCategory(){Product=Products[5],Category=Categories[6]},
        };
    }

}

