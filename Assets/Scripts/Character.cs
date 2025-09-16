using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //Attributes
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknown Hero"; }
            else { name = value; }
        }
    }

    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else health = 0;
        }
    }

    public int AttackPower { get; set; }

    //Constructor to create an object
    public virtual void Init(string newName, int newHp, int newAttackPower)
    {
        Name = newName;
        Health = newHp;
        AttackPower = newAttackPower;
    }

    //Methods
    public virtual void ShowStat()
    {
        Debug.Log($"Character name: {Name} | Health: {Health} | Attack Power: {AttackPower}");
    }

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
    }

    public void Attack(Monster target)
    {
        Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }

    public bool IsAlive() { return Health > 0; }
}
