using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Enemy",menuName ="new Enemy",order =0)]
public class ScEnemy : ScriptableObject
{
    public string _EnemyName;
    public int _attack;
    public int _defense;
    public Sprite _faceImg;
    public Sprite _modelImg;
}
