using System;
using System.Linq;
using System.Collections.Generic;

public class AuthenticationManager
{
    private List<User> users;

    public AuthenticationManager()
    {
        users = new List<User>();
        // Здесь можно добавить начальных пользователей
        users.Add(new User { Username = "admin", Password = "admin" });
    }

    public bool Authenticate(string username, string password)
    {
        // Поиск пользователя по имени пользователя и паролю
        User user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

        // Если пользователь найден, возвращаем true, иначе false
        return user != null;
    }
}
