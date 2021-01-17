using System;
using System.Collections.Generic;

public class GameManager
{
    static GameManager s_instance;
    public static GameManager instance {get{Init(); return s_instance;}}

    SceneManager s_Scene = new SceneManager();
    public SceneManager Scene {get{return instance.s_Scene;}}

    DataManager s_data = new DataManager();
    public DataManager data {get{return instance.s_data;}}

    public Player s_player {get;set;}
    public static Player player {get{return instance.s_player;}}

    public static void Init()
    {
        if(s_instance != null)
            return;

        if(s_instance == null)
        {
            s_instance = new GameManager();
        }

        s_instance.s_Scene.Init(s_instance.s_player);
    }
}