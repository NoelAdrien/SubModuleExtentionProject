using System;

namespace SubModuleExtentionSln
{
  public class Customer
  {
    public int Tune { get; set; }
    public int GetTune(int multiplicateur)
    {
      return this.Tune * multiplicateur;
    }
  }
}
