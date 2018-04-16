using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shot : MonoBehaviour
{
    private Animator animate2;
    bool shot = false;
    public Text winText;
    public Button btn;
    private void Start()
    {
        animate2 = gameObject.GetComponent<Animator>();
        btn = GameObject.Find("Button").GetComponent<Button>();
        btn.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            //Destroy(gameObject);
            Debug.Log("Dead");
            shot = true;
            animate2.SetBool("Shot", shot);
            if (shot)
            {
                winText.text = "Game Over";
                btn.gameObject.SetActive(true);

            }

        }

    }
}