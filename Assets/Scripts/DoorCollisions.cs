using UnityEngine;

public class Collisions : MonoBehaviour
{

    // spent 30 minutes trying to figure out why this function didn't work only for it to be 
    // because the first o was in lowercase
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Door")
        {

            FindAnyObjectByType<GameManager>().nextScene();
        }

            
        
    }
}
