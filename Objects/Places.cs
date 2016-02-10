using System.Collections.Generic;

namespace Places.Objects
{
    public class Place
    {
      private string _city;
      private int _id;
      private static List<Place> _placeList = new List<Place> {};

      public Place(string city)
      {
        _city = city;
        _placeList.Add(this);
        _id = _placeList.Count;
      }
      public string GetCity()
      {
        return _city;
      }
      public void SetCity(string newCity)
      {
        _city = newCity;
      }
      public int GetId()
      {
        return _id;
      }
      public static List<Place> GetAll()
      {
        return _placeList;
      }
      public static Place Find(int searchId)
      {
        return _placeList[searchId-1];
      }
    }
}
