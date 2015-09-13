using OrnekKod.Models.Veri.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OrnekKod.Models.Veri.Context
{
    public class KodDBContext:DbContext{



        public KodDBContext() {

         Database.Connection.ConnectionString = "server=TUGBAPC; database=ornek; Trusted_Connection=true;";
          
        }

        
        public DbSet <Product> Products { get; set; }
         public void ekle()
        {
            KodDBContext entity = new KodDBContext();

            Product product1 = new Product() { Name = "kalem",  DisplayOrder = "yes" };
            Product product2 = new Product() { Name = "silgi",  DisplayOrder = "yes"  };
            Product product3 = new Product() { Name = "defter", DisplayOrder = "yes" };
            Product product4 = new Product() { Name = "çanta",  DisplayOrder = "yes" };

            entity.Products.Add(product1);
            entity.Products.Add(product2);
            entity.Products.Add(product3);
            entity.Products.Add(product4);
            entity.SaveChanges();

        }

          
              
       

            
    
  
        
        
        }

    }


           
    
     


