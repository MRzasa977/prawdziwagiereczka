using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
            float oss = transform.position.x;
            //Debug.Log(oss);
            Vector2 movement = new Vector2(transform.position.x, transform.position.y);
            movement.x = Mathf.Clamp(oss, 0.5f, 15.5f);
            transform.position = movement;
        }
        else

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        { 
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            float oss = transform.position.x;
            Vector2 movement = new Vector2(transform.position.x, transform.position.y);
            movement.x = Mathf.Clamp(oss, 0.5f, 15.5f);
            transform.position = movement;

        }
    }
}
