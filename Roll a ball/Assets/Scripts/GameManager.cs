using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager instance;

    private void Awake()
    {
        if (GameManager.instance == null)
        {
            instance = this;
        }
        else
            Destroy(this);
    }
    #endregion


    [SerializeField] private int CoinNumber;

    public void AddCoin()
    {
        CoinNumber++;
    }

    public void PickupCoin(GameObject ObjToDestroy)
    {
        CoinNumber--;

        Destroy(ObjToDestroy);
           
        if(CoinNumber <= 0)
        {
            CompleteLevel();
        }
    }

    public void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
