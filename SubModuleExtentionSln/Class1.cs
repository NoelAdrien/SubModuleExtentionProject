using System;

namespace SubModuleExtentionSln
{
  public class Customer
  {
    public int Age { get; set; }
    public int GetAge (int multiplicateur)
    {
      return this.Age * multiplicateur;
    }
  }
}
