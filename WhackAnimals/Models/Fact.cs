using System.Collections.Generic;
using System;
using NewtonSoft.Json;
using NewtwonSoft.Json.Linq;

namespace WhackAnimalClient.Models
{
  public class Fact
  {
    public int FactId { get; set; }
    public string AnimalType { get; set; }
    public string Species { get; set; }
    public string Description { get; set; }
    public string Nsfw { get; set; }
    
    public static Array<Fact> GetFacts()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Fact> factList = JsonConvert.DeserializeObject<List<Fact>>(jsonResponse.ToString());
      //Can be changed to list, to array may need a different method.
      return factList;
    }
    
    public static Fact GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;
      
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Fact fact =JsonConvert.DserializeObject<Fact>(jsonResponse.ToString());
      
      return fact;
    }
    
    
  }
}