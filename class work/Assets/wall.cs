using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wall : MonoBehaviour
{
    public Text text;
     public int score =  0;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        score += 1;
        text.text = score.ToString();
    }

}
