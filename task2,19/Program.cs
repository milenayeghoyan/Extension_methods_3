/*// Day1-Task 2 
List<Person> person = new List<Person>()
{
    new Person(){Age=10,Name="Armine"},
    new Person(){Age=20,Name="John"},
    new Person(){Age=30,Name="Tatev"}

};
 var person1 =person.SortByPropertyDescending<Person,string>(p =>  p.Name);
Console.ReadLine();
    public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
public static class ListExtension
{
    public static List<T> SortByPropertyDescending<T, TKey>(this List<T> list, Func<T, TKey> propertySelector)
    {
        return list.OrderByDescending(propertySelector).ToList();
    }

}
*/


/*//Day1- Task 19 -
using System.Security.Cryptography.X509Certificates;

GeoLocation geoLocation = new GeoLocation(50.12545, 30.25845);
List<CellTower> cellTower = new List<CellTower>()
{
    new CellTower(){Latitude =40.2547,Longitude=60.2548, Name=" Monopole Tower" },
    new CellTower(){Latitude =20.2456,Longitude=40.5419, Name="Lattice tower" },
    new CellTower(){Latitude =30.2543,Longitude=40.2544, Name="Guyed Tower" },
    new CellTower(){Latitude =52.2544,Longitude=60.2575, Name="Stealth Tower" }
};

CellTower celltower=geoLocation.FindNearestTower(cellTower);
Console.WriteLine(celltower.Name);


public class GeoLocation
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public GeoLocation(double latitude, double longitude)
    {
        Latitude=latitude;
        Longitude=longitude;
    }

}
public class CellTower 
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Name { get; set; }
}

public static class GeoLocationExtension
{
    public static CellTower FindNearestTower(this GeoLocation  geoLocation,List<CellTower> cellTower) 
    {
        static double CalculateDistance(double Latitude1, double Longitude1, double Latitude2,
                               double Longitude2) // √ (x 2 - x 1 ) 2 + (y 2 - y 1 ) 2
        {
           return Math.Sqrt(Math.Pow((Latitude2- Latitude2), 2) + Math.Pow((Longitude2- Longitude2), 2)); 

           
        }
        if (cellTower == null)
        {
            throw new ArgumentNullException();
        }
        double minDistance = double.MaxValue;
        CellTower nearestTower=null;

        foreach (var item in cellTower)
        {
            double distance = CalculateDistance(geoLocation.Latitude, geoLocation.Longitude, item.Latitude, item.Longitude);
            if (distance < minDistance)
            {
                minDistance = distance;
                nearestTower = item;
            }
        }

        return nearestTower;
    }

}
*/
