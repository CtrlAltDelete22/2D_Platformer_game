using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Collect_items : MonoBehaviour
{
    [SerializeField] private Text cherriestext;
    [SerializeField] private AudioSource CollectAudio;
    private int cherries = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry")) 
        {
            CollectAudio.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriestext.text = "Cherries: " + cherries; 
        }
    }
}
