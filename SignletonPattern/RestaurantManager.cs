namespace SignletonPattern;

public class RestaurantManager:IManageResturant
{
    private static RestaurantManager _instance;
    public RestaurantManager()
    {


    }

    public static RestaurantManager GetInstance() {

        if (_instance == null)
        {
            _instance = new RestaurantManager();
        }

        return _instance;

    }

    public void ManageRestaurant()
    {
        Console.WriteLine("Managing restaurant...");
    }
}
