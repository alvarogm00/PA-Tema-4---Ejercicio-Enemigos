using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionPanelController : MonoBehaviour
{
    [SerializeField] InputField damageTxt;
    [SerializeField] Text infoTxt;
    [SerializeField] EnemyDisplay enemyConstructorDisplay;

    public void AttackButon() {
       enemyConstructorDisplay.enemyInstance.TakeDamage(int.Parse(damageTxt.text));
        
    }

    public void DisplayInfo(string info) {
        infoTxt.text = info;
    }
}
