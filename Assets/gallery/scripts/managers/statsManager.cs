using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class stats {

    public string character { get; set; }
    public int lvl { get; set; }
    public int hp { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
    public int magic { get; set; }
    public int exp { get; set; }
    public int expNeeded { get; set; }

}

public class equipmentList {

    public GameObject model { get; set; }
    public string name { get; set; }
    public string type { get; set; }
    public string desc { get; set; }
    public int lvl { get; set; }
    public int hp { get; set; }
    public int mp { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
    public int magic { get; set; }

}

public class statsManager : MonoBehaviour {

    public List<equipmentList> el = new List<equipmentList>(0);
    public string actorsPath;
    public string expPath;
    public string itemsPath;
    public string savePath;
    public string readme;

    void Start(){

        actorsPath = Application.dataPath + "/scripts/stats/actors.json";
        expPath = Application.dataPath + "/scripts/stats/exp.json";
        itemsPath = Application.dataPath + "/scripts/stats/items.json";
        savePath = Application.persistentDataPath + "/GhostszMusic/Shooting Gallery/data/Save.sav";
        readme = Application.persistentDataPath + "/GhostszMusic/Shooting Gallery/custom/readme.txt";

#if UNITY_EDITOR
        Debug.Log(fileCheck(actorsPath));
        Debug.Log(fileCheck(expPath));
        Debug.Log(fileCheck(itemsPath));
        Debug.Log(fileCheck(savePath));
        Debug.Log(fileCheck(readme));
#endif

    }

	public static int damageTaken(stats attacker, stats defender) {

        int damage = 0;

        damage = attacker.atk - defender.def;

        return damage;
    }

    public static int getExp(string character) {

        return 0;
    }

    public void saveNewItemToList(equipmentList e) {



    }

    public string fileCheck(string f) {
        string msg = "";

        if (File.Exists(f)) {

            msg = f + " was found";

        } else {

            msg = "Error: " + f + " was not found!";
        }

        return msg;
    }

}
