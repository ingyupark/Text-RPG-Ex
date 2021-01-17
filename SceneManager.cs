using System;
using System.Collections.Generic;

public class SceneManager
{
    private Scene_Mode s_mode = Scene_Mode.None;
    public void Init(Player player)
    {
        Checked_Jop();
        Login();
    }
    
    private void Checked_Jop()
    {
        if(GameManager.player != null)
        {
            Console.WriteLine("You has job!");
            Console.WriteLine($"Your job is {GameManager.player.p_job.ToString()}");
            Console.WriteLine("You want New Job? [1]Yes [2]No");
            int New_job = Convert.ToInt32(Console.ReadLine());
            switch(New_job)
            {
                case 1:
                GameManager.instance.s_player = null;
                Login();
                break;
                case 2:
                Lobby();
                break;
                default:
                Console.WriteLine("Plz Choise [1] or [2]");      
                Checked_Jop();
                break;
            }
        }
        else
            Login();
    }
    public void Login()
    {
        s_mode = Scene_Mode.Login;
        Console.WriteLine("Game First Login!");
        Console.WriteLine("You Choise Your Job");
        Console.WriteLine("[1]Knight [2]Mage [3]Exit");

        int Choise = Convert.ToInt32(Console.ReadLine());
        
        switch(Choise)
        {
            case 1:
            GameManager.instance.s_player = new Knight();
            Console.WriteLine($"Your Choise is {GameManager.player.p_job.ToString()}");
            Console.WriteLine($"Your Stat is \nHP : {GameManager.player.P_stat.HP}\nattack : {GameManager.player.P_stat.attack}\nDefence : {GameManager.player.P_stat.Defence}");
            Lobby();
            break;

            case 2:
            GameManager.instance.s_player = new Mage(50);
            Console.WriteLine($"Your Choise is {GameManager.player.p_job.ToString()}");
            Console.WriteLine($"Your Stat is \nHP : {GameManager.player.P_stat.HP}\nMP : {GameManager.player.P_stat.Mage_MP}\nattack : {GameManager.player.P_stat.attack}\nDefence : {GameManager.player.P_stat.Defence}");
            Lobby();
            break;

            case 3:
            Console.WriteLine($"Good Bye!");
            break;

            default:
            Console.WriteLine("Plz Choise [1] or [2]");
            Login();
            break;
        }

    }

    private void Lobby()
    {
        s_mode = Scene_Mode.Lobby;
        Console.WriteLine("You welcome to Lobby!!");
        Console.WriteLine($"Your Gold have {GameManager.instance.data.Player_gold}");
        Console.WriteLine("Where you go?");
        Console.WriteLine("[1]Bill [2]Fighting [3]Inven [4]Login");

        int Choise = Convert.ToInt32(Console.ReadLine());
        
        switch(Choise)
        {
            case 1:
            Bill();
            break;

            case 2:
            Fightting_Base();
            break;

            case 3:
            Invan();
            break;

            case 4:
            Login();
            break;

            default:
            Console.WriteLine("Plz Choise [1] or [2] or [3] or [4]");
            Lobby();
            break;
        }

    }
    public void Bill()
    {
        Console.WriteLine("Welcome To Bill!");
    }

    private void Fightting_Base()
    {
        Console.WriteLine("Welcome To Fight!");
    }

    private void Invan()
    {
        Console.WriteLine("Your Inven!");
        Console.WriteLine($"Your Stat is \nHP : {GameManager.player.P_stat.HP}\nMP : {GameManager.player.P_stat.Mage_MP}\nattack : {GameManager.player.P_stat.attack}\nDefence : {GameManager.player.P_stat.Defence}");
        Console.WriteLine($"Your Gold have {GameManager.instance.data.Player_gold}");
        
    }
}