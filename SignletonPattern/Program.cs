using SignletonPattern;

internal class Program
{
    private static void Main(string[] args)
    {
       IManageResturant instanc = RestaurantManager.GetInstance();

        instanc.ManageRestaurant();
    }
}