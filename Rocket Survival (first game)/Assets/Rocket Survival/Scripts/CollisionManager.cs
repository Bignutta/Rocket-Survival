using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour
{
    /// PRIVATE ///
    
    bool isDead = false;
    /// PUBLIC ///


    public void OnCollisionEnter(Collision other) 
    {
        switch (other.gameObject.tag)
        {
            case "Start Level":
                Debug.Log("You are on start.");
                LevelStart();
                break;
            case "Finish Level":
                Debug.Log("You have finished");
                LevelFinish();
                break;
            case "obstacle":
                Debug.Log("You hit an obstacle");
                isDead = true;
                PlayerCollider();
                break;
            default:
                Debug.Log("What ever");
                break;
        }
    }

    public void LevelStart()
    {

    }

    public void LevelFinish()
    {

    }
    public void PlayerCollider()
    {
        if (isDead)
        {
            SceneManager.LoadScene(1);
            Debug.Log("Loaded scene 1");
        }
    }
}
