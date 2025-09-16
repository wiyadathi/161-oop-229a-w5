using UnityEngine;

public class Monster : Character
{
    //Attributes
    private int lootReward;
    public int LootReward 
    { 
        get { return lootReward; } 
        set 
        { 
            if (value < 0) { lootReward = 0; }
            else { lootReward = value; }
        } 
    }

    private bool defeated = false;

    //Constructor
    public void Init(string newName, int newHP, int newAttackPower, int newLootReward)
    {
        base.Init(newName, newHP, newAttackPower);  
        LootReward = newLootReward;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Monster Loot : {lootReward}");
    }

    public int DropReward()
    {
        return LootReward;
    }
}
