
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Controllers;

using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Databases;
public class DatabaseContext
{
    public IEnumerable<Product> products { get; }

    public DatabaseContext()
    {
        products = [
            new Product(1,3333,"bag", "pic1", 44.5),
             new Product(2,4444,"purse", "pic2", 44.5),
             new Product(3,5555,"shirt", "pic3", 44.5),

            users = [
                new User( "Aishah", "AlSaud" , "123456" , "Aishah@gmail.com", "0544444444"),
                new User(  "Renad", "AlZahrani", "654321",  "Renad@gmail.com" ,"0533333344"),
                new User( "Raneem", "AlMutairi", "098765", "Raneem@gmail.com", "0555555544"),
                new User( "Bashayer", "AlWahbi", "567890", "Bashayer@gmail.com", "0566666644"), 
                
            ];
        }
    }
