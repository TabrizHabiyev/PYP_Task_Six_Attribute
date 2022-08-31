using ConsoleApp5.models;

List<User> users = new List<User>();

User userEntity = new User() { Email = "tabriz@mail.com", Name = "Tabriz", Password = "Tabriz321" };

void addToEntityToList(User user)
{
    if (ModelState.IsValid(user))
    {
        users.Add(user);
    }
    else
    {
        Console.WriteLine("Invalid Model");
    }

}

addToEntityToList(userEntity);