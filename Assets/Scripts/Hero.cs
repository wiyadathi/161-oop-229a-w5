using UnityEngine;

public class Hero : Character
{
    private int gold;
    public int Gold { 
        get { return gold; } 
        set 
        {
            if (value > 999) { gold = 999; }
            else if (value <= 0) { gold = 0; }
            else { gold = value; }
        } 
    }

    //Constructor to create an object
    public override void Init(string newName, int newHp, int newAttackPower)
    {
        base.Init(newName, newHp, newAttackPower); 
        Gold = 0;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Hero Gold : {Gold}");
    }

    public void EarnGold(int amount) 
    {
        if (amount > 0)
        {
            Gold += amount;
        }
     }
}
