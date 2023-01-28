using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using UnityEngine.UIElements;

public class Collector : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    float Distance;
    void Start()
    {
       
    }

    void Update()
    {
       
    }

    

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Clone")
        {
            for (var i = 0; i < 3; i++)
            {
                Instantiate(prefab, new Vector3(Distance - 0.1f, transform.position.y, transform.position.z), Quaternion.identity);
            }
        }
        if (other.gameObject.tag == "Cage")
        {
            for (var i = 0; i > 0; i--)
            {
                Instantiate(prefab, new Vector3(Distance - 0.1f, transform.position.y, transform.position.z), Quaternion.identity);
            }
        }
        if (other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }



    }

}
