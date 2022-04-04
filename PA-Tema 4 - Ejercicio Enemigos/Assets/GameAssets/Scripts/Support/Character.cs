using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public int maxHp = 100;
    public string characerName;
    public int attak;
    public int defense;

    private int _hp;
    public int hp {
        get { return _hp; }
        set { _hp = Mathf.Clamp(value, 0, maxHp); }
    }

    public Character(string _chName, int _atk, int _def)
    {
        characerName = _chName;
        attak = _atk;
        defense = _def;
        hp = maxHp;
    }

    public virtual void TakeDamage(int ammount)
    {
        hp -= ammount;
        
    }

}
