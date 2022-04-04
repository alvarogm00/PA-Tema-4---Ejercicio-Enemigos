using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaves : MonoBehaviour
{
    GenericEnemyQueue<Monster> oleada1 = new GenericEnemyQueue<Monster>();
    GenericEnemyQueue<Monster> oleada2 = new GenericEnemyQueue<Monster>();
    //Numero de oleadas
    [SerializeField] int waves = 2;
    //Montruos por oleada
    [SerializeField] int enemiesPerWave = 10;

    [SerializeField] EnemyDisplay EnemyDisplay;

    //La información de los enemigos scriptados cargada de la carpeta resources
    object[] enemiesData;

    private void Start()
    {
        Init();
    }

    void Init()
    {
        //Cargar la información de los enemigos scriptados desde la carpeta resources
        enemiesData = Resources.LoadAll("Enemies");

        //Rellenar las oleadas de instancias de monstruos
        for (int i = 0; i < waves; i++)
        {
            if(oleada1.count < enemiesPerWave)
            {
                for (int j = 0; j < enemiesPerWave; j++)
                {
                    Monster m = new Monster(enemiesData[j] as ScEnemy);
                    oleada1.PonerALaFila(m);
                }
            }
            else
            {
                for (int k = 0; k < enemiesPerWave; k++)
                {
                    Monster m = new Monster(enemiesData[k] as ScEnemy);
                    oleada2.PonerALaFila(m);
                }
            }
            
        }
        
         //Monster m1 = new Monster(enemiesData[0] as ScEnemy);//Ejemplo instancia Monster
    }

    IEnumerator NextEnemy() {
        yield return new WaitForSeconds(2);

        //Cada vez que se cargue un nuevo enemigo hay que llamar a su display
        Monster nextEnemy = oleada1.QuitarDeLaFila();
        //Pasarle la instancia del enemigo a cargar y eliminarlo de la lista de oleada
       

        //actualizar los datos del display al cargar nuevo enemigo
        EnemyDisplay.ActualiceDisplayData();
        
    }

    //no editar, lo llama el enemigo cuando recibe daño
    public void ActualiceHp()
    {
        EnemyDisplay.ActualiceHp();
    }

    //no editar, lo llama el enemigo cuando muere
    public void EnemyIsDead()
    {
        StartCoroutine(NextEnemy());
    }
}
