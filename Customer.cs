
using System.Collections.Generic;

public class Customer{
    private string _name;
    private string _id;
    public string Name{ 
        get
    {
        return this._name;
    }
    
     }
    public string Id{ 
        get
    {
        return this._id;
    }
    
     }

     public List<Order> OrderList = new List<Order>();
     

      public Customer(string id,string Name )
     {
       this._id= id;
       this._name= Name;

     }

}