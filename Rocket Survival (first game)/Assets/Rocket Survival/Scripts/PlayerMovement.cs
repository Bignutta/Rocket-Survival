using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// PRIVATE ///
    Rigidbody playerRB;
    AudioSource gameSounds;

    /// PUBLIC ///
    public float upThrustAmount = 1000f;
    public float rotationSpeed = 100f;   
    [SerializeField] AudioClip shipThrustAudio; 

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        gameSounds = GetComponent<AudioSource>();    
    }

    void Update()
    {
        ShipMovement();
    }
    public void ShipMovement()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerRB.AddRelativeForce(Vector3.up * upThrustAmount * Time.deltaTime);
            if (!gameSounds.isPlaying)
            {
                gameSounds.Play();
            }
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            gameSounds.Stop();
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            playerRB.freezeRotation = true;
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            playerRB.freezeRotation = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRB.freezeRotation = true;
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
            playerRB.freezeRotation = false;
        }
    }
}
