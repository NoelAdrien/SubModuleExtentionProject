using System;

namespace SubModuleExtentionSln
{
  public class Customer
  {
    public int Tune { get; set; }
    public int GetTune()
    {
      return this.Tune + 100;
    }
  }
}
