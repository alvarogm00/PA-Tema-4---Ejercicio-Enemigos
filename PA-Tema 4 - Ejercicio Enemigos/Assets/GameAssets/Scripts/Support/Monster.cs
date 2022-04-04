using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Character
{
    public ScEnemy enemyData;

    public Monster(ScEnemy data) : base(data._EnemyName,data._attack, data._defense) {
        enemyData = data;
    }

    public override void TakeDamage(int ammount)
    {
        base.TakeDamage(ammount);
        FindObjectOfType<EnemyWaves>().ActualiceHp();
        FindObjectOfType<ActionPanelController>().DisplayInfo("Enemy " + characerName + " takes " + ammount + " damage.");
        if (hp == 0)
        {
            print("Enemy " + characerName + " is dead.");
            FindObjectOfType<ActionPanelController>().DisplayInfo("Enemy " + characerName + " is dead.");
            FindObjectOfType<EnemyWaves>().EnemyIsDead();
        }
    }

    public void Attack() { }
}
