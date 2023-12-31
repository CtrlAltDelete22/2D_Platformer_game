using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_life : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    [SerializeField] private AudioSource DeathAudio;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap")) 
        {
            Die();
            DeathAudio.Play();
        }
    }
    private void Die() 
    {
        anim.SetTrigger("death");
        rb.bodyType = RigidbodyType2D.Static;
    }
    private void RestartLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
