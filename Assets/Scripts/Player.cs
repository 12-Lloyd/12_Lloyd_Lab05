using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{

    public int coin;
    public GameObject coinText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Debug.Log("touch");
            Destroy(collision.gameObject);
            coin += 10 ;
            coinText.GetComponent<Text>().text = "Score: " + coin;
        }
    }
}