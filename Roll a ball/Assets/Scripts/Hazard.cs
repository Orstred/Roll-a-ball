using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
