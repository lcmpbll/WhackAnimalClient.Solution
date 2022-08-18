using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WhackAnimals.Models
{
  public class Fact
  {
    public int FactId { get; set; }
    public string AnimalType { get; set; }
    public string Species { get; set; }
    public string Description { get; set; }
    public string Nsfw { get; set; }
    public string ImageUrl { get; set; }
    //public string FoundSpecies { get { return Description.Contains(Species);} }
    public string Question {get { return Description.ToUpper().Replace(Species.ToUpper(), "___________");}}
    public string Answer { get; set; }
    public bool Check { get { return Species.ToUpper().Contains(Answer.ToUpper());}}
    
    public static List<Fact> GetFacts()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      
      // JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      // List<Fact> factList = JsonConvert.DeserializeObject<List<Fact>>(jsonResponse.ToString());
      
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Fact> factList = JsonConvert.DeserializeObject<List<Fact>>(jsonResponse.ToString());
      
      return factList;
    }
    
    public static Fact GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;
      
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Fact fact = JsonConvert.DeserializeObject<Fact>(jsonResponse.ToString());
      
      return fact;
    }
    
    // public static List<Fact> GetBingo(allFacts)
    // {
    //   var random = new Random();
    //   for( int i = 0; i <= 24; i ++)
    //   {
    //     int
    //   }
    // }
    
    
  }
}