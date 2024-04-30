using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Databases;

    public class DatabaseContext
    {
        public List<User> users;
        public DatabaseContext()
        {
            users = [
                new User( "Aishah", "AlSaud" , "123456" , "Aishah@gmail.com", "0544444444"),
                new User(  "Renad", "AlZahrani", "654321",  "Renad@gmail.com" ,"0533333344"),
                new User( "Raneem", "AlMutairi", "098765", "Raneem@gmail.com", "0555555544"),
                new User( "Bashayer", "AlWahbi", "567890", "Bashayer@gmail.com", "0566666644"), 
                
            ];
        }
    }
