using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class card : MonoBehaviour
{

    public int id;
    public string cardname;
    public int cost;
    public int power;
    public int health;
    public string carddescription;

    public card(int Id, string Cardname, int Cost, int Power, int Health, string Carddescription) {

    id = Id;
    cardname = Cardname;
    cost = Cost;
    power = Power;
    health = Health;
    carddescription = Carddescription;
        }
}
    

