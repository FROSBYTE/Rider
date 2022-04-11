using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carcontroller : MonoBehaviour
{   bool move = false;
    bool isGround = false;
    public Rigidbody2D rb;
    public float speed = 22f;
    public float rotspeed = 3f;
    public GameObject end_canvas;
    public GameObject win_canvas;

    void Start()
    {
       end_canvas.SetActive(false);
       win_canvas.SetActive(false);
        Time.timeScale = 1;
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            move = true;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            move = false;
        }
        Death();
    }
    private void FixedUpdate()
    {
        if(move == true)
        {
            if(isGround == true)
            {
                rb.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
            else
            {
                rb.AddTorque(rotspeed * rotspeed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
            
        }
    }
    private void OnCollisionEnter2D()
    {
        isGround = true;
    }
    private void OnCollisionExit2D()
    {
        isGround = false;
    }
    public void Death()
    {
        Quaternion Rider_Rot_negative = Quaternion.Euler(0, 0, -100);
        Quaternion Rider_Rot_Positive = Quaternion.Euler(0, 0, 100);

        if (isGround == true && (transform.rotation.z <= Rider_Rot_negative.z || transform.rotation.z >= Rider_Rot_Positive.z))
        {
            Time.timeScale = 0;
            end_canvas.SetActive(true);

        }
        if (isGround ==false && transform.position.y < -10)
        {   Time.timeScale = 0;
            end_canvas.SetActive(true);
        }
    }
}

