using System.Collections.Generic;

namespace Places.Objects
{
    public class Place
    {
      private string _city;
      private string _state;
      private int _year;
      private int _id;
      private static List<Place> _placeList = new List<Place> {};

      public Place(string city, string state, int year)
      {
        _city = city;
        _state = state;
        _year = year;
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
      public string GetState()
      {
        return _state;
      }
      public void SetState(string newState)
      {
        _state = newState;
      }
      public int GetYear()
      {
        return _year;
      }
      public void SetYear(int newYear)
      {
        _year = newYear;
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
