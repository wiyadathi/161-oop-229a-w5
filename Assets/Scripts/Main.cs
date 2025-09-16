using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    //private List<Monster> monsters = new List<Monster>();

    public Hero hero;
    public List<Monster> monsterPrefabs;

    public Monster currentMonster;

    public List<Monster> monsters = new List<Monster>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hero.Init("The Knight", 20, 10);
        hero.ShowStat();

        //-------- Spawn Dragon --------
        //Spawn monster game object from prefab
        currentMonster = Instantiate(monsterPrefabs[0]);

        //Initialization
        currentMonster.Init("Dragon", 200, 15, 100);

        //Add monster to list
        monsters.Add(currentMonster);

        //------------------------------


        //-------- Spawn Goblin --------
        //Spawn monster game object from prefab
        currentMonster = Instantiate(monsterPrefabs[1]);

        //Initialization
        currentMonster.Init("Goblin", 10, 3, 5);

        //Add monster to list
        monsters.Add(currentMonster);


        //------------------------------


        //-------- Spawn Orc --------
        //Spawn monster game object from prefab
        currentMonster = Instantiate(monsterPrefabs[2]);

        //Initialization
        currentMonster.Init("Orc", 50, 10, 15);


        //Add monster to list
        monsters.Add(currentMonster);

        //------------------------------


        //Show Stats
        foreach (var monster in monsters)
        {
            monster.ShowStat();
        }
   



        /*
        //Create Hero
        Hero hero = new Hero("The Knight", 20, 15);

        //Create Monster
        Monster monster = new Monster("Orc", 20, 5, 15);
        Monster monster2 = new Monster("Goblin", 15, 4, 10);
        Monster monster3 = new Monster("Dragon", 300, 30, 100);

        monsters.Add(monster);
        monsters.Add(monster2);
        monsters.Add(monster3);
        monsters.Add(new Monster("Evil King", 20, 10, 30)); // Add Instantly

        //Show Hero Stasts
        //Debug.Log($"Hero name: {hero.Name} | Hero Health: {hero.Health} | Hero gold: {hero.Gold}");
        hero.ShowStat();

        //Show Monster Stats
        foreach (var m in monsters)
        {
            //Debug.Log($"Monster Name: {m.Name} | Monster Health: {m.Health}");
            m.ShowStat();
        }

        //Player Attack
        monster2.ShowStat();

        hero.Attack(monster2);

        monster2.ShowStat();

        //Monster Attack
        hero.ShowStat();

        monster.Attack(hero);

        hero.ShowStat();
        */
    }

}
