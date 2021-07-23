using System;
using System.Collections.Generic;

namespace MyCodesFolder
{
class Wizard
{
  public string name;
  public string faverateSpell;
  public int spellSlots;
  public float exp;

  public void CastSpell()
  {
    if (spellSlots > 0)
    {
      Console.WriteLine(name + " casts: " + faverateSpell);
      spellSlots--;
      exp += 0.3f;
    }else
    {
      Console.WriteLine(name + " is out of spells.");
    }
    
  }

  public void Regan()
  {
    Console.WriteLine(name + " is regaining his spells now");
    spellSlots = 2;
  }

}



  class Program
  {
    static void Main(string[] args)
    {
      Wizard wizard01 = new Wizard();

      wizard01.name = "Jeff";
      wizard01.faverateSpell = "FireBall";
      wizard01.spellSlots = 2;
      wizard01.exp = 0f;


      wizard01.CastSpell();
      wizard01.CastSpell();
      wizard01.CastSpell();

      wizard01.Regan();

      wizard01.CastSpell();
      wizard01.CastSpell();
      


      Console.WriteLine("Spell slots: " + wizard01.spellSlots + "\n exp is: " + wizard01.exp);

     
      // Wait before closing
      Console.ReadKey();
    }
  }
}