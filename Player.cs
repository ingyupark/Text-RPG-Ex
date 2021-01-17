using System;
using System.Collections.Generic;

public abstract class  Player
{
    protected Player(int HP,int attack,int Defence,Player_Job p_job)
    {
        P_stat.HP = HP;
        P_stat.attack = attack;
        P_stat.Defence = Defence;
        GameManager.instance.data.Player_gold = 100;
        this.p_job = p_job;
    }
    protected Stat S_stat = new Stat();
    public Stat P_stat {get{return S_stat;}}
    public Player_Job p_job {get; private set;}
    public abstract void Init();

}

public class Knight : Player
{
    public Knight() : base(100,10,5,Player_Job.Knight)
    {

    }
    public override void Init()
    {
        
    }



}

public class Mage : Player
{

    public Mage(int MP) : base(80,15,3,Player_Job.Mage)
    {
        S_stat.Mage_MP = MP;
    }
    public override void Init()
    {

    }



}