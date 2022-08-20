using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


}
