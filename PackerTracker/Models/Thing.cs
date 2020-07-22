using System;
using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Thing
  {
    public string Name { get; set;}
    public int Id { get; }
    public static Dictionary<string, string> Instances = new Dictionary<string, string>() { {"name", ""}, {"weight", ""} , {"manufacturer", ""} , {"packed", ""} , {"purchased", ""} } {get; set;}
    
    
    public Thing(string name)
    {
      Name = name;
      // _instances.Add(this);
      Id = _instances.Count;
    }
    public Thing(string weight, string manufacturer, string packed, string purchased)
      : this(name)
    {
      Weight = weight;
      Manufacturer = manufacturer;
      Packed = packed;
      Purchased = purchased;
    }
    
    // public static Dictionary<Thing> AddToDictionary()
    // {
      
    // }
    public static Dictionary<String, String> GetAll()
    {
      return _instances["name"];
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Thing Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
