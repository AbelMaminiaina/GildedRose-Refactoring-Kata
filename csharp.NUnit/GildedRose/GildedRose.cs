using System.Collections.Generic;                      
using GildedRoseKata.Strategies;                         
                                                          
namespace GildedRoseKata;                              
                                                          
public class GildedRose                                
{                                                      
    IList<Item> Items;                                 
                                                        
    public GildedRose(IList<Item> Items)               
    {                                                  
        this.Items = Items;                            
    }                                                  
                                                        
    public void UpdateQuality()                        
    {                                                  
        foreach (var item in Items)                    
        {                                              
            var updater =                              
            ItemStrategyFactory.Create(item);                       
            updater.Update(item);                      
        }                                              
    } 
}  