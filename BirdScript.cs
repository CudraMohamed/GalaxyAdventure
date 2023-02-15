using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //vector to represent a position in 2d space
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            myRigidBody.velocity = Vector2.up * flapStrength;
        } 
        if (transform.position.y > 12 || transform.position.y < -12) 
        {
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
