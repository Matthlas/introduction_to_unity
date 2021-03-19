using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField]
    private float _speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(x: 0, y: 0, z: 0);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 playerTranslate = new Vector3(
            x: 1 * horizontalInput * _speed * Time.deltaTime,
            y: 1 * verticalInput * _speed * Time.deltaTime,
            z: 0);
        transform.Translate(playerTranslate);

        if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x,
                0,
                0);
        }
        else if (transform.position.y < -4.5f)
        {
            transform.position = new Vector3(transform.position.x,
                -4.5f,
                0f);
        }
        
        if (transform.position.x > 11.3f)
        {
            transform.position = new Vector3(
                x:-transform.position.x,
                y:transform.position.y,
                0);
        }
        else if (transform.position.x < -11.3f)
        {
            transform.position = new Vector3(
                transform.position.x * (-1),
                y:transform.position.y,
                0f);
        }
    }
}
