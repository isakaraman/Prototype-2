using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float HorizontalInput;
    [SerializeField] private float VerticalInput;
    [SerializeField] private float Speed;
    [SerializeField] private float xRange = 10;
    [SerializeField] private float zRangeUp = 10;
    [SerializeField] private float zRangeDown = 10;

    [SerializeField] private GameObject ProjectilePrefab;
    [SerializeField] private UIManager UI_manager;
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * Speed);
        transform.Translate(Vector3.forward * VerticalInput * Time.deltaTime * Speed);


        PlayerBoundries();


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ProjectilePrefab, new Vector3(transform.position.x,transform.position.y+1,transform.position.z), ProjectilePrefab.transform.rotation);
        }
    }
    void PlayerBoundries()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < zRangeDown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeDown);
        }
        else if (transform.position.z > zRangeUp)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y , zRangeUp);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Animals")
        {
            UI_manager.Lives();
        }
    }
}
