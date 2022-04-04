using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDisplay : MonoBehaviour
{
    [HideInInspector]
    public Monster enemyInstance;

    [SerializeField] Text nameTxt;
    [SerializeField] Text attackTxt;
    [SerializeField] Text defenseTxt;
    [SerializeField] Image face;
    [SerializeField] Image characterModel;
    [SerializeField] Image hp;

    // Start is called before the first frame update
    void Start()
    {
       // ActualiceDisplayData();
    }

    public void ActualiceDisplayData()
    {
        nameTxt.text = enemyInstance.characerName.ToString();
        attackTxt.text = enemyInstance.attak.ToString();
        defenseTxt.text = enemyInstance.defense.ToString();
        face.sprite = enemyInstance.enemyData._faceImg;
        characterModel.sprite = enemyInstance.enemyData._modelImg;
        ActualiceHp();
    }

    public void ActualiceHp() {
        float width = (enemyInstance.hp * 100) / enemyInstance.maxHp;
        hp.rectTransform.sizeDelta = new Vector2(width, hp.rectTransform.sizeDelta.y);
    }
    

}
